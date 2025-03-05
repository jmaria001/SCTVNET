using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MSAClass.AsmxTipoComercial;

namespace WCL_SCTV
{
    public partial class UCTipoComercial : UCPesquisa
    {
        #region Form

        public UCTipoComercial()
        {
            InitializeComponent();
        }

        private void UCTipoComercial_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DataMember == null)
                {
                    this.asmxTipoComercial = new asmxTipoComercial();
                    this.dtsTipoComercial = this.asmxTipoComercial.spuCarregar("");

                    this.DataMember = this.dtsTipoComercial.dtbTipo_Comercial;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCTipoComercial_Load\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DataRowTipoComercial

        public dtsTipoComercial.dtbTipo_ComercialRow DataRowTipoComercial
        {
            get
            {
                return (dtsTipoComercial.dtbTipo_ComercialRow)this.DataRow;
            }
        }

        #endregion
    }
}
