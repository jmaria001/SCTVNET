namespace WCL_SCTV
{
    partial class UCSelTipoComercial
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
            this.dataGridViewColumnCod_Tipo_Comercial = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumnDescricao = new System.Windows.Forms.DataGridViewColumn();
            this.asmxTipoComercial = new MSAClass.AsmxTipoComercial.asmxTipoComercial();
            this.dtsTipoComercial = new MSAClass.AsmxTipoComercial.dtsTipoComercial();
            this.dataGridViewColumnMerchandising = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumnAbsorcao = new System.Windows.Forms.DataGridViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTipoComercial)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewColumnCod_Tipo_Comercial
            // 
            this.dataGridViewColumnCod_Tipo_Comercial.DataPropertyName = "Cod_Tipo_Comercial";
            this.dataGridViewColumnCod_Tipo_Comercial.HeaderText = "Código";
            this.dataGridViewColumnCod_Tipo_Comercial.Name = "dataGridViewColumnCod_Tipo_Comercial";
            this.dataGridViewColumnCod_Tipo_Comercial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewColumnDescricao
            // 
            this.dataGridViewColumnDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewColumnDescricao.DataPropertyName = "Descricao";
            this.dataGridViewColumnDescricao.HeaderText = "Descrição";
            this.dataGridViewColumnDescricao.Name = "dataGridViewColumnDescricao";
            this.dataGridViewColumnDescricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // asmxTipoComercial
            // 
            this.asmxTipoComercial.Credentials = null;
            this.asmxTipoComercial.Url = "http://localhost/WebServiceMSA/asmxTipoComercial.asmx";
            this.asmxTipoComercial.UseDefaultCredentials = false;
            // 
            // dtsTipoComercial
            // 
            this.dtsTipoComercial.DataSetName = "dtsTipoComercial";
            this.dtsTipoComercial.Locale = new System.Globalization.CultureInfo("en-US");
            this.dtsTipoComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewColumnMerchandising
            // 
            this.dataGridViewColumnMerchandising.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewColumnMerchandising.DataPropertyName = "Merchandising";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewColumnMerchandising.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewColumnMerchandising.HeaderText = "Mercha.";
            this.dataGridViewColumnMerchandising.Name = "dataGridViewColumnMerchandising";
            this.dataGridViewColumnMerchandising.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewColumnAbsorcao
            // 
            this.dataGridViewColumnAbsorcao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewColumnAbsorcao.DataPropertyName = "Absorcao";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewColumnAbsorcao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewColumnAbsorcao.HeaderText = "Absorção";
            this.dataGridViewColumnAbsorcao.Name = "dataGridViewColumnAbsorcao";
            this.dataGridViewColumnAbsorcao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UCSelTipoComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Columns = new System.Windows.Forms.DataGridViewColumn[] {
        this.dataGridViewColumnCod_Tipo_Comercial,
        this.dataGridViewColumnDescricao,
        this.dataGridViewColumnAbsorcao,
        this.dataGridViewColumnMerchandising};
            this.Name = "UCSelTipoComercial";
            this.WindowText = "Seleciona Tipo de Comercial";
            this.Load += new System.EventHandler(this.UCSelTipoComercial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsTipoComercial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnCod_Tipo_Comercial;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnDescricao;
        private MSAClass.AsmxTipoComercial.asmxTipoComercial asmxTipoComercial;
        private MSAClass.AsmxTipoComercial.dtsTipoComercial dtsTipoComercial;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnMerchandising;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnAbsorcao;
    }
}
