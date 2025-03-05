using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MSAClass.AsmxTipoMidia;

namespace WCL_SCTV
{
    public partial class UCTipoMidia : UCPesquisa
    {
        #region Form

        public UCTipoMidia()
        {
            InitializeComponent();
        }

        private void UCTipoMidia_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DataMember == null)
                {
                    this.asmxTipoMidia = new asmxTipoMidia();
                    this.dtsTipoMidia = this.asmxTipoMidia.spuCarregar("");

                    this.DataMember = this.dtsTipoMidia.dtbTipoMidia;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCTipoMidia_Load\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DataRowTipoMidia

        public dtsTipoMidia.dtbTipoMidiaRow DataRowTipoMidia
        {
            get
            {
                return (dtsTipoMidia.dtbTipoMidiaRow)this.DataRow;
            }
        }

        #endregion
    }
}
