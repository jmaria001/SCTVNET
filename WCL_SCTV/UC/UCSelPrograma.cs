using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MSAClass.AsmxPrograma;

namespace WCL_SCTV
{
    public partial class UCSelPrograma : UCSeleciona
    {
        #region Form

        public UCSelPrograma()
        {
            InitializeComponent();
        }

        private void UCSelPrograma_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DataMember == null)
                {
                    this.asmxPrograma = new asmxPrograma();
                    this.dtsPrograma = this.asmxPrograma.spuCarregar();

                    this.DataMember = this.dtsPrograma.dtbPrograma;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCSelPrograma_Load\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DataRowPrograma

        public dtsPrograma.dtbProgramaRow[] DataRowPrograma
        {
            get
            {
                return (dtsPrograma.dtbProgramaRow[])this.DataRow;
            }
        }

        #endregion

    }
}
