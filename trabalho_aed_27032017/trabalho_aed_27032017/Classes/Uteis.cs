using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_aed_27032017.Classes
{
    public class Contato
    {
        int codigo;
        string nome;
        string telefone;

        public static Contato Novo()
        {
            Contato novo = new Contato();
            Console.Write("\nNome: ");
            novo.nome = Console.ReadLine();
            Console.Write("\nTelefone: ");
            novo.telefone = Console.ReadLine();
            return novo;
        }

        public void Exibir()
        {
            Console.WriteLine("Código: {0}", codigo);
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Telefone: {0}", telefone);
        }
    }

    public class Grupo
    {
        public int codigo;
        public string nome;
        public string data_criacao;
        public int codigo_criador;

        public static Grupo Novo(int codigo_criador)
        {
            Grupo novo = new Grupo();
            Console.Write("\nNome: ");
            novo.nome = Console.ReadLine();
            novo.data_criacao = DateTime.Now.ToShortDateString();
            novo.codigo_criador = codigo_criador;
            return novo;
        }

        public void Exibir()
        {
            Console.WriteLine("Código: {0}", codigo);
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Data de criação: {0}", data_criacao);
            Console.WriteLine("Criador: {0}", codigo_criador);
        }
    }
    public class Conversa
    {
        public int codigo;
        public string nome;
        public string hora_ultima_msg;

        public static Conversa Nova()
        {
            Conversa nova = new Conversa();
            Console.Write("\nNome: ");
            nova.nome = Console.ReadLine();
            nova.hora_ultima_msg = "";
            return nova;
        }

        public void Exibir()
        {
            Console.WriteLine("Código: {0}", codigo);
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Hora última mensagem: {0}", hora_ultima_msg);
        }
    }
    public class Mensagem
    {
        public int codigo;
        public string texto;
        public string destinatario;
        public string data;
        public string hora;

        public static Mensagem Nova(string destinatario)
        {
            Mensagem nova = new Mensagem();
            Console.Write("\nTexto: ");
            nova.texto = Console.ReadLine();
            nova.data = DateTime.Now.ToShortDateString();
            nova.hora = DateTime.Now.ToShortTimeString();
            nova.destinatario = destinatario;

            return nova;
        }

        public void Exibir()
        {
            Console.WriteLine("Código: {0}", codigo);
            Console.WriteLine("Texto: {0}", texto);
            Console.WriteLine("Destinatário: {0}", destinatario);
            Console.WriteLine("Data: {0}", data);
            Console.WriteLine("Hora: {0}", data);
        }
    }

}
