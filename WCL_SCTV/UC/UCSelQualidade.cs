using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MSAClass.AsmxQualidade;

namespace WCL_SCTV
{
    public partial class UCSelQualidade : UCSeleciona
    {
        #region Form

        public UCSelQualidade()
        {
            InitializeComponent();
        }

        private void UCSelQualidade_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DataMember == null)
                {
                    this.asmxQualidade = new asmxQualidade();
                    this.dtsQualidade = this.asmxQualidade.spuCarregar("");

                    this.DataMember = this.dtsQualidade.dtbQualidade;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCSelQualidade_Load\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DataRowQualidade

        public dtsQualidade.dtbQualidadeRow[] DataRowQualidade
        {
            get
            {
                return (dtsQualidade.dtbQualidadeRow[])this.DataRow;
            }
        }

        #endregion
    }
}
