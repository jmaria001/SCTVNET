namespace WCL_SCTV.UC
{
    partial class UCCNPJ_CPF
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
            this.txtCNPJ_CPF = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCNPJ_CPF
            // 
            this.txtCNPJ_CPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCNPJ_CPF.Location = new System.Drawing.Point(1, 1);
            this.txtCNPJ_CPF.MaxLength = 14;
            this.txtCNPJ_CPF.Name = "txtCNPJ_CPF";
            this.txtCNPJ_CPF.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCNPJ_CPF.Size = new System.Drawing.Size(123, 20);
            this.txtCNPJ_CPF.TabIndex = 0;
            this.txtCNPJ_CPF.Enter += new System.EventHandler(this.txtCNPJ_CPF_Enter);
            this.txtCNPJ_CPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNPJ_CPF_KeyPress);
            this.txtCNPJ_CPF.Validating += new System.ComponentModel.CancelEventHandler(this.txtCNPJ_CPF_Validating);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Image = global::WCL_SCTV.ResourceIMG.imgClear;
            this.btnClear.Location = new System.Drawing.Point(127, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(22, 22);
            this.btnClear.TabIndex = 1;
            this.btnClear.TabStop = false;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // UCCNPJ_CPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtCNPJ_CPF);
            this.MaximumSize = new System.Drawing.Size(150, 23);
            this.MinimumSize = new System.Drawing.Size(50, 23);
            this.Name = "UCCNPJ_CPF";
            this.Size = new System.Drawing.Size(150, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCNPJ_CPF;
        private System.Windows.Forms.Button btnClear;
    }
}
