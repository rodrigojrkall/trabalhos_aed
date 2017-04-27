using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_20170324.Classes
{
    public class Pilha
    {
        public Elemento Topo { get; set; }
        public int Tamanho { get; set; }

        public Pilha()
        {
            Topo = null;
            Tamanho = 0;
        }

        public bool Vazia()
        {
            return Topo == null;
        }

        public void Empilhar(int x)
        {
            Elemento novo = new Elemento();
            novo.Numero = x;
            novo.Proximo = Topo;
            Topo = novo;
            Tamanho++;
        }

        public Elemento Desempilhar(int x)
        {
            if (Vazia())
                return null;

            Elemento aux = Topo;
            Topo = aux.Proximo;
            Tamanho--;
            return aux;
        }

        public void Esvaziar()
        {
            Topo = null;
            Tamanho = 0;
        }

        public void Exibir()
        {
            Elemento aux = Topo;
            int cont = Tamanho;
            while (aux != null)
            {
                Console.WriteLine("{0} - {1}", --cont, aux.Numero);
                aux = aux.Proximo;
            }
            Console.WriteLine("{0} elementos exibidos.", Tamanho);
        }
    }

}