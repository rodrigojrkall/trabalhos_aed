namespace tp_aed.Forms
{
    partial class frm_mensagens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.dgv_mensagens = new System.Windows.Forms.DataGridView();
            this.txt_nova_mensagem = new System.Windows.Forms.TextBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dara_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mensagens)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(595, 313);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(81, 35);
            this.btn_enviar.TabIndex = 2;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(12, 9);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(0, 20);
            this.lbl_nome.TabIndex = 3;
            // 
            // dgv_mensagens
            // 
            this.dgv_mensagens.AllowUserToAddRows = false;
            this.dgv_mensagens.AllowUserToDeleteRows = false;
            this.dgv_mensagens.AllowUserToResizeColumns = false;
            this.dgv_mensagens.AllowUserToResizeRows = false;
            this.dgv_mensagens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_mensagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mensagens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.dara_hora,
            this.mensagem});
            this.dgv_mensagens.Location = new System.Drawing.Point(16, 48);
            this.dgv_mensagens.Name = "dgv_mensagens";
            this.dgv_mensagens.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_mensagens.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_mensagens.RowTemplate.ReadOnly = true;
            this.dgv_mensagens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mensagens.Size = new System.Drawing.Size(882, 238);
            this.dgv_mensagens.TabIndex = 4;
            // 
            // txt_nova_mensagem
            // 
            this.txt_nova_mensagem.AcceptsReturn = true;
            this.txt_nova_mensagem.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nova_mensagem.Location = new System.Drawing.Point(16, 292);
            this.txt_nova_mensagem.Multiline = true;
            this.txt_nova_mensagem.Name = "txt_nova_mensagem";
            this.txt_nova_mensagem.Size = new System.Drawing.Size(573, 56);
            this.txt_nova_mensagem.TabIndex = 5;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(709, 292);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 6;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(823, 292);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Fechar";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // dara_hora
            // 
            this.dara_hora.DataPropertyName = "data_hora";
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = null;
            this.dara_hora.DefaultCellStyle = dataGridViewCellStyle3;
            this.dara_hora.FillWeight = 220F;
            this.dara_hora.HeaderText = "Enviada em";
            this.dara_hora.MinimumWidth = 220;
            this.dara_hora.Name = "dara_hora";
            this.dara_hora.ReadOnly = true;
            this.dara_hora.Width = 220;
            // 
            // mensagem
            // 
            this.mensagem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mensagem.DataPropertyName = "texto";
            this.mensagem.HeaderText = "Mensagem";
            this.mensagem.Name = "mensagem";
            this.mensagem.ReadOnly = true;
            // 
            // frm_mensagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 356);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.txt_nova_mensagem);
            this.Controls.Add(this.dgv_mensagens);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_enviar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_mensagens";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mensagens";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mensagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.DataGridView dgv_mensagens;
        private System.Windows.Forms.TextBox txt_nova_mensagem;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dara_hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensagem;
    }
}