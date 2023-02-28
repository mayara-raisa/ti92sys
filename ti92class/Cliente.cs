using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Renci.SshNet.Security.Cryptography;

namespace ti92class
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }
        public bool Ativo { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public List<Telefone> Telefones { get; set; }

        public Cliente() { }
        public Cliente(int id, string nome, string cpf, string email, DateTime data, bool ativo, List<Endereco> enderecos, List<Telefone> telefones)
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
        public Cliente(string nome, string cpf, string email, DateTime data, bool ativo)
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
            Enderecos = Endereco.ListarPorCliente(id);
        }
        private void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert cliente (nome,cpf,email,datacad,ativo) " +
            " value ('" + Nome + "'," + Cpf + ",'" + Email + "'," + Data + "," + Ativo + ")";
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
            cmd.CommandText = "select * from clientes order by nome asc";
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
                Endereco.ListarPorCliente(dr.GetInt32(0)),
                Telefone.ListarPorTelefone(dr.GetInt32(0))
               )
              );
            }
            return lista;
        }
        public static Cliente ObterPorId(int _id)
        {
            Cliente cliente = new Cliente();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente.Id = dr.GetInt32(0);
                cliente.Nome = dr.GetString(1);
                cliente.Cpf = dr.GetString(2);
                cliente.Email = dr.GetString(3);
                cliente.Data = dr.GetDateTime(4);
                cliente.Ativo = dr.GetBoolean(5);
                cliente.Enderecos = Endereco.ListarPorCliente(dr.GetInt32(0));
                cliente.Telefones = Telefone.ListarPorTelefone(dr.GetInt32(0));
            }
            return cliente;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update cliente set nome = " +
            "'" + Nome + "', cpf '" + Cpf + "', email'" + Email + "', data '" + Data + "', ativo'" + Ativo;
            cmd.ExecuteNonQuery();
        }
        public bool Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update cliente set ativo = 0 whare id = " + id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
        public static List<Cliente> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from cliente where nome like '%" + _parte + "%' orde by nome;";
            var dr = cmd.ExecuteReader();
            List<Cliente> listar = new List<Cliente>();
            while (dr.Read())
            {
                listar.Add(new Cliente(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetString(3),
                dr.GetDateTime(4),
                dr.GetBoolean(5),
                Endereco.ListarPorCliente(dr.GetInt32(6)),
                Telefone.ListarPorTelefone(dr.GetInt32(7))
                    )
                 );
               }
            return listar;
        }
    }


}
