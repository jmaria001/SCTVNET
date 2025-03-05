namespace WCL_SCTV
{
    partial class UCSelEmpresa
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
            this.dataGridViewColumnCod_Empresa = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumnRazao_Social = new System.Windows.Forms.DataGridViewColumn();
            this.dtsEmpresa = new MSAClass.AsmxEmpresa.dtsEmpresa();
            this.asmxEmpresa = new MSAClass.AsmxEmpresa.asmxEmpresa();
            ((System.ComponentModel.ISupportInitialize)(this.dtsEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewColumnCod_Empresa
            // 
            this.dataGridViewColumnCod_Empresa.DataPropertyName = "Cod_Empresa";
            this.dataGridViewColumnCod_Empresa.HeaderText = "Código";
            this.dataGridViewColumnCod_Empresa.Name = "dataGridViewColumnCod_Empresa";
            // 
            // dataGridViewColumnRazao_Social
            // 
            this.dataGridViewColumnRazao_Social.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumnRazao_Social.DataPropertyName = "Razao_Social";
            this.dataGridViewColumnRazao_Social.HeaderText = "Razão Social";
            this.dataGridViewColumnRazao_Social.Name = "dataGridViewColumnRazao_Social";
            this.dataGridViewColumnRazao_Social.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dtsEmpresa
            // 
            this.dtsEmpresa.DataSetName = "dtsEmpresa";
            this.dtsEmpresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asmxEmpresa
            // 
            this.asmxEmpresa.Credentials = null;
            this.asmxEmpresa.Url = "http://localhost/WebServiceMSA/asmxEmpresa.asmx";
            this.asmxEmpresa.UseDefaultCredentials = false;
            // 
            // UCSelEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Columns = new System.Windows.Forms.DataGridViewColumn[] {
        this.dataGridViewColumnCod_Empresa,
        this.dataGridViewColumnRazao_Social};
            this.Name = "UCSelEmpresa";
            this.WindowText = "Seleciona Empresa";
            this.Load += new System.EventHandler(this.UCSelEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnCod_Empresa;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnRazao_Social;
        private MSAClass.AsmxEmpresa.dtsEmpresa dtsEmpresa;
        private MSAClass.AsmxEmpresa.asmxEmpresa asmxEmpresa;
    }
}
