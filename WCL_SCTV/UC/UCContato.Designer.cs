namespace WCL_SCTV
{
    partial class UCContato
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
            this.dataGridViewColumnCod_Contato = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumnNome = new System.Windows.Forms.DataGridViewColumn();
            this.asmxContato = new MSAClass.AsmxContato.asmxContato();
            this.dtsContato = new MSAClass.AsmxContato.dtsContato();
            ((System.ComponentModel.ISupportInitialize)(this.dtsContato)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.MaxLength = 5;
            // 
            // dataGridViewColumnCod_Contato
            // 
            this.dataGridViewColumnCod_Contato.DataPropertyName = "Cod_Contato";
            this.dataGridViewColumnCod_Contato.HeaderText = "Código";
            this.dataGridViewColumnCod_Contato.Name = "dataGridViewColumnCod_Contato";
            this.dataGridViewColumnCod_Contato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewColumnNome
            // 
            this.dataGridViewColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumnNome.DataPropertyName = "Nome";
            this.dataGridViewColumnNome.HeaderText = "Nome";
            this.dataGridViewColumnNome.Name = "dataGridViewColumnNome";
            this.dataGridViewColumnNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // asmxContato
            // 
            this.asmxContato.Credentials = null;
            this.asmxContato.Url = "http://localhost/WebServiceMSA/asmxContato.asmx";
            this.asmxContato.UseDefaultCredentials = false;
            // 
            // dtsContato
            // 
            this.dtsContato.DataSetName = "dtsContato";
            this.dtsContato.Locale = new System.Globalization.CultureInfo("en-US");
            this.dtsContato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UCContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CodigoLength = 5;
            this.Columns = new System.Windows.Forms.DataGridViewColumn[] {
        this.dataGridViewColumnCod_Contato,
        this.dataGridViewColumnNome};
            this.Name = "UCContato";
            this.WindowText = "Pesquisa Contato";
            this.Load += new System.EventHandler(this.UCContato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsContato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnCod_Contato;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnNome;
        private MSAClass.AsmxContato.asmxContato asmxContato;
        private MSAClass.AsmxContato.dtsContato dtsContato;
    }
}
