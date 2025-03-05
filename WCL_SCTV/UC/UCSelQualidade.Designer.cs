namespace WCL_SCTV
{
    partial class UCSelQualidade
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
            this.dataGridViewColumnCod_Qualidade = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumnDescricao = new System.Windows.Forms.DataGridViewColumn();
            this.dtsQualidade = new MSAClass.AsmxQualidade.dtsQualidade();
            this.asmxQualidade = new MSAClass.AsmxQualidade.asmxQualidade();
            ((System.ComponentModel.ISupportInitialize)(this.dtsQualidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewColumnCod_Qualidade
            // 
            this.dataGridViewColumnCod_Qualidade.DataPropertyName = "Cod_Qualidade";
            this.dataGridViewColumnCod_Qualidade.HeaderText = "Código";
            this.dataGridViewColumnCod_Qualidade.Name = "dataGridViewColumnCod_Qualidade";
            // 
            // dataGridViewColumnDescricao
            // 
            this.dataGridViewColumnDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumnDescricao.DataPropertyName = "Descricao";
            this.dataGridViewColumnDescricao.HeaderText = "Descrição";
            this.dataGridViewColumnDescricao.Name = "dataGridViewColumnDescricao";
            this.dataGridViewColumnDescricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dtsQualidade
            // 
            this.dtsQualidade.DataSetName = "dtsQualidade";
            this.dtsQualidade.Locale = new System.Globalization.CultureInfo("en-US");
            this.dtsQualidade.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asmxQualidade
            // 
            this.asmxQualidade.Credentials = null;
            this.asmxQualidade.Url = "http://localhost/WebServiceMSA/asmxQualidade.asmx";
            this.asmxQualidade.UseDefaultCredentials = false;
            // 
            // UCSelQualidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Columns = new System.Windows.Forms.DataGridViewColumn[] {
        this.dataGridViewColumnCod_Qualidade,
        this.dataGridViewColumnDescricao};
            this.Name = "UCSelQualidade";
            this.WindowText = "Seleciona Qualidade";
            this.Load += new System.EventHandler(this.UCSelQualidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsQualidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnCod_Qualidade;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnDescricao;
        private MSAClass.AsmxQualidade.dtsQualidade dtsQualidade;
        private MSAClass.AsmxQualidade.asmxQualidade asmxQualidade;
    }
}
