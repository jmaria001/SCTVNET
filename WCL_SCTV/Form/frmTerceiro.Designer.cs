namespace WCL_SCTV
{
    partial class frmTerceiro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTerceiro));
            this.dtsTerceiro = new MSAClass.AsmxTerceiro.dtsTerceiro();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.codTerceiroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPesquisarCodigo = new System.Windows.Forms.Button();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnPesquisarRazaoSocial = new System.Windows.Forms.Button();
            this.asmxTerceiro = new MSAClass.AsmxTerceiro.asmxTerceiro();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisarCNPJCPF = new System.Windows.Forms.Button();
            this.ucCNPJ_CPF = new WCL_SCTV.UC.UCCNPJ_CPF();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTerceiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtsTerceiro
            // 
            this.dtsTerceiro.DataSetName = "dtsTerceiro";
            this.dtsTerceiro.Locale = new System.Globalization.CultureInfo("en-US");
            this.dtsTerceiro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPesquisa.AutoGenerateColumns = false;
            this.dgvPesquisa.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTerceiroDataGridViewTextBoxColumn,
            this.razaoSocialDataGridViewTextBoxColumn,
            this.nomeFantasiaDataGridViewTextBoxColumn});
            this.dgvPesquisa.DataMember = "dtbTerceiro_Pesquisa";
            this.dgvPesquisa.DataSource = this.dtsTerceiro;
            this.dgvPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPesquisa.Location = new System.Drawing.Point(3, 96);
            this.dgvPesquisa.MultiSelect = false;
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.RowHeadersVisible = false;
            this.dgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisa.Size = new System.Drawing.Size(626, 319);
            this.dgvPesquisa.TabIndex = 1;
            this.dgvPesquisa.DoubleClick += new System.EventHandler(this.dgvPesquisa_DoubleClick);
            // 
            // codTerceiroDataGridViewTextBoxColumn
            // 
            this.codTerceiroDataGridViewTextBoxColumn.DataPropertyName = "Cod_Terceiro";
            this.codTerceiroDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codTerceiroDataGridViewTextBoxColumn.Name = "codTerceiroDataGridViewTextBoxColumn";
            this.codTerceiroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            this.razaoSocialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "Razao_Social";
            this.razaoSocialDataGridViewTextBoxColumn.HeaderText = "Razão Social";
            this.razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            this.razaoSocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeFantasiaDataGridViewTextBoxColumn
            // 
            this.nomeFantasiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeFantasiaDataGridViewTextBoxColumn.DataPropertyName = "Nome_Fantasia";
            this.nomeFantasiaDataGridViewTextBoxColumn.HeaderText = "Nome Fantasia";
            this.nomeFantasiaDataGridViewTextBoxColumn.Name = "nomeFantasiaDataGridViewTextBoxColumn";
            this.nomeFantasiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Image = global::WCL_SCTV.ResourceIMG.imgUnChecked;
            this.btnFechar.Location = new System.Drawing.Point(540, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(83, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSelecionar);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 29);
            this.panel2.TabIndex = 2;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelecionar.Image = global::WCL_SCTV.ResourceIMG.imgChecked;
            this.btnSelecionar.Location = new System.Drawing.Point(451, 3);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(83, 23);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "&Selecionar";
            this.btnSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvPesquisa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 453);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnPesquisarCodigo, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCodigo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ucCNPJ_CPF, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtRazaoSocial, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnPesquisarCNPJCPF, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnPesquisarRazaoSocial, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(626, 87);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnPesquisarCodigo
            // 
            this.btnPesquisarCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarCodigo.Enabled = false;
            this.btnPesquisarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarCodigo.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarCodigo.Image")));
            this.btnPesquisarCodigo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarCodigo.Location = new System.Drawing.Point(533, 3);
            this.btnPesquisarCodigo.Name = "btnPesquisarCodigo";
            this.btnPesquisarCodigo.Size = new System.Drawing.Size(85, 22);
            this.btnPesquisarCodigo.TabIndex = 2;
            this.btnPesquisarCodigo.Text = "&Pesquisar";
            this.btnPesquisarCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarCodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarCodigo.UseVisualStyleBackColor = true;
            this.btnPesquisarCodigo.Click += new System.EventHandler(this.btnPesquisarCodigo_Click);
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Location = new System.Drawing.Point(103, 61);
            this.txtRazaoSocial.MaxLength = 50;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(420, 20);
            this.txtRazaoSocial.TabIndex = 7;
            this.txtRazaoSocial.TextChanged += new System.EventHandler(this.txtRazaoSocial_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Razão Social:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(103, 4);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(64, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // btnPesquisarRazaoSocial
            // 
            this.btnPesquisarRazaoSocial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarRazaoSocial.Enabled = false;
            this.btnPesquisarRazaoSocial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarRazaoSocial.Image = global::WCL_SCTV.ResourceIMG.imgLocalizar;
            this.btnPesquisarRazaoSocial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarRazaoSocial.Location = new System.Drawing.Point(533, 60);
            this.btnPesquisarRazaoSocial.Name = "btnPesquisarRazaoSocial";
            this.btnPesquisarRazaoSocial.Size = new System.Drawing.Size(85, 23);
            this.btnPesquisarRazaoSocial.TabIndex = 8;
            this.btnPesquisarRazaoSocial.Text = "&Pesquisar";
            this.btnPesquisarRazaoSocial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarRazaoSocial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarRazaoSocial.UseVisualStyleBackColor = true;
            this.btnPesquisarRazaoSocial.Click += new System.EventHandler(this.btnPesquisarRazaoSocial_Click);
            // 
            // asmxTerceiro
            // 
            this.asmxTerceiro.Credentials = null;
            this.asmxTerceiro.Url = "http://localhost/WebServiceMSA/asmxTerceiro.asmx";
            this.asmxTerceiro.UseDefaultCredentials = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CNPJ / CPF:";
            // 
            // btnPesquisarCNPJCPF
            // 
            this.btnPesquisarCNPJCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarCNPJCPF.Enabled = false;
            this.btnPesquisarCNPJCPF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarCNPJCPF.Image = global::WCL_SCTV.ResourceIMG.imgLocalizar;
            this.btnPesquisarCNPJCPF.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarCNPJCPF.Location = new System.Drawing.Point(533, 31);
            this.btnPesquisarCNPJCPF.Name = "btnPesquisarCNPJCPF";
            this.btnPesquisarCNPJCPF.Size = new System.Drawing.Size(85, 22);
            this.btnPesquisarCNPJCPF.TabIndex = 5;
            this.btnPesquisarCNPJCPF.Text = "&Pesquisar";
            this.btnPesquisarCNPJCPF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarCNPJCPF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarCNPJCPF.UseVisualStyleBackColor = true;
            this.btnPesquisarCNPJCPF.Click += new System.EventHandler(this.btnPesquisarCNPJCPF_Click);
            // 
            // ucCNPJ_CPF
            // 
            this.ucCNPJ_CPF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ucCNPJ_CPF.CNPJ_CPF = null;
            this.ucCNPJ_CPF.Location = new System.Drawing.Point(103, 31);
            this.ucCNPJ_CPF.Name = "ucCNPJ_CPF";
            this.ucCNPJ_CPF.Permite_Limpar = true;
            this.ucCNPJ_CPF.Size = new System.Drawing.Size(150, 22);
            this.ucCNPJ_CPF.TabIndex = 4;
            this.ucCNPJ_CPF.Validating += new System.ComponentModel.CancelEventHandler(this.ucCNPJ_CPF_Validating);
            // 
            // frmTerceiro
            // 
            this.AcceptButton = this.btnSelecionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "frmTerceiro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terceiro";
            ((System.ComponentModel.ISupportInitialize)(this.dtsTerceiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected internal MSAClass.AsmxTerceiro.dtsTerceiro dtsTerceiro;
        protected internal System.Windows.Forms.Button btnSelecionar;
        protected internal MSAClass.AsmxTerceiro.asmxTerceiro asmxTerceiro;
        protected internal System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Button btnPesquisarRazaoSocial;
        private System.Windows.Forms.Button btnPesquisarCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTerceiroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private WCL_SCTV.UC.UCCNPJ_CPF ucCNPJ_CPF;
        private System.Windows.Forms.Button btnPesquisarCNPJCPF;
    }
}