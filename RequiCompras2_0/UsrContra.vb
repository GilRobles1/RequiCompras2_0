Public Class UsrContra
    Public Msgrelleno As String = "Los campos de coneccion estan vacios "
    Public StrBD As String
    Public StrUsuario As String
    Public StrContra As String
    Public OpcUsrContrCancelar As Boolean = True

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If String.IsNullOrEmpty(CBDatabase.Text) Or String.IsNullOrEmpty(TBContra.Text) Or String.IsNullOrEmpty(TBUsuario.Text) Then
            MsgBox(MsgRelleno)
            Exit Sub
        End If
        StrBD = CBDatabase.Text
        StrUsuario = TBUsuario.Text
        StrContra = TBContra.Text
        OpcUsrContrCancelar = False
        Close()
        'Dispose()
    End Sub

    Private Sub BtnUsrContrCancelar_Click(sender As Object, e As EventArgs) Handles BtnUsrContrCancelar.Click
        OpcUsrContrCancelar = True
        Close()
        Dispose()
    End Sub

    Private Sub CBDatabase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBDatabase.SelectedIndexChanged
        Dim Usuario As String
        Usuario = LCase(Environment.UserName.ToString())
        If Usuario = "grobles" Then
            TBUsuario.Text = "manager"
            TBContra.Text = "tiempo8"
        End If
    End Sub
End Class