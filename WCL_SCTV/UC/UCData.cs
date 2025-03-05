using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
 
using System.Text;
using System.Windows.Forms;

namespace WCL_SCTV.UC
{
    public partial class UCData : UserControl
    {
        private ushort intAno;
        private ushort intMes;
        private ushort intDia;
        private String strFormato;
        private String[] strAbrSemana = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        private Boolean blnPassado = true;
        private Boolean blnFuturo = true;
        private Boolean blnObrigatorio = false;
        private DateTime dteData;

        #region Form

        public UCData()
        {
            InitializeComponent();
            this.Formato = "dd/MM/yyyy ddd";
        }

        #endregion

        #region Properties

        #region Data Text

        public override String Text
        {
            get { return this.DateTime.ToString(); }
            set {
                DateTime dte;
                DateTime.TryParse(value, out dte);

                if (!dte.Equals(DateTime.MinValue))
                    this.DateTime = dte;
            }
        }

        #endregion

        //#region Data Text

        //public override String Text
        //{
        //    get { return this.txtData.Text.Trim(); }
        //    set { this.txtData.Text = value; }
        //}

        //#endregion

        #region DateTime

        public DateTime DateTime
        {
            get { return this.dteData; }
            set
            {
                String strFormatComparacao = "yyyyMMdd";

                try
                {
                    this.txtData.Text = "";
                    this.intAno = 0;
                    this.intMes = 0;
                    this.intDia = 0;

                    this.dteData = value;

                    if (value <= DateTime.MinValue)
                    {
                        return;
                    }

                    if (this.Formato.IndexOf("H") > -1 || this.Formato.IndexOf("m") > -1 || this.Formato.IndexOf("s") > -1)
                    {
                        strFormatComparacao = "yyyyMMddHHmmss";
                    }

                    if (!this.Permite_Futuro && ulong.Parse(value.ToString(strFormatComparacao)) > ulong.Parse(DateTime.Now.ToString(strFormatComparacao)))
                    {
                        MessageBox.Show(this.ParentForm, "Este campo não permite datas a futuro!", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }

                    if (!this.Permite_Passado && ulong.Parse(value.ToString(strFormatComparacao)) < ulong.Parse(DateTime.Now.ToString(strFormatComparacao)))
                    {
                        MessageBox.Show(this.ParentForm, "Este campo não permite datas a passado!", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }

                    this.txtData.Text = value.ToString(this.Formato);
                    this.intAno = (ushort)value.Year;
                    this.intMes = (ushort)value.Month;
                    this.intDia = (ushort)value.Day;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this.ParentForm, "Data_DateTime\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Permite_Limpar

        public Boolean Permite_Limpar
        {
            get { return this.btnClear.Enabled; }
            set { this.btnClear.Enabled = value; }
        }

        #endregion

        #region Hoje

        public Boolean Hoje
        {
            get { return (this.DateTime.ToShortDateString().Equals(DateTime.Now.ToShortDateString())); }
            set
            {
                if (value)
                {
                    this.DateTime = DateTime.Now;
                }
            }
        }

        #endregion

        #region isDate

        public Boolean isDate
        {
            get { return (this.DateTime != DateTime.MinValue); }
        }

        #endregion

        #region Dia

        public ushort Dia
        {
            get { return this.intDia; }
        }

        #endregion

        #region Mes

        public ushort Mes
        {
            get { return this.intMes; }
        }

        #endregion

        #region Ano

        public ushort Ano
        {
            get { return this.intAno; }
        }

        #endregion

        #region Formato

        public String Formato
        {
            get { return this.strFormato; }
            set
            {
                this.strFormato = value.Replace("h", "H").Replace("D", "d").Replace("Y", "y").Replace("S", "s");
                if (this.isDate)
                    this.DateTime = this.DateTime;
            }
        }

        #endregion

        #region PermitePassado

        public Boolean Permite_Passado
        {
            get { return this.blnPassado; }
            set { this.blnPassado = value; }
        }

        #endregion

        #region PermiteFuturo

        public Boolean Permite_Futuro
        {
            get { return this.blnFuturo; }
            set { this.blnFuturo = value; }
        }

        #endregion

        #region Preenchimento Obrigatorio

        public Boolean Preenchimento_Obrigatorio
        {
            get { return this.blnObrigatorio; }
            set { this.blnObrigatorio = value; }
        }

        #endregion

        #endregion

        #region btnClear

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                this.DateTime = DateTime.MinValue;
                this.txtData.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "btnClear_Click\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region txtData

        private void txtData_Enter(object sender, EventArgs e)
        {
            try
            {
                if (this.isDate)
                {
                    if (this.Formato.IndexOf("H") > -1
                        || this.Formato.IndexOf("m") > -1
                        || this.Formato.IndexOf("s") > -1)
                    {
                        this.txtData.Text = this.DateTime.ToString("ddMMyyyyHHmmss");
                    }
                    else
                    {
                        this.txtData.Text = this.DateTime.ToString("ddMMyyyy");
                    }
                }
                else
                {
                    this.txtData.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "txtData_Enter\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show(this.ParentForm, "txtData_KeyPress\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtData_Leave(object sender, EventArgs e)
        {
        }

        private void txtData_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.Preenchimento_Obrigatorio && !this.isDate)
                {
                    MessageBox.Show(this.ParentForm, "O preenchimento deste campo é obrigatório", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "txtData_Leave\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DateTime dteData;
            String strData;
            try
            {
                strData = this.txtData.Text.Trim();

                if (this.txtData.Text.Length == 6 && this.Formato.IndexOf("d") > -1)
                    this.txtData.Text = ulong.Parse(this.txtData.Text).ToString("00\\/00\\/00");
                else if (this.txtData.Text.Length == 6 && this.Formato.IndexOf("H") > -1)
                    this.txtData.Text = ulong.Parse(this.txtData.Text).ToString("00:00:00");
                else if (this.txtData.Text.Length == 8 && this.Formato.IndexOf("d") > -1)
                    this.txtData.Text = ulong.Parse(this.txtData.Text).ToString("00\\/00\\/0000");
                else if (this.Formato.IndexOf("H") > -1 || this.Formato.IndexOf("m") > -1 || this.Formato.IndexOf("s") > -1)
                {
                    // Permite a digitacao e formatacao de tempo junto com a data
                    if (this.txtData.Text.Length == 10)
                        this.txtData.Text = ulong.Parse(this.txtData.Text).ToString("00\\/00\\/00 00:00");
                    else if (this.txtData.Text.Length == 12 && this.Formato.IndexOf("s") > -1)
                        this.txtData.Text = ulong.Parse(this.txtData.Text).ToString("00\\/00\\/00 00:00:00");
                    else if (this.txtData.Text.Length == 12)
                        this.txtData.Text = ulong.Parse(this.txtData.Text).ToString("00\\/00\\/0000 00:00");
                    else if (this.txtData.Text.Length == 14)
                        this.txtData.Text = ulong.Parse(this.txtData.Text).ToString("00\\/00\\/0000 00:00:00");
                }
                else
                    this.txtData.Text = "";

                DateTime.TryParse(this.txtData.Text, out  dteData);

                this.txtData.Text = "";
                this.intAno = 0;
                this.intMes = 0;
                this.intDia = 0;

                this.DateTime = dteData;

                if (strData.Length > 0 && this.txtData.Text.ToString().Trim().Length == 0)
                {
                    MessageBox.Show(this.ParentForm, "Data Inválida", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "txtData_Leave\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region btnCalendario

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            try
            {
                (new frmCalendario(this)).ShowDialog();
                this.txtData.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "btnCalendario_Click\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}