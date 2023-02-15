using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }

        public Endereco() { }
        public Endereco(int id, string numero, string tipo)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
        }
        public Endereco(string numero, string tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }
        public void Inserir(int cliente_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "inserir tefones(cliente_id,numeros,tipos)" +
                " value (" + cliente_id + "'" + Numero + "','" + Tipo + "')";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static List<Endereco> ListarPorEndereco(int cliente_id)
        {
            List<Endereco> listaTel = new List<Endereco>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select id, numero, tipo from Endereco where cliente_id = " + cliente_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaTel.Add(new Endereco(
                        dr.GetInt32(2),
                        dr.GetString(0),
                        dr.GetString(1)
                    )
                    );
            }
            return listaTel;
        }

    }
}
