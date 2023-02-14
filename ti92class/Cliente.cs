using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ti92class
{
    public class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }
        public bool Ativo { get; set; }

        public Cliente() { }

        public Cliente(int id, string nome, int cpf, string email, DateTime data, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Data = data;
            Ativo = ativo;
        }

        public Cliente(string nome, int cpf, string email, DateTime data, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Data = data;
            Ativo = ativo;
        }
        private void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert cliente(nome,cpf,email,datacad,ativo) " 
            + " value ('"+Nome+"',"+Cpf+",'"+Email+"',"+Data+","+Ativo+")";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes orde by descricao asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetInt32(2),
                dr.GetString(3),
                dr.GetInt32(4),
                dr.GetBoolean(5)
                
                )
              );
            }
        }

    }

}
