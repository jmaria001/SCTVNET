using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WCL_SCTV
{
    public partial class frmPesquisa : Form
    {
        UCPesquisa UCP;

        #region Form

        public frmPesquisa(UCPesquisa _UCP)
        {
            InitializeComponent();
            this.UCP = _UCP;
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = this.UCP.WindowText;

                if (this.UCP.DataMember != null && this.UCP.Columns != null)
                {
                    this.UCP.DataMember.DefaultView.RowFilter = this.UCP.RowFilter;
                    this.UCP.DataMember.DefaultView.Sort = this.UCP.Sort;

                    this.dgvPesquisa.DataSource = this.UCP.DataMember.DefaultView;

                    this.dgvPesquisa.Columns.Clear();

                    foreach (DataGridViewColumn dgvc in this.UCP.Columns)
                    {
                            this.cboFiltrar.Items.Add(dgvc.HeaderText);

                        if (this.UCP.DataMember.Columns[dgvc.DataPropertyName].DataType.Name == "Boolean" ||
                            this.UCP.DataMember.Columns[dgvc.DataPropertyName].DataType.Name == "Byte")
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

                            this.dgvPesquisa.Columns.Add(dgvn);
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

                            this.dgvPesquisa.Columns.Add(dgvn);
                        }
                    }

                    //this.dgvPesquisa.Columns.AddRange(this.UCP._dataGridViewColumns);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "frmPesquisa_Load\n" + ex.Message, "frmPesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPesquisa_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.UCP.DataMember != null)
                    this.UCP.DataMember.DefaultView.RowFilter = this.UCP.RowFilter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "cboFiltrar_SelectedIndexChanged\n" + ex.Message, "frmPesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region DataGridView

        private void dgvPesquisa_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.Selecionar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "dgvPesquisa_DoubleClick\n" + ex.Message, "frmPesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(this, "btnFechar_Click\n" + ex.Message, "frmPesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region btnSelecionar

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Selecionar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "btnSelecionar_Click\n" + ex.Message, "frmPesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Selecionar

        private void Selecionar()
        {
            try
            {
                this.UCP.txtCodigo.Text = "";
                this.UCP.txtDescricao.Text = "";
                this.UCP.DataRow = null;

                if (this.dgvPesquisa.SelectedRows.Count > 0)
                {
                    this.UCP.DataRow = ((DataRowView)this.dgvPesquisa.SelectedRows[0].DataBoundItem).Row; 
                    this.UCP.txtCodigo.Text = this.dgvPesquisa.SelectedRows[0].Cells[0].Value.ToString();
                    this.UCP.txtDescricao.Text = this.dgvPesquisa.SelectedRows[0].Cells[1].Value.ToString();
                }
                this.btnFechar_Click(this.btnFechar, (new EventArgs()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Selecionar\n" + ex.Message, "frmPesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(this, "txtFiltrar_TextChanged\n" + ex.Message, "frmPesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(this, "cboFiltrar_SelectedIndexChanged\n" + ex.Message, "frmPesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            String strFiltrar = "";
            DataGridViewColumn dgvc;

            try
            {
                dgvc = this.UCP.Columns[this.cboFiltrar.SelectedIndex];
                strFiltrar = dgvc.DataPropertyName;

                switch (this.UCP.DataMember.Columns[dgvc.DataPropertyName].DataType.Name)
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
                        Int64.TryParse(this.txtFiltrar.Text, out intFiltrar);

                        this.txtFiltrar.Text = intFiltrar.ToString();

                        strFiltrar += " = ";
                        strFiltrar += intFiltrar.ToString();

                        break;
                    default:
                        return;
                }

                if (this.UCP.RowFilter.Length == 0)
                {
                    this.UCP.DataMember.DefaultView.RowFilter = strFiltrar;
                }
                else
                {
                    this.UCP.DataMember.DefaultView.RowFilter = this.UCP.RowFilter + " and " + strFiltrar;
                }

                this.dgvPesquisa.DataSource = this.UCP.DataMember.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "btnFiltrar_Click\n" + ex.Message, "frmSeleciona", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}