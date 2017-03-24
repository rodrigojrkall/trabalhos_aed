using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalho_aed.Classes;

namespace trabalho_aed
{
    class Program
    {
        static int opcao;
        static List<Contato> contatos = new List<Contato>();
        static List<Grupo> grupos = new List<Grupo>();
        static List<Conversa> conversas = new List<Conversa>();
        static List<Mensagem> mensagens = new List<Mensagem>();

        static void MontarMenus(string titulo, string[] menus)
        {
            Console.Clear();
            Console.WriteLine(titulo);
            int aux = 0;
            foreach (var menu in menus)
            {
                aux++;
                Console.WriteLine("{0} - {1}", aux, menu);
            }
            Console.WriteLine("99 - Sair");
            Console.Write("\nDigite o menu desejado: ");

            try
            {
                opcao = int.Parse(Console.ReadLine());
                if ((opcao == 0 || opcao > 5) && opcao != 99)
                    throw new Exception();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Opcao invalida.");
                Console.Write("Pressione alguma tecla para voltar.");
                Console.ReadKey();
            }
        }
        
        static void SwitchContato()
        {
            switch (opcao)
            {
                case 1:
                    //VisualizarContato();
                    break;
                case 2:
                    Contato.Novo();
                    break;
                case 3:
                    //SelecionarContato();
                    break;
            }
        }

        static void VisualizarItens<T>(List<T> t)
        {
            foreach (var item in t)
            {
                ExibirAtributo(item);
            }
        }

        static void ExibirAtributo<T>(T t)
        {                        
            foreach (var item in t.GetType().GetProperties())
            {
                Console.WriteLine("{0}: {1}", item.Name, item.GetValue(t));
            }            
        }
                       
        static void Main(string[] args)
        {
            /*
            do
            {
                MontarMenus("MENU", new string[] { "Contatos", "Grupos", "Conversas", "Mensagens" });
                switch (opcao)
                {
                    case 1:
                        MontarMenus("CONTATOS", new string[] { "Visualizar", "Novo", "Remover" });                        
                        break;
                    case 2:
                        MontarMenus("GRUPOS", new string[] { "Visualizar", "Novo", "Remover" });
                        break;
                    case 3:
                        MontarMenus("CONVERSAS", new string[] { "Visualizar todas", "Nova", "Remover" });
                        break;
                    case 4:
                        MontarMenus("MENSAGENS", new string[] { "Visualizar todas", "Nova", "Remover" });
                        break;
                }
            } while (opcao != 99);           
            */
            conversas.Add(new Conversa() { Codigo = 1, Nome = "Conversa com Rodrigo", Hora_ultima_msg = DateTime.Now.ToLongTimeString() });
            conversas.Add(new Conversa() { Codigo = 1, Nome = "Conversa com Rodrigo", Hora_ultima_msg = DateTime.Now.ToLongTimeString() });
            conversas.Add(new Conversa() { Codigo = 1, Nome = "Conversa com Rodrigo", Hora_ultima_msg = DateTime.Now.ToLongTimeString() });
            conversas.Add(new Conversa() { Codigo = 1, Nome = "Conversa com Rodrigo", Hora_ultima_msg = DateTime.Now.ToLongTimeString() });
            conversas.Add(new Conversa() { Codigo = 1, Nome = "Conversa com Rodrigo", Hora_ultima_msg = DateTime.Now.ToLongTimeString() });
            conversas.Add(new Conversa() { Codigo = 1, Nome = "Conversa com Rodrigo", Hora_ultima_msg = DateTime.Now.ToLongTimeString() });
            conversas.Add(new Conversa() { Codigo = 1, Nome = "Conversa com Rodrigo", Hora_ultima_msg = DateTime.Now.ToLongTimeString() });
            conversas.Add(new Conversa() { Codigo = 1, Nome = "Conversa com Rodrigo", Hora_ultima_msg = DateTime.Now.ToLongTimeString() });
            VisualizarItens(conversas);
            Console.ReadKey();
        }
    }
}
