Imports System
Imports System.Management
Module modSCTV
    Enum ShowMode
        Show
        Dialog
    End Enum
#Region "DECLARACOES"
    Public Declare Function GetSystemMetrics Lib "User32" (ByVal nIndex As Short) As Short
    Public dtsEmpresaUsuario As DataSet = New DataSet
    Public gsUsuario As String = "" '"USRSCTVWEB" '-- VALOR DEFAULT PARA VALIDAR ACESSO- DEPOIS MUDA PARA USUARIO INFORMADO NO LOGIN 
    Public gsSenha As String = "" '-- VALOR DEFAULT PARA VALIDAR ACESSO- DEPOIS MUDA PARA SENHA INFORMADO NO LOGIN 
    Public gsEmpresa_Net As String = ""
    Public sEmpresadoUsuario As String = ""
    Public nLin As Integer, nCont As Integer
    Public sSql As String
    Public FlexOpcoes As AxMSFlexGridLib.AxMSFlexGrid
    Public strVeiculodoUsuario As String
    Public lngIdUsuario As Long
    Public sTipoAcesso As String
    Public strListaVeiculos As String
    Public bUsuario_Net As Boolean
    Public glFechaFormulario As Boolean
    Public MACAddress As String
    Public CPUIdentificador As String
    Public NomeComputador As String
