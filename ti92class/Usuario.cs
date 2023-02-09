using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Nivel Nivel { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }  

        // Métodos construtores
        public Usuario() { }
        public Usuario(string _nome, string _email,Nivel _nivel ,string _senha, bool _ativo)
        {
            Nome = _nome;
            Email = _email;
            Nivel = _nivel;
            Senha = _senha;
            Ativo = _ativo;
        }
        public Usuario(int _id, string _nome, string _email,Nivel _nivel, string _senha, bool _ativo)
        {
            Id = _id;
            Nome = _nome;
            Email = _email;
            Nivel = _nivel;
            Senha = _senha;
            Ativo = _ativo;
        }
        // Métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert usuarios (nome, email, nivel_id, senha, ativo)" +
                " values('"+Nome+"','"+Email+"',"+Nivel.Id+",'"+Senha+"',"+Ativo+" );";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id= Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public static List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from usuarios order by nome;";
            var dR = cmd.ExecuteReader();
            while (dR.Read())
            {
                lista.Add(new Usuario(
                        dR.GetInt32(0),
                        dR.GetString(1),
                        dR.GetString(2),
                        Nivel.ObterPorId(dR.GetInt32(4)),
                        dR.GetString(3),
                        dR.GetBoolean(5)
                    )) ;
            }
            return lista;
        }
        public static Usuario ObterPorId(int _id)
        {
            Usuario usuario = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from usuarios where id ="+_id;
            var dR = cmd.ExecuteReader();
            while (dR.Read())
            {
                usuario = new Usuario(
                        dR.GetInt32(0),
                        dR.GetString(1),
                        dR.GetString(2),
                        Nivel.ObterPorId(dR.GetInt32(4)),
                        dR.GetString(3),
                        dR.GetBoolean(5)
                    );
            }
            return usuario;
        }
        public static void Atualizar(Usuario Usuario)
        {

        }
        public bool Excluir(int _id)
        {
            return true;
        }

    }
}
