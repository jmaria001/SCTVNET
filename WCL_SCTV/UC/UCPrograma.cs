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
    public partial class UCPrograma : UCPesquisa
    {
        public string Usuario = "";
        public string Senha = "";
        private MSAClass.AsmxPrograma.asmxPrograma asmxPrograma;
        private Modulo.Asmx NewClass = new Modulo.Asmx() ;
        private MSAClass.AsmxPrograma.dtsPrograma dtsPrograma = new MSAClass.AsmxPrograma.dtsPrograma();
        public UCPrograma()
        {
            InitializeComponent();
        }

        private void UCPrograma_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DataMember == null)
                {
                    this.asmxPrograma = NewClass.NewPrograma(this.Usuario, this.Senha);
                    this.dtsPrograma = this.asmxPrograma.spuCarregar();

                    this.DataMember = this.dtsPrograma.dtbPrograma;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCPrograma_Load\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public dtsPrograma.dtbProgramaRow DataRowPrograma
        {
            get
            {
                return (dtsPrograma.dtbProgramaRow)this.DataRow;
            }
        }



    }
}
