namespace WCL_SCTV
{
    partial class UCNaturezaServico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewColumnCod_Natureza = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumnDescricao = new System.Windows.Forms.DataGridViewColumn();
            this.asmxNaturezaServico = new MSAClass.AsmxNaturezaServico.asmxNaturezaServico();
            this.dtsNaturezaServico = new MSAClass.AsmxNaturezaServico.dtsNaturezaServico();
            this.dataGridViewColumnPercentual_Iss = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumnIndica_Midia = new System.Windows.Forms.DataGridViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtsNaturezaServico)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.MaxLength = 6;
            // 
            // dataGridViewColumnCod_Natureza
            // 
            this.dataGridViewColumnCod_Natureza.DataPropertyName = "Cod_Natureza";
            this.dataGridViewColumnCod_Natureza.HeaderText = "Código";
            this.dataGridViewColumnCod_Natureza.Name = "dataGridViewColumnCod_Natureza";
            this.dataGridViewColumnCod_Natureza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewColumnDescricao
            // 
            this.dataGridViewColumnDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumnDescricao.DataPropertyName = "Descricao";
            this.dataGridViewColumnDescricao.HeaderText = "Descrição";
            this.dataGridViewColumnDescricao.Name = "dataGridViewColumnDescricao";
            this.dataGridViewColumnDescricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // asmxNaturezaServico
            // 
            this.asmxNaturezaServico.Credentials = null;
            this.asmxNaturezaServico.Url = "http://localhost/WebServiceMSA/asmxNaturezaServico.asmx";
            this.asmxNaturezaServico.UseDefaultCredentials = false;
            // 
            // dtsNaturezaServico
            // 
            this.dtsNaturezaServico.DataSetName = "dtsNaturezaServico";
            this.dtsNaturezaServico.Locale = new System.Globalization.CultureInfo("en-US");
            this.dtsNaturezaServico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewColumnPercentual_Iss
            // 
            this.dataGridViewColumnPercentual_Iss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewColumnPercentual_Iss.DataPropertyName = "Percentual_Iss";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.dataGridViewColumnPercentual_Iss.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewColumnPercentual_Iss.HeaderText = "% ISS";
            this.dataGridViewColumnPercentual_Iss.MinimumWidth = 100;
            this.dataGridViewColumnPercentual_Iss.Name = "dataGridViewColumnPercentual_Iss";
            this.dataGridViewColumnPercentual_Iss.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewColumnIndica_Midia
            // 
            this.dataGridViewColumnIndica_Midia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewColumnIndica_Midia.DataPropertyName = "Indica_Midia";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewColumnIndica_Midia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewColumnIndica_Midia.HeaderText = "Mídia";
            this.dataGridViewColumnIndica_Midia.Name = "dataGridViewColumnIndica_Midia";
            this.dataGridViewColumnIndica_Midia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UCNaturezaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CodigoLength = 6;
            this.Columns = new System.Windows.Forms.DataGridViewColumn[] {
        this.dataGridViewColumnCod_Natureza,
        this.dataGridViewColumnDescricao,
        this.dataGridViewColumnIndica_Midia,
        this.dataGridViewColumnPercentual_Iss};
            this.Name = "UCNaturezaServico";
            this.WindowText = "Pesquisa Natureza de Serviços";
            this.Load += new System.EventHandler(this.UCNaturezaServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsNaturezaServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnCod_Natureza;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnDescricao;
        private MSAClass.AsmxNaturezaServico.asmxNaturezaServico asmxNaturezaServico;
        private MSAClass.AsmxNaturezaServico.dtsNaturezaServico dtsNaturezaServico;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnPercentual_Iss;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnIndica_Midia;
    }
}
