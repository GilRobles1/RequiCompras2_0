Imports System.Net

Public Class ConnSAP

    Public oCompany As SAPbobsCOM.Company
    Public DBUser As String = "sa"
    Public DBPass As String = "ConvertSolutions09"
    Public CompanyNa As String = "DIECUTFINAL"
    Public SUser As String = "MacroExcel2"
    Public SPass As String = "Macro02"
    Dim oOrderVen As SAPbobsCOM.Documents
    Dim oOrderComp As SAPbobsCOM.Documents
    Public ValidaRequiFalla As Boolean = False

    Public Sub IniConnSAP()
        oCompany = New SAPbobsCOM.Company
        oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English
        oCompany.UseTrusted = False
        oCompany.LicenseServer = "SERVIDORSAP:30000"
        oCompany.Server = "SERVIDORSAP"
        oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2014
        oCompany.DbUserName = DBUser
        oCompany.DbPassword = DBPass
        oCompany.CompanyDB = CompanyNa
        oCompany.UserName = SUser
        oCompany.Password = SPass
        Dim LRetCode As Integer
        Dim LErrCode As String
        Dim sErrMsg As String
        Try
            LRetCode = oCompany.Connect
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        If LRetCode <> 0 Then
            oCompany.GetLastError(LErrCode, sErrMsg)
            Console.WriteLine(sErrMsg)
        Else
            Console.WriteLine("Connected to " & oCompany.CompanyName)
        End If
    End Sub

    Public Sub CreaRequi(NE As String, NS As String, Mail As String,
                         Depto As String, Just As String, JDirecto As String,
                         DArea As String, FDeseada As Date, Psugerido As String,
                         Tel As String, Pcontacto As String, Mcontacto As String,
                         MCompras As String, ByRef DG As DataGridView,
                         PMens As String, RMens As String, TMens As String,
                         PAnual As String, RAnual As String, TAnual As String)

        Dim oPurchReq As SAPbobsCOM.Documents
        oPurchReq = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oPurchaseRequest)
        oPurchReq.ReqType = 12
        oPurchReq.Requester = "Company" 'NE
        oPurchReq.RequesterName = NS + System.Environment.UserName
        oPurchReq.RequesterEmail = Mail
        'If Not BuscarDepto(Depto) = 0 Then
        '    oPurchReq.RequesterDepartment = BuscarDepto(Depto)
        'End If
        oPurchReq.Comments = Just
        oPurchReq.UserFields.Fields.Item("U_BXP_CE_AA_EXP").Value = JDirecto 'Jefe Directo
        oPurchReq.UserFields.Fields.Item("U_BXP_CE_AA_IMP").Value = DArea 'Director
        oPurchReq.DocDate = Now
        oPurchReq.DocDueDate = FDeseada
        oPurchReq.TaxDate = Now
        oPurchReq.RequriedDate = FDeseada
        oPurchReq.UserFields.Fields.Item("U_LETRA").Value = Psugerido & "    " & Tel & "  " & Pcontacto 'CONTACTO TELEFONO
        oPurchReq.UserFields.Fields.Item("U_BXP_INCOTERM").Value = MCompras 'Mail del Contacto

        oPurchReq.UserFields.Fields.Item("U_CS_PMensual").Value = PMens
        oPurchReq.UserFields.Fields.Item("U_CS_PMReal").Value = RMens
        oPurchReq.UserFields.Fields.Item("U_CS_PMTotal").Value = TMens
        oPurchReq.UserFields.Fields.Item("U_CS_PAnual").Value = PAnual
        oPurchReq.UserFields.Fields.Item("U_CS_PAReal").Value = RAnual
        oPurchReq.UserFields.Fields.Item("U_CS_PATotal").Value = TAnual
        'oPurchReq.UserFields.Fields.Item("U_BXP_INCOTERM").Value = Mcontacto 'Mail del Contacto
        Dim Row As DataGridViewRow
        For Each Row In DG.Rows
            If String.IsNullOrEmpty(Row.Cells(0).Value) Then
                Exit For
            End If
            oPurchReq.Lines.ItemCode = Row.Cells(0).Value.ToString() 'Clave del articulo para comprar
            oPurchReq.Lines.ItemDescription = Row.Cells(1).Value.ToString()
            oPurchReq.Lines.Quantity = Row.Cells(2).Value
            oPurchReq.Lines.Price = Row.Cells(3).Value
            oPurchReq.Lines.TaxCode = Row.Cells(4).Value.ToString()
            oPurchReq.Lines.Currency = Row.Cells(5).Value.ToString()
            oPurchReq.Lines.CostingCode = BuscaCC(Depto)
            Try
                oPurchReq.Lines.Add()
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
            Console.WriteLine(Row.Cells(0).Value)
        Next

        Dim RetVal As Long
        Dim ErrCode As Long
        Dim ErrMsg As String
        Dim ExitoMsg As String = "Se ha dado de alta la solicitud de compras con el numero: "
        Dim ExitoMsg2 As String = " Guarde este numero para futuras referencias"
        Dim sNewKey As String

        Try
            RetVal = oPurchReq.Add
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try

        If RetVal <> 0 Then
            oCompany.GetLastError(ErrCode, ErrMsg)
            MsgBox(ErrMsg)
        Else
            sNewKey = CStr(oCompany.GetNewObjectKey)
            If Len(sNewKey) > 0 Then
                MsgBox(ExitoMsg & sNewKey & ExitoMsg2)
            Else
                Console.WriteLine("La longitud del la requi esta mal")
            End If
        End If

        Console.WriteLine("aqui vamos")
    End Sub

    Sub ValidaRequi(NE As String, NS As String, Mail As String,
                         Depto As String, Just As String, JDirecto As String,
                         DArea As String, FDeseada As Date, Psugerido As String,
                         Tel As String, Pcontacto As String, Mcontacto As String,
                         MCompras As String, ByRef DG As DataGridView)

        Dim NumEmpleado As String = "El numero del empleado esta vacio"
        Dim NombSol As String = "El nombre del solicitante esta vacio"
        Dim NomMail As String = "El mail del solicitante esta vacio"
        Dim Ndepto As String = "El departamento esta vacio"
        Dim NJusti As String = "La justificacion esta vacia"
        Dim NJDirecto As String = "El mail del Jefe directo esta vacia "
        Dim NDArea As String = "El mail del Director del area esta vacio si es el mismo el jefe inmediato entonces repita el MAIL "
        Dim NFe As String = "La fecha deseada es menor a la fecha actual"
        Dim Npsug As String = "El proveedor sugeriro esta vacio"
        Dim NTel As String = "El telofono esta vacio"
        Dim NPCont As String = "La persona de contacto esta vacio"
        Dim NMco As String = "El mailo de contacto esta vacio"

        ValidaRequiFalla = False
        If String.IsNullOrEmpty(NE) Then
            MsgBox(NumEmpleado)
            ValidaRequiFalla = True
            Exit Sub
        End If

        If String.IsNullOrEmpty(NS) Then
            MsgBox(NombSol)
            ValidaRequiFalla = True
            Exit Sub
        End If

        If String.IsNullOrEmpty(Mail) Then
            MsgBox(NomMail)
            ValidaRequiFalla = True
            Exit Sub
        End If

        If String.IsNullOrEmpty(Depto) Then
            MsgBox(Ndepto)
            ValidaRequiFalla = True
            Exit Sub
        End If

        If String.IsNullOrEmpty(Just) Then
            MsgBox(NJusti)
            ValidaRequiFalla = True
            Exit Sub
        End If

        If String.IsNullOrEmpty(JDirecto) Then
            MsgBox(NJDirecto)
            ValidaRequiFalla = True
            Exit Sub
        End If
        If String.IsNullOrEmpty(DArea) Then
            MsgBox(NDArea)
            ValidaRequiFalla = True
            Exit Sub
        End If
        If FDeseada < Now Then
            MsgBox(NFe)
            ValidaRequiFalla = True
            Exit Sub
        End If
        If String.IsNullOrEmpty(Psugerido) Then
            MsgBox(Npsug)
            ValidaRequiFalla = True
            Exit Sub
        End If
        If String.IsNullOrEmpty(Tel) Then
            MsgBox(NTel)
            ValidaRequiFalla = True
            Exit Sub
        End If
        If String.IsNullOrEmpty(Pcontacto) Then
            MsgBox(NPCont)
            ValidaRequiFalla = True
            Exit Sub
        End If
        If String.IsNullOrEmpty(Mcontacto) Then
            MsgBox(NMco)
            ValidaRequiFalla = True
            Exit Sub
        End If

        Dim Msg1 As String = "no hay Articulos  que capturar "
        Dim Msg2 As String = "El campo Descripcion esta vacio favor de corregirlo "
        Dim Msg3 As String = "El campo Cantidad esta vacio favor de corregirlo "
        Dim Msg4 As String = "El campo Cantidad no es numero favor de corregirlo "
        Dim Msg5 As String = "El campo Precio esta vacio favor de corregirlo "
        Dim Msg6 As String = "El campo Precio no es numero favor de corregirlo "
        Dim Msg7 As String = "El impuesto esta vacio favor de corregirlo "
        Dim Msg8 As String = "El tipo de impuesto no existe favor de corregirlo "
        Dim Msg9 As String = "La moneda esta vacia favor de corregirla "
        Dim Msg10 As String = "La moneda no existe favor de corregirla "


        Dim band As Boolean = True
        Dim row As DataGridViewRow
        For Each row In DG.Rows
            If String.IsNullOrEmpty(row.Cells(0).Value) Then
                If band Then
                    MsgBox(Msg1)
                    ValidaRequiFalla = True
                End If
                Exit For
            End If
            band = False


            If String.IsNullOrEmpty(row.Cells(1).Value) Then 'Descripcion
                MsgBox(Msg2)
                ValidaRequiFalla = True
                Exit For
            End If

            If String.IsNullOrEmpty(row.Cells(2).Value) Then 'Cantidad
                MsgBox(Msg3)
                ValidaRequiFalla = True
                Exit For
            ElseIf Not IsNumeric(row.Cells(2).Value) Then
                MsgBox(Msg4)
                ValidaRequiFalla = True
                Exit For
            End If

            If String.IsNullOrEmpty(row.Cells(3).Value) Then 'Precio
                MsgBox(Msg5)
                ValidaRequiFalla = True
                Exit For
            ElseIf Not IsNumeric(row.Cells(3).Value) Then
                MsgBox(Msg6)
                ValidaRequiFalla = True
                Exit For
            End If

            If String.IsNullOrEmpty(row.Cells(4).Value) Then 'Impuesto
                MsgBox(Msg7)
                ValidaRequiFalla = True
                Exit For
            ElseIf Not (row.Cells(4).Value = "V3" Or row.Cells(4).Value = "V0") Then
                MsgBox(Msg8)
                ValidaRequiFalla = True
                Exit For
            End If

            If String.IsNullOrEmpty(row.Cells(5).Value) Then 'Moneda
                MsgBox(Msg9)
                ValidaRequiFalla = True
                Exit For
            ElseIf Not (row.Cells(5).Value = "MXP" Or row.Cells(5).Value = "USD") Then
                MsgBox(Msg10)
                ValidaRequiFalla = True
                Exit For
            End If

            'For Each R In row.Cells
            '    If IsNothing(R.value) Then
            '        Dim cad As String = R.OwningColumn.HeaderText.ToString()
            '        MsgBox("la columna " & cad & " esta vacia en uno de los reglones favor de verificar")
            '    End If
            'Next
        Next



    End Sub


    '----------++++-------------------------------- Funciones ----------------------++++--------------------------
    Function BuscarDepto(Parametro As String) As Integer

        Dim CoSQL As ConnSQL = New ConnSQL
        CoSQL.SQLQry = "SELECT TOP 1 T0.Code FROM OUDP T0 where T0.Remarks= " & "'" & Parametro & "'"
        CoSQL.Conectar()

        If Not CoSQL.dr.HasRows Then
            MsgBox("El departamento no existe")
            Parametro = 0
            Exit Function
        End If
        CoSQL.dr.Read()
        Dim cadena As String = CoSQL.dr(0).ToString
        BuscarDepto = Int(cadena)
        'Dim cadena3 As Object = CoSQL.dr.GetValue(0)
        'Dim cadena5 As String = CoSQL.dr("Code").ToString
        'Dim cadena6 As Object = CoSQL.dr.Item(0).ToString

    End Function

    Function BuscaCC(depto As String) As String
        Dim varia As String = ""
        If depto = "ADMON, FINANZAS Y TI" Then
            BuscaCC = "CC5"
            Exit Function
        End If
        If depto = "CADENA DE SUMINISTRO" Then
            BuscaCC = "CC2"
            Exit Function
        End If
        If depto = "CALIDAD" Then
            BuscaCC = "CC9"
            Exit Function
        End If
        If depto = "DIRECCION GENERAL" Then
            BuscaCC = "CC6"
            Exit Function
        End If
        If depto = "ESTRUCTURA HUMANA" Then
            BuscaCC = "CC3"
            Exit Function
        End If
        If depto = "LOGISTICA" Then
            BuscaCC = "CC7"
            Exit Function
        End If
        If depto = "MANUFACTURA" Then
            BuscaCC = "CC1"
            Exit Function
        End If
        If depto = "SEGURIDAD" Then
            BuscaCC = "CC8"
            Exit Function
        End If
        If depto = "VENTAS" Then
            BuscaCC = "CC4"
            Exit Function
        End If
    End Function

End Class
