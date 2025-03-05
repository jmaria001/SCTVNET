using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MSAClass.AsmxTerceiro;
using MSAClass.AsmxUsuario;

namespace WCL_SCTV
{
    public partial class UCTerceiro : UCPesquisa
    {
        private String strUsuario_Empresa = "";
        private String strCod_Pesquisa = "";
        private dtsTerceiro.dtbTerceiroRow drwTerceiro = null;
        
        

        #region Form

        public UCTerceiro()
        {
            InitializeComponent();

            this.asmxTerceiro = new asmxTerceiro();
            this.DataMember = this.dtsTerceiro.dtbTerceiro;
        }

        private void UCTerceiro_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCodigo.Text.Trim().Length != 0 && this.DataMember is dtsTerceiro.dtbTerceiroDataTable)
                    this.Preenchimento_Descricao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "UCTerceiro_Load\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Codigo

        public override String Codigo
        {
            get { return this.txtCodigo.Text.Trim(); }
            set
            {
                try
                {
                    base.Codigo = value.Trim().ToUpper();

                    if (this.strCod_Pesquisa != this.txtCodigo.Text && this.DataMember is dtsTerceiro.dtbTerceiroDataTable)
                        this.Preenchimento_Descricao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this.ParentForm, "Codigo\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region btnPesquisa

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DataMember == null || this.DataMember is dtsTerceiro.dtbTerceiroDataTable)
                {
                    if (this.Usuario_Empresa == "")
                    {
                        MessageBox.Show(this.ParentForm, "Desenvolvedor\nFAVOR configurar este objeto por Empresa do usuário" + this.Name, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    (new frmTerceiro(this)).ShowDialog();
                    this.blnValidaTerceiroUsuario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "btnPesquisa_Click\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region txtCodigo

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                this.txtCodigo.Text = this.txtCodigo.Text.Trim();

                //if (this.txtCodigo.Text.Trim().Length != 0 && this.strCod_Pesquisa != this.txtCodigo.Text)
                if (this.strCod_Pesquisa != this.txtCodigo.Text && (this.DataMember == null || this.DataMember is MSAClass.AsmxTerceiro.dtsTerceiro.dtbTerceiroDataTable))
                    this.Preenchimento_Descricao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "txtCodigo_Validating\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Preenchimento_Descricao

        internal void Preenchimento_Descricao()
        {
            String strCod_Pesquisa2;
            try
            {
                strCod_Pesquisa2 = this.txtCodigo.Text.Trim();

                this.strCod_Pesquisa = "";
                this.txtCodigo.Text = "";
                this.txtDescricao.Text = "";
                this.drwTerceiro = null;

                if (strCod_Pesquisa2 == "")
                    return;

                this.dtsTerceiro = asmxTerceiro.spuCarregar(strCod_Pesquisa2);

                this.DataMember = this.dtsTerceiro.dtbTerceiro;

                if (this.DataMember is dtsTerceiro.dtbTerceiroDataTable)
                {
                    if (this.RowFilter.Length != 0)
                    {
                        this.dtsTerceiro.dtbTerceiro.DefaultView.RowFilter = this.RowFilter;
                    }

                    if (this.dtsTerceiro.dtbTerceiro.DefaultView.Count != 0)
                    {
                        this.drwTerceiro = (dtsTerceiro.dtbTerceiroRow)this.dtsTerceiro.dtbTerceiro.DefaultView[0].Row;
                        if (this.blnValidaTerceiroUsuario())
                        {
                            this.strCod_Pesquisa = this.drwTerceiro.Cod_Terceiro.Trim();
                            this.txtCodigo.Text = this.drwTerceiro.Cod_Terceiro.Trim();
                            this.txtDescricao.Text = this.drwTerceiro.Razao_Social.Trim();
                        }
                    }
                    this.dtsTerceiro.dtbTerceiro.DefaultView.RowFilter = this.RowFilter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Preenchimento_Descricao\n" + ex.Message, "UCTerceiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Valida Terceiro Usuario
        private Boolean blnValidaTerceiroUsuario()
        {
            Boolean blnRetorno = false;
            try
            {
                blnRetorno = true;

                //if (this._dtbUsuario_Empresa == null)
                //    return true;

                //if (this.drwTerceiro == null)
                //    return false;

                //foreach (MSAClass.AsmxUsuario.dtsUsuario.dtbUsuario_EmpresaRow drwUE in this._dtbUsuario_Empresa.Rows)
                //{
                //    if (this.dtsTerceiro.dtbTerceiro_Complementar.Select("Cod_Terceiro = '" + this.drwTerceiro.Cod_Terceiro + "' and Cod_Empresa = '" + drwUE.Cod_Empresa + "'").Length > 0)
                //    {
                //        blnRetorno = true;
                //        break;
                //    }
                //}

                //if (!blnRetorno)
                //{
                //    MessageBox.Show(this.ParentForm, "Este Terceiro não é valido para nenhuma das empresas do usuário!", this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    this.drwTerceiro = null;
                //    this.txtCodigo.Text = "";
                //    this.txtDescricao.Text = "";
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ParentForm, "blnValidaTerceiroUsuario\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return blnRetorno;
        }
        #endregion

        #region Properties

        #region dtsTerceiro

        public dtsTerceiro DataSet_Terceiro
        {
            get { return this.dtsTerceiro; }
        }

        #endregion

        #region DataRowTerceiro

        public dtsTerceiro.dtbTerceiroRow DataRowTerceiro
        {
            get { return drwTerceiro; }
        }

        #endregion

        #region Usuario_Empresa

        public dtsUsuario.dtbUsuario_EmpresaDataTable dtbUsuario_Empresa
        {
            set
            {
                String strUsuario_Empresa;
                try
                {
                    strUsuario_Empresa = "";
                    if (value != null)
                    {
                        foreach (dtsUsuario.dtbUsuario_EmpresaRow drw in value.Rows)
                        {
                            strUsuario_Empresa += drw.Cod_Empresa;
                            strUsuario_Empresa += ",";
                        }
                    }
                    this.Usuario_Empresa = strUsuario_Empresa;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this.ParentForm, "dtbUsuario_Empresa\n" + ex.Message, this.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public String Usuario_Empresa
        {
            set{ this.strUsuario_Empresa = value ;}
            get{ return this.strUsuario_Empresa; }
        }

        #endregion

        #endregion
    }
}
