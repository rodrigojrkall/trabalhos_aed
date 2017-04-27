using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_aed.Classes
{
    public class Contato
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public static Contato Novo()
        {
            Contato novo = new Contato();
            Console.Write("\nNome: ");
            novo.Nome = Console.ReadLine();
            Console.Write("\nTelefone: ");
            novo.Telefone = Console.ReadLine();
            return novo;
        }
    }
    public class Grupo
    {
        public int codigo;
        public string nome;
        public string data_criacao;
        public int codigo_criador;
        public List<Contato> participantes;

        public static Grupo Novo(int codigo_criador, List<Contato> participantes)
        {
            Grupo novo = new Grupo();
            Console.Write("\nNome: ");
            novo.nome = Console.ReadLine();
            novo.data_criacao = DateTime.Now.ToShortDateString();
            novo.codigo_criador = codigo_criador;
            novo.participantes = participantes;
            return novo;
        }
    }
    public class Conversa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Hora_ultima_msg { get; set; }
        public List<Mensagem> mensagens;

        public static Conversa Nova()
        {
            Conversa nova = new Conversa();
            Console.Write("\nNome: ");
            nova.Nome = Console.ReadLine();
            nova.Hora_ultima_msg = "";
            return nova;
        }
    }
    public class Mensagem
    {
        public int codigo;
        public string texto;
        public Contato destinatario;
        public string data;
        public string hora;

        public static Mensagem Nova(Contato destinatario)
        {
            Mensagem nova = new Mensagem();
            Console.Write("\nTexto: ");
            nova.texto = Console.ReadLine();
            nova.data = DateTime.Now.ToShortDateString();
            nova.hora = DateTime.Now.ToShortTimeString();
            nova.destinatario = destinatario;

            return nova;
        }
    }
}
