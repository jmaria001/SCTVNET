using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WCL_SCTV.UC
{
    public partial class UCCompetencia : UserControl
    {
        private ushort intAno;
        private ushort intMes;
        private Boolean blnPermite_Passado = true;
        private Boolean blnPermite_Futuro = true;

        #region Form

        public UCCompetencia()
        {
            InitializeComponent();
            this.Competencia_Int = 0;
        }

        #endregion

        #region Properties

        #region Competencia Text

        public string Competencia_Text
        {
            get { return this.txtCompetencia.Text.Trim(); }
        }

        #endregion

        #region Competencia Int

        public int Competencia_Int
        {
            get { return int.Parse(this.intAno.ToString("0000") + this.intMes.ToString("00")); }
            set
            {
                String strCompetencia;
                try
                {
                    this.intAno = 0;
                    this.intMes = 0;
                    this.txtCompetencia.Text = "";

                    strCompetencia = value.ToString();

                    if (strCompetencia.Length != 6)
                    {
                        return;
                    }

                    ushort.TryParse(strCompetencia.Substring(0, 4), out this.intAno);
                    ushort.TryParse(strCompetencia.Substring(4, 2), out this.intMes);

                    if (this.intMes == 0 || this.intMes > 12 || this.intAno == 0)
                    {
                        this.intAno = 0;
                        this.intMes = 0;
                        return;
                    }

                    this.intAno += ushort.Parse((this.intAno < 1000 ? 2000 : 0).ToString());

                    this.txtCompetencia.Text += this.intMes.ToString("00");
                    this.txtCompetencia.Text += "/";
                    this.txtCompetencia.Text += this.intAno.ToString("0000");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this.ParentForm, "Competencia_Int\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #region CompetenciaAtual

        public Boolean CompetenciaAtual
        {
            get { return (this.Competencia_Int == int.Parse(DateTime.Now.ToString("yyyyMM"))); }

            set
            {
                if (value)
                {
                    this.Competencia_Int = int.Parse(DateTime.Now.ToString("yyyyMM"));
                }
            }
        }

        #endregion

        #region isCompetencia

        public Boolean isCompetencia
        {
            get { return (this.Competencia_Int != 0); }
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

        #region Data_Inicio

        public DateTime Data_Inicio
        {
            get
            {
                DateTime dteRetorno = DateTime.MinValue;
                try
                {
                    DateTime.TryParse(this.intAno.ToString("0000") + "/" + this.intMes.ToString("00") + "/01", out dteRetorno);
                }
                catch (Exception ex)
                {
                    MessageBox.Show( this.ParentForm, "Data_Inicio\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return dteRetorno;
            }
        }

        #endregion

        #region Data_Termino

        public DateTime Data_Termino
        {
            get
            {
                DateTime dteRetorno = DateTime.MaxValue;
                try
                {
                    dteRetorno = this.Data_Inicio.AddMonths(1).AddDays(-1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this.ParentForm, "Data_Termino\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return dteRetorno;
            }
        }

        #endregion
        #region Permite_Passado

        public Boolean Permite_Passado
        {
            get { return this.blnPermite_Passado; }
            set { this.blnPermite_Passado = value; }
        }

        #endregion
        #region Permite_Futuro

        public Boolean Permite_Futuro
        {
            get { return this.blnPermite_Futuro; }
            set { this.blnPermite_Futuro = value; }
        }

               #endregion

        #endregion

        #region btnClear

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                this.Competencia_Int = 0;
                this.txtCompetencia.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "btnClear_Click\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region txtCompetencia

        private void txtCompetencia_Enter(object sender, EventArgs e)
        {
            try
            {
                this.txtCompetencia.Text = this.txtCompetencia.Text.Trim().Replace("/", "").Replace("-", "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "txtCompetencia_Enter\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCompetencia_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show(this.ParentForm, "txtCompetencia_KeyPress\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCompetencia_Validating(object sender, CancelEventArgs e)
        {
            byte intPosicao;
            String strCompetencia;
            try
            {
                strCompetencia = this.txtCompetencia.Text.Trim().Replace("/", "").Replace("-", "");
                this.txtCompetencia.Text = "";
                this.intAno = 0;
                this.intMes = 0;

                switch (strCompetencia.Length)
                {
                    case 4:
                        intPosicao = 2;
                        break;
                    case 6:
                        intPosicao = 4;
                        break;
                    default:
                        return;
                }

                ushort.TryParse(strCompetencia.Substring(0, 2), out this.intMes);
                ushort.TryParse(strCompetencia.Substring(2, intPosicao), out this.intAno);

                if (this.intMes == 0 || this.intMes > 12 || this.intAno == 0)
                {
                    MessageBox.Show(this.ParentForm, "Competência inválida", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnClear_Click(this, new EventArgs());
                    this.intAno = 0;
                    this.intMes = 0;
                    e.Cancel = true;
                    return;
                }

                this.intAno += ushort.Parse((this.intAno < 1000 ? 2000 : 0).ToString());

                this.txtCompetencia.Text += this.intMes.ToString("00");
                this.txtCompetencia.Text += "/";
                this.txtCompetencia.Text += this.intAno.ToString("0000");
                            
            
                if (!this.Permite_Passado && this.Competencia_Int < int.Parse(DateTime.Now.ToString("yyyyMM")))
                {
                    MessageBox.Show(this.ParentForm, "Não é permitido competencia a passado neste campo", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                    this.btnClear_Click(this, new EventArgs());
                    return ;
                }

                if (!this.Permite_Futuro && this.Competencia_Int > int.Parse(DateTime.Now.ToString("yyyyMM")))
                {
                    MessageBox.Show(this.ParentForm, "Não é permitido competencia a futuro neste campo", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnClear_Click(this,new EventArgs() );
                    e.Cancel = true;
                    return ;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "txtCompetencia_Validating\n" + ex.ToString(), this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


    }
}
