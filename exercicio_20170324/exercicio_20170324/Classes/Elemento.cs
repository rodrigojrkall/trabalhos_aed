using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_20170324.Classes
{
    public class Elemento
    {
        public int Numero { get; set; }
        public Elemento Proximo { get; set; }
        /// <summary>
        /// Inicia Proximo com NULL 
        /// </summary>
        public Elemento()
        {
            Proximo = null;
        }
    }
}
