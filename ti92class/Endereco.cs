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
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }        
        public string Uf { get; set; }
        public string Tipo { get; set; }
        

        public Endereco() { }
        public Endereco(
        int id,string cep,string logradouro,string numero, string complemento,string bairro, string cidade, string estado , string uf,string tipo)
        {
            Id = id;
            Cep= cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
            Tipo = tipo;

        }
        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
            Tipo = tipo;
        }
        public void Inserir(int cliente_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "inserir tefones(cliente_id,numeros,tipos)" +
           " value (" + cliente_id + "'" + Cep + "','" + Logradouro + "', '" +Numero+ "', '"+Complemento+"')";
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
        public static Endereco ObterPorId(int _id)
        {
           Endereco endereco = new Endereco();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from endercos where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
             
            }
        }

    }
}