#End Region
#Region "Funcoes/Subs"
    Public Sub fnSetaTamanhoColuna(ByRef pGrid As DataGridView, ByVal pColumn As String, ByVal pQtdCaracteres As Short)
        Dim texto As String = ReplicateString("M", pQtdCaracteres)
        Dim fr As New Form
        Dim f As New Font(pGrid.Font.FontFamily.Name, pGrid.Font.Size)
        Dim g As Graphics = fr.CreateGraphics()
        Dim s As SizeF = g.MeasureString(texto, f)
        pGrid.Columns(pColumn).Width = s.Width
        fr.Dispose()
    End Sub
    Public Sub fnGetTamanhoColuna(ByRef pGrid As DataGridView)
        For x As Integer = 0 To pGrid.Columns.Count - 1
            'Debug.Print(pGrid.Name & "(" & Chr(34) & pGrid.Columns(x).Name & Chr(34) & ") = " & pGrid.Columns(x).Width)
            MsgBox(pGrid.Name & "(" & Chr(34) & pGrid.Columns(x).Name & Chr(34) & ") = " & pGrid.Columns(x).Width)
        Next
    End Sub
    Public Sub EstiloGrid(ByVal dtg As DataGridView, ByVal pEstilo As Byte)
        Try
            If pEstilo = 1 Then '=======Gride de Apresentação de dados 
                With dtg
                    .BackgroundColor = Color.White
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    .ReadOnly = True
                    .AllowUserToAddRows = False
                    .AllowUserToDeleteRows = False
                    .AllowUserToResizeRows = False
                    .RowHeadersVisible = False
                    .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
                    .RowHeadersDefaultCellStyle.NullValue = ""
                    .RowsDefaultCellStyle.BackColor = Color.White
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
                    '.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
                    '.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.White
                    .BackgroundColor = Color.White
                End With
            End If

            If pEstilo = 2 Then '=======Gride de Escolha 
                With dtg
                    .BackgroundColor = Color.White
                    .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
                    .AllowUserToAddRows = False
                    .AllowUserToDeleteRows = False
                    .AllowUserToResizeRows = False
                    .RowHeadersVisible = False
                    .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
                    .RowHeadersDefaultCellStyle.NullValue = ""
                    .RowsDefaultCellStyle.BackColor = Color.White
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.White
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
                    .BackgroundColor = Color.White

                End With
            End If

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Public Sub PintaCelula(ByRef pCell As DataGridViewCell, ByVal pTipo As String, ByVal pColor As Color)
        Try
            Dim Estilo As DataGridViewCellStyle = New DataGridViewCellStyle
            Select Case pTipo.ToUpper
                Case "F"
                    Estilo.ForeColor = Color.Red
                Case "B"
                    Estilo.BackColor = Color.Red
            End Select
            pCell.Style = Estilo
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub
    Public Sub LimpaCampos(ByVal pControl As Control) 'Recursive function 
        Try
            For Each Ctl As Object In pControl.Controls
                If TypeOf Ctl Is WUC.UcText Then
                    Ctl.text = ""
                    Ctl.MensagemErro = ""
                    Ctl.Descricao = ""
                End If
                If TypeOf Ctl Is System.Windows.Forms.TextBox Then Ctl.Text = ""
                If TypeOf Ctl Is System.Windows.Forms.ComboBox Then Ctl.Selectedindex = -1
                If TypeOf Ctl Is System.Windows.Forms.CheckBox Then Ctl.checked = False
                If TypeOf Ctl Is System.Windows.Forms.RadioButton Then Ctl.checked = False
                If TypeOf Ctl Is System.Windows.Forms.ListBox Then Ctl.SelectedIndex = -1
                Call LimpaCampos(Ctl)
            Next
        Catch ex As Exception
            ShowErro(ex)
        End Try

    End Sub
    Public Function isData(ByVal pData As String) As Boolean
        Dim sData As String
        isData = True
        If pData Is Nothing Then
            Exit Function
        End If
        If pData.Trim = "" Then
            Exit Function
        End If
        Dim sDia As String = "", sMes As String = "", sAno As String = ""
        Try
            '=========================Tira as Barras
            sData = pData.Replace("/", "")
            sDia = sData.Substring(0, 2)
            sMes = sData.Substring(2, 2)
            sAno = sData.Substring(4, 4)
            If Val(sAno) < 1000 Then
                sAno = 2000 + Val(sAno).ToString
            End If
            sData = sDia & "/" & sMes & "/" & sAno
            sData = FormatDateTime(sData, DateFormat.ShortDate)

        Catch ex As Exception
            isData = False
        End Try
    End Function
    Public Function isEmptyCell(ByVal Cell As DataGridViewCell) As Boolean
        Try
            If Cell.FormattedValue IsNot Nothing _
            AndAlso String.IsNullOrEmpty(Cell.FormattedValue.ToString().Trim) Then
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
        End Try

    End Function
    Public Sub SalvaPreferencia(ByVal pForm As Form)
        'Dim dts As New DataSet("Config")
        'Dim dtb As New DataTable("Form")
        'Dim drw As DataRow
        'Dim strFile As String
        'Try '
        '    strFile = "C:\" & IO.Path.GetFileName(Application.ExecutablePath).ToString.ToUpper.Replace(".EXE", "")
        '    If Not System.IO.Directory.Exists(strFile) Then
        '        System.IO.Directory.CreateDirectory(strFile)
        '    End If
        '    strFile += pForm.Name & ".XML"

        '    dtb.Columns.Add("Top", GetType(Integer))
        '    dtb.Columns.Add("Left", GetType(Integer))
        '    dtb.Columns.Add("Width", GetType(Integer))
        '    dtb.Columns.Add("Height", GetType(Integer))
        '    dts.Tables.Add(dtb)

        '    drw = dts.Tables("Form").NewRow
        '    drw("top") = pForm.Top
        '    drw("left") = pForm.Left
        '    drw("Width") = pForm.Width
        '    drw("Height") = pForm.Height
        '    dtb.Rows.Add(drw)
        '    dts.WriteXml(strFile)
        'Catch ex As Exception
        '    ShowErro(ex)
        'End Try
    End Sub
    Public Function LastDay(ByVal pCompetencia As Integer) As Byte
        Dim strData As Date
        Try
            strData = "01/" & pCompetencia.ToString.Substring(4, 2) & "/" & pCompetencia.ToString.Substring(0, 4)
            strData = DateAdd(DateInterval.Month, 1, strData)
            strData = DateAdd(DateInterval.Day, -1, strData)
            LastDay = strData.Day
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Function
    Public Sub LerPreferencia(ByVal pForm As Form)

        Dim dts As New DataSet
        Dim drw As DataRow
        Dim strFile As String
        Try
            strFile = "C:\" & IO.Path.GetFileName(Application.ExecutablePath).ToString.ToUpper.Replace(".EXE", "")
            strFile += pForm.Name & ".XML"
            If System.IO.File.Exists(strFile) Then
                dts.ReadXml(strFile)
                If dts.Tables("Form").Rows.Count > 0 Then
                    drw = dts.Tables("form").Rows(0)
                    pForm.Top = drw.Item("Top")
                    pForm.Left = drw.Item("Left")
                    pForm.Width = drw.Item("Width")
                    pForm.Height = drw.Item("Height")
                End If
            End If

        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Sub
    Public Function IsCNPJorCPF(ByVal sCGC As String) As Boolean
        Dim sNumeroCgc As String
        Dim sDigitoCgc As String
        Dim nSomaDigito As Integer
        Dim nContDigito As Integer
        Dim nBase As Integer
        Dim nResto As Integer
        Try
            sCGC = Trim(sCGC)
            If Len(sCGC) < 8 Then
                IsCNPJorCPF = False
                Exit Function
            End If

            sDigitoCgc = Right(sCGC, 2)
            sNumeroCgc = Left(sCGC, Len(sCGC) - 2)
            Do Until Len(sNumeroCgc) = Len(sCGC)
                nBase = 2
                nSomaDigito = 0
                For nContDigito = Len(sNumeroCgc) To 1 Step -1
                    nSomaDigito = nSomaDigito + (Val(Mid(sNumeroCgc, nContDigito, 1))) * nBase
                    If Len(sCGC) = 14 Then
                        nBase = IIf(nBase = 9, 2, nBase + 1)
                    Else
                        nBase = nBase + 1
                    End If
                Next nContDigito
                nResto = 11 - (nSomaDigito Mod 11)

                nResto = IIf(nResto > 9, 0, nResto)
                sNumeroCgc = sNumeroCgc & Trim(Str(nResto))
            Loop
            If Right(sNumeroCgc, 2) = sDigitoCgc Then
                IsCNPJorCPF = True
            Else
                IsCNPJorCPF = False
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Function
    Public Function StrLeft(ByVal str As String, ByVal index As Integer) As String
        StrLeft = str.Substring(0, index)
    End Function
    Public Function StrRight(ByVal str As String, ByVal index As Integer) As String
        StrRight = str.Substring(str.Length - index)
    End Function
    Public Function FormataCPF(ByVal pCPF As String) As String
        FormataCPF = ""
        Try
            pCPF = pCPF.Replace(".", "")
            pCPF = pCPF.PadLeft(11, "0")
            pCPF = pCPF.Substring(0, 3) & "." & _
            pCPF.Substring(3, 3) & "." & _
            pCPF.Substring(6, 3) & "." & _
            pCPF.Substring(9, 2)
            FormataCPF = pCPF
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Function
    Public Function FormataCNPJ(ByVal pCNPJ As String) As String
        FormataCNPJ = ""
        Try
            pCNPJ = pCNPJ.Replace("-", "")
            pCNPJ = pCNPJ.Replace("/", "")
            pCNPJ = pCNPJ.Replace(".", "")
            pCNPJ = pCNPJ.PadLeft(14, "0")
            pCNPJ = pCNPJ.Substring(0, 2) & "." & _
            pCNPJ.Substring(2, 3) & "." & _
            pCNPJ.Substring(5, 3) & "/" & _
            pCNPJ.Substring(8, 4) & "-" & _
            pCNPJ.Substring(12, 2)
            Return pCNPJ
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Function
    Public Function FormataCep(ByVal pCep As String) As String
        FormataCep = ""
        Try
            pCep = pCep.Replace("-", "")
            pCep = pCep.PadLeft(8, "0")
            pCep = pCep.Substring(0, 5) & "-" & pCep.Substring(5, 3)
            Return pCep
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Function
    Public Function FormataNumero(ByVal strNumero As String, ByVal pDecimal As Byte) As String
        Dim dbNumber As Double = 0
        Try
            strNumero = Replace(strNumero, ",", "")
            strNumero = Replace(strNumero, ".", "")
            dbNumber = CDbl(strNumero)
            dbNumber = dbNumber / (10 ^ pDecimal)
            Return String.Format("{0:N" & pDecimal & "}", dbNumber)
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try
    End Function
    Public Function FormataCompetencia(ByVal pAnoMes As String) As String

        FormataCompetencia = ""
        Try
            Dim strMes As String = ""
            Dim strAno As String = ""
            Select Case pAnoMes.Length
                Case Is < 4
                Case 4
                    strMes = pAnoMes.Substring(0, 2)
                    strAno = "20" & pAnoMes.Substring(2, 2)
                Case 5
                    strMes = pAnoMes.Substring(0, 2)
                    strAno = "2" & pAnoMes.Substring(2, 3)
                Case 6
                    strMes = pAnoMes.Substring(0, 2)
                    strAno = pAnoMes.Substring(2, 4)
                Case Is > 4
            End Select
            Return strMes & "/" & strAno
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try
    End Function
    Public Function Vernulo(ByVal pInput As Object, ByVal pDefault As Object) As Object
        Vernulo = pDefault
        Try
            If IsDBNull(pInput) Then
                Return pDefault
            Else
                Return pInput
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Function
    Function ReplicateString(ByVal Source As String, ByVal Times As Integer) As String
        ReplicateString = ""
        Try
            For i As Integer = 1 To Times
                ReplicateString += Source
            Next
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Function
    Public Function DataToMesAno(ByVal pData As DateTime) As String
        pData = FormatDateTime(pData, DateFormat.GeneralDate)
        Dim strMes As String = ""
        Dim strAno As String = ""
        DataToMesAno = ""
        Try
            DataToMesAno = Month(pData).ToString.PadLeft(2, "0") & "/" & Year(pData).ToString.PadLeft(2, "0")
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Function
    Public Function DataToCompentencia(ByVal pData As DateTime) As Int32
        pData = FormatDateTime(pData, DateFormat.GeneralDate)
        DataToCompentencia = 0
        Try
            DataToCompentencia = Int32.Parse(Year(pData).ToString.PadLeft(2, "0") & Month(pData).ToString.PadLeft(2, "0"))
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Function
    Public Function FormataData(ByVal pData As String) As String

        If pData.IndexOf("/") = -1 Then
            pData = pData.Substring(0, 2) & "/" & pData.Substring(2, 2) & "/" & pData.Substring(4, 4)
        End If
        Dim sData As DateTime = pData

        FormataData = ""
        If pData.Trim = "" Then
            Exit Function
        End If
        Dim sDia As String = "", sMes As String = "", sAno As String = ""
        Try
            '=========================Tira as Barras
            sDia = DatePart(DateInterval.Day, sData).ToString.PadLeft(2, "0")
            sMes = DatePart(DateInterval.Month, sData).ToString.PadLeft(2, "0")
            sAno = DatePart(DateInterval.Year, sData).ToString.PadLeft(2, "0")
            If Val(sAno) < 1000 Then
                sAno = 2000 + Val(sAno).ToString
            End If
            Return sDia & "/" & sMes & "/" & sAno
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Function
    Public Sub ShowErro(ByVal Ex As Exception)
        frmErro.Excepction = Ex
        frmErro.txtErro.Text = Ex.Message
        frmErro.ShowDialog()
        frmErro.Dispose()
    End Sub
    Public Function fnEmpresadoUsuario(ByVal sUsuario As String) As String
        Dim sEmpresadoUsuario As String = ""
        Dim drDataRow As DataRow
        If sUsuario <> "ADMIN" Then
            sEmpresadoUsuario = ","
            For Each drDataRow In dtsEmpresaUsuario.Tables(0).Rows
                sEmpresadoUsuario = drDataRow("Cod_Empresa") & "," & sEmpresadoUsuario
            Next
        Else
            sEmpresadoUsuario = "999"
        End If
        Return sEmpresadoUsuario
    End Function
    Public Function Aviso(ByRef Mensagem As String, Optional ByRef Botao As Short = 0, Optional ByRef Icone As Short = 0, Optional ByRef Cabecalho As String = "") As Boolean
        If IsNothing(Botao) Then
            Botao = MsgBoxStyle.OkOnly
        End If

        If IsNothing(Icone) Then
            Icone = MsgBoxStyle.Information
        End If
        If IsNothing(Cabecalho) Then
            Cabecalho = "Atenção"
        End If
        Select Case MsgBox(Mensagem, Botao + Icone, Cabecalho)
            Case Is = 2, 3, 4, 5, 7
                Aviso = False
            Case Is = 1, 6
                Aviso = True
        End Select
    End Function
    Public Sub seleciona_no_foco(ByRef oObjeto As System.Windows.Forms.TextBox)
        On Error Resume Next
        If oObjeto.Text = "" Then Exit Sub
        oObjeto.SelectionStart = 0
        oObjeto.SelectionLength = Len(oObjeto.Text)

    End Sub
    Function FirstCaps(ByRef cText As String) As String

        Dim cChar_Renamed As String
        Dim lFirst As Boolean
        Dim cRetVal As String

        If Not IsDBNull(cText) Then
            lFirst = True
            cRetVal = ""

            For nCont = 1 To Len(cText)

                cChar_Renamed = Mid(cText, nCont, 1)

                If lFirst Then
                    cRetVal = cRetVal & UCase(cChar_Renamed)
                    lFirst = False
                Else

                    cRetVal = cRetVal & LCase(cChar_Renamed)
                End If

                If cChar_Renamed = " " Then
                    lFirst = True
                End If
            Next

            cRetVal = Replace(cRetVal, "Sr", "SR")
            cRetVal = Replace(cRetVal, "Pl", "PL")
            cRetVal = Replace(cRetVal, "Jr", "JR")
            cRetVal = Replace(cRetVal, "Ii", "II")
            cRetVal = Replace(cRetVal, "Iii", "III")
            cRetVal = Replace(cRetVal, "S/a", "S/A")
            cRetVal = Replace(cRetVal, " E ", " e ")
            cRetVal = Replace(cRetVal, " O ", " o ")
            cRetVal = Replace(cRetVal, " A ", " a ")
            cRetVal = Replace(cRetVal, "De ", "de ")
            cRetVal = Replace(cRetVal, "Da ", "da ")
            cRetVal = Replace(cRetVal, "Do ", "do ")
            cRetVal = Replace(cRetVal, "Das ", "das ")
            cRetVal = Replace(cRetVal, "Dos ", "dos ")
            FirstCaps = cRetVal
        Else
            FirstCaps = ""
        End If

    End Function
    Public Function fColuna(ByRef Par_Flex As AxMSFlexGridLib.AxMSFlexGrid, ByRef Par_Key As String, Optional ByRef Par_Linha As Short = 0) As Short
        On Error GoTo Erro
        Dim nCol As Short
        fColuna = -1 '----Para forcar a dar erro onde chamou quando não encolrar
        If IsNothing(Par_Linha) Then
            Par_Linha = 0
        End If
        With Par_Flex
            For nCol = 0 To .Cols - 1
                If Trim(UCase(.get_TextMatrix(Par_Linha, nCol))) = Trim(UCase(Par_Key)) Then
                    fColuna = nCol
                    Exit For
                End If
            Next nCol
        End With
        If fColuna = -1 Then
            Aviso(Par_Flex.Name & "." & Par_Key & " - Coluna Inválida")
        End If
