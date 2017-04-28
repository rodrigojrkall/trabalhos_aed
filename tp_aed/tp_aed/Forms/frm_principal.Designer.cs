namespace tp_aed.Forms
{
    partial class frm_principal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_conversas = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_conversas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_excluir_conversa = new System.Windows.Forms.Button();
            this.btn_ver_conversa = new System.Windows.Forms.Button();
            this.tab_geral = new System.Windows.Forms.TabControl();
            this.tab_contatos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_contatos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_excluir_contato = new System.Windows.Forms.Button();
            this.btn_novo_contato = new System.Windows.Forms.Button();
            this.btn_conversa_contato = new System.Windows.Forms.Button();
            this.tab_grupos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_novo_grupo = new System.Windows.Forms.Button();
            this.btn_excluir_grupo = new System.Windows.Forms.Button();
            this.dgv_grupos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacao_criador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_criacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ultima_mensagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ver_contatos = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tab_conversas.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_conversas)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tab_geral.SuspendLayout();
            this.tab_contatos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contatos)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tab_grupos.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tab_conversas
            // 
            this.tab_conversas.Controls.Add(this.tableLayoutPanel1);
            this.tab_conversas.Location = new System.Drawing.Point(4, 26);
            this.tab_conversas.Name = "tab_conversas";
            this.tab_conversas.Padding = new System.Windows.Forms.Padding(3);
            this.tab_conversas.Size = new System.Drawing.Size(708, 431);
            this.tab_conversas.TabIndex = 2;
            this.tab_conversas.Text = "Conversas";
            this.tab_conversas.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dgv_conversas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(702, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_conversas
            // 
            this.dgv_conversas.AllowUserToAddRows = false;
            this.dgv_conversas.AllowUserToDeleteRows = false;
            this.dgv_conversas.AllowUserToResizeColumns = false;
            this.dgv_conversas.AllowUserToResizeRows = false;
            this.dgv_conversas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_conversas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.data_ultima_mensagem});
            this.dgv_conversas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_conversas.Location = new System.Drawing.Point(3, 3);
            this.dgv_conversas.Name = "dgv_conversas";
            this.dgv_conversas.ReadOnly = true;
            this.dgv_conversas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_conversas.Size = new System.Drawing.Size(696, 379);
            this.dgv_conversas.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btn_excluir_conversa, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_ver_conversa, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 388);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(696, 34);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btn_excluir_conversa
            // 
            this.btn_excluir_conversa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_excluir_conversa.Enabled = false;
            this.btn_excluir_conversa.Location = new System.Drawing.Point(467, 3);
            this.btn_excluir_conversa.Name = "btn_excluir_conversa";
            this.btn_excluir_conversa.Size = new System.Drawing.Size(226, 28);
            this.btn_excluir_conversa.TabIndex = 2;
            this.btn_excluir_conversa.Text = "Excluir";
            this.btn_excluir_conversa.UseVisualStyleBackColor = true;
            this.btn_excluir_conversa.Click += new System.EventHandler(this.btn_excluir_conversa_Click);
            // 
            // btn_ver_conversa
            // 
            this.btn_ver_conversa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ver_conversa.Enabled = false;
            this.btn_ver_conversa.Location = new System.Drawing.Point(235, 3);
            this.btn_ver_conversa.Name = "btn_ver_conversa";
            this.btn_ver_conversa.Size = new System.Drawing.Size(226, 28);
            this.btn_ver_conversa.TabIndex = 3;
            this.btn_ver_conversa.Text = "Ver mensagens";
            this.btn_ver_conversa.UseVisualStyleBackColor = true;
            this.btn_ver_conversa.Click += new System.EventHandler(this.btn_ver_conversa_Click);
            // 
            // tab_geral
            // 
            this.tab_geral.Controls.Add(this.tab_contatos);
            this.tab_geral.Controls.Add(this.tab_conversas);
            this.tab_geral.Controls.Add(this.tab_grupos);
            this.tab_geral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_geral.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_geral.Location = new System.Drawing.Point(0, 28);
            this.tab_geral.Name = "tab_geral";
            this.tab_geral.SelectedIndex = 0;
            this.tab_geral.Size = new System.Drawing.Size(716, 461);
            this.tab_geral.TabIndex = 0;
            // 
            // tab_contatos
            // 
            this.tab_contatos.Controls.Add(this.tableLayoutPanel2);
            this.tab_contatos.Location = new System.Drawing.Point(4, 26);
            this.tab_contatos.Name = "tab_contatos";
            this.tab_contatos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_contatos.Size = new System.Drawing.Size(708, 431);
            this.tab_contatos.TabIndex = 3;
            this.tab_contatos.Text = "Contatos";
            this.tab_contatos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.dgv_contatos, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(702, 425);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgv_contatos
            // 
            this.dgv_contatos.AllowUserToAddRows = false;
            this.dgv_contatos.AllowUserToDeleteRows = false;
            this.dgv_contatos.AllowUserToResizeColumns = false;
            this.dgv_contatos.AllowUserToResizeRows = false;
            this.dgv_contatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.telefone});
            this.dgv_contatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_contatos.Location = new System.Drawing.Point(3, 3);
            this.dgv_contatos.Name = "dgv_contatos";
            this.dgv_contatos.ReadOnly = true;
            this.dgv_contatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_contatos.Size = new System.Drawing.Size(696, 379);
            this.dgv_contatos.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.FillWeight = 200F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.btn_excluir_contato, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_novo_contato, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_conversa_contato, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 388);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(696, 34);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btn_excluir_contato
            // 
            this.btn_excluir_contato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_excluir_contato.Enabled = false;
            this.btn_excluir_contato.Location = new System.Drawing.Point(467, 3);
            this.btn_excluir_contato.Name = "btn_excluir_contato";
            this.btn_excluir_contato.Size = new System.Drawing.Size(226, 28);
            this.btn_excluir_contato.TabIndex = 3;
            this.btn_excluir_contato.Text = "Excluir";
            this.btn_excluir_contato.UseVisualStyleBackColor = true;
            this.btn_excluir_contato.Click += new System.EventHandler(this.btn_excluir_contato_Click);
            // 
            // btn_novo_contato
            // 
            this.btn_novo_contato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_novo_contato.Location = new System.Drawing.Point(235, 3);
            this.btn_novo_contato.Name = "btn_novo_contato";
            this.btn_novo_contato.Size = new System.Drawing.Size(226, 28);
            this.btn_novo_contato.TabIndex = 1;
            this.btn_novo_contato.Text = "Adicionar";
            this.btn_novo_contato.UseVisualStyleBackColor = true;
            this.btn_novo_contato.Click += new System.EventHandler(this.btn_novo_contato_Click);
            // 
            // btn_conversa_contato
            // 
            this.btn_conversa_contato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_conversa_contato.Enabled = false;
            this.btn_conversa_contato.Location = new System.Drawing.Point(3, 3);
            this.btn_conversa_contato.Name = "btn_conversa_contato";
            this.btn_conversa_contato.Size = new System.Drawing.Size(226, 28);
            this.btn_conversa_contato.TabIndex = 4;
            this.btn_conversa_contato.Text = "Iniciar conversa";
            this.btn_conversa_contato.UseVisualStyleBackColor = true;
            this.btn_conversa_contato.Click += new System.EventHandler(this.btn_conversa_contato_Click);
            // 
            // tab_grupos
            // 
            this.tab_grupos.Controls.Add(this.tableLayoutPanel3);
            this.tab_grupos.Location = new System.Drawing.Point(4, 26);
            this.tab_grupos.Name = "tab_grupos";
            this.tab_grupos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_grupos.Size = new System.Drawing.Size(708, 431);
            this.tab_grupos.TabIndex = 4;
            this.tab_grupos.Text = "Grupos";
            this.tab_grupos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dgv_grupos, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(702, 425);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.btn_novo_grupo, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_excluir_grupo, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_ver_contatos, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 388);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(696, 34);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // btn_novo_grupo
            // 
            this.btn_novo_grupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_novo_grupo.Location = new System.Drawing.Point(235, 3);
            this.btn_novo_grupo.Name = "btn_novo_grupo";
            this.btn_novo_grupo.Size = new System.Drawing.Size(226, 28);
            this.btn_novo_grupo.TabIndex = 1;
            this.btn_novo_grupo.Text = "Criar";
            this.btn_novo_grupo.UseVisualStyleBackColor = true;
            this.btn_novo_grupo.Click += new System.EventHandler(this.btn_novo_grupo_Click);
            // 
            // btn_excluir_grupo
            // 
            this.btn_excluir_grupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_excluir_grupo.Enabled = false;
            this.btn_excluir_grupo.Location = new System.Drawing.Point(467, 3);
            this.btn_excluir_grupo.Name = "btn_excluir_grupo";
            this.btn_excluir_grupo.Size = new System.Drawing.Size(226, 28);
            this.btn_excluir_grupo.TabIndex = 2;
            this.btn_excluir_grupo.Text = "Excluir";
            this.btn_excluir_grupo.UseVisualStyleBackColor = true;
            this.btn_excluir_grupo.Click += new System.EventHandler(this.btn_excluir_grupo_Click);
            // 
            // dgv_grupos
            // 
            this.dgv_grupos.AllowUserToAddRows = false;
            this.dgv_grupos.AllowUserToDeleteRows = false;
            this.dgv_grupos.AllowUserToResizeColumns = false;
            this.dgv_grupos.AllowUserToResizeRows = false;
            this.dgv_grupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.identificacao_criador,
            this.data_criacao});
            this.dgv_grupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_grupos.Location = new System.Drawing.Point(3, 3);
            this.dgv_grupos.Name = "dgv_grupos";
            this.dgv_grupos.ReadOnly = true;
            this.dgv_grupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_grupos.Size = new System.Drawing.Size(696, 379);
            this.dgv_grupos.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn4.FillWeight = 200F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // identificacao_criador
            // 
            this.identificacao_criador.DataPropertyName = "identificacao_criador";
            this.identificacao_criador.HeaderText = "ID Criador";
            this.identificacao_criador.Name = "identificacao_criador";
            this.identificacao_criador.ReadOnly = true;
            this.identificacao_criador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // data_criacao
            // 
            this.data_criacao.DataPropertyName = "data_criacao";
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = null;
            this.data_criacao.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_criacao.FillWeight = 150F;
            this.data_criacao.HeaderText = "Data criação";
            this.data_criacao.Name = "data_criacao";
            this.data_criacao.ReadOnly = true;
            this.data_criacao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.data_criacao.Width = 150;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 20;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            this.nome.FillWeight = 200F;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // data_ultima_mensagem
            // 
            this.data_ultima_mensagem.DataPropertyName = "data_hora_ultima_mensagem";
            dataGridViewCellStyle4.Format = "G";
            dataGridViewCellStyle4.NullValue = null;
            this.data_ultima_mensagem.DefaultCellStyle = dataGridViewCellStyle4;
            this.data_ultima_mensagem.FillWeight = 150F;
            this.data_ultima_mensagem.HeaderText = "Última mensagem em";
            this.data_ultima_mensagem.MinimumWidth = 150;
            this.data_ultima_mensagem.Name = "data_ultima_mensagem";
            this.data_ultima_mensagem.ReadOnly = true;
            this.data_ultima_mensagem.Width = 150;
            // 
            // btn_ver_contatos
            // 
            this.btn_ver_contatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ver_contatos.Enabled = false;
            this.btn_ver_contatos.Location = new System.Drawing.Point(3, 3);
            this.btn_ver_contatos.Name = "btn_ver_contatos";
            this.btn_ver_contatos.Size = new System.Drawing.Size(226, 28);
            this.btn_ver_contatos.TabIndex = 3;
            this.btn_ver_contatos.Text = "Ver integrantes";
            this.btn_ver_contatos.UseVisualStyleBackColor = true;
            this.btn_ver_contatos.Click += new System.EventHandler(this.btn_ver_contatos_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 489);
            this.Controls.Add(this.tab_geral);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatSimulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab_conversas.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_conversas)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tab_geral.ResumeLayout(false);
            this.tab_contatos.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contatos)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tab_grupos.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabPage tab_conversas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_conversas;
        private System.Windows.Forms.TabControl tab_geral;
        private System.Windows.Forms.TabPage tab_contatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_contatos;
        private System.Windows.Forms.TabPage tab_grupos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgv_grupos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_excluir_conversa;
        private System.Windows.Forms.Button btn_ver_conversa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btn_novo_contato;
        private System.Windows.Forms.Button btn_excluir_contato;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btn_novo_grupo;
        private System.Windows.Forms.Button btn_excluir_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.Button btn_conversa_contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacao_criador;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_criacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ultima_mensagem;
        private System.Windows.Forms.Button btn_ver_contatos;
    }
}

