using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MSAClass.AsmxNucleo;

namespace WCL_SCTV
{
    public partial class UCSelNucleo : UCSeleciona
    {
        #region Form

        public UCSelNucleo()
        {
            InitializeComponent();
        }

        private void UCSelNucleo_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DataMember == null)
                {
                    this.asmxNucleo = new asmxNucleo();
                    this.dtsNucleo = this.asmxNucleo.spuCarregar();

                    this.DataMember = this.dtsNucleo.dtbNucleo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCSelNucleo_Load\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DataRowNucleo
        public dtsNucleo.dtbNucleoRow[] DataRowNucleo
        {
            get
            {
                return (dtsNucleo.dtbNucleoRow[])this.DataRow;
            }
        }

        #endregion
    }
}