Saida:
        Exit Function
Erro:
        Erro(Err.Number)
        Resume Saida
    End Function
    Public Sub Mensagem(ByVal strMens As String)
        mdiPrincipal.sttMensagem.Text = strMens
    End Sub
    Public Function isTime(ByVal pHora As String) As Boolean
        Dim btHora As Byte
        Dim btMinuto As Byte
        pHora = pHora.Trim
        isTime = True
        Try
            If pHora.Length < 4 Or pHora.Length > 5 Then
                isTime = False
            Else
                pHora = pHora.Replace(":", "")
                If pHora.Length > 4 Then
                    isTime = False
                    Exit Try
                End If
                btHora = pHora.Substring(0, 2)
                btMinuto = pHora.Substring(2, 2)
                If btHora < 0 Or btHora > 23 Or btMinuto < 0 Or btMinuto > 59 Then
                    isTime = False
                End If
            End If
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Function
    Public Function formataHora(ByVal pHora As String) As String
        Dim btHora As Byte
        Dim btMinuto As Byte
        formataHora = String.Empty


        Try
            pHora = pHora.Replace(":", "")
            pHora = pHora.PadLeft(4, "0")
            btHora = pHora.Substring(0, 2)
            btMinuto = pHora.Substring(2, 2)
            formataHora = btHora.ToString.PadLeft(2, "0") + ":" + btMinuto.ToString.PadLeft(2, "0")
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Function
    Public Sub CalculaAlturaLinha(ByRef Par_Flex As AxMSFlexGridLib.AxMSFlexGrid, ByVal Par_Linha As Integer, ByVal Par_Coluna As Integer)
        On Error GoTo Erro
        Dim nAlturaLinha As Integer
        Dim nTamanhoTexto As Integer
        Dim nQtdLinha As Integer
        Dim nTamanhoColuna As Integer
        Dim lblTamanhoColuna As New Windows.Forms.Label
        lblTamanhoColuna.AutoSize = True

        With Par_Flex
            lblTamanhoColuna.Text = .get_TextMatrix(Par_Linha, Par_Coluna).Trim
            nTamanhoTexto = lblTamanhoColuna.Width
            'nTamanhoTexto = (VB6.PixelsToTwipsX(lblTamanhoColuna.Width))

            nTamanhoTexto = GetStringWidth(lblTamanhoColuna.Text, Par_Flex.Font)
            nTamanhoTexto = nTamanhoTexto * 15
            nTamanhoColuna = .get_ColWidth(Par_Coluna)
            If nTamanhoTexto > nTamanhoColuna Then
                nQtdLinha = CInt((nTamanhoColuna / nTamanhoTexto) + 0.999999)
            Else
                nQtdLinha = 1
            End If
            nAlturaLinha = .RowHeightMin * nQtdLinha
            .set_RowHeight(Par_Linha, nAlturaLinha)
        End With
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
    Public Function VePermissao(ByVal nCodFuncao As Short) As Boolean
        On Error GoTo Erro
        If gsUsuario.ToUpper = "ADMIN" Then
            VePermissao = True
        Else
            VePermissao = mdiPrincipal.dtsUsuario.dtbUsuario_MSAFuncao.Select("cod_funcao = " & nCodFuncao).Length > 0
        End If

