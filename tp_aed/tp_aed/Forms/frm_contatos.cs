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
    public partial class frm_contatos : Form
    {
        public frm_contatos(lista contatos)
        {
            InitializeComponent();

            dgv_contatos.DataSource = contatos.listarElementos();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
