<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsrContra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CBDatabase = New System.Windows.Forms.ComboBox()
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.TBContra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnUsrContrCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CBDatabase
        '
        Me.CBDatabase.FormattingEnabled = True
        Me.CBDatabase.Items.AddRange(New Object() {"DIECUTFINAL", "CSCOMPANYFINAL", "Pruebas"})
        Me.CBDatabase.Location = New System.Drawing.Point(107, 26)
        Me.CBDatabase.Name = "CBDatabase"
        Me.CBDatabase.Size = New System.Drawing.Size(160, 21)
        Me.CBDatabase.TabIndex = 0
        Me.CBDatabase.Text = "DIECUTFINAL"
        '
        'TBUsuario
        '
        Me.TBUsuario.Location = New System.Drawing.Point(107, 58)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(160, 20)
        Me.TBUsuario.TabIndex = 1
        '
        'TBContra
        '
        Me.TBContra.Location = New System.Drawing.Point(107, 89)
        Me.TBContra.Name = "TBContra"
        Me.TBContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBContra.Size = New System.Drawing.Size(160, 20)
        Me.TBContra.TabIndex = 2
        Me.TBContra.Text = "tiempo8"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Base de Datos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contraseña:"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(41, 125)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 6
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnUsrContrCancelar
        '
        Me.BtnUsrContrCancelar.Location = New System.Drawing.Point(153, 125)
        Me.BtnUsrContrCancelar.Name = "BtnUsrContrCancelar"
        Me.BtnUsrContrCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnUsrContrCancelar.TabIndex = 7
        Me.BtnUsrContrCancelar.Text = "Cancelar"
        Me.BtnUsrContrCancelar.UseVisualStyleBackColor = True
        '
        'UsrContra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 160)
        Me.Controls.Add(Me.BtnUsrContrCancelar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBContra)
        Me.Controls.Add(Me.TBUsuario)
        Me.Controls.Add(Me.CBDatabase)
        Me.Name = "UsrContra"
        Me.Text = "BD, Usuario y Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBDatabase As ComboBox
    Friend WithEvents TBUsuario As TextBox
    Friend WithEvents TBContra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnUsrContrCancelar As Button
End Class
