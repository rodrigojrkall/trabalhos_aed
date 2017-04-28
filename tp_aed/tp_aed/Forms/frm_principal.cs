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
        public lista grupos { get; set; }
        public lista conversas { get; set; }

        public frm_principal()
        {
            InitializeComponent();

            contatos = new lista();
            grupos = new lista();
            conversas = new lista();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void atualizarGridConversas()
        {
            dgv_conversas.AutoGenerateColumns = false;
            dgv_conversas.DataSource = conversas.listarElementos();

            btn_excluir_conversa.Enabled = !conversas.vazio();
            btn_ver_conversa.Enabled = !conversas.vazio();
        }

        public void atualizarGridContatos()
        {
            dgv_contatos.AutoGenerateColumns = false;
            dgv_contatos.DataSource = contatos.listarElementos();

            btn_excluir_contato.Enabled = !contatos.vazio();
            btn_conversa_contato.Enabled = !contatos.vazio();
        }

        public void atualizarGridGrupos()
        {
            dgv_grupos.AutoGenerateColumns = false;
            dgv_grupos.DataSource = grupos.listarElementos();

            btn_excluir_grupo.Enabled = !grupos.vazio();
            btn_ver_contatos.Enabled = !grupos.vazio();
        }

        private void btn_novo_contato_Click(object sender, EventArgs e)
        {
            frm_novo_contato novo = new frm_novo_contato();
            novo.ShowDialog();

            if (novo.contato != null)
            {
                int ultCodigo = 0;
                if (contatos.inicio != null)
                    ultCodigo = ((contato)contatos.inicio.objeto).codigo;

                novo.contato.codigo = ultCodigo + 1;
                contatos.inserir(novo.contato);
                atualizarGridContatos();
            }
        }

        private void btn_excluir_contato_Click(object sender, EventArgs e)
        {
            var contatoExcluir = (contato)dgv_contatos.SelectedRows[0].DataBoundItem;
            contatos.remover(contatoExcluir);
            atualizarGridContatos();
        }

        private void btn_conversa_contato_Click(object sender, EventArgs e)
        {
            var contatoSelecionado = (contato)dgv_contatos.SelectedRows[0].DataBoundItem;

            conversa conversa = verificarConversas(contatoSelecionado);

            if (conversa == null)
                conversa = new conversa();

            conversa.nome = contatoSelecionado.nome;
            conversa.contato = contatoSelecionado;

            frm_mensagens frm_mensagens = new frm_mensagens(conversa, contatoSelecionado);
            frm_mensagens.ShowDialog();

            conversa.mensagens = frm_mensagens.mensagens;

            if (conversa.mensagens != null && conversa.mensagens.inicio != null)
            {
                conversa.data_hora_ultima_mensagem = ((mensagem)conversa.mensagens.inicio.objeto).data_hora;
            }

            int ultCodigo = 0;
            if (conversas.inicio != null)
                ultCodigo = ((conversa)conversas.inicio.objeto).codigo;

            conversa.codigo = ultCodigo + 1;

            conversas.remover(conversa);
            conversas.inserir(conversa);

            atualizarGridConversas();
        }

        private void btn_novo_grupo_Click(object sender, EventArgs e)
        {

            if (contatos.vazio())
            {
                MessageBox.Show("Adicione pelo menos um contato antes de criar um novo grupo.", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frm_novo_grupo novo = new frm_novo_grupo(contatos);
            novo.ShowDialog();

            if (novo.grupo != null)
            {
                int ultCodigo = 0;
                if (grupos.inicio != null)
                    ultCodigo = ((grupo)grupos.inicio.objeto).codigo;

                novo.grupo.codigo = ultCodigo + 1;
                grupos.inserir(novo.grupo);
                atualizarGridGrupos();
            }
        }

        private void btn_excluir_grupo_Click(object sender, EventArgs e)
        {
            var grupoExcluir = (grupo)dgv_grupos.SelectedRows[0].DataBoundItem;
            grupos.remover(grupoExcluir);
            atualizarGridGrupos();
        }

        private void btn_ver_conversa_Click(object sender, EventArgs e)
        {
            var conversaSelecionada = (conversa)dgv_conversas.SelectedRows[0].DataBoundItem;
            frm_mensagens frm_mensagens = new frm_mensagens(conversaSelecionada, conversaSelecionada.contato);
            frm_mensagens.ShowDialog();

            conversa conversa = (conversa)conversas.pesquisar(conversaSelecionada);

            conversa.mensagens = frm_mensagens.mensagens;
            if (conversa.mensagens.inicio != null)
                conversa.data_hora_ultima_mensagem = ((mensagem)frm_mensagens.mensagens.inicio.objeto).data_hora;

            atualizarGridConversas();
        }

        private void btn_excluir_conversa_Click(object sender, EventArgs e)
        {
            var conversaSelecionada = (conversa)dgv_conversas.SelectedRows[0].DataBoundItem;
            conversas.remover(conversaSelecionada);

            atualizarGridConversas();
        }

        private conversa verificarConversas(contato contato)
        {
            elemento aux = conversas.inicio;
            while (aux != null && ((conversa)aux.objeto).contato != contato)
                aux = aux.proximo;

            if (aux != null)
                return (conversa)aux.objeto;
            else
                return null;
        }

        private void btn_ver_contatos_Click(object sender, EventArgs e)
        {
            var grupoSelecionado = (grupo)dgv_grupos.SelectedRows[0].DataBoundItem;

            frm_contatos frm_contatos = new frm_contatos(grupoSelecionado.contatos);
            frm_contatos.ShowDialog();
        }
    }
}
