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
        public List<Endereco> Enderecos { get; set; }
        public List<Telefone> Telefones { get; set; }
 
        public Cliente() { }
        public Cliente(int id, string nome, int cpf, string email, DateTime data, bool ativo,List<Endereco>enderecos,List<Telefone> telefones)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Data = data;
            Ativo = ativo;
            Enderecos = enderecos;
            Telefones = telefones;
        }
        public Cliente(string nome, int cpf, string email, DateTime data, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Data = data;
            Ativo = ativo;
        }
        public Cliente(int id)
        { 
            Telefones = Telefone.ListarPorTelefone(id);
            Enderecos = Endereco.ListarPorEndereco(id);
        }
        private void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert cliente (nome,cpf,email,datacad,ativo) " + 
            " value ('" + Nome + "'," + Cpf + ",'" + Email + "'," + Data + "," + Ativo +")";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar()); 
            foreach (var telefone in Telefones)
            {
                telefone.Inserir(Id);
            }
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
                dr.GetString(2),
                dr.GetString(3),
                dr.GetDateTime(4),
                dr.GetBoolean(5),
                Endereco.ListarPorEndereco(dr.GetInt32(6)),
                
               )
              );
            }
            return lista;
        }

    }

}
