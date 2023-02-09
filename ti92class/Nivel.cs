using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Org.BouncyCastle.Bcpg;

namespace ti92class
{
    public class Nivel
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        // Métodos construtores
        public Nivel() { }
        public Nivel(string _nome, string _sigla) 
        { 
            Nome= _nome;
            Sigla= _sigla;
        }
        public Nivel(int _id,string _nome, string _sigla)
        {
            Id = _id;
            Nome = _nome;
            Sigla = _sigla;
        }
        // Métodos da classe
        public void Inserir()
        {
            // gravar um novo nível na tabela niveis
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert niveis (nome, sigla) values ('"+Nome+"','"+Sigla+"')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static List<Nivel> Listar() 
        {
            // 0 - entrega uma lista de todos os níveis (cria um espaço do tipo lista)
            List<Nivel> lista = new List<Nivel>();
            // lógica que recupera todos os níveis da tabela
            // 1 - Abrir conexão com o banco de dados - 
            var cmd = Banco.Abrir();
            // 2 - Definir tipo de comando SQL (text/store procedure)
            cmd.CommandType = System.Data.CommandType.Text;
            // 3 - Atribuir comando SQL (Texto)
            cmd.CommandText = "select * from niveis order by nome asc";
            // 4 - Executar o comando sql e armazenar o retorno do banco em um objeto MySqlDataReader
            var dr = cmd.ExecuteReader();
            // 5 - preencher o objeto List com o retorno do banco, se houver
            while (dr.Read()) // enquanto houver próximo registro 
            {
                lista.Add(new Nivel(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    )
                );
            }
            dr.Close();
            // retorna a lista preenchida
            return lista;
        }
        public static Nivel ObterPorId(int _id)
        { 
            Nivel nivel = new Nivel();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis where id = "+_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nivel.Id = dr.GetInt32(0);
                nivel.Nome= dr.GetString(1);
                nivel.Sigla = dr.GetString(2);
            }
            dr.Close();
            return nivel;

        }
        public void Atualizar() 
        { 
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update niveis set nome = '" +
                Nome+"', sigla = '"+ Sigla +
                "' where id = "+ Id;
            cmd.ExecuteNonQuery();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from niveis where id = "+_id;
            return cmd.ExecuteNonQuery()==1?true:false;
             
        }
        public static List<Nivel> BuscarPorNome(string _parte) 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis where nome like '%" + _parte + "%'  order by nome;";
            var dr = cmd.ExecuteReader();
            List<Nivel> lista = new List<Nivel>();
            while (dr.Read())
            {
                lista.Add(new Nivel(
                        dr.GetInt32(0),dr.GetString(1), dr.GetString(2)        
                    )
                );
            }
            return lista; 
        }




    }
}
