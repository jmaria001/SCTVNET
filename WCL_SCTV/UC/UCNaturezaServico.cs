using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MSAClass.AsmxNaturezaServico;

namespace WCL_SCTV
{
    public partial class UCNaturezaServico : UCPesquisa
    {
        #region Form

        public UCNaturezaServico()
        {
            InitializeComponent();
        }

        private void UCNaturezaServico_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DataMember == null)
                {
                    this.asmxNaturezaServico = new asmxNaturezaServico();
                    this.dtsNaturezaServico = this.asmxNaturezaServico.spuCarregar("", "");

                    this.DataMember = this.dtsNaturezaServico.dtbNaturezaServico;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCNaturezaServico_Load\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DataRowNaturezaServico

        public dtsNaturezaServico.dtbNaturezaServicoRow DataRowNaturezaServico
        {
            get
            {
                    return (dtsNaturezaServico.dtbNaturezaServicoRow)this.DataRow;
            }
        }

        #endregion
    }
}
