using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{    

    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Etatus { get; set;}
        public double Desconto { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set;}
        public DateTime ArquivadoEM { get; set; }
        public List<ItemPedido> Items { get; set; }

        public Pedido()
        {
            Usuario= new Usuario();
            Cliente= new Cliente();
        }
        public Pedido(DateTime data, string etatus, double desconto, Cliente cliente, Usuario usuario,List<ItemPedido> items = null)
        {
            Data = data;
            Etatus = etatus;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Items = items;
        }

        public Pedido(int id, DateTime data, string etatus, double desconto, Cliente cliente, Usuario usuario,List<ItemPedido> items = null)
        {
            Id = id;
            Data = data;
            Etatus = etatus;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Items = items;
            
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
        }
        public static List<Pedido> Listar()
        {
            List<Pedido> list = new List<Pedido>();

            return list;
        }
        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new Pedido();

            return pedido;
        }
        public bool Atualizar()
        {            
            return false;
        }

        public void Arquivar(int id)
        {
            
        }

        public void Restaurar(int id)
        {

        }

    }
}
