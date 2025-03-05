using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WCL_SCTV
{
    public partial class UCSeleciona : UserControl
    {
        private DataTable _DataMember = null;
        private DataRow[] _DataRow = null;
        private String _RowFilter = "";
        private String _Sort = "";
        private DataGridViewColumn[] _DataGridViewColumnCollection;
        private String _WindowText ="Seleciona";

        #region Form

        public UCSeleciona()
        {
            InitializeComponent();
        }

        private void UCSeleciona_Load(object sender, EventArgs e)
        {
            try
            {
                if ((this.Columns == null ? 0 : this.Columns.Length) < 2)
                {
                    this.btnSeleciona.Enabled = false;
                    this.Permite_Limpar = false;
                }
                else
                {
                    this.btnSeleciona.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCSeleciona_Load\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCSeleciona_EnabledChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtCodigo.BackColor = (this.Enabled ? System.Drawing.Color.White : System.Drawing.SystemColors.Control);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCSeleciona_EnabledChanged\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #region Codigo

        public virtual String Codigo
        {
            get { return this.txtCodigo.Text.Trim().Replace("|", ","); }
        }

        #endregion

        #region Permite_Limpar

        public Boolean Permite_Limpar
        {
            get { return this.btnClear.Enabled; }
            set { this.btnClear.Enabled = value; }
        }

        #endregion

        #region DataMember

        public DataTable DataMember
        {
            get { return this._DataMember; }
            set
            {
                this._DataMember = (DataTable)value;
                if (!this._DataMember.Columns.Contains("UCSeleciona"))
                {
                    DataColumn dtc = new DataColumn("UCSeleciona", Type.GetType("System.Boolean"));
                    dtc.DefaultValue = false;
                    
                    this._DataMember.Columns.Add(dtc);
                }
            }
        }

        #endregion

        #region DataRow

        public virtual DataRow[] DataRow
        {
            set
            {
                String strCodigo = "";
                Boolean blnString = true;
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    this._DataRow = value;
                    this.txtCodigo.Text = "";

                    if (value != null && value.Length > 0 )
                    {
                        blnString = (value[0][this.Columns[0].DataPropertyName].GetType() == Type.GetType("System.String"));
                        foreach (DataRow drw in value)
                        {
                            if (blnString)
                            {
                                strCodigo += " '";
                                strCodigo += drw[this.Columns[0].DataPropertyName].ToString().Trim();
                                strCodigo += "',";
                            }
                            else
                            {
                                strCodigo += drw[this.Columns[0].DataPropertyName].ToString().Trim();
                                strCodigo += " ,";
                            }
                        }

                        if (strCodigo.Length > 0)
                        {
                            if (strCodigo.LastIndexOf(",") == strCodigo.Length - 1)
                            {
                                strCodigo = strCodigo.Substring(0, strCodigo.Length - 1);
                            }
                            this.txtCodigo.Text = strCodigo.Trim();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this.ParentForm, "DataRow\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
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
                foreach (DataRow drw in this._DataMember.Select("UCSeleciona"))
                {
                    drw["UCSeleciona"] = false;
                }
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

        #region btnSeleciona

        private void btnSeleciona_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._DataMember != null && this._DataMember.Rows.Count > 0 && !(this._DataMember is MSAClass.AsmxTerceiro.dtsTerceiro.dtbTerceiro_ComplementarDataTable))
                    (new frmSeleciona(this)).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "btnSeleciona_Click\n" + ex.Message, "UCSeleciona", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
