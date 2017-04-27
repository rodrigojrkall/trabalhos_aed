using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalho_aed_27032017.Classes;
namespace trabalho_aed_27032017
{
    class Program
    {
        static List<Contato> contatos;
        static List<Grupo> grupos;
        static List<Conversa> conversas;
        static List<Mensagem> mensagens;

        static void Main(string[] args)
        {
            contatos = new List<Contato>();
            grupos = new List<Grupo>();
            conversas = new List<Conversa>();
            mensagens = new List<Mensagem>();

        }

        static void Exibir<T>(List<T> lista)
        {
            foreach (var item in lista)
            {
                switch (item.GetType().Name)
                {
                    case "Contato":
                        Contato contato = item;
                        ((Contato)item).Exibir();
                        break;
                }
            }
        }
    }
}
