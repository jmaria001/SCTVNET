using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WCL_SCTV
{
    public partial class UCPesquisa : UserControl
    {
        private string strCod_Pesquisa = "";
        private Boolean _isNumeric = true;
        private DataTable _DataMember = null;
        private DataRow _DataRow = null;
        private String _RowFilter = "";
        private String _Sort = "";
        private DataGridViewColumn[] _DataGridViewColumnCollection;
        private String _WindowText ="Pesquisa";

        #region Form

        public UCPesquisa()
        {
            InitializeComponent();
        }

        private void UCPesquisa_Load(object sender, EventArgs e)
        {
            try
            {
                if ((this.Columns == null ? 0 : this.Columns.Length) < 2)
                {
                    this.btnPesquisa.Enabled = false;
                    this.txtCodigo.Enabled = false;
                    this.Permite_Limpar = false;
                }
                else
                {
                    this.btnPesquisa.Enabled = true;

                    if (this.txtCodigo.Text.Trim().Length != 0)
                        this.Preenchimento_Descricao();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "UCPesquisa_Load\n" + ex.Message, "UCPesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Properties

        #region Columns

        public DataGridViewColumn[] Columns
        {
            get { return this._DataGridViewColumnCollection; }
            set { this._DataGridViewColumnCollection = value; }
        }

        #endregion

        #region Codigo Length

        public int CodigoLength
        {
            get { return this.txtCodigo.MaxLength; }
            set { this.txtCodigo.MaxLength = value; }
        }

        #endregion

        //#region Codigo Numerico

        //protected Boolean isNumeric
        //{
        //    get { return this._isNumeric; }
        //    set { this._isNumeric = value; }
        //}

        //#endregion

        #region Codigo

        public virtual String Codigo
        {
            get { return this.txtCodigo.Text.Trim(); }
            set
            {
                try
                {
                    this.txtCodigo.Text = value.Trim().ToUpper();

                    if (this.strCod_Pesquisa != this.txtCodigo.Text && !(this._DataMember is MSAClass.AsmxTerceiro.dtsTerceiro.dtbTerceiroDataTable))
                        this.Preenchimento_Descricao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Codigo\n" + ex.Message, "UCPesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Boolean Codigo_Digitacao
        {
            get { return !this.txtCodigo.ReadOnly; }
            set
            {
                this.txtCodigo.ReadOnly = !value;
                this.txtCodigo.TabStop = value;
            }
        }

        #endregion

        #region Descricao

        public String Descricao
        {
            get { return this.txtDescricao.Text.Trim(); }
        }

        #endregion

        #region Permite_Limpar

        public Boolean Permite_Limpar
        {
            get { return this.btnClear.Enabled; }
            set { this.btnClear.Enabled = value; }
        }

        #endregion

        #region Permite_Pesquisar

        public Boolean Permite_Pesquisar
        {
            get { return this.btnPesquisa.Enabled; }
            set { this.btnPesquisa.Enabled = value; }
        }

        #endregion

        #region DataMember

        public DataTable DataMember
        {
            get { return this._DataMember; }
            set {
                this._DataMember = (DataTable)value;

                if (value != null)
                {
                    switch (this._DataMember.Columns[0].DataType.Name)
                    {
                        case "Int16":
                        case "Int32":
                        case "Int64":
                        case "UInt16":
                        case "UInt32":
                        case "UInt64":
                        case "Decimal":
                            this._isNumeric = true;
                            break;
                        default:
                            this._isNumeric = false;
                            break;
                    }
                }
            }
        }

        #endregion

        #region DataRow

        public virtual DataRow DataRow
        {
            set
            {
                this._DataRow = value;
                if (this._DataRow == null)
                {
                    this.strCod_Pesquisa = "";
                    this.txtCodigo.Text = "";
                    this.txtDescricao.Text = "";
                }
            }
            get { return this._DataRow; }
        }

        #endregion

        #region RowFilter

        public String RowFilter
        {
            get { return this._RowFilter; }
            set { this._RowFilter = value; }
        }

        #endregion

        #region Sort

        public String Sort
        {
            get { return this._Sort; }
            set { this._Sort = value; }
        }

        #endregion

        #region WindowText

        public String WindowText
        {
            get { return this._WindowText; }
            set { this._WindowText = value; }
        }

        #endregion

        #endregion

        #region btnClear

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.DataRow = null;
                this.txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "btnClear_Click\n" + ex.Message, "UserControlPesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region btnPesquisa

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._DataMember != null && this._DataMember.Rows.Count > 0 && !(this._DataMember is MSAClass.AsmxTerceiro.dtsTerceiro.dtbTerceiroDataTable))
                    (new frmPesquisa(this)).ShowDialog();

                this.txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "btnPesquisa_Click\n" + ex.Message, "UCPesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region txtCodigo

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (this._isNumeric)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "txtCodigo_Validating\n" + ex.Message, "UCPesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            String strCodigo;
            try
            {
                this.txtCodigo.Text = this.txtCodigo.Text.Trim();

                strCodigo = this.txtCodigo.Text;

                //if (this.txtCodigo.Text.Trim().Length != 0 && this.strCod_Pesquisa != this.txtCodigo.Text)
                if (this.strCod_Pesquisa != this.txtCodigo.Text && this.DataMember != null && !( this._DataMember is MSAClass.AsmxTerceiro.dtsTerceiro.dtbTerceiroDataTable ) )
                    this.Preenchimento_Descricao();

                if (strCodigo.Trim().ToUpper() != this.txtCodigo.Text.Trim().ToUpper())
                {
                    MessageBox.Show(this.ParentForm, "Código '" + strCodigo + "' Inválido", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "txtCodigo_Validating\n" + ex.Message, "UCPesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Preenchimento_Descricao

        private void Preenchimento_Descricao()
        {
            String strCod_Pesquisa2;
            String strRowFilter;
            try
            {
                strCod_Pesquisa2 = this.txtCodigo.Text.ToString();

                this.DataRow = null;

                if (this._DataMember == null || this.Columns == null)
                {
                    return;
                }

                if (this.Columns.Length < 2)
                {
                    return;
                }

                strRowFilter = this.RowFilter;
                strRowFilter += ((this.RowFilter.Length != 0) ? " and " : "");
                strRowFilter += this.Columns[0].DataPropertyName + " = ";

                switch (this._DataMember.Columns[this.Columns[0].DataPropertyName].DataType.Name)
                {
                    case "String":
                        strRowFilter += "'" + strCod_Pesquisa2 + "'";
                        break;

                    case "Int16":
                    case "Int32":
                    case "Int64":
                    case "UInt16":
                    case "UInt32":
                    case "UInt64":
                        long lngPesquisa;
                        long.TryParse(strCod_Pesquisa2, out lngPesquisa);
                        strRowFilter += lngPesquisa.ToString();
                        break;

                    case "Decimal":
                        Decimal decPesquisa;
                        Decimal.TryParse(strCod_Pesquisa2, out decPesquisa);
                        strRowFilter += decPesquisa.ToString();
                        break;
                }
                this._DataMember.DefaultView.RowFilter = strRowFilter;

                if (this._DataMember.DefaultView.Count != 0)
                {
                    this._DataRow = this._DataMember.DefaultView[0].Row;
                    this.strCod_Pesquisa = this._DataRow[this.Columns[0].DataPropertyName].ToString();
                    this.txtCodigo.Text = this._DataRow[this.Columns[0].DataPropertyName].ToString();
                    this.txtDescricao.Text = this._DataRow[this.Columns[1].DataPropertyName].ToString();
                }

                this._DataMember.DefaultView.RowFilter = this._RowFilter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Preenchimento_Descricao\n" + ex.Message, "UCPesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
