using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundo_tp_aed
{
    public static class ArquivoUtil
    {
        public static void novo(string diretorio, string nome)
        {
            string path = @"" + diretorio + "/" + nome;
            if (!File.Exists(path))
            {
                File.Create(path);
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine("The very first line!");
                tw.Close();
            }
            else if (File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine("The next line!");
                    tw.Close();
                }
            }
        }
    }
}
