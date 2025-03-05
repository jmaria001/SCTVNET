namespace WCL_SCTV
{
    partial class UCNucleo
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
            this.dataGridViewColumnCod_Nucleo = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumnDescricao = new System.Windows.Forms.DataGridViewColumn();
            this.asmxNucleo = new MSAClass.AsmxNucleo.asmxNucleo();
            this.dtsNucleo = new MSAClass.AsmxNucleo.dtsNucleo();
            ((System.ComponentModel.ISupportInitialize)(this.dtsNucleo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewColumnCod_Nucleo
            // 
            this.dataGridViewColumnCod_Nucleo.DataPropertyName = "Cod_Nucleo";
            this.dataGridViewColumnCod_Nucleo.HeaderText = "Código";
            this.dataGridViewColumnCod_Nucleo.Name = "dataGridViewColumnCod_Nucleo";
            this.dataGridViewColumnCod_Nucleo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewColumnDescricao
            // 
            this.dataGridViewColumnDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumnDescricao.DataPropertyName = "Descricao";
            this.dataGridViewColumnDescricao.HeaderText = "Descrição";
            this.dataGridViewColumnDescricao.Name = "dataGridViewColumnDescricao";
            this.dataGridViewColumnDescricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // asmxNucleo
            // 
            this.asmxNucleo.Credentials = null;
            this.asmxNucleo.Url = "http://localhost/WebServiceMSA/asmxNucleo.asmx";
            this.asmxNucleo.UseDefaultCredentials = false;
            // 
            // dtsNucleo
            // 
            this.dtsNucleo.DataSetName = "dtsNucleo";
            this.dtsNucleo.Locale = new System.Globalization.CultureInfo("en-US");
            this.dtsNucleo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UCNucleo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Columns = new System.Windows.Forms.DataGridViewColumn[] {
        this.dataGridViewColumnCod_Nucleo,
        this.dataGridViewColumnDescricao};
            this.Name = "UCNucleo";
            this.WindowText = "Pesquisa Núcleo de Vendas";
            this.Load += new System.EventHandler(this.UCNucleo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsNucleo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnCod_Nucleo;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnDescricao;
        private MSAClass.AsmxNucleo.asmxNucleo asmxNucleo;
        private MSAClass.AsmxNucleo.dtsNucleo dtsNucleo;
    }
}
