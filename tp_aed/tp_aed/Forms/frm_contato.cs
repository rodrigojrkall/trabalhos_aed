using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_aed.Classes;

namespace tp_aed.Forms
{
    public partial class frm_contato : Form
    {
        public contato contato { get; set; }

        public frm_contato()
        {
            InitializeComponent();
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            contato = new contato();
            contato.nome = txt_nome.Text;
            contato.telefone = txt_telefone.Text;

            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            contato = null;
            this.Close();
        }
    }
}
