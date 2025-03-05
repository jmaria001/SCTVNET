using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MSAClass.AsmxTerceiro;

namespace WCL_SCTV
{
    public partial class frmTerceiro : Form
    {
        UCTerceiro UCP;

        #region Form

        public frmTerceiro(UCTerceiro _UCP)
        {
            InitializeComponent();
            this.UCP = _UCP;
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
                MessageBox.Show(this, "dgvPesquisa_DoubleClick\n" + ex.Message, "frmTerceiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(this, "btnFechar_Click\n" + ex.Message, "frmTerceiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(this, "btnSelecionar_Click\n" + ex.Message, "frmTerceiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if (this.dgvPesquisa.SelectedRows.Count > 0)
                {
                    this.UCP.txtCodigo.Text = this.dgvPesquisa.SelectedRows[0].Cells[0].Value.ToString();
                    this.UCP.txtDescricao.Text = this.dgvPesquisa.SelectedRows[0].Cells[1].Value.ToString();
                }

                this.UCP.Preenchimento_Descricao();
                this.btnFechar_Click(this.btnFechar, (new EventArgs()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Selecionar\n" + ex.Message, "frmTerceiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Pesquisar

        #region TextChanged

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.btnPesquisarCodigo.Enabled = (this.txtCodigo.Text.Trim().Length != 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "txtCodigo_TextChanged\n" + ex.Message, "frmTerceiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRazaoSocial_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.btnPesquisarRazaoSocial.Enabled = (this.txtRazaoSocial.Text.Trim().Length != 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "txtRazaoSocial_TextChanged\n" + ex.Message, "frmTerceiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region ucCNPJ_CPF_Validating

        private void ucCNPJ_CPF_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                this.btnPesquisarCNPJCPF.Enabled = (this.ucCNPJ_CPF.isCNPF || this.ucCNPJ_CPF.isCPF);
                this.btnPesquisarCNPJCPF.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "ucCNPJ_CPF_Validating\n" + ex.Message, "frmTerceiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion
        
        #region Button

        private void btnPesquisarCodigo_Click(object sender, EventArgs e)
        {
            dtsTerceiro.dtbTerceiro_PesquisaDataTable dtb;
            try
            {
                this.asmxTerceiro = new MSAClass.AsmxTerceiro.asmxTerceiro();
                dtb = this.asmxTerceiro.spuPesquisar_Codigo(this.txtCodigo.Text.Trim(), this.UCP.Usuario_Empresa);

                this.dgvPesquisa.DataSource = dtb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "btnPesquisarCodigo_Click\n" + ex.Message, "frmTerceiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisarRazaoSocial_Click(object sender, EventArgs e)
        {
            dtsTerceiro.dtbTerceiro_PesquisaDataTable dtb;
            try
            {
                this.asmxTerceiro = new MSAClass.AsmxTerceiro.asmxTerceiro();
                dtb = this.asmxTerceiro.spuPesquisar_Razao_Social(this.txtRazaoSocial.Text.Trim(), this.UCP.Usuario_Empresa.ToString());

                this.dgvPesquisa.DataSource = dtb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "btnPesquisarRazaoSocial_Click\n" + ex.Message, "frmTerceiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisarCNPJCPF_Click(object sender, EventArgs e)
        {
            dtsTerceiro.dtbTerceiro_PesquisaDataTable dtb;
            try
            {
                this.asmxTerceiro = new MSAClass.AsmxTerceiro.asmxTerceiro();
                dtb = this.asmxTerceiro.spuPesquisar_CNPJ(this.ucCNPJ_CPF.CNPJ_CPF, this.UCP.Usuario_Empresa);

                this.dgvPesquisa.DataSource = dtb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "btnPesquisarCNPJCPF_Click\n" + ex.Message, "frmTerceiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion
    }
}