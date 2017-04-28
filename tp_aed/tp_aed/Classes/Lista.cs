using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_aed.Classes
{
    public class elemento
    {
        public object objeto;
        public elemento proximo;

        public elemento(object objeto)
        {
            this.objeto = objeto;
        }
    }

    public class lista
    {
        public elemento inicio;
        public int tamanho = 0;

        public bool vazio()
        {
            return tamanho == 0;
        }

        public void inserir(object objeto)
        {
            elemento novo = new elemento(objeto);
            novo.proximo = inicio;
            inicio = novo;

            tamanho++;
        }

        public void remover(object objeto)
        {
            elemento aux = inicio;
            elemento anterior = null;

            while (aux != null && aux.objeto != objeto)
            {
                anterior = aux;
                aux = aux.proximo;
            }
            if (aux == null)
                return;
            else
            {
                if (anterior != null)
                    anterior.proximo = aux.proximo;
                else
                    inicio = inicio.proximo;

                tamanho--;
            }
        }

        public List<object> listarElementos()
        {
            List<object> elementos = new List<object>();
            elemento aux = inicio;

            while (aux != null)
            {
                elementos.Add(aux.objeto);
                aux = aux.proximo;
            }

            return elementos;
        }  
        
        public object pesquisar(object objeto)
        {
            elemento aux = inicio;

            while( aux != null && aux.objeto != objeto)            
                aux = aux.proximo;

            return aux.objeto;
        }      
    }   
}
