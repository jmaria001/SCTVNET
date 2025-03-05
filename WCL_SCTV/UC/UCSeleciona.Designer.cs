namespace WCL_SCTV
{
    partial class UCSeleciona
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSeleciona));
            this.btnClear = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnSeleciona = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.ImageKey = "imgClear.gif";
            this.btnClear.ImageList = this.imageList;
            this.btnClear.Location = new System.Drawing.Point(328, 22);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(22, 22);
            this.btnClear.TabIndex = 2;
            this.btnClear.TabStop = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "imgSeek.gif");
            this.imageList.Images.SetKeyName(1, "imgBlocked.gif");
            this.imageList.Images.SetKeyName(2, "imgClear.gif");
            // 
            // btnSeleciona
            // 
            this.btnSeleciona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleciona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleciona.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleciona.ImageKey = "imgSeek.gif";
            this.btnSeleciona.ImageList = this.imageList;
            this.btnSeleciona.Location = new System.Drawing.Point(328, 0);
            this.btnSeleciona.Margin = new System.Windows.Forms.Padding(0);
            this.btnSeleciona.Name = "btnSeleciona";
            this.btnSeleciona.Size = new System.Drawing.Size(22, 22);
            this.btnSeleciona.TabIndex = 1;
            this.btnSeleciona.TabStop = false;
            this.btnSeleciona.UseVisualStyleBackColor = true;
            this.btnSeleciona.Click += new System.EventHandler(this.btnSeleciona_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCodigo.Location = new System.Drawing.Point(0, 1);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCodigo.Size = new System.Drawing.Size(325, 42);
            this.txtCodigo.TabIndex = 0;
            // 
            // UCSeleciona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnSeleciona);
            this.Controls.Add(this.btnClear);
            this.MaximumSize = new System.Drawing.Size(1000, 220);
            this.MinimumSize = new System.Drawing.Size(300, 22);
            this.Name = "UCSeleciona";
            this.Size = new System.Drawing.Size(350, 44);
            this.Load += new System.EventHandler(this.UCSeleciona_Load);
            this.EnabledChanged += new System.EventHandler(this.UCSeleciona_EnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        protected System.Windows.Forms.Button btnSeleciona;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}
