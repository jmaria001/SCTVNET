using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MSAClass.AsmxMotivo;

namespace WCL_SCTV
{
    public partial class UCMotivoFalha : UCPesquisa
    {
        #region Form

        public UCMotivoFalha()
        {
            InitializeComponent();
        }

        private void UCMotivoFalha_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DataMember == null)
                {
                    this.asmxMotivo = new asmxMotivo();
                    this.dtsMotivo = this.asmxMotivo.spuCarregarMotivo_Falha();

                    this.DataMember = this.dtsMotivo.dtbMotivoFalha;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCMotivoFalha_Load\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DataRowMotivoFalha

        public dtsMotivo.dtbMotivoFalhaRow DataRowMotivoFalha
        {
            get
            {
                return (dtsMotivo.dtbMotivoFalhaRow)this.DataRow;
            }
        }

        #endregion
    }
}