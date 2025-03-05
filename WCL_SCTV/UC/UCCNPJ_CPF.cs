using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WCL_SCTV.UC
{
    public partial class UCCNPJ_CPF : UserControl
    {
        private String strCNPJ_CPF;

        #region Form

        public UCCNPJ_CPF()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        #region CNPJ_CPF

        public String CNPJ_CPF
        {
            get { return this.strCNPJ_CPF; }
            set { this.ShowCNPJ_CPF(value); }
        }

        #endregion

        #region Permite_Limpar

        public Boolean Permite_Limpar
        {
            get { return this.btnClear.Enabled; }
            set { this.btnClear.Enabled = value; }
        }

        #endregion

        #region isCNPF

        public Boolean isCNPF
        {
            get { return (this.strCNPJ_CPF.Length == 14); }
        }

        #endregion

        #region isCPF

        public Boolean isCPF
        {
            get { return (this.strCNPJ_CPF.Length == 11); }
        }

        #endregion

        #endregion

        #region txtCNPJ_CPF

        private void txtCNPJ_CPF_Enter(object sender, EventArgs e)
        {
            try
            {
                this.txtCNPJ_CPF.Text = this.CNPJ_CPF;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "txtCNPJ_CPF_Enter\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCNPJ_CPF_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show(this.ParentForm, "txtCNPJ_CPF_KeyPress\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCNPJ_CPF_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                this.ShowCNPJ_CPF(this.txtCNPJ_CPF.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "txtCNPJ_CPF_Validating\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region btnClear

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                this.CNPJ_CPF = "";
                this.txtCNPJ_CPF.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "btnClear_Click\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region ShowCNPJ_CPF

        private void ShowCNPJ_CPF(String strValue)
        {
            try
            {
                this.txtCNPJ_CPF.Text = "";
                this.strCNPJ_CPF = "";

                if (strValue == null)
                    return;

                strValue = strValue.Trim().Replace("/", "").Replace(".", "").Replace("-", "");

                for (int intCont = 0; intCont < strValue.Length; intCont++)
                {
                    Byte bytDIG;
                    Byte.TryParse(strValue.Substring(intCont, 1), out bytDIG);
                    if (bytDIG.ToString("0") == strValue.Substring(intCont, 1))
                    {
                        this.strCNPJ_CPF += bytDIG.ToString("0");
                    }
                }

                if (this.isCNPF || this.isCPF)
                {
                    if (!this.isCNPJ_CPF_Valido())
                    {
                        this.strCNPJ_CPF = "";
                    }
                }
                else
                {
                    this.strCNPJ_CPF = "";
                }

                if (this.isCNPF)
                {
                    this.txtCNPJ_CPF.Text = ulong.Parse(this.strCNPJ_CPF).ToString("00\\.000\\.000\\/0000\\-00");
                }
                else if (this.isCPF)
                {
                    this.txtCNPJ_CPF.Text = ulong.Parse(this.strCNPJ_CPF).ToString("000\\.000\\.000\\-00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "ShowCNPJ_CPF\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region isCNPJ_CPF_Valido

        private Boolean isCNPJ_CPF_Valido()
        {
            String strNumero_sem_dig = this.strCNPJ_CPF.Substring(0, (this.strCNPJ_CPF.Length - 2));
            Boolean blnRetorno = false;
            try
            {
                while (this.strCNPJ_CPF.Length != strNumero_sem_dig.Length)
                {
                    int base_ = 2;
                    int soma_ = 0;
                    for (int cont_digito = (strNumero_sem_dig.Length - 1); cont_digito >= 0; cont_digito--)
                    {
                        soma_ += int.Parse(strNumero_sem_dig.Substring(cont_digito, 1)) * base_;
                        if (base_ == 9 && this.isCNPF)
                            base_ = 2;
                        else
                            base_++;
                    }

                    int resto_divsao = (11 - (soma_ - (int.Parse((soma_ / 11).ToString()) * 11)));

                    if (resto_divsao > 9)
                        resto_divsao = 0;

                    strNumero_sem_dig += resto_divsao.ToString("0");
                }

                if (strNumero_sem_dig == this.strCNPJ_CPF)
                {
                    blnRetorno = true;
                }
                else
                {
                    blnRetorno = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "isCNPJ_CPF_Valido\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (blnRetorno);
        }

        #endregion
    }
}
