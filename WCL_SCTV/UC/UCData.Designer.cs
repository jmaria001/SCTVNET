namespace WCL_SCTV.UC
{
    partial class UCData
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.Location = new System.Drawing.Point(0, 1);
            this.txtData.MaxLength = 14;
            this.txtData.Name = "txtData";
            this.txtData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtData.Size = new System.Drawing.Size(88, 20);
            this.txtData.TabIndex = 0;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtData.Enter += new System.EventHandler(this.txtData_Enter);
            this.txtData.Leave += new System.EventHandler(this.txtData_Leave);
            this.txtData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtData_KeyPress);
            this.txtData.Validating += new System.ComponentModel.CancelEventHandler(this.txtData_Validating);
            // 
            // btnCalendario
            // 
            this.btnCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalendario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalendario.Image = global::WCL_SCTV.ResourceIMG.MonthlyViewHS;
            this.btnCalendario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalendario.Location = new System.Drawing.Point(89, 0);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(22, 22);
            this.btnCalendario.TabIndex = 1;
            this.btnCalendario.TabStop = false;
            this.btnCalendario.UseVisualStyleBackColor = false;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Image = global::WCL_SCTV.ResourceIMG.imgClear;
            this.btnClear.Location = new System.Drawing.Point(113, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(22, 22);
            this.btnClear.TabIndex = 2;
            this.btnClear.TabStop = false;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // UCData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnClear);
            this.MaximumSize = new System.Drawing.Size(500, 23);
            this.MinimumSize = new System.Drawing.Size(115, 23);
            this.Name = "UCData";
            this.Size = new System.Drawing.Size(135, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnCalendario;
    }
}
