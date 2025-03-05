namespace WCL_SCTV
{
    partial class UCSelVeiculo
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
            this.asmxVeiculo = new MSAClass.AsmxVeiculo.asmxVeiculo();
            this.dtsVeiculo = new MSAClass.AsmxVeiculo.dtsVeiculo();
            this.dataGridViewCod_Veiculo = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumnNome_Veiculo = new System.Windows.Forms.DataGridViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtsVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // asmxVeiculo
            // 
            this.asmxVeiculo.Credentials = null;
            this.asmxVeiculo.Url = "http://localhost/WebServiceMSA/asmxVeiculo.asmx";
            this.asmxVeiculo.UseDefaultCredentials = false;
            // 
            // dtsVeiculo
            // 
            this.dtsVeiculo.DataSetName = "dtsVeiculo";
            this.dtsVeiculo.Locale = new System.Globalization.CultureInfo("en-US");
            this.dtsVeiculo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewCod_Veiculo
            // 
            this.dataGridViewCod_Veiculo.DataPropertyName = "Cod_Veiculo";
            this.dataGridViewCod_Veiculo.HeaderText = "Código";
            this.dataGridViewCod_Veiculo.Name = "dataGridViewCod_Veiculo";
            this.dataGridViewCod_Veiculo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewColumnNome_Veiculo
            // 
            this.dataGridViewColumnNome_Veiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumnNome_Veiculo.DataPropertyName = "Nome_Veiculo";
            this.dataGridViewColumnNome_Veiculo.HeaderText = "Nome Veículo";
            this.dataGridViewColumnNome_Veiculo.Name = "dataGridViewColumnNome_Veiculo";
            // 
            // UCSelVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Columns = new System.Windows.Forms.DataGridViewColumn[] {
        this.dataGridViewCod_Veiculo,
        this.dataGridViewColumnNome_Veiculo};
            this.Name = "UCSelVeiculo";
            this.WindowText = "Seleciona Veículo";
            this.Load += new System.EventHandler(this.UCSelVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MSAClass.AsmxVeiculo.asmxVeiculo asmxVeiculo;
        private MSAClass.AsmxVeiculo.dtsVeiculo dtsVeiculo;
        private System.Windows.Forms.DataGridViewColumn dataGridViewCod_Veiculo;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnNome_Veiculo;
    }
}
