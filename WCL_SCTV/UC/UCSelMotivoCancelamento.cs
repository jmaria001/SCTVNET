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
    public partial class UCSelMotivoCancelamento : UCSeleciona
    {
        #region Form

        public UCSelMotivoCancelamento()
        {
            InitializeComponent();
        }

        private void UCSelMotivoCancelamento_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DataMember == null)
                {
                    this.asmxMotivo = new asmxMotivo();
                    this.dtsMotivo = this.asmxMotivo.spuCarregarMotivo_Cancelamento();

                    this.DataMember = this.dtsMotivo.dtbMotivoCancelamento;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCSelMotivoCancelamento_Load\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DataRowMotivoCancelamento

        public dtsMotivo.dtbMotivoCancelamentoRow[] DataRowMotivoCancelamento
        {
            get
            {
                return (dtsMotivo.dtbMotivoCancelamentoRow[])this.DataRow;
            }
        }

        #endregion
    }
}
