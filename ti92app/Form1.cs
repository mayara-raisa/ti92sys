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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          
            

        }

        private void btnIsereNivel_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(txtNomeNivel.Text,txtSiglaNivel.Text);
            nivel.Inserir();
            txtIdNivel.Text = nivel.Id.ToString();
            AtualizaListBox();
            MessageBox.Show("Nível inserido com Sucesso \n ID: "+ nivel.Id.ToString());
          
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "Editar")
            {
                txtIdNivel.ReadOnly = false;
                txtIdNivel.Focus();
                btnEditar.Text = "Gravar";
                btnIsereNivel.Enabled = false;
            }
            else
            {
                Nivel nivel = new Nivel();
                nivel.Id = int.Parse(txtIdNivel.Text);
                nivel.Nome = txtNomeNivel.Text; 
                nivel.Sigla= txtSiglaNivel.Text;
                nivel.Atualizar();
                txtIdNivel.ReadOnly = true;
                txtNomeNivel.Focus();
                btnEditar.Text = "Editar";
                AtualizaListBox();
            }
           
        }

        private void txtIdNivel_TextChanged(object sender, EventArgs e)
        {
            if (txtIdNivel.Text!=string.Empty)
            {
                int id = int.Parse(txtIdNivel.Text);
                var nivel = Nivel.ObterPorId(id);
                txtNomeNivel.Text= nivel.Nome;
                txtSiglaNivel.Text = nivel.Sigla;
            }

        }
        private void AtualizaListBox() 
        {
            List<Nivel> list = Nivel.Listar();
            listBox1.Items.Clear();
            foreach (var item in list)
            {
                listBox1.Items.Add("ID: "+item.Id + " - NOME: " + item.Nome +" - SIGLA: "+item.Sigla );
            }
            txtIdNivel.Clear();
            txtNomeNivel.Clear();
            txtSiglaNivel.Clear();
            txtNomeNivel.Focus();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            // se txtBusca.Text for diferente de vazio
            // e (&&) txtBusca.Text.Length for maior ou igual a 2 caracteres
            if (txtBusca.Text != string.Empty && txtBusca.Text.Length >= 2)
            {
                listBox1.Items.Clear();
                var niveis = Nivel.BuscarPorNome(txtBusca.Text);
                if (niveis.Count > 0)
                { 
                    foreach (var nivel in niveis)
                    {
                        listBox1.Items.Add(nivel.Id +" - "+nivel.Nome+" - "+nivel.Sigla);
                    }
                }
                else
                { 
                    listBox1.Items.Add("Não há registros para essa consulta...");
                }       
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtIdNivel.Text != string.Empty)
            {
                Nivel nivel = Nivel.ObterPorId(int.Parse(txtIdNivel.Text));
                if (nivel.Excluir(nivel.Id))
                {
                    MessageBox.Show("Nível "+ nivel.Nome +" excluído com sucesso!","Exclusão de nível");
                    AtualizaListBox();
                }
                
            }
        }


    }
}
