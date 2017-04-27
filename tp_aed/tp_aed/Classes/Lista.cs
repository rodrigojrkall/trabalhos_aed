using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_aed.Classes
{
    public class lista
    {
        protected elemento inicio;
        protected elemento fim;
        protected int tamanho;

        public bool Vazio()
        {
            return tamanho == 0;
        }

        public void Inserir(elemento novo)
        {
            novo.proximo = inicio;
            novo.anterior = null;
            if (inicio != null)
                inicio.anterior = novo;

            inicio = novo;            

        }

    }
    public class contatos : lista
    {
        private Object inicio;
        private Object fim;
        private int tamanho;

        public bool Vazio()
        {
            return tamanho == 0;
        }
    }

    public class grupos
    {
        private Object inicio;
        private Object fim;
        private int tamanho;

        public bool Vazio()
        {
            return tamanho == 0;
        }
    }

    public class conversas
    {
        private Object inicio;
        private Object fim;
        private int tamanho;

        public bool Vazio()
        {
            return tamanho == 0;
        }
    }

    public class mensagens
    {
        private Object inicio;
        private Object fim;
        private int tamanho;

        public bool Vazio()
        {
            return tamanho == 0;
        }
    }
}
