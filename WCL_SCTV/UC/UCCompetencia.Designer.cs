namespace WCL_SCTV.UC
{
    partial class UCCompetencia
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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtCompetencia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Image = global::WCL_SCTV.ResourceIMG.imgClear;
            this.btnClear.Location = new System.Drawing.Point(58, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(22, 22);
            this.btnClear.TabIndex = 1;
            this.btnClear.TabStop = false;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCompetencia
            // 
            this.txtCompetencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompetencia.Location = new System.Drawing.Point(0, 1);
            this.txtCompetencia.MaxLength = 6;
            this.txtCompetencia.Name = "txtCompetencia";
            this.txtCompetencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCompetencia.Size = new System.Drawing.Size(55, 20);
            this.txtCompetencia.TabIndex = 0;
            this.txtCompetencia.Enter += new System.EventHandler(this.txtCompetencia_Enter);
            this.txtCompetencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompetencia_KeyPress);
            this.txtCompetencia.Validating += new System.ComponentModel.CancelEventHandler(this.txtCompetencia_Validating);
            // 
            // UCCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCompetencia);
            this.Controls.Add(this.btnClear);
            this.MaximumSize = new System.Drawing.Size(200, 23);
            this.MinimumSize = new System.Drawing.Size(80, 23);
            this.Name = "UCCompetencia";
            this.Size = new System.Drawing.Size(80, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtCompetencia;
    }
}
