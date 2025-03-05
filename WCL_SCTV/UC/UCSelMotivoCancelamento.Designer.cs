namespace WCL_SCTV
{
    partial class UCSelMotivoCancelamento
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
            this.dataGridViewColumnCod_Cancelamento = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumnDescricao = new System.Windows.Forms.DataGridViewColumn();
            this.asmxMotivo = new MSAClass.AsmxMotivo.asmxMotivo();
            this.dtsMotivo = new MSAClass.AsmxMotivo.dtsMotivo();
            ((System.ComponentModel.ISupportInitialize)(this.dtsMotivo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewColumnCod_Cancelamento
            // 
            this.dataGridViewColumnCod_Cancelamento.DataPropertyName = "Cod_Cancelamento";
            this.dataGridViewColumnCod_Cancelamento.HeaderText = "Código";
            this.dataGridViewColumnCod_Cancelamento.Name = "dataGridViewColumnCod_Cancelamento";
            this.dataGridViewColumnCod_Cancelamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // UCSelMotivoCancelamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Columns = new System.Windows.Forms.DataGridViewColumn[] {
        this.dataGridViewColumnCod_Cancelamento,
        this.dataGridViewColumnDescricao};
            this.Name = "UCSelMotivoCancelamento";
            this.WindowText = "Seleciona Motivo de Cancelamento";
            this.Load += new System.EventHandler(this.UCSelMotivoCancelamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsMotivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnCod_Cancelamento;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnDescricao;
        private MSAClass.AsmxMotivo.asmxMotivo asmxMotivo;
        private MSAClass.AsmxMotivo.dtsMotivo dtsMotivo;
    }
}
