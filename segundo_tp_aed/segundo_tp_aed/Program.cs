using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundo_tp_aed
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 100000;

            int[] vetor = VetorUtil.gerarAleatorio(tamanho);            
            var inicio = DateTime.Now;
            int[] vetorOrdenado = VetorUtil.bubbleSort(vetor);
            var fim = DateTime.Now;            
            var tempoGasto = fim - inicio;

            Console.WriteLine(tempoGasto.TotalMilliseconds);

            Console.ReadKey();
        }
    }
}
