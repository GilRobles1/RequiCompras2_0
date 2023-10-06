Public Class ConnSQL
    'Deficion de los parametros para la conexion con la base de datos
    Public conn As New OleDb.OleDbConnection("Provider=sqloledb;Data Source=SERVIDORSAP;Initial Catalog=DIECUTFINAL;Persist Security Info=True;User ID=Macro;Password=Convert123")
    'Variable para executar las instrucciones a a la Base de Datos
    Public cmd As New OleDb.OleDbCommand
    'Matrix para almacenar el resultado de la variable que ejecuta las instrucciones de la Base de Datos.
    Public dr As OleDb.OleDbDataReader
    'se tiene que definir primero antes de hacer la consulta 
    Public SQLQry As String
    Public Sub Conectar()
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = SQLQry
        Try
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                Console.WriteLine("El comando se ejecuto con exito")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Public Sub RellenaCombo(ByRef Cmb As DataGridViewComboBoxColumn)
        If dr Is Nothing Then
            Throw New ArgumentNullException(NameOf(dr))
            Exit Sub
        End If
        Do While dr.Read()
            Cmb.Items.Add(dr.GetString(0))
        Loop
    End Sub
End Class
