namespace WCL_SCTV
{
    partial class UCTerceiro
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.asmxTerceiro = new MSAClass.AsmxTerceiro.asmxTerceiro();
            this.dtsTerceiro = new MSAClass.AsmxTerceiro.dtsTerceiro();
            this.dataGridViewColumnCod_Terceiro = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumnRazao_Social = new System.Windows.Forms.DataGridViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTerceiro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Size = new System.Drawing.Size(52, 20);
            this.txtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigo_Validating);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // asmxTerceiro
            // 
            this.asmxTerceiro.Credentials = null;
            this.asmxTerceiro.Url = "http://localhost/WebServiceMSA/asmxTerceiro.asmx";
            this.asmxTerceiro.UseDefaultCredentials = false;
            // 
            // dtsTerceiro
            // 
            this.dtsTerceiro.DataSetName = "dtsTerceiro";
            this.dtsTerceiro.Locale = new System.Globalization.CultureInfo("en-US");
            this.dtsTerceiro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewColumnCod_Terceiro
            // 
            this.dataGridViewColumnCod_Terceiro.DataPropertyName = "Cod_Terceiro";
            this.dataGridViewColumnCod_Terceiro.HeaderText = "Código";
            this.dataGridViewColumnCod_Terceiro.Name = "dataGridViewColumnCod_Terceiro";
            this.dataGridViewColumnCod_Terceiro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewColumnRazao_Social
            // 
            this.dataGridViewColumnRazao_Social.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumnRazao_Social.DataPropertyName = "Razao_Social";
            this.dataGridViewColumnRazao_Social.HeaderText = "Razão Social";
            this.dataGridViewColumnRazao_Social.Name = "dataGridViewColumnRazao_Social";
            this.dataGridViewColumnRazao_Social.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UCTerceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CodigoLength = 6;
            this.Columns = new System.Windows.Forms.DataGridViewColumn[] {
        this.dataGridViewColumnCod_Terceiro,
        this.dataGridViewColumnRazao_Social};
            this.Name = "UCTerceiro";
            this.WindowText = "Pesquisa Terceiro";
            this.Load += new System.EventHandler(this.UCTerceiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsTerceiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MSAClass.AsmxTerceiro.asmxTerceiro asmxTerceiro;
        private MSAClass.AsmxTerceiro.dtsTerceiro dtsTerceiro;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnCod_Terceiro;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnRazao_Social;
    }
}
