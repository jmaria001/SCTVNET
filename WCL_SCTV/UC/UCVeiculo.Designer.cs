namespace WCL_SCTV
{
    partial class UCVeiculo
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
            this.dataGridViewCod_Veiculo = new System.Windows.Forms.DataGridViewColumn();
            this.dataGridViewColumnNome_Veiculo = new System.Windows.Forms.DataGridViewColumn();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.MaxLength = 3;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
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
            // UCVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CodigoLength = 3;
            this.Columns = new System.Windows.Forms.DataGridViewColumn[] {
        this.dataGridViewCod_Veiculo,
        this.dataGridViewColumnNome_Veiculo};
            this.Name = "UCVeiculo";
            this.WindowText = "Pesquisa Veículo";
            this.Load += new System.EventHandler(this.UCVeiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewColumn dataGridViewCod_Veiculo;
        private System.Windows.Forms.DataGridViewColumn dataGridViewColumnNome_Veiculo;
    }
}
