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
    public partial class UCSelMotivoAlteracao : UCSeleciona
    {
        #region Form

        public UCSelMotivoAlteracao()
        {
            InitializeComponent();
        }

        private void UCSelMotivoAlteracao_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DataMember == null)
                {
                    this.asmxMotivo = new asmxMotivo();
                    this.dtsMotivo = this.asmxMotivo.spuCarregarMotivo_Alteracao();

                    this.DataMember = this.dtsMotivo.dtbMotivoAlteracao;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCSelMotivoAlteracao_Load\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DataRowMotivoAlteracao

        public dtsMotivo.dtbMotivoAlteracaoRow[] DataRowMotivoAlteracao
        {
            get
            {
                return (dtsMotivo.dtbMotivoAlteracaoRow[])this.DataRow;
            }
        }

        #endregion
    }
}
