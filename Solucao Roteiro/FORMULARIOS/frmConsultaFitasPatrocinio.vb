Public Class frmConsultaFitasPatrocinio
    Dim strTipoFitaPatrocinio As String
    Dim clsControleFita As MSAClass.asmxControleFita.asmxControleFita = NewControleFita()
    Dim dtbFita As New DataTable

    Private Sub frmConsultaFitasPatrocinio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CenterToScreen()
        SetaUserControl(Me)
        strTipoFitaPatrocinio = fParametro(279) & ","
    End Sub

   
    Private Sub btnCarregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregar.Click
        Dim strCompencia As String = ""
        Dim intCompetencia As Int32 = 0
        Dim tx As New DataGridViewTextBoxColumn
        Dim ck As New DataGridViewCheckBoxCell

        Try
            If UcCompetencia.Text.Trim <> "" Then

                strCompencia = UcCompetencia.Text.Substring(3, 4) & UcCompetencia.Text.Substring(0, 2)
                intCompetencia = Int32.Parse(strCompencia)
            End If
            dtbFita = clsControleFita.spuConsultaFitaPatrocinio(intCompetencia, ucPrograma.Text, ucVeiculo.Text, ucFinaInicio.Text, ucFitaFinal.Text, ucTipoComercial.Text, gsUsuario)

            dtbFita.Columns.Add("Flag", GetType(System.Boolean))
            For Each dt As DataRow In dtbFita.Rows
                dt.Item("Flag") = False
            Next
            gridFita.DataSource = dtbFita

            '=============================Titulo das Colunas 
            With gridFita

                .AllowUserToAddRows = False

                .Columns("Flag").HeaderText = ""
                .Columns("Cod_Veiculo").HeaderText = "Veiculo"
                .Columns("Cod_Programa").HeaderText = "Programa"
                .Columns("Cod_Tipo_Comercial").HeaderText = "Tp Comercial"
                .Columns("Inicio_Validade").HeaderText = "Data Inicio"
                .Columns("Fim_Validade").HeaderText = "Data Fim"
                .Columns("Numero_Fita").HeaderText = "Fita"
                .Columns("Duracao_Cabeca").HeaderText = "Dur. Cabeça"
                .Columns("Data_Desativacao").HeaderText = "Dt Desativação"
                .Columns("Obs_Texto").HeaderText = "Obs"
                .Columns("Id_Fita_Patrocinio").HeaderText = "Id_Fita"
                .Columns("Id_Fita_Patrocinio").Visible = False
                .Columns("Descricao").Visible = False

                .Columns("Flag").DisplayIndex = 0
                .Columns("Cod_Veiculo").DisplayIndex = 1
                .Columns("Cod_Programa").DisplayIndex = 2
                .Columns("Cod_Tipo_Comercial").DisplayIndex = 3
                .Columns("Inicio_Validade").DisplayIndex = 4
                .Columns("Fim_Validade").DisplayIndex = 5
                .Columns("Numero_Fita").DisplayIndex = 6
                .Columns("Duracao_Cabeca").DisplayIndex = 7
                .Columns("Data_Desativacao").DisplayIndex = 8
                .Columns("Obs_Texto").DisplayIndex = 9
                .Columns("Id_Fita_Patrocinio").DisplayIndex = 10
                .Columns("Id_Fita_Patrocinio").DisplayIndex = 11

                .Columns("Flag").ReadOnly = False
                .Columns("Cod_Veiculo").ReadOnly = True
                .Columns("Cod_Programa").ReadOnly = True
                .Columns("Cod_Tipo_Comercial").ReadOnly = True
                .Columns("Inicio_Validade").ReadOnly = True
                .Columns("Fim_Validade").ReadOnly = True
                .Columns("Numero_Fita").ReadOnly = True
                .Columns("Duracao_Cabeca").ReadOnly = True
                .Columns("Data_Desativacao").ReadOnly = True
                .Columns("Obs_Texto").ReadOnly = True
                .Columns("Id_Fita_Patrocinio").ReadOnly = True
                .Columns("Id_Fita_Patrocinio").ReadOnly = True

                .Columns("Flag").Width = 30
                .Columns("Cod_Veiculo").Width = 50
                .Columns("Cod_Programa").Width = 60
                .Columns("Cod_Tipo_Comercial").Width = 60
                .Columns("Inicio_Validade").Width = 90
                .Columns("Fim_Validade").Width = 90
                .Columns("Numero_Fita").Width = 80
                .Columns("Duracao_Cabeca").Width = 60
                .Columns("Data_Desativacao").Width = 70
                .Columns("Obs_Texto").Width = 300
                .Columns("Id_Fita_Patrocinio").Width = 0

                .SelectionMode = DataGridViewSelectionMode.FullRowSelect


            End With
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnDesativar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDesativar.Click
        Dim intMarcados As Integer
        Try
            With gridFita
                For x As Integer = 0 To .Rows.Count - 1
                    If .Item("flag", x).Value = True Then
                        intMarcados = intMarcados + 1
                    End If
                Next
            End With
            If intMarcados = 0 Then
                Aviso("Nenhuma Linha foi Marcada para Desativação")
                Exit Sub
            End If

            If Aviso("Confirma a desativação da(s) Fita(s) selecionada(s) ? ", vbYesNo, vbQuestion, "Atenção") Then
                With gridFita
                    For x As Integer = 0 To .Rows.Count - 1
                        If .Item("flag", x).Value = True Then
                            clsControleFita.spuDesativarFitaPatrocinio(.Item("Id_Fita_Patrocinio", x).Value)
                            .Item("Data_Desativacao", x).Value = DateTime.Today()
                        End If
                    Next
                End With
            End If

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim intMarcados As Integer
        Try
            With gridFita
                For x As Integer = 0 To .Rows.Count - 1
                    If .Item("flag", x).Value = True Then
                        intMarcados = intMarcados + 1
                    End If
                Next
            End With
            If intMarcados = 0 Then
                Aviso("Nenhuma Linha foi Marcada para Exclusão")
                Exit Sub
            End If


            If Aviso("Confirma a exclusão da(s) Fita(s) selecionada(s) ? ", vbYesNo, vbQuestion, "Atenção") Then
                With gridFita

                    For x As Integer = 0 To .Rows.Count - 1
                        If .Item("flag", x).Value = True Then
                            intMarcados = intMarcados + 1
                            clsControleFita.spuExcluirFitaPatrocinio(.Item("Id_Fita_Patrocinio", x).Value)
                        End If
                    Next
                End With
                btnCarregar_Click(New Object, New System.EventArgs)
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub


    Private Sub btnOkCancel_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkCancel.Cancel_Click
        Me.Close()
    End Sub
End Class