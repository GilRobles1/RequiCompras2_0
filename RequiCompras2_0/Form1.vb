Public Class Requi

    Private Sub Requi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReqDSET.OPCHFact' Puede moverla o quitarla según sea necesario.
        'Me.OPCHTAFact.Fill(Me.ReqDSET.OPCHFact)
        'TODO: esta línea de código carga datos en la tabla 'ReqDSET.OPDNEmerc' Puede moverla o quitarla según sea necesario.
        'Me.OPDNTAmerc.Fill(Me.ReqDSET.OPDNEmerc)
        Dim BuscArt As ConnSQL = New ConnSQL
        BuscArt.SQLQry = "SELECT T0.[ItemCode] FROM OITM T0 WHERE T0.[ItemCode] NOT LIKE 'MP%' AND  T0.[ItemCode] NOT LIKE 'CS%' AND  T0.[ItemCode] NOT LIKE 'HA%'  AND  T0.[ItemCode] NOT LIKE 'YUN%' AND  T0.[ItemCode] NOT LIKE 'HER%' AND  T0.[ItemCode] NOT LIKE 'ME%' AND  T0.[ItemCode] NOT LIKE 'RT%' AND  T0.[ItemCode] NOT LIKE 'CR%' AND  T0.[ItemCode] NOT LIKE 'SR%' "
        BuscArt.Conectar()
        BuscArt.RellenaCombo(DGVDatos.Columns.Item(0))

        'Dim BuscProv As ConnSQL = New ConnSQL
        'BuscProv.SQLQry = "SELECT T0.[CardCode] FROM OCRD T0 WHERE T0.[CardType] = 'S'"
        'BuscProv.Conectar()
        'BuscProv.RellenaCombo(DGVDatos.Columns.Item(6))
        Console.WriteLine("Eso es todo")
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim Oc As ConnSAP = New ConnSAP
        Oc.ValidaRequi(TxtNumEmp.Text, TxtNombSol.Text, TxtMail.Text, CbxDepartamento.Text, TxtJusti.Text,
                       TxtJefeDir.Text, TxtDirector.Text, DtpFDeseada.Value, TxtProvSugerido.Text,
                       TxtTelefono.Text, TxtContacto.Text, TxtMailContacto.Text, TxtMailCompras.Text, DGVDatos)
        If Oc.ValidaRequiFalla Then
            Exit Sub
        End If

        Dim real As Double
        Double.TryParse(RealLabel1.Text, real)
        Dim total As Double
        Double.TryParse(TotalLabel1.Text, total)
        If ((DGVDatos.Rows.Item(0).Cells(2).Value * DGVDatos.Rows.Item(0).Cells(3).Value) + real) > total Then
            MsgBox("Ha llegado al limite del presupuesto")
            Exit Sub
        End If


        If UsrContra.OpcUsrContrCancelar Then
            UsrContra.ShowDialog()
        End If

        If UsrContra.OpcUsrContrCancelar Then
            Exit Sub
        End If



        Oc.SUser = UsrContra.StrUsuario
        Oc.SPass = UsrContra.StrContra
        Oc.CompanyNa = UsrContra.StrBD
        Oc.IniConnSAP()

        Oc.CreaRequi(TxtNumEmp.Text, TxtNombSol.Text, TxtMail.Text, CbxDepartamento.Text, TxtJusti.Text,
                     TxtJefeDir.Text, TxtDirector.Text, DtpFDeseada.Value, TxtProvSugerido.Text,
                     TxtTelefono.Text, TxtContacto.Text, TxtMailContacto.Text, TxtMailCompras.Text, DGVDatos,
                     PresupuestoLabel3.Text, RealLabel3.Text, TotalLabel3.Text,
                     PresupuestoLabel1.Text, RealLabel1.Text, TotalLabel1.Text)

        Oc = Nothing
        MsgBox("Listo")
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtNumEmp.Text = ""
        TxtNombSol.Text = ""
        TxtMail.Text = ""
        CbxDepartamento.Text = ""
        TxtJusti.Text = ""
        TxtJefeDir.Text = ""
        TxtDirector.Text = ""
        TxtProvSugerido.Text = ""
        TxtTelefono.Text = ""
        TxtContacto.Text = ""
        TxtMailContacto.Text = ""
        TxtMailCompras.Text = ""

        DGVDatos.Rows.Clear()


    End Sub



    Private Sub EjecutaQryToolStripButton_Click_1(sender As Object, e As EventArgs) Handles EjecutaQryToolStripButton.Click
        Try
            Me.OPRQ_TA.EjecutaQry(Me.ReqDSET.OPRQ, CType(CodeToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        '------------------------------Busca detalle-------------------------------------------------
        Try
            Me.PRQ1TA1.ExecQry(Me.ReqDSET.PRQ1, CType(CodeToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        '------------------------------Busca el pedido-------------------------------------------------
        Try
            Me.OPOR_TAPeD.Fill(Me.ReqDSET.OPORPeD, CType(CodeToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        '-------------------------------Entrada de merca-------------------------------------------------------
        Try
            Me.OPDNTAmerc.Fill(Me.ReqDSET.OPDNEmerc, CType(CodeToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        '-------------------------------Factura-------------------------------------------------------
        Try
            Me.OPCHTAFact.Fill(Me.ReqDSET.OPCHFact, CType(CodeToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        '-------------------------------Compras comentarios-------------------------------------------------------
        Try
            Me.CommCompTA.Fill(Me.ReqDSET.CommComp, CType(CodeToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        '-------------------------------Comentarios Jefe-------------------------------------------------------
        Try
            Me.CommJefeTA.Fill(Me.ReqDSET.CommJefe, CType(CodeToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        '-------------------------------Comentario Dir-------------------------------------------------------
        Try
            Me.CommDirTA.Fill(Me.ReqDSET.CommDir, CType(CodeToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        '-------------------------------Comentario Luis-------------------------------------------------------
        Try
            Me.CommLuisTA.Fill(Me.ReqDSET.CommLuis, CType(CodeToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        '-----------------------------Cambiar de colores-------------------------------------------
        CambiaColor(U_CS_AutComprasLabel1)
        CambiaColor(U_CS_AutJefeLabel1)
        CambiaColor(U_CS_AutDirectorLabel1)
        CambiaColor(U_CS_AutLuisLabel1)
    End Sub

    Private Sub CambiaColor(ByRef Obj As Label)
        If Obj.Text.ToUpper() = "SI" Then
            Obj.ForeColor = Color.Green
        ElseIf Obj.Text.ToUpper() = "NO" Then
            Obj.ForeColor = Color.Red
        End If
    End Sub

    Private Sub CbxDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxDepartamento.SelectedIndexChanged
        'Presupuesto Anual---------------------------------------------------------
        Try
            Me.DTPRESTOT.Fill(Me.ReqDSET.PRESTOT, CbxDepartamento.Text)
            Dim numero As Double
            Double.TryParse(PresupuestoLabel1.Text, numero)
            PresupuestoLabel1.Text = numero.ToString("###,###,###.##")
            numero = 0
            Double.TryParse(RealLabel1.Text, numero)
            RealLabel1.Text = numero.ToString("###,###,###.##")
            numero = 0
            Double.TryParse(TotalLabel1.Text, numero)
            TotalLabel1.Text = numero.ToString("###,###,###.##")

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        'Presupuesto Mensual-------------------------------------------------------
        Try
            Me.PreMensualTA.Fill(Me.ReqDSET.PreMensual, CbxDepartamento.Text)
            Dim numero As Double
            Double.TryParse(PresupuestoLabel3.Text, numero)
            PresupuestoLabel3.Text = numero.ToString("###,###,###.##")
            numero = 0
            Double.TryParse(RealLabel3.Text, numero)
            RealLabel3.Text = numero.ToString("###,###,###.##")
            numero = 0
            Double.TryParse(TotalLabel3.Text, numero)
            TotalLabel3.Text = numero.ToString("###,###,###.##")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