Saida:
        Exit Function
Erro:
        VePermissao = False
        Erro(Err.Number)
        Resume Saida
        Resume
    End Function
    Public Function fParametro(ByVal sCod_Parametro As Short, Optional ByVal sCod_Empresa_Faturamento As String = Nothing, Optional ByVal sCod_Empresa_Venda As String = Nothing, Optional ByVal sCod_Veiculo As String = Nothing) As String

        On Error GoTo Erro
        Dim sValorParametro As String = ""
        '===============================================Verifica se existe o parametro 
        sSql = "Cod_Parametro = " & sCod_Parametro
        If mdiPrincipal.dtsParametro.dtbParametro.Select(sSql).Length = 0 Then
            Aviso("Não Existe o Parâmetro " & sCod_Parametro & " Cadastrado.Favor comunicar o Adminstrador do Sistema")
            GoTo saida
        End If
        '===============================================Se não for individual, obtem o valor e sai
        For Each DRW As MSAClass.AsmxParametro.dtsParametro.dtbParametroRow In mdiPrincipal.dtsParametro.dtbParametro.Select(sSql)
            sValorParametro = DRW.Cod_Chave
            If DRW.IsIndica_Valor_IndividualNull Then GoTo saida
            If DRW.Indica_Valor_Individual = 0 Then GoTo saida
        Next
        '===============================================obtem o valor por empresa de faturamento
        If Not IsNothing(sCod_Empresa_Faturamento) Then
            sSql = "Cod_Parametro = " & sCod_Parametro
            sSql = sSql & " and  Cod_Empresa_Faturamento    = '" & sCod_Empresa_Faturamento & "'"
            For Each DRW As MSAClass.AsmxParametro.dtsParametro.dtbParametro_ValorRow In mdiPrincipal.dtsParametro.dtbParametro_Valor.Select(sSql)
                sValorParametro = DRW.Cod_Chave
                GoTo SAIDA
            Next
        End If
        '===============================================obtem o valor por empresa de faturamento
        If Not IsNothing(sCod_Empresa_Venda) Then
            sSql = "Cod_Parametro = " & sCod_Parametro
            sSql = sSql & " and  Cod_Empresa_Venda= '" & sCod_Empresa_Venda & "'"
            For Each DRW As MSAClass.AsmxParametro.dtsParametro.dtbParametro_ValorRow In mdiPrincipal.dtsParametro.dtbParametro_Valor.Select(sSql)
                sValorParametro = DRW.Cod_Chave
                GoTo SAIDA
            Next
        End If

        '===============================================obtem o valor por Veiculo
        If Not IsNothing(sCod_Veiculo) Then
            sSql = "Cod_Parametro = " & sCod_Parametro
            sSql = sSql & " and  Cod_Veiculo = '" & sCod_Veiculo & "'"
            For Each DRW As MSAClass.AsmxParametro.dtsParametro.dtbParametro_ValorRow In mdiPrincipal.dtsParametro.dtbParametro_Valor.Select(sSql)
                sValorParametro = DRW.Cod_Chave
                GoTo SAIDA
            Next
        End If
Saida:
        fParametro = sValorParametro.ToString.Trim
        Exit Function
Erro:
        fParametro = ""
        Erro(Err.Number)
        Resume Saida
        Resume

    End Function
    Public Function Between(ByRef pItem As Integer, ByRef pMinimo As Integer, ByRef pMaximo As Integer) As Boolean
        Between = (pItem >= pMinimo And pItem <= pMaximo)
    End Function
    Public Function FPorta(ByRef Asmx As MSAClass.AsmxPorta.asmxPorta, ByRef Dts As MSAClass.AsmxPorta.dtsPorta, ByVal Par_Funcao As Short, ByVal Par_Veiculo As String, ByVal Par_Data As DateTime, ByVal Par_Programa As String) As Integer

        ' Par_Funcao  1 =  Usuario Ordenando Roteiro
        '             2 =  Usuario compondo Breaks  
        '             3 =  Usuario Pre-Ordenando o roteiro  
        On Error GoTo Erro
        'Dim Asmx As New MSAClass.Porta.asmxPorta
        'Dim Dts As New MSAClass.Porta.dtsPorta

        '==================================Consulta usuario ativos em ordenacao/comp.breaks/pre-ordenacao
        FPorta = 0
        FPorta = Asmx.spuConsistir(Par_Veiculo, Par_Data, Par_Programa)

        If FPorta = 0 Then
            '==================================Insere o Usuario
            Dts.dtbPorta.AdddtbPortaRow(Par_Funcao, Par_Veiculo, Par_Data, Par_Programa, gsUsuario, "")
            'Asmx.spuAtualizar(Dts)
        End If

Saida:
        Exit Function
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Function
    Public Sub FDeletaPorta(ByRef Asmx As MSAClass.AsmxPorta.asmxPorta, ByVal Par_Funcao As Short)
        On Error GoTo Erro
        Asmx.spuLimpar(Par_Funcao, gsUsuario)
Saida:
        Exit Sub
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Sub
    Public Function Resolucao_Monitor_1024() As Boolean
        On Error GoTo Erro
        Dim xResolucao As Short
        Dim yResolucao As Short

        Resolucao_Monitor_1024 = False

        xResolucao = GetSystemMetrics(0)
        yResolucao = GetSystemMetrics(1)

        If xResolucao < 1024 And yResolucao < 768 Then
            Resolucao_Monitor_1024 = False
        Else
            Resolucao_Monitor_1024 = True
        End If

Saida:
        Exit Function

Erro:
        Erro(Err.Number)
        GoTo Saida
        Resume
    End Function
    Public Function ExisteRoteiroEncerrado(ByVal Par_Veiculo As String, ByVal Par_Data As DateTime) As Boolean
        On Error GoTo Erro
        Dim Asmx As MSAClass.asmxRoteiro.asmxRoteiro = NewRoteiro()
        ExisteRoteiroEncerrado = Asmx.spuCheckEncerramento(Par_Veiculo, Par_Data)
Saida:

        Exit Function
Erro:
        ExisteRoteiroEncerrado = False
        Erro(Err.Number)
        Resume Saida
        Resume
    End Function
    Public Function StrZero(ByVal Par_Valor As Integer, ByVal Par_Qtde As Short) As String
        StrZero = Par_Valor.ToString.PadLeft(Par_Qtde, "0")
    End Function
    Public Function AddTime(ByVal Par_Intervalo As String, ByVal Par_Soma As Short, ByVal Par_Horario As String) As String

        On Error GoTo Erro

        Dim nSegundo, nHora, nMinuto, nTotal As Integer
        Dim nResto As Short
        Par_Horario = Replace(Par_Horario, ":", "")


        nHora = Val(Mid(Par_Horario, 1, 2))

        nMinuto = Val(Mid(Par_Horario, 3, 2))

        nSegundo = Val(Mid(Par_Horario, 5, 2))

        nTotal = (nHora * 3600) + (nMinuto * 60) + nSegundo

        Select Case UCase(Par_Intervalo)
            Case "H" '----soma de Horas
                nTotal = nTotal + (Par_Soma * 3600)
            Case "M" '----soma de Minutos
                nTotal = nTotal + (Par_Soma * 60)
            Case "S" '----soma de segundos
                nTotal = nTotal + Par_Soma
        End Select

        nHora = Int(nTotal / 3600)
        nResto = nTotal Mod 3600
        nMinuto = Int(nResto / 60)
        nSegundo = nResto Mod 60


        If nHora > 0 Then
            AddTime = VB6.Format(nHora, "00") & ":" & VB6.Format(nMinuto, "00") & ":" & VB6.Format(nSegundo, "00")
        Else
            AddTime = VB6.Format(nMinuto, "00") & ":" & VB6.Format(nSegundo, "00")
        End If


Saida:
        Exit Function
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Function
    Public Function ExisteRoteiro(ByVal sVeiculo As String, ByVal sData As Date, Optional ByRef sPrograma As String = "", Optional ByVal nBreak As Short = -1, Optional ByRef nSequenciaFaixa As Short = -1) As Boolean

        On Error GoTo Erro
        Dim sSql As String
        Dim Amsx As MSAClass.asmxRoteiro.asmxRoteiro = NewRoteiro()
        Dim dts As MSAClass.asmxRoteiro.dtsRoteiro
        sSql = "Cod_Veiculo = '" & sVeiculo & "'"
        If nBreak > -1 Then sSql = sSql & " And breaks  = " & nBreak
        If nSequenciaFaixa > -1 Then sSql = sSql & " And sequencia_faixa = " & nSequenciaFaixa
        dts = Amsx.spuCarregar_Roteiro(sVeiculo, sData, sPrograma, 0, 0)
        ExisteRoteiro = dts.dtbRoteiro_Ordenado.Select(sSql).Length > 0

Saida:
        Exit Function
