using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WCL_SCTV
{
    public partial class frmCompetencia : Form
    {
        #region Form

        public frmCompetencia()
        {
            InitializeComponent();
        }

        private void frmCompetencia_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "frmCompetencia_Load\n" + ex.Message, "frmCompetencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCompetencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "cboFiltrar_SelectedIndexChanged\n" + ex.Message, "frmCompetencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

    }
}