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
    public partial class frm_novo_grupo : Form
    {
        public grupo grupo { get; set; }

        public frm_novo_grupo(lista contatos)
        {
            InitializeComponent();

            iniciarDataGrid(contatos);
        }

        public void iniciarDataGrid(lista contatos)
        {
            dgv_contatos.AutoGenerateColumns = false;
            dgv_contatos.DataSource = contatos.listarElementos();
        }

        public lista listarContatosSelecionados()
        {
            lista contatos = new lista();
            foreach (DataGridViewRow item in dgv_contatos.Rows)
            {
                if (item.Cells[0].Value != null && (bool)item.Cells[0].Value == true)
                    contatos.inserir((contato)item.DataBoundItem);
            }

            return contatos;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            grupo = new grupo();
            grupo.identificacao_criador = txt_identificacao_criador.Text;
            grupo.nome = txt_nome.Text;
            grupo.contatos = listarContatosSelecionados();
            grupo.data_criacao = DateTime.Now;
            if(grupo.contatos.vazio())
            {
                MessageBox.Show("Selecione pelo menos um contato antes de criar um novo grupo.", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
