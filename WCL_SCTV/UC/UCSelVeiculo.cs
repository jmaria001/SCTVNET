using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MSAClass.AsmxVeiculo;

namespace WCL_SCTV
{
    public partial class UCSelVeiculo : UCSeleciona
    {
        #region Form

        public UCSelVeiculo()
        {
            InitializeComponent();
        }

        private void UCSelVeiculo_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DataMember == null)
                {
                    this.asmxVeiculo = new asmxVeiculo();
                    this.dtsVeiculo = this.asmxVeiculo.spuCarregar();

                    this.DataMember = this.dtsVeiculo.dtbVeiculo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCSelVeiculo_Load\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DataRowVeiculo

        public dtsVeiculo.dtbVeiculoRow[] DataRowVeiculo
        {
            get
            {
                return (dtsVeiculo.dtbVeiculoRow[])this.DataRow;
            }
        }

        #endregion
    }
}
