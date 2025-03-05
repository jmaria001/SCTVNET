using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WCL_SCTV.UC
{
    public partial class UCNumero : UserControl
    {
        private String strFormato;
        private Decimal decNumero;
        private Decimal decNumero_Max;
        private Decimal decNumero_Min;

        #region Form

        public UCNumero()
        {
            InitializeComponent();
            this.Formato = "N2";
            this.Numero_Decimal = 0;
            this.Numero_Max = Decimal.MaxValue;
            this.Numero_Min = Decimal.MinValue;
        }

        private void UCNumero_Load(object sender, EventArgs e)
        {
            try
            {
                Decimal.TryParse(this.txtNumero.Text, out this.decNumero);
                this.txtNumero.Text = "";
                if (this.decNumero != 0)
                {
                    this.txtNumero.Text = this.decNumero.ToString(this.Formato);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnClear_Click\n" + ex.ToString());
            }
        }

        #endregion

        #region Properties

        #region Numero_Decimal

        public Decimal Numero_Decimal
        {
            get { return this.decNumero; }
            set
            {
                try
                {
                    this.decNumero = value;
                    this.ShowNumero();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this.ParentForm, "Numero_Decimal\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Numero_Int

        public long Numero_Int
        {
            get
            {
                try
                {
                    return Decimal.ToInt64(this.decNumero);
                }
                catch
                {
                    return (0);
                }
            }
        }

        #endregion

        #region Numero Max

        public Decimal Numero_Max
        {
            get { return this.decNumero_Max; }
            set
            {
                try
                {
                    if (this.decNumero_Min > value)
                    {
                        this.decNumero_Max = Decimal.MaxValue;
                    }
                    else
                    {
                        this.decNumero_Max = value;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this.ParentForm, "Numero_Max\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Numero Min

        public Decimal Numero_Min
        {
            get { return this.decNumero_Min; }
            set
            {
                try
                {
                    if (this.decNumero_Max < value)
                    {
                        this.decNumero_Min = Decimal.MinValue;
                    }
                    else
                    {
                        this.decNumero_Min = value;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this.ParentForm, "Numero_Min\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Formato

        public String Formato
        {
            get { return this.strFormato; }
            set
            {
                this.strFormato = value.ToUpper();
                this.ShowNumero();
            }
        }

        #endregion

        #region MaxLength

        public int MaxLength
        {
            get { return this.txtNumero.MaxLength; }
            set { this.txtNumero.MaxLength = value; }
        }

        #endregion

        #region Permite_Limpar

        public Boolean Permite_Limpar
        {
            get { return this.btnClear.Enabled; }
            set { this.btnClear.Enabled = value; }
        }

        #endregion

        #endregion

        #region txtNumero

        private void txtNumero_Enter(object sender, EventArgs e)
        {
            Decimal decNumeroTemp;
            try
            {
                Decimal.TryParse(this.txtNumero.Text.Replace("%", ""), out decNumeroTemp);
                this.txtNumero.Text = "";
                if (decNumeroTemp != 0)
                {
                    this.txtNumero.Text = decNumeroTemp.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "txtNumero_Enter\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            Decimal decNumeroTemp;
            try
            {
                Decimal.TryParse(this.txtNumero.Text, out decNumeroTemp);

                if (this.Formato.IndexOf("P") > -1)
                {
                    decNumeroTemp *= Decimal.Parse((0.01).ToString());
                    Decimal.TryParse(decNumeroTemp.ToString(this.Formato).Replace("%", ""), out this.decNumero);
                    this.decNumero *= Decimal.Parse((0.01).ToString());
                }
                else
                {
                    Decimal.TryParse(decNumeroTemp.ToString(this.Formato), out this.decNumero);
                }

                if (this.decNumero > this.Numero_Max || this.decNumero < this.Numero_Min)
                {
                    MessageBox.Show("Este campo permite valores entre "
                    + "\n'" + this.Numero_Min.ToString(this.Formato) + "'"
                    + " e "
                    + "'" + this.Numero_Max.ToString(this.Formato) + "'", this.ParentForm.Name.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.decNumero = (this.Numero_Min > 0 ? this.Numero_Min : 0);
                }

                this.ShowNumero();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "txtNumero_Leave\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == char.Parse(",") || e.KeyChar == char.Parse("-"))
                {
                    if (this.txtNumero.Text.IndexOf(e.KeyChar) > -1)
                    {
                        //Permite apenas uma unica vez
                        e.KeyChar = (char)0;
                    }
                    return;
                }

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
                MessageBox.Show(this.ParentForm, "txtNumero_KeyPress\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            Decimal decNumeroTemp;
            try
            {
                Decimal.TryParse(this.txtNumero.Text.Replace("%", ""), out decNumeroTemp);
                if (decNumeroTemp < 0)
                {
                    this.txtNumero.ForeColor = Color.Red;
                }
                else
                {
                    this.txtNumero.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "txtNumero_TextChanged\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region btnClear

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                this.Numero_Decimal = 0;
                this.txtNumero.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "btnClear_Click\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region ShowNumero

        private void ShowNumero()
        {
            try
            {
                this.txtNumero.Text = this.decNumero.ToString(this.Formato);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "ShowNumero\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
