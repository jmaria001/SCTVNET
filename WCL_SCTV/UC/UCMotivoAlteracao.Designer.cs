namespace WCL_SCTV
{
    partial class UCMotivoAlteracao
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
            this.dataGridViewColumnCod_Alteracao = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumnDescricao = new System.Windows.Forms.DataGridViewColumn();
            this.asmxMotivo = new MSAClass.AsmxMotivo.asmxMotivo();
            this.dtsMotivo = new MSAClass.AsmxMotivo.dtsMotivo();
            ((System.ComponentModel.ISupportInitialize)(this.dtsMotivo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.MaxLength = 3;
            // 
            // dataGridViewColumnCod_Alteracao
            // 
            this.dataGridViewColumnCod_Alteracao.DataPropertyName = "Cod_Alteracao";
            this.dataGridViewColumnCod_Alteracao.HeaderText = "Código";
            this.dataGridViewColumnCod_Alteracao.Name = "dataGridViewColumnCod_Alteracao";
            this.dataGridViewColumnCod_Alteracao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewColumnDescricao
            // 
            this.dataGridViewColumnDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumnDescricao.DataPropertyName = "Descricao";
            this.dataGridViewColumnDescricao.HeaderText = "Descrição";
            this.dataGridViewColumnDescricao.Name = "dataGridViewColumnDescricao";
            this.dataGridViewColumnDescricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // asmxMotivo
            // 
            this.asmxMotivo.Credentials = null;
            this.asmxMotivo.Url = "http://localhost/WebServiceMSA/asmxMotivo.asmx";
            this.asmxMotivo.UseDefaultCredentials = false;
            // 
            // dtsMotivo
            // 
            this.dtsMotivo.DataSetName = "dtsMotivo";
            this.dtsMotivo.Locale = new System.Globalization.CultureInfo("en-US");
            this.dtsMotivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UCMotivoAlteracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CodigoLength = 3;
            this.Columns = new System.Windows.Forms.DataGridViewColumn[] {
        this.dataGridViewColumnCod_Alteracao,
        this.dataGridViewColumnDescricao};
            this.Name = "UCMotivoAlteracao";
            this.WindowText = "Pesquisa Motivo de Alteração";
            this.Load += new System.EventHandler(this.UCMotivoAlteracao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsMotivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnCod_Alteracao;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnDescricao;
        private MSAClass.AsmxMotivo.asmxMotivo asmxMotivo;
        private MSAClass.AsmxMotivo.dtsMotivo dtsMotivo;
    }
}
