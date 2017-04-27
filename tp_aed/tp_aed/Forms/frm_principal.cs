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
    public partial class frm_principal : Form
    {
        public lista contatos { get; set; }
        
        public frm_principal()
        {
            InitializeComponent();

            contatos = new lista();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void atualizarGridContatos()
        {
            dgv_contatos.DataSource = contatos.listarElementos();
        }

        private void btn_novo_contato_Click(object sender, EventArgs e)
        {
            frm_contato novo = new frm_contato();
            novo.ShowDialog();

            if (novo != null)
            {
                int ultCodigo = 0;
                if (contatos.inicio != null)
                    ultCodigo = ((contato)contatos.inicio.objeto).codigo;

                novo.contato.codigo = ultCodigo + 1;
                contatos.inserir(novo.contato);
                atualizarGridContatos();
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var contatoExcluir = (contato)dgv_contatos.SelectedRows[0].DataBoundItem;          
            contatos.remover(contatoExcluir);
            atualizarGridContatos();
        }
    }
}
