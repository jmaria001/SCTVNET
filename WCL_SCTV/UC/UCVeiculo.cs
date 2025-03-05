using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WCL_SCTV
{
    public partial class UCVeiculo : UCPesquisa
    {
        private string Usuario="";
        private string Senha = "";
        private MSAClass.AsmxVeiculo.asmxVeiculo asmxVeiculo;
        private MSAClass.AsmxVeiculo.dtsVeiculo dtsVeiculo;
        private Modulo.Asmx NewClass = new Modulo.Asmx();


        public UCVeiculo()
        {
            InitializeComponent();
        }

        private void UCVeiculo_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DataMember == null)
                {
                    this.asmxVeiculo = NewClass.NewVeiculo(this.Usuario, this.Senha);
                    dtsVeiculo = new MSAClass.AsmxVeiculo.dtsVeiculo(); 
                    this.dtsVeiculo = this.asmxVeiculo.spuCarregar();
                    this.DataMember = this.dtsVeiculo.dtbVeiculo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCVeiculo_Load\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        #region txtCodigo

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                switch ((Keys)e.KeyChar & Keys.KeyCode)
                {
                    case Keys.Left:
                    case Keys.Up:
                    case Keys.Down:
                    case Keys.Right:
                    case Keys.Home:
                    case Keys.End:
                    case Keys.PageDown:
                    case Keys.PageUp:
                    case Keys.Back:
                    case Keys.D0:
                    case Keys.D1:
                    case Keys.D2:
                    case Keys.D3:
                    case Keys.D4:
                    case Keys.D5:
                    case Keys.D6:
                    case Keys.D7:
                    case Keys.D8:
                    case Keys.D9:
                        return;
                    default:
                        e.KeyChar = (char)0;
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "txtCodigo_KeyPress\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DataRowVeiculo

        public  MSAClass.AsmxVeiculo.dtsVeiculo.dtbVeiculoRow DataRowVeiculo
        {
            get
            {
                return (MSAClass.AsmxVeiculo.dtsVeiculo.dtbVeiculoRow)this.DataRow;
            }
        }

        #endregion
    }
}
