using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MSAClass.AsmxEmpresa;

namespace WCL_SCTV
{
    public partial class UCSelEmpresa : UCSeleciona
    {
        #region Form

        public UCSelEmpresa()
        {
            InitializeComponent();
        }

        private void UCSelEmpresa_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DataMember == null)
                {
                    this.asmxEmpresa = new asmxEmpresa();
                    this.dtsEmpresa = this.asmxEmpresa.spuCarregar("");

                    this.DataMember = (DataTable)this.dtsEmpresa.dtbEmpresa;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCSelEmpresa_Load\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DataRowEmpresa

        public dtsEmpresa.dtbEmpresaRow[] DataRowEmpresa
        {
            get
            {
                return (dtsEmpresa.dtbEmpresaRow[])this.DataRow;
            }
        }

        #endregion
    }
}
