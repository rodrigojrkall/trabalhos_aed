using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundo_tp_aed
{
    public static class VetorUtil
    {
        public static int[] gerarAleatorio(int tamanho)
        {
            int[] vetor = new int[tamanho];

            var rand = new Random();

            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = rand.Next(1, tamanho);
            }

            return vetor;
        }

        public static int[] bubbleSort(int[] vetor)
        {
            bool trocando;
            int tamanho = vetor.Length;
            do
            {
                trocando = false;
                tamanho--;
                for (int i = 0; i < tamanho; i++)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        int aux = vetor[i + 1];
                        vetor[i + 1] = vetor[i];
                        vetor[i] = aux;
                        trocando = true;
                    }
                }
            } while (trocando);

            return vetor;
        }
    }
}
