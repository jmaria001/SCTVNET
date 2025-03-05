using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MSAClass.AsmxContato;

namespace WCL_SCTV
{
    public partial class UCSelContato : UCSeleciona
    {
        #region Form

        public UCSelContato()
        {
            InitializeComponent();
        }

        private void UCSelContato_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DataMember == null)
                {
                    this.asmxContato = new asmxContato();
                    this.dtsContato = this.asmxContato.spuCarregar("");

                    this.DataMember = this.dtsContato.dtbContato;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCSelContato_Load\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DataRowContato

        public dtsContato.dtbContatoRow[] DataRowContato
        {
            get
            {
                return (dtsContato.dtbContatoRow[])this.DataRow;
            }
        }

        #endregion
    }
}
