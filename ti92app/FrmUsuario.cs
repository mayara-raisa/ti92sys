using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ti92class;

namespace ti92app
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            cmbNivel.DataSource = Nivel.Listar();
            cmbNivel.DisplayMember = "Nome";
            cmbNivel.ValueMember= "Id";
            CarregaLista();

        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbNivel.SelectedValue.ToString());
        }

        private void CarregaLista()
        { 
            lstLista.Items.Clear();
            var lista = Usuario.Listar();
            foreach (var item in lista)
            {
                lstLista.Items.Add(item.Id + " - "+ item.Nome + " - " + item.Nivel.Nome);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario(
                txtNome.Text,
                txtEmail.Text,
                Nivel.ObterPorId((int)cmbNivel.SelectedValue),
                txtSenha.Text,
                chkAtivo.Checked
                );
            user.Inserir();
            txtId.Text = user.Id.ToString();
            CarregaLista();
        }
    }
}
