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
    public partial class frm_mensagens : Form
    {
        public lista mensagens { get; set; }

        public contato destinatario { get; set; }

        public frm_mensagens(conversa conversa, contato _destinatario)
        {
            InitializeComponent();

            if (conversa.mensagens == null)
                mensagens = new lista();
            else
            {
                mensagens = conversa.mensagens;
                atualizarDataGridMensagens();
            }

            lbl_nome.Text = "Conversa com " + conversa.nome;
            destinatario = _destinatario;

            dgv_mensagens.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        public void atualizarDataGridMensagens()
        {
            dgv_mensagens.AutoGenerateColumns = false;
            dgv_mensagens.DataSource = mensagens.listarElementos();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            mensagem nova = new mensagem();

            nova.texto = txt_nova_mensagem.Text;
            nova.destinatario = destinatario;
            nova.data_hora = DateTime.Now;

            int ultCodigo = 0;
            if (mensagens.inicio != null)
                ultCodigo = ((mensagem)mensagens.inicio.objeto).codigo;

            nova.codigo = ultCodigo + 1;
            mensagens.inserir(nova);

            atualizarDataGridMensagens();

            txt_nova_mensagem.Text = "";
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var mensagemSelecionada = (mensagem)dgv_mensagens.SelectedRows[0].DataBoundItem;

            mensagens.remover(mensagemSelecionada);

            atualizarDataGridMensagens();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
