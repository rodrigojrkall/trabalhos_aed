using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_20170324.Classes
{
    public class Fila
    {
        public Elemento Inicio { get; set; }
        public Elemento Fim { get; set; }
        public int Tamanho { get; set; }

        public Fila()
        {
            Inicio = null;
            Fim = null;
            Tamanho = 0;
        }

        public bool Vazia()
        {
            return Inicio == null;
        }

        public void Enfileirar(int x)
        {
            Elemento novo = new Elemento(); // Construtor com próximo == null
            novo.Numero = x;
            if (Vazia())
                Inicio = novo;
            else
                Fim.Proximo = novo;            
            Fim = novo;
            Tamanho++;
        }

        public Elemento Desenfileirar()
        {
            Elemento aux = Inicio;
            if (!Vazia())
            {
                Inicio = Inicio.Proximo;
                Tamanho--;
                if (Inicio == null)
                    Fim = null;
            }
            return aux;
        }
        public void Esvaziar()
        {
            Inicio = null;
            Fim = null;
            Tamanho = 0;
        }
    }
}