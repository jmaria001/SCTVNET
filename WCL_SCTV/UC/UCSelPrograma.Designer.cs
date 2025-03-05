namespace WCL_SCTV
{
    partial class UCSelPrograma
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
            this.dataGridViewColumnCod_Programa = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumnTitulo = new System.Windows.Forms.DataGridViewColumn();
            this.asmxPrograma = new MSAClass.AsmxPrograma.asmxPrograma();
            this.dtsPrograma = new MSAClass.AsmxPrograma.dtsPrograma();
            ((System.ComponentModel.ISupportInitialize)(this.dtsPrograma)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewColumnCod_Programa
            // 
            this.dataGridViewColumnCod_Programa.DataPropertyName = "Cod_Programa";
            this.dataGridViewColumnCod_Programa.HeaderText = "Código";
            this.dataGridViewColumnCod_Programa.Name = "dataGridViewColumnCod_Programa";
            this.dataGridViewColumnCod_Programa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewColumnTitulo
            // 
            this.dataGridViewColumnTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumnTitulo.DataPropertyName = "Titulo";
            this.dataGridViewColumnTitulo.HeaderText = "Título";
            this.dataGridViewColumnTitulo.Name = "dataGridViewColumnTitulo";
            this.dataGridViewColumnTitulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // asmxPrograma
            // 
            this.asmxPrograma.Credentials = null;
            this.asmxPrograma.Url = "http://localhost/WebServiceMSA/asmxPrograma.asmx";
            this.asmxPrograma.UseDefaultCredentials = false;
            // 
            // dtsPrograma
            // 
            this.dtsPrograma.DataSetName = "dtsPrograma";
            this.dtsPrograma.Locale = new System.Globalization.CultureInfo("en-US");
            this.dtsPrograma.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UCSelPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Columns = new System.Windows.Forms.DataGridViewColumn[] {
        this.dataGridViewColumnCod_Programa,
        this.dataGridViewColumnTitulo};
            this.Name = "UCSelPrograma";
            this.WindowText = "Seleciona Programa";
            this.Load += new System.EventHandler(this.UCSelPrograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsPrograma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnCod_Programa;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnTitulo;
        private MSAClass.AsmxPrograma.asmxPrograma asmxPrograma;
        private MSAClass.AsmxPrograma.dtsPrograma dtsPrograma;
    }
}
