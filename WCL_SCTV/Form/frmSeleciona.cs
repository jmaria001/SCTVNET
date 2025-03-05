using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WCL_SCTV
{
    public partial class frmSeleciona : Form
    {
        UCSeleciona UCS;

        #region Form

        public frmSeleciona(UCSeleciona _UCS)
        {
            InitializeComponent();
            this.UCS = _UCS;
        }

        private void frmSeleciona_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = this.UCS.WindowText;

                if (this.UCS.DataMember != null && this.UCS.Columns != null)
                {
                    this.UCS.DataMember.DefaultView.RowFilter = this.UCS.RowFilter;
                    this.UCS.DataMember.DefaultView.Sort = this.UCS.Sort;

                    this.dgvSeleciona.DataSource = this.UCS.DataMember.DefaultView;

                    this.dgvSeleciona.Columns.Clear();

                    DataGridViewCheckBoxColumn dgvUCSeleciona = new DataGridViewCheckBoxColumn();
                    dgvUCSeleciona.DataPropertyName = "UCSeleciona";
                    dgvUCSeleciona.HeaderText = "";
                    dgvUCSeleciona.Name = "dgvUCSeleciona";
                    dgvUCSeleciona.SortMode = DataGridViewColumnSortMode.Automatic;
                    dgvUCSeleciona.Visible = true;
                    dgvUCSeleciona.Width = 30;
                    dgvUCSeleciona.Frozen = true;
                    dgvUCSeleciona.ReadOnly = false;
                    dgvUCSeleciona.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                    this.dgvSeleciona.Columns.Add(dgvUCSeleciona);

                    foreach (DataGridViewColumn dgvc in this.UCS.Columns)
                    {
                        this.cboFiltrar.Items.Add(dgvc.HeaderText);

                        if (this.UCS.DataMember.Columns[dgvc.DataPropertyName].DataType.Name == "Boolean" ||
                            this.UCS.DataMember.Columns[dgvc.DataPropertyName].DataType.Name == "Byte")
                        {
                            DataGridViewCheckBoxColumn dgvn = new DataGridViewCheckBoxColumn();
                            dgvn.DataPropertyName = dgvc.DataPropertyName;
                            dgvn.HeaderText = dgvc.HeaderText;
                            dgvn.Name = dgvc.Name;
                            dgvn.SortMode = dgvc.SortMode;
                            dgvn.Visible = dgvc.Visible;
                            dgvn.Width = dgvc.Width;
                            dgvn.Frozen = dgvc.Frozen;
                            dgvn.AutoSizeMode = dgvc.AutoSizeMode;
                            dgvn.DefaultCellStyle = dgvc.DefaultCellStyle;
                            dgvn.ReadOnly = true;

                            this.dgvSeleciona.Columns.Add(dgvn);
                        }
                        else
                        {
                            DataGridViewTextBoxColumn dgvn = new DataGridViewTextBoxColumn();
                            dgvn.DataPropertyName = dgvc.DataPropertyName;
                            dgvn.HeaderText = dgvc.HeaderText;
                            dgvn.Name = dgvc.Name;
                            dgvn.SortMode = dgvc.SortMode;
                            dgvn.Visible = dgvc.Visible;
                            dgvn.Width = dgvc.Width;
                            dgvn.Frozen = dgvc.Frozen;
                            dgvn.AutoSizeMode = dgvc.AutoSizeMode;
                            dgvn.DefaultCellStyle = dgvc.DefaultCellStyle;
                            dgvn.ReadOnly = true;

                            this.dgvSeleciona.Columns.Add(dgvn);
                        }
                    }

                    //this.dgvSeleciona.Columns.AddRange(this.UCS._dataGridViewColumns);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "frmSeleciona_Load\n" + ex.Message, "frmSeleciona", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSeleciona_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Selecionar();

                if (this.UCS.DataMember != null)
                    this.UCS.DataMember.DefaultView.RowFilter = this.UCS.RowFilter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "cboFiltrar_SelectedIndexChanged\n" + ex.Message, "frmSeleciona", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region btnFechar

        private void btnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "btnFechar_Click\n" + ex.Message, "frmSeleciona", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Selecionar

        private void Selecionar()
        {
            try
            {
                this.UCS.DataRow = null;
                this.UCS.DataRow = this.UCS.DataMember.Select("UCSeleciona");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Selecionar\n" + ex.Message, "frmSeleciona", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Filtrar

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.btnFiltrar.Enabled = (this.txtFiltrar.Text.Trim().Length != 0 && this.cboFiltrar.SelectedIndex != -1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "txtFiltrar_TextChanged\n" + ex.Message, "frmSeleciona", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.btnFiltrar.Enabled = (this.txtFiltrar.Text.Trim().Length != 0 && this.cboFiltrar.SelectedIndex != -1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "cboFiltrar_SelectedIndexChanged\n" + ex.Message, "frmSeleciona", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            String strFiltrar = "";
            DataGridViewColumn dgvc;

            try
            {
                dgvc = this.UCS.Columns[this.cboFiltrar.SelectedIndex];
                strFiltrar = dgvc.DataPropertyName;

                switch (this.UCS.DataMember.Columns[dgvc.DataPropertyName].DataType.Name)
                {
                    case "String":
                        strFiltrar += " LIKE '%";
                        strFiltrar += this.txtFiltrar.Text;
                        strFiltrar += "%'";
                        break;
                    case "int":
                    case "Int16":
                    case "Int32":
                    case "Int64":
                        Int64 intFiltrar = 0;
                        Int64.TryParse( this.txtFiltrar.Text, out intFiltrar );

                        this.txtFiltrar.Text = intFiltrar.ToString();

                        strFiltrar += " = ";
                        strFiltrar += intFiltrar.ToString();

                        break;
                    default:
                        return;
                }

                if (this.UCS.RowFilter.Length == 0)
                {
                    this.UCS.DataMember.DefaultView.RowFilter = strFiltrar;
                }
                else
                {
                    this.UCS.DataMember.DefaultView.RowFilter = this.UCS.RowFilter + " and " + strFiltrar;
                }

                this.dgvSeleciona.DataSource = this.UCS.DataMember.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "btnFiltrar_Click\n" + ex.Message, "frmSeleciona", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Marcar Desmarcar

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow drw in this.UCS.DataMember.Select("not UCSeleciona"))
                {
                    drw["UCSeleciona"] = true;
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "btnMarcar_Click\n" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow drw in this.UCS.DataMember.Select("UCSeleciona"))
                {
                    drw["UCSeleciona"] = false;
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "btnDesmarcar_Click\n" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}