namespace WCL_SCTV
{
    partial class UCSelTipoMidia
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
            this.dataGridViewColumnCod_Tipo_Midia = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumnDescricao = new System.Windows.Forms.DataGridViewColumn();
            this.asmxTipoMidia = new MSAClass.AsmxTipoMidia.asmxTipoMidia();
            this.dtsTipoMidia = new MSAClass.AsmxTipoMidia.dtsTipoMidia();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTipoMidia)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewColumnCod_Tipo_Midia
            // 
            this.dataGridViewColumnCod_Tipo_Midia.DataPropertyName = "Cod_Tipo_Midia";
            this.dataGridViewColumnCod_Tipo_Midia.HeaderText = "Código";
            this.dataGridViewColumnCod_Tipo_Midia.Name = "dataGridViewColumnCod_Tipo_Midia";
            this.dataGridViewColumnCod_Tipo_Midia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewColumnDescricao
            // 
            this.dataGridViewColumnDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumnDescricao.DataPropertyName = "Descricao";
            this.dataGridViewColumnDescricao.HeaderText = "Descrição";
            this.dataGridViewColumnDescricao.Name = "dataGridViewColumnDescricao";
            this.dataGridViewColumnDescricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // asmxTipoMidia
            // 
            this.asmxTipoMidia.Credentials = null;
            this.asmxTipoMidia.Url = "http://localhost/WebServiceMSA/asmxTipoMidia.asmx";
            this.asmxTipoMidia.UseDefaultCredentials = false;
            // 
            // dtsTipoMidia
            // 
            this.dtsTipoMidia.DataSetName = "dtsTipoMidia";
            this.dtsTipoMidia.Locale = new System.Globalization.CultureInfo("en-US");
            this.dtsTipoMidia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UCSelTipoMidia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Columns = new System.Windows.Forms.DataGridViewColumn[] {
        this.dataGridViewColumnCod_Tipo_Midia,
        this.dataGridViewColumnDescricao};
            this.Name = "UCSelTipoMidia";
            this.WindowText = "Seleciona Tipo de Mídia";
            this.Load += new System.EventHandler(this.UCSelTipoMidia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsTipoMidia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnCod_Tipo_Midia;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnDescricao;
        private MSAClass.AsmxTipoMidia.asmxTipoMidia asmxTipoMidia;
        private MSAClass.AsmxTipoMidia.dtsTipoMidia dtsTipoMidia;
    }
}
