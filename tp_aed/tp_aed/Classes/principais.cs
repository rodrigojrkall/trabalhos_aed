﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_aed.Classes
{

    public class contato
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }

        public contato()
        {
            this.codigo = 0;            
        }
    }

    public class grupo
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public DateTime data_criacao { get; set; }
        public string identificacao_criador { get; set; }
        public lista contatos { get; set; }
    }

    public class conversa
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public DateTime data_hora_ultima_mensagem { get; set; }
        public lista mensagens { get; set; }
        public contato contato { get; set; }
    }

    public class mensagem
    {
        public int codigo { get; set; }
        public string texto { get; set; }
        public contato destinatario { get; set; }
        public DateTime data_hora { get; set; }
    }

}