Erro:
        Erro(Err.Number)
        Resume Saida
        Resume
    End Function
    Public Function fnCompetenciaNumeroToExtenso(ByVal lngCompetencia As Long) As String
        Dim aMes As New ArrayList
        Dim btMes As Byte
        Try
            btMes = Integer.Parse(lngCompetencia.ToString.Trim.Substring(4, 2))

            aMes.Add("Janeiro")
            aMes.Add("Fevereiro")
            aMes.Add("Março")
            aMes.Add("Abril")
            aMes.Add("Maio")
            aMes.Add("Junho")
            aMes.Add("Julho")
            aMes.Add("Agosto")
            aMes.Add("Setembro")
            aMes.Add("Outubro")
            aMes.Add("Novembro")
            aMes.Add("Dezembro")
            Return aMes(btMes - 1) & "/" & lngCompetencia.ToString.Trim.Substring(0, 4)
        Catch ex As Exception
            ShowErro(ex)
            Return ""
        End Try
    End Function
    Public Function fnCompetenciaExtensoToNumero(ByVal strCompetencia As String) As Int32
        Dim btMes As Byte = 0
        Dim strMes As String
        Dim intAno As Int32 = 0
        Try
            intAno = Int32.Parse(strCompetencia.Substring(strCompetencia.IndexOf("/") + 1, 4))
            strMes = strCompetencia.Substring(0, strCompetencia.IndexOf("/")).ToUpper
            Select Case strMes
                Case "JANEIRO"
                    btMes = 1
                Case "FEVEREIRO"
                    btMes = 2
                Case "MARÇO"
                    btMes = 3
                Case "ABRIL"
                    btMes = 4
                Case "MAIO"
                    btMes = 5
                Case "JUNHO"
                    btMes = 6
                Case "JULHO"
                    btMes = 7
                Case "AGOSTO"
                    btMes = 8
                Case "SETEMBRO"
                    btMes = 9
                Case "OUTUBRO"
                    btMes = 10
                Case "NOVEMBRO"
                    btMes = 11
                Case "DEZEMBRO"
                    btMes = 12
            End Select
            Return Int32.Parse(intAno.ToString.PadLeft(4, "0") & btMes.ToString.PadLeft(2, "0"))
        Catch ex As Exception
            ShowErro(ex)
            Return 0
        End Try
    End Function
    Public Function fnCompetenciaStringtoInt(ByVal strCompetencia As String) As Int32
        Try
            If strCompetencia.Trim <> "" Then
                Return Int32.Parse(strCompetencia.Substring(3, 4) & strCompetencia.Substring(0, 2))
            Else
                Return 0
            End If
        Catch ex As Exception
            ShowErro(ex)
            Return 0
        End Try
    End Function
    Public Function fnCompetenciaInttoString(ByVal IntCompetencia As Int32) As String
        Try
            If IntCompetencia > 0 Then
                Return IntCompetencia.ToString.Substring(4, 2) & "/" & IntCompetencia.ToString.Substring(0, 4)
            Else
                Return ""
            End If
        Catch ex As Exception
            ShowErro(ex)
            Return ""
        End Try
    End Function
    Public Function fnDataToCompetenciaInt(ByVal dt As Date) As Int32
        Try
            Return Int32.Parse(DatePart(DateInterval.Year, dt).ToString & DatePart(DateInterval.Month, dt).ToString.PadLeft(2, "0"))
        Catch ex As Exception
            ShowErro(ex)
        End Try
    End Function
    Public Function PrimeiroDiadoMes(ByVal pCompetencia As Int32, ByVal pData As Date) As Date
        Dim strDia As String = ""
        Dim strMes As String = ""
        Dim strAno As String = ""
        Dim dtData As Date = Nothing
        Dim intCompetencia As Integer
        Try
            If Not pCompetencia = Nothing Then
                intCompetencia = pCompetencia
            ElseIf Not pData = Nothing Then
                intCompetencia = DataToCompentencia(pData)
            End If
            strDia = "01"
            strMes = intCompetencia.ToString.Substring(4, 2)
            strAno = intCompetencia.ToString.Substring(0, 4)
            dtData = Date.Parse(strDia & "/" & strMes & "/" & strAno)
        Catch ex As Exception
            ShowErro(ex)
        End Try
        Return dtData
    End Function
    Public Function UltimoDiadoMes(ByVal pCompetencia As Int32, ByVal pData As Date) As Date
        Dim strDia As String = ""
        Dim strMes As String = ""
        Dim strAno As String = ""
        Dim dtData As Date = Nothing
        Dim intCompetencia As Integer
        Try
            If Not pCompetencia = Nothing Then
                intCompetencia = pCompetencia
            ElseIf Not pData = Nothing Then
                intCompetencia = DataToCompentencia(pData)
            End If
            strDia = LastDay(intCompetencia)
            strMes = intCompetencia.ToString.Substring(4, 2)
            strAno = intCompetencia.ToString.Substring(0, 4)
            dtData = Date.Parse(strDia & "/" & strMes & "/" & strAno)
        Catch ex As Exception
            ShowErro(ex)
        End Try
        Return dtData
    End Function
    Public Function IsFormLoad(ByVal pFormName As String) As Boolean
        For Each x As Form In mdiPrincipal.MdiChildren
            If x.Name.ToUpper.Trim = pFormName.ToUpper.Trim Then
                Return True
            End If
        Next
    End Function
    Public Sub Erro(ByVal cErro As Long)
        MsgBox("Erro: " & cErro & " - " & Err.Description, MsgBoxStyle.Critical, "erro")
    End Sub
    Public Sub SetaUserControl(ByVal PControl As Control)
        For Each Obj As Object In PControl.Controls
            If TypeOf Obj Is WUC.UcText Then
                Obj.Usuario = gsUsuario
                Obj.Senha = gsSenha
            Else
                If Obj.HasChildren Then
                    SetaUserControl(Obj)
                End If
            End If
        Next
    End Sub


    Public Function GetStringWidth(ByVal sStr As String, ByVal fFont As Font) As Single
        Dim fForm As New Form
        Dim g As Graphics = fForm.CreateGraphics
        Dim TextWidth As Single
        TextWidth = g.MeasureString(sStr, fFont).Width()

        g.Dispose()
        g = Nothing
        fForm.Dispose()
        fForm = Nothing
        Return TextWidth

    End Function

    Public Function GetStringSizeF(ByVal sStr As String, ByVal fFont As Font) As SizeF
        Dim fForm As New Form
        Dim g As Graphics = fForm.CreateGraphics
        Dim TextSizeF As SizeF
        TextSizeF = g.MeasureString(sStr, fFont)
        g.Dispose() : g = Nothing
        fForm.Dispose()
        fForm = Nothing
        Return TextSizeF
    End Function

    Public Function GetMACAddress() As String
        Dim mc As ManagementClass
        Dim mo As ManagementBaseObject
        mc = New Management.ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As ManagementObjectCollection = mc.GetInstances

        MACAddress = String.Empty

        For Each mo In moc
            If mo.Item("IPenabled") = True Then
                MACAddress = mo.Item("MacAddress")
            End If
        Next

        Return MACAddress.Replace(":", "").Replace("-", "").Replace(" ", "")

    End Function

    Public Function GetCPUId() As String
        Dim mc As ManagementClass
        Dim mo As ManagementBaseObject
        mc = New ManagementClass("Win32_Processor")
        Dim moc As ManagementObjectCollection = mc.GetInstances

        CPUIdentificador = String.Empty

        For Each mo In moc
            If (CPUIdentificador = String.Empty) Then
                CPUIdentificador = mo.Item("ProcessorId")
            End If
        Next

        Return CPUIdentificador

    End Function

    Public Function GetNomeComputador() As String

        NomeComputador = String.Empty

        NomeComputador = Environment.MachineName

        Return NomeComputador

    End Function
#End Region
End Module
