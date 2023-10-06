<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Requi
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DocNumLabel As System.Windows.Forms.Label
        Dim DocDateLabel As System.Windows.Forms.Label
        Dim ReqNameLabel As System.Windows.Forms.Label
        Dim RequesterLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim CommentsLabel As System.Windows.Forms.Label
        Dim ReqDateLabel As System.Windows.Forms.Label
        Dim DocTotalLabel As System.Windows.Forms.Label
        Dim PresupuestoLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim RealLabel As System.Windows.Forms.Label
        Dim PedidoLabel As System.Windows.Forms.Label
        Dim Recibo_de_EntradaLabel As System.Windows.Forms.Label
        Dim FacturaLabel As System.Windows.Forms.Label
        Dim U_CS_AutComprasLabel As System.Windows.Forms.Label
        Dim U_CS_ComentComprasLabel As System.Windows.Forms.Label
        Dim U_CS_AutJefeLabel As System.Windows.Forms.Label
        Dim U_CS_ComentJefeLabel As System.Windows.Forms.Label
        Dim U_CS_AutDirectorLabel As System.Windows.Forms.Label
        Dim U_CS_ComentDirectorLabel As System.Windows.Forms.Label
        Dim U_CS_AutLuisLabel As System.Windows.Forms.Label
        Dim U_CS_ComentLuisLabel As System.Windows.Forms.Label
        Dim PresupuestoLabel2 As System.Windows.Forms.Label
        Dim TotalLabel2 As System.Windows.Forms.Label
        Dim RealLabel2 As System.Windows.Forms.Label
        Dim DVencidosLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RealLabel3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TotalLabel3 = New System.Windows.Forms.Label()
        Me.PresupuestoLabel3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RealLabel1 = New System.Windows.Forms.Label()
        Me.TotalLabel1 = New System.Windows.Forms.Label()
        Me.PresupuestoLabel1 = New System.Windows.Forms.Label()
        Me.DtpFDeseada = New System.Windows.Forms.DateTimePicker()
        Me.CbxDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DGVDatos = New System.Windows.Forms.DataGridView()
        Me.TCArticulo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TCDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCImpuesto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TCMoneda = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtDirector = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMailCompras = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtMailContacto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtContacto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtProvSugerido = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtJefeDir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtJusti = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombSol = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumEmp = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.U_CS_AutLuisLabel1 = New System.Windows.Forms.Label()
        Me.U_CS_ComentLuisLabel1 = New System.Windows.Forms.Label()
        Me.U_CS_AutDirectorLabel1 = New System.Windows.Forms.Label()
        Me.U_CS_ComentDirectorLabel1 = New System.Windows.Forms.Label()
        Me.U_CS_AutJefeLabel1 = New System.Windows.Forms.Label()
        Me.U_CS_ComentJefeLabel1 = New System.Windows.Forms.Label()
        Me.U_CS_AutComprasLabel1 = New System.Windows.Forms.Label()
        Me.U_CS_ComentComprasLabel1 = New System.Windows.Forms.Label()
        Me.FacturaTextBox = New System.Windows.Forms.TextBox()
        Me.Recibo_de_EntradaTextBox = New System.Windows.Forms.TextBox()
        Me.PedidoTextBox = New System.Windows.Forms.TextBox()
        Me.PRQ1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DocTotalTextBox = New System.Windows.Forms.TextBox()
        Me.EjecutaQryToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CodeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CodeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.EjecutaQryToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DocNumTextBox = New System.Windows.Forms.TextBox()
        Me.DocDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ReqNameTextBox = New System.Windows.Forms.TextBox()
        Me.RequesterTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.CommentsTextBox = New System.Windows.Forms.TextBox()
        Me.ReqDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PreMensualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReqDSET = New RequiCompras2_0.ReqDSET()
        Me.PRESTOTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommLuisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommDirBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommJefeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommCompBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OPCHFactBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OPDNEmercBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OPORPeDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRQ1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OPRQBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OPRQ_TA = New RequiCompras2_0.ReqDSETTableAdapters.OPRQ_TA()
        Me.TableAdapterManager = New RequiCompras2_0.ReqDSETTableAdapters.TableAdapterManager()
        Me.DTPRESTOT = New RequiCompras2_0.ReqDSETTableAdapters.DTPRESTOT()
        Me.OPOR_TAPeD = New RequiCompras2_0.ReqDSETTableAdapters.OPOR_TAPeD()
        Me.OPDNTAmerc = New RequiCompras2_0.ReqDSETTableAdapters.OPDNTAmerc()
        Me.OPCHTAFact = New RequiCompras2_0.ReqDSETTableAdapters.OPCHTAFact()
        Me.CommCompTA = New RequiCompras2_0.ReqDSETTableAdapters.CommCompTA()
        Me.CommJefeTA = New RequiCompras2_0.ReqDSETTableAdapters.CommJefeTA()
        Me.CommDirTA = New RequiCompras2_0.ReqDSETTableAdapters.CommDirTA()
        Me.CommLuisTA = New RequiCompras2_0.ReqDSETTableAdapters.CommLuisTA()
        Me.PRQ1TA1 = New RequiCompras2_0.ReqDSETTableAdapters.PRQ1TA()
        Me.PreMensualTA = New RequiCompras2_0.ReqDSETTableAdapters.PreMensualTA()
        Me.DVencidosTextBox = New System.Windows.Forms.TextBox()
        DocNumLabel = New System.Windows.Forms.Label()
        DocDateLabel = New System.Windows.Forms.Label()
        ReqNameLabel = New System.Windows.Forms.Label()
        RequesterLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CommentsLabel = New System.Windows.Forms.Label()
        ReqDateLabel = New System.Windows.Forms.Label()
        DocTotalLabel = New System.Windows.Forms.Label()
        PresupuestoLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        RealLabel = New System.Windows.Forms.Label()
        PedidoLabel = New System.Windows.Forms.Label()
        Recibo_de_EntradaLabel = New System.Windows.Forms.Label()
        FacturaLabel = New System.Windows.Forms.Label()
        U_CS_AutComprasLabel = New System.Windows.Forms.Label()
        U_CS_ComentComprasLabel = New System.Windows.Forms.Label()
        U_CS_AutJefeLabel = New System.Windows.Forms.Label()
        U_CS_ComentJefeLabel = New System.Windows.Forms.Label()
        U_CS_AutDirectorLabel = New System.Windows.Forms.Label()
        U_CS_ComentDirectorLabel = New System.Windows.Forms.Label()
        U_CS_AutLuisLabel = New System.Windows.Forms.Label()
        U_CS_ComentLuisLabel = New System.Windows.Forms.Label()
        PresupuestoLabel2 = New System.Windows.Forms.Label()
        TotalLabel2 = New System.Windows.Forms.Label()
        RealLabel2 = New System.Windows.Forms.Label()
        DVencidosLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PRQ1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EjecutaQryToolStrip.SuspendLayout()
        CType(Me.PreMensualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReqDSET, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRESTOTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommLuisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommDirBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommJefeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommCompBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPCHFactBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPDNEmercBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPORPeDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRQ1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPRQBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocNumLabel
        '
        DocNumLabel.AutoSize = True
        DocNumLabel.Location = New System.Drawing.Point(14, 41)
        DocNumLabel.Name = "DocNumLabel"
        DocNumLabel.Size = New System.Drawing.Size(87, 13)
        DocNumLabel.TabIndex = 0
        DocNumLabel.Text = "Num Requisicion"
        '
        'DocDateLabel
        '
        DocDateLabel.AutoSize = True
        DocDateLabel.Location = New System.Drawing.Point(333, 41)
        DocDateLabel.Name = "DocDateLabel"
        DocDateLabel.Size = New System.Drawing.Size(97, 13)
        DocDateLabel.TabIndex = 2
        DocDateLabel.Text = "Fecha de Creacion"
        '
        'ReqNameLabel
        '
        ReqNameLabel.AutoSize = True
        ReqNameLabel.Location = New System.Drawing.Point(14, 93)
        ReqNameLabel.Name = "ReqNameLabel"
        ReqNameLabel.Size = New System.Drawing.Size(87, 13)
        ReqNameLabel.TabIndex = 6
        ReqNameLabel.Text = "Nomb Solicitante"
        '
        'RequesterLabel
        '
        RequesterLabel.AutoSize = True
        RequesterLabel.Location = New System.Drawing.Point(14, 70)
        RequesterLabel.Name = "RequesterLabel"
        RequesterLabel.Size = New System.Drawing.Size(79, 13)
        RequesterLabel.TabIndex = 8
        RequesterLabel.Text = "Num Empleado"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(14, 145)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(74, 13)
        DepartmentLabel.TabIndex = 10
        DepartmentLabel.Text = "Departamento"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(14, 119)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Email:"
        '
        'CommentsLabel
        '
        CommentsLabel.AutoSize = True
        CommentsLabel.Location = New System.Drawing.Point(333, 142)
        CommentsLabel.Name = "CommentsLabel"
        CommentsLabel.Size = New System.Drawing.Size(65, 13)
        CommentsLabel.TabIndex = 16
        CommentsLabel.Text = "Justificacion"
        '
        'ReqDateLabel
        '
        ReqDateLabel.AutoSize = True
        ReqDateLabel.Location = New System.Drawing.Point(333, 70)
        ReqDateLabel.Name = "ReqDateLabel"
        ReqDateLabel.Size = New System.Drawing.Size(86, 13)
        ReqDateLabel.TabIndex = 18
        ReqDateLabel.Text = "Fecha Requerira"
        '
        'DocTotalLabel
        '
        DocTotalLabel.AutoSize = True
        DocTotalLabel.Location = New System.Drawing.Point(14, 203)
        DocTotalLabel.Name = "DocTotalLabel"
        DocTotalLabel.Size = New System.Drawing.Size(31, 13)
        DocTotalLabel.TabIndex = 21
        DocTotalLabel.Text = "Total"
        '
        'PresupuestoLabel
        '
        PresupuestoLabel.AutoSize = True
        PresupuestoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PresupuestoLabel.Location = New System.Drawing.Point(570, 58)
        PresupuestoLabel.Name = "PresupuestoLabel"
        PresupuestoLabel.Size = New System.Drawing.Size(91, 15)
        PresupuestoLabel.TabIndex = 31
        PresupuestoLabel.Text = "Presupuesto:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalLabel.Location = New System.Drawing.Point(570, 161)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(43, 15)
        TotalLabel.TabIndex = 34
        TotalLabel.Text = "Total:"
        '
        'RealLabel
        '
        RealLabel.AutoSize = True
        RealLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RealLabel.Location = New System.Drawing.Point(570, 117)
        RealLabel.Name = "RealLabel"
        RealLabel.Size = New System.Drawing.Size(41, 15)
        RealLabel.TabIndex = 35
        RealLabel.Text = "Real:"
        '
        'PedidoLabel
        '
        PedidoLabel.AutoSize = True
        PedidoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PedidoLabel.Location = New System.Drawing.Point(728, 41)
        PedidoLabel.Name = "PedidoLabel"
        PedidoLabel.Size = New System.Drawing.Size(56, 15)
        PedidoLabel.TabIndex = 22
        PedidoLabel.Text = "Pedido:"
        '
        'Recibo_de_EntradaLabel
        '
        Recibo_de_EntradaLabel.AutoSize = True
        Recibo_de_EntradaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Recibo_de_EntradaLabel.Location = New System.Drawing.Point(728, 97)
        Recibo_de_EntradaLabel.Name = "Recibo_de_EntradaLabel"
        Recibo_de_EntradaLabel.Size = New System.Drawing.Size(130, 15)
        Recibo_de_EntradaLabel.TabIndex = 23
        Recibo_de_EntradaLabel.Text = "Recibo de Entrada:"
        '
        'FacturaLabel
        '
        FacturaLabel.AutoSize = True
        FacturaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FacturaLabel.Location = New System.Drawing.Point(728, 145)
        FacturaLabel.Name = "FacturaLabel"
        FacturaLabel.Size = New System.Drawing.Size(59, 15)
        FacturaLabel.TabIndex = 24
        FacturaLabel.Text = "Factura:"
        '
        'U_CS_AutComprasLabel
        '
        U_CS_AutComprasLabel.AutoSize = True
        U_CS_AutComprasLabel.Location = New System.Drawing.Point(725, 203)
        U_CS_AutComprasLabel.Name = "U_CS_AutComprasLabel"
        U_CS_AutComprasLabel.Size = New System.Drawing.Size(70, 13)
        U_CS_AutComprasLabel.TabIndex = 26
        U_CS_AutComprasLabel.Text = "Aut Compras:"
        '
        'U_CS_ComentComprasLabel
        '
        U_CS_ComentComprasLabel.AutoSize = True
        U_CS_ComentComprasLabel.Location = New System.Drawing.Point(725, 226)
        U_CS_ComentComprasLabel.Name = "U_CS_ComentComprasLabel"
        U_CS_ComentComprasLabel.Size = New System.Drawing.Size(90, 13)
        U_CS_ComentComprasLabel.TabIndex = 28
        U_CS_ComentComprasLabel.Text = "Coment Compras:"
        '
        'U_CS_AutJefeLabel
        '
        U_CS_AutJefeLabel.AutoSize = True
        U_CS_AutJefeLabel.Location = New System.Drawing.Point(725, 259)
        U_CS_AutJefeLabel.Name = "U_CS_AutJefeLabel"
        U_CS_AutJefeLabel.Size = New System.Drawing.Size(49, 13)
        U_CS_AutJefeLabel.TabIndex = 30
        U_CS_AutJefeLabel.Text = "Aut Jefe:"
        '
        'U_CS_ComentJefeLabel
        '
        U_CS_ComentJefeLabel.AutoSize = True
        U_CS_ComentJefeLabel.Location = New System.Drawing.Point(725, 282)
        U_CS_ComentJefeLabel.Name = "U_CS_ComentJefeLabel"
        U_CS_ComentJefeLabel.Size = New System.Drawing.Size(69, 13)
        U_CS_ComentJefeLabel.TabIndex = 32
        U_CS_ComentJefeLabel.Text = "Coment Jefe:"
        '
        'U_CS_AutDirectorLabel
        '
        U_CS_AutDirectorLabel.AutoSize = True
        U_CS_AutDirectorLabel.Location = New System.Drawing.Point(725, 313)
        U_CS_AutDirectorLabel.Name = "U_CS_AutDirectorLabel"
        U_CS_AutDirectorLabel.Size = New System.Drawing.Size(66, 13)
        U_CS_AutDirectorLabel.TabIndex = 34
        U_CS_AutDirectorLabel.Text = "Aut Director:"
        '
        'U_CS_ComentDirectorLabel
        '
        U_CS_ComentDirectorLabel.AutoSize = True
        U_CS_ComentDirectorLabel.Location = New System.Drawing.Point(725, 336)
        U_CS_ComentDirectorLabel.Name = "U_CS_ComentDirectorLabel"
        U_CS_ComentDirectorLabel.Size = New System.Drawing.Size(86, 13)
        U_CS_ComentDirectorLabel.TabIndex = 36
        U_CS_ComentDirectorLabel.Text = "Coment Director:"
        '
        'U_CS_AutLuisLabel
        '
        U_CS_AutLuisLabel.AutoSize = True
        U_CS_AutLuisLabel.Location = New System.Drawing.Point(725, 375)
        U_CS_AutLuisLabel.Name = "U_CS_AutLuisLabel"
        U_CS_AutLuisLabel.Size = New System.Drawing.Size(48, 13)
        U_CS_AutLuisLabel.TabIndex = 38
        U_CS_AutLuisLabel.Text = "Aut Luis:"
        '
        'U_CS_ComentLuisLabel
        '
        U_CS_ComentLuisLabel.AutoSize = True
        U_CS_ComentLuisLabel.Location = New System.Drawing.Point(725, 398)
        U_CS_ComentLuisLabel.Name = "U_CS_ComentLuisLabel"
        U_CS_ComentLuisLabel.Size = New System.Drawing.Size(68, 13)
        U_CS_ComentLuisLabel.TabIndex = 40
        U_CS_ComentLuisLabel.Text = "Coment Luis:"
        '
        'PresupuestoLabel2
        '
        PresupuestoLabel2.AutoSize = True
        PresupuestoLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PresupuestoLabel2.Location = New System.Drawing.Point(464, 58)
        PresupuestoLabel2.Name = "PresupuestoLabel2"
        PresupuestoLabel2.Size = New System.Drawing.Size(91, 15)
        PresupuestoLabel2.TabIndex = 37
        PresupuestoLabel2.Text = "Presupuesto:"
        '
        'TotalLabel2
        '
        TotalLabel2.AutoSize = True
        TotalLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalLabel2.Location = New System.Drawing.Point(463, 164)
        TotalLabel2.Name = "TotalLabel2"
        TotalLabel2.Size = New System.Drawing.Size(43, 15)
        TotalLabel2.TabIndex = 41
        TotalLabel2.Text = "Total:"
        '
        'RealLabel2
        '
        RealLabel2.AutoSize = True
        RealLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RealLabel2.Location = New System.Drawing.Point(464, 116)
        RealLabel2.Name = "RealLabel2"
        RealLabel2.Size = New System.Drawing.Size(41, 15)
        RealLabel2.TabIndex = 43
        RealLabel2.Text = "Real:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(7, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1109, 546)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(RealLabel2)
        Me.TabPage1.Controls.Add(Me.RealLabel3)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(TotalLabel2)
        Me.TabPage1.Controls.Add(Me.TotalLabel3)
        Me.TabPage1.Controls.Add(PresupuestoLabel2)
        Me.TabPage1.Controls.Add(Me.PresupuestoLabel3)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(RealLabel)
        Me.TabPage1.Controls.Add(Me.RealLabel1)
        Me.TabPage1.Controls.Add(TotalLabel)
        Me.TabPage1.Controls.Add(Me.TotalLabel1)
        Me.TabPage1.Controls.Add(PresupuestoLabel)
        Me.TabPage1.Controls.Add(Me.PresupuestoLabel1)
        Me.TabPage1.Controls.Add(Me.DtpFDeseada)
        Me.TabPage1.Controls.Add(Me.CbxDepartamento)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.DGVDatos)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.TxtDirector)
        Me.TabPage1.Controls.Add(Me.BtnGuardar)
        Me.TabPage1.Controls.Add(Me.BtnNuevo)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.TxtMailCompras)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.TxtMailContacto)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.TxtContacto)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.TxtTelefono)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.TxtProvSugerido)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TxtJefeDir)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TxtJusti)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TxtMail)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TxtNombSol)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TxtNumEmp)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1101, 520)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Crear Requisicion"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'RealLabel3
        '
        Me.RealLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PreMensualBindingSource, "Real", True))
        Me.RealLabel3.Location = New System.Drawing.Point(464, 140)
        Me.RealLabel3.Name = "RealLabel3"
        Me.RealLabel3.Size = New System.Drawing.Size(100, 23)
        Me.RealLabel3.TabIndex = 44
        Me.RealLabel3.Text = "Label17"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(466, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 15)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Mensual"
        '
        'TotalLabel3
        '
        Me.TotalLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PreMensualBindingSource, "Total", True))
        Me.TotalLabel3.Location = New System.Drawing.Point(464, 182)
        Me.TotalLabel3.Name = "TotalLabel3"
        Me.TotalLabel3.Size = New System.Drawing.Size(100, 23)
        Me.TotalLabel3.TabIndex = 42
        Me.TotalLabel3.Text = "Label16"
        '
        'PresupuestoLabel3
        '
        Me.PresupuestoLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PreMensualBindingSource, "Presupuesto", True))
        Me.PresupuestoLabel3.Location = New System.Drawing.Point(464, 94)
        Me.PresupuestoLabel3.Name = "PresupuestoLabel3"
        Me.PresupuestoLabel3.Size = New System.Drawing.Size(100, 23)
        Me.PresupuestoLabel3.TabIndex = 38
        Me.PresupuestoLabel3.Text = "Label16"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(570, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 15)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Anual"
        '
        'RealLabel1
        '
        Me.RealLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRESTOTBindingSource, "Real", True))
        Me.RealLabel1.Location = New System.Drawing.Point(570, 140)
        Me.RealLabel1.Name = "RealLabel1"
        Me.RealLabel1.Size = New System.Drawing.Size(100, 23)
        Me.RealLabel1.TabIndex = 36
        Me.RealLabel1.Text = "Label15"
        '
        'TotalLabel1
        '
        Me.TotalLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRESTOTBindingSource, "Total", True))
        Me.TotalLabel1.Location = New System.Drawing.Point(570, 182)
        Me.TotalLabel1.Name = "TotalLabel1"
        Me.TotalLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TotalLabel1.TabIndex = 35
        Me.TotalLabel1.Text = "Label15"
        '
        'PresupuestoLabel1
        '
        Me.PresupuestoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRESTOTBindingSource, "Presupuesto", True))
        Me.PresupuestoLabel1.Location = New System.Drawing.Point(570, 98)
        Me.PresupuestoLabel1.Name = "PresupuestoLabel1"
        Me.PresupuestoLabel1.Size = New System.Drawing.Size(100, 23)
        Me.PresupuestoLabel1.TabIndex = 32
        Me.PresupuestoLabel1.Text = "Label15"
        '
        'DtpFDeseada
        '
        Me.DtpFDeseada.Location = New System.Drawing.Point(811, 15)
        Me.DtpFDeseada.Name = "DtpFDeseada"
        Me.DtpFDeseada.Size = New System.Drawing.Size(284, 20)
        Me.DtpFDeseada.TabIndex = 31
        '
        'CbxDepartamento
        '
        Me.CbxDepartamento.FormattingEnabled = True
        Me.CbxDepartamento.Items.AddRange(New Object() {"ADMON, FINANZAS Y TI", "CADENA DE SUMINISTRO", "CALIDAD", "DIRECCION GENERAL", "ESTRUCTURA HUMANA", "LOGISTICA", "MANUFACTURA", "SEGURIDAD", "VENTAS"})
        Me.CbxDepartamento.Location = New System.Drawing.Point(157, 82)
        Me.CbxDepartamento.Name = "CbxDepartamento"
        Me.CbxDepartamento.Size = New System.Drawing.Size(284, 21)
        Me.CbxDepartamento.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label14.Location = New System.Drawing.Point(447, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(509, 15)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "! Si el Director y el Jefe inmediato son el mismo, favor de repetir el correo en " &
    "los dos campos"
        '
        'DGVDatos
        '
        Me.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TCArticulo, Me.TCDescripcion, Me.TCCantidad, Me.TCPrecio, Me.TCImpuesto, Me.TCMoneda})
        Me.DGVDatos.Location = New System.Drawing.Point(3, 250)
        Me.DGVDatos.Name = "DGVDatos"
        Me.DGVDatos.Size = New System.Drawing.Size(1092, 263)
        Me.DGVDatos.TabIndex = 28
        '
        'TCArticulo
        '
        Me.TCArticulo.HeaderText = "Articulo"
        Me.TCArticulo.Name = "TCArticulo"
        Me.TCArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TCArticulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TCArticulo.Width = 120
        '
        'TCDescripcion
        '
        Me.TCDescripcion.HeaderText = "Descripcion"
        Me.TCDescripcion.Name = "TCDescripcion"
        Me.TCDescripcion.Width = 200
        '
        'TCCantidad
        '
        Me.TCCantidad.HeaderText = "Cantidad"
        Me.TCCantidad.Name = "TCCantidad"
        '
        'TCPrecio
        '
        Me.TCPrecio.HeaderText = "Precio"
        Me.TCPrecio.Name = "TCPrecio"
        '
        'TCImpuesto
        '
        Me.TCImpuesto.HeaderText = "Impuesto"
        Me.TCImpuesto.Items.AddRange(New Object() {"V3", "V0"})
        Me.TCImpuesto.Name = "TCImpuesto"
        Me.TCImpuesto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TCImpuesto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TCMoneda
        '
        Me.TCMoneda.HeaderText = "Moneda"
        Me.TCMoneda.Items.AddRange(New Object() {"MXP", "USD"})
        Me.TCMoneda.Name = "TCMoneda"
        Me.TCMoneda.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TCMoneda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 217)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 15)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Director del Area (Mail)"
        '
        'TxtDirector
        '
        Me.TxtDirector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDirector.Location = New System.Drawing.Point(157, 211)
        Me.TxtDirector.Name = "TxtDirector"
        Me.TxtDirector.Size = New System.Drawing.Size(284, 21)
        Me.TxtDirector.TabIndex = 26
        Me.TxtDirector.Text = "grobles@convertsolutions.com"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(467, 11)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 25
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(560, 11)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 24
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(684, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 15)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Mail de Compras"
        '
        'TxtMailCompras
        '
        Me.TxtMailCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMailCompras.Location = New System.Drawing.Point(811, 142)
        Me.TxtMailCompras.Name = "TxtMailCompras"
        Me.TxtMailCompras.Size = New System.Drawing.Size(284, 21)
        Me.TxtMailCompras.TabIndex = 22
        Me.TxtMailCompras.Text = "imruiz@convertsolutions.com"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(684, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 15)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Mail de Contacto"
        '
        'TxtMailContacto
        '
        Me.TxtMailContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMailContacto.Location = New System.Drawing.Point(811, 116)
        Me.TxtMailContacto.Name = "TxtMailContacto"
        Me.TxtMailContacto.Size = New System.Drawing.Size(284, 21)
        Me.TxtMailContacto.TabIndex = 20
        Me.TxtMailContacto.Text = "janpenas@patito.com"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(684, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Persona de contacto"
        '
        'TxtContacto
        '
        Me.TxtContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContacto.Location = New System.Drawing.Point(811, 90)
        Me.TxtContacto.Name = "TxtContacto"
        Me.TxtContacto.Size = New System.Drawing.Size(284, 21)
        Me.TxtContacto.TabIndex = 18
        Me.TxtContacto.Text = "Juan Penas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(684, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Telefono:"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(811, 65)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(284, 21)
        Me.TxtTelefono.TabIndex = 16
        Me.TxtTelefono.Text = "33 10 66 38 90"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(684, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 15)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Proveedor Sugerido"
        '
        'TxtProvSugerido
        '
        Me.TxtProvSugerido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProvSugerido.Location = New System.Drawing.Point(811, 39)
        Me.TxtProvSugerido.Name = "TxtProvSugerido"
        Me.TxtProvSugerido.Size = New System.Drawing.Size(284, 21)
        Me.TxtProvSugerido.TabIndex = 14
        Me.TxtProvSugerido.Text = "Alestra"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(684, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 15)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Fecha Deseada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Jefe Directo (Mail)"
        '
        'TxtJefeDir
        '
        Me.TxtJefeDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJefeDir.Location = New System.Drawing.Point(157, 185)
        Me.TxtJefeDir.Name = "TxtJefeDir"
        Me.TxtJefeDir.Size = New System.Drawing.Size(284, 21)
        Me.TxtJefeDir.TabIndex = 10
        Me.TxtJefeDir.Text = "grobles@convertsolutions.com"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Justificacion"
        '
        'TxtJusti
        '
        Me.TxtJusti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJusti.Location = New System.Drawing.Point(157, 109)
        Me.TxtJusti.Multiline = True
        Me.TxtJusti.Name = "TxtJusti"
        Me.TxtJusti.Size = New System.Drawing.Size(284, 70)
        Me.TxtJusti.TabIndex = 8
        Me.TxtJusti.Text = "Esto es la justificacion zas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Departamento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mail"
        '
        'TxtMail
        '
        Me.TxtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMail.Location = New System.Drawing.Point(157, 58)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(284, 21)
        Me.TxtMail.TabIndex = 4
        Me.TxtMail.Text = "grobles@convertsolutions.com"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre del Solicitante"
        '
        'TxtNombSol
        '
        Me.TxtNombSol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombSol.Location = New System.Drawing.Point(157, 32)
        Me.TxtNombSol.Name = "TxtNombSol"
        Me.TxtNombSol.Size = New System.Drawing.Size(284, 21)
        Me.TxtNombSol.TabIndex = 2
        Me.TxtNombSol.Text = "Gildardo Robles"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero Empleado"
        '
        'TxtNumEmp
        '
        Me.TxtNumEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumEmp.Location = New System.Drawing.Point(157, 6)
        Me.TxtNumEmp.Name = "TxtNumEmp"
        Me.TxtNumEmp.Size = New System.Drawing.Size(284, 21)
        Me.TxtNumEmp.TabIndex = 0
        Me.TxtNumEmp.Text = "339"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(DVencidosLabel)
        Me.TabPage2.Controls.Add(Me.DVencidosTextBox)
        Me.TabPage2.Controls.Add(U_CS_AutLuisLabel)
        Me.TabPage2.Controls.Add(Me.U_CS_AutLuisLabel1)
        Me.TabPage2.Controls.Add(U_CS_ComentLuisLabel)
        Me.TabPage2.Controls.Add(Me.U_CS_ComentLuisLabel1)
        Me.TabPage2.Controls.Add(U_CS_AutDirectorLabel)
        Me.TabPage2.Controls.Add(Me.U_CS_AutDirectorLabel1)
        Me.TabPage2.Controls.Add(U_CS_ComentDirectorLabel)
        Me.TabPage2.Controls.Add(Me.U_CS_ComentDirectorLabel1)
        Me.TabPage2.Controls.Add(U_CS_AutJefeLabel)
        Me.TabPage2.Controls.Add(Me.U_CS_AutJefeLabel1)
        Me.TabPage2.Controls.Add(U_CS_ComentJefeLabel)
        Me.TabPage2.Controls.Add(Me.U_CS_ComentJefeLabel1)
        Me.TabPage2.Controls.Add(U_CS_AutComprasLabel)
        Me.TabPage2.Controls.Add(Me.U_CS_AutComprasLabel1)
        Me.TabPage2.Controls.Add(U_CS_ComentComprasLabel)
        Me.TabPage2.Controls.Add(Me.U_CS_ComentComprasLabel1)
        Me.TabPage2.Controls.Add(FacturaLabel)
        Me.TabPage2.Controls.Add(Me.FacturaTextBox)
        Me.TabPage2.Controls.Add(Recibo_de_EntradaLabel)
        Me.TabPage2.Controls.Add(Me.Recibo_de_EntradaTextBox)
        Me.TabPage2.Controls.Add(PedidoLabel)
        Me.TabPage2.Controls.Add(Me.PedidoTextBox)
        Me.TabPage2.Controls.Add(Me.PRQ1DataGridView)
        Me.TabPage2.Controls.Add(DocTotalLabel)
        Me.TabPage2.Controls.Add(Me.DocTotalTextBox)
        Me.TabPage2.Controls.Add(Me.EjecutaQryToolStrip)
        Me.TabPage2.Controls.Add(DocNumLabel)
        Me.TabPage2.Controls.Add(Me.DocNumTextBox)
        Me.TabPage2.Controls.Add(DocDateLabel)
        Me.TabPage2.Controls.Add(Me.DocDateDateTimePicker)
        Me.TabPage2.Controls.Add(ReqNameLabel)
        Me.TabPage2.Controls.Add(Me.ReqNameTextBox)
        Me.TabPage2.Controls.Add(RequesterLabel)
        Me.TabPage2.Controls.Add(Me.RequesterTextBox)
        Me.TabPage2.Controls.Add(DepartmentLabel)
        Me.TabPage2.Controls.Add(Me.DepartmentTextBox)
        Me.TabPage2.Controls.Add(EmailLabel)
        Me.TabPage2.Controls.Add(Me.EmailTextBox)
        Me.TabPage2.Controls.Add(CommentsLabel)
        Me.TabPage2.Controls.Add(Me.CommentsTextBox)
        Me.TabPage2.Controls.Add(ReqDateLabel)
        Me.TabPage2.Controls.Add(Me.ReqDateDateTimePicker)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1101, 520)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar Requisicion"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'U_CS_AutLuisLabel1
        '
        Me.U_CS_AutLuisLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommLuisBindingSource, "U_CS_AutLuis", True))
        Me.U_CS_AutLuisLabel1.Location = New System.Drawing.Point(815, 375)
        Me.U_CS_AutLuisLabel1.Name = "U_CS_AutLuisLabel1"
        Me.U_CS_AutLuisLabel1.Size = New System.Drawing.Size(100, 23)
        Me.U_CS_AutLuisLabel1.TabIndex = 39
        Me.U_CS_AutLuisLabel1.Text = "-"
        '
        'U_CS_ComentLuisLabel1
        '
        Me.U_CS_ComentLuisLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommLuisBindingSource, "U_CS_ComentLuis", True))
        Me.U_CS_ComentLuisLabel1.Location = New System.Drawing.Point(815, 398)
        Me.U_CS_ComentLuisLabel1.Name = "U_CS_ComentLuisLabel1"
        Me.U_CS_ComentLuisLabel1.Size = New System.Drawing.Size(100, 23)
        Me.U_CS_ComentLuisLabel1.TabIndex = 41
        Me.U_CS_ComentLuisLabel1.Text = "-"
        '
        'U_CS_AutDirectorLabel1
        '
        Me.U_CS_AutDirectorLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommDirBindingSource, "U_CS_AutDirector", True))
        Me.U_CS_AutDirectorLabel1.Location = New System.Drawing.Point(815, 313)
        Me.U_CS_AutDirectorLabel1.Name = "U_CS_AutDirectorLabel1"
        Me.U_CS_AutDirectorLabel1.Size = New System.Drawing.Size(100, 23)
        Me.U_CS_AutDirectorLabel1.TabIndex = 35
        Me.U_CS_AutDirectorLabel1.Text = "-"
        '
        'U_CS_ComentDirectorLabel1
        '
        Me.U_CS_ComentDirectorLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommDirBindingSource, "U_CS_ComentDirector", True))
        Me.U_CS_ComentDirectorLabel1.Location = New System.Drawing.Point(815, 336)
        Me.U_CS_ComentDirectorLabel1.Name = "U_CS_ComentDirectorLabel1"
        Me.U_CS_ComentDirectorLabel1.Size = New System.Drawing.Size(100, 23)
        Me.U_CS_ComentDirectorLabel1.TabIndex = 37
        Me.U_CS_ComentDirectorLabel1.Text = "-"
        '
        'U_CS_AutJefeLabel1
        '
        Me.U_CS_AutJefeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommJefeBindingSource, "U_CS_AutJefe", True))
        Me.U_CS_AutJefeLabel1.Location = New System.Drawing.Point(815, 259)
        Me.U_CS_AutJefeLabel1.Name = "U_CS_AutJefeLabel1"
        Me.U_CS_AutJefeLabel1.Size = New System.Drawing.Size(100, 23)
        Me.U_CS_AutJefeLabel1.TabIndex = 31
        Me.U_CS_AutJefeLabel1.Text = "-"
        '
        'U_CS_ComentJefeLabel1
        '
        Me.U_CS_ComentJefeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommJefeBindingSource, "U_CS_ComentJefe", True))
        Me.U_CS_ComentJefeLabel1.Location = New System.Drawing.Point(815, 282)
        Me.U_CS_ComentJefeLabel1.Name = "U_CS_ComentJefeLabel1"
        Me.U_CS_ComentJefeLabel1.Size = New System.Drawing.Size(100, 23)
        Me.U_CS_ComentJefeLabel1.TabIndex = 33
        Me.U_CS_ComentJefeLabel1.Text = "-"
        '
        'U_CS_AutComprasLabel1
        '
        Me.U_CS_AutComprasLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommCompBindingSource, "U_CS_AutCompras", True))
        Me.U_CS_AutComprasLabel1.Location = New System.Drawing.Point(815, 203)
        Me.U_CS_AutComprasLabel1.Name = "U_CS_AutComprasLabel1"
        Me.U_CS_AutComprasLabel1.Size = New System.Drawing.Size(100, 23)
        Me.U_CS_AutComprasLabel1.TabIndex = 27
        Me.U_CS_AutComprasLabel1.Text = "-"
        '
        'U_CS_ComentComprasLabel1
        '
        Me.U_CS_ComentComprasLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommCompBindingSource, "U_CS_ComentCompras", True))
        Me.U_CS_ComentComprasLabel1.Location = New System.Drawing.Point(815, 226)
        Me.U_CS_ComentComprasLabel1.Name = "U_CS_ComentComprasLabel1"
        Me.U_CS_ComentComprasLabel1.Size = New System.Drawing.Size(100, 23)
        Me.U_CS_ComentComprasLabel1.TabIndex = 29
        Me.U_CS_ComentComprasLabel1.Text = "-"
        '
        'FacturaTextBox
        '
        Me.FacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OPCHFactBindingSource, "Factura", True))
        Me.FacturaTextBox.Location = New System.Drawing.Point(731, 170)
        Me.FacturaTextBox.Name = "FacturaTextBox"
        Me.FacturaTextBox.ReadOnly = True
        Me.FacturaTextBox.Size = New System.Drawing.Size(205, 20)
        Me.FacturaTextBox.TabIndex = 25
        '
        'Recibo_de_EntradaTextBox
        '
        Me.Recibo_de_EntradaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OPDNEmercBindingSource, "Recibo de Entrada", True))
        Me.Recibo_de_EntradaTextBox.Location = New System.Drawing.Point(731, 119)
        Me.Recibo_de_EntradaTextBox.Name = "Recibo_de_EntradaTextBox"
        Me.Recibo_de_EntradaTextBox.ReadOnly = True
        Me.Recibo_de_EntradaTextBox.Size = New System.Drawing.Size(205, 20)
        Me.Recibo_de_EntradaTextBox.TabIndex = 24
        '
        'PedidoTextBox
        '
        Me.PedidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OPORPeDBindingSource, "Pedido", True))
        Me.PedidoTextBox.Location = New System.Drawing.Point(728, 63)
        Me.PedidoTextBox.Name = "PedidoTextBox"
        Me.PedidoTextBox.ReadOnly = True
        Me.PedidoTextBox.Size = New System.Drawing.Size(208, 20)
        Me.PedidoTextBox.TabIndex = 23
        '
        'PRQ1DataGridView
        '
        Me.PRQ1DataGridView.AllowUserToAddRows = False
        Me.PRQ1DataGridView.AllowUserToDeleteRows = False
        Me.PRQ1DataGridView.AutoGenerateColumns = False
        Me.PRQ1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRQ1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.PRQ1DataGridView.DataSource = Me.PRQ1BindingSource
        Me.PRQ1DataGridView.Location = New System.Drawing.Point(6, 250)
        Me.PRQ1DataGridView.Name = "PRQ1DataGridView"
        Me.PRQ1DataGridView.ReadOnly = True
        Me.PRQ1DataGridView.Size = New System.Drawing.Size(699, 264)
        Me.PRQ1DataGridView.TabIndex = 22
        '
        'DocTotalTextBox
        '
        Me.DocTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OPRQBindingSource, "DocTotal", True))
        Me.DocTotalTextBox.Location = New System.Drawing.Point(107, 200)
        Me.DocTotalTextBox.Name = "DocTotalTextBox"
        Me.DocTotalTextBox.ReadOnly = True
        Me.DocTotalTextBox.Size = New System.Drawing.Size(150, 20)
        Me.DocTotalTextBox.TabIndex = 22
        '
        'EjecutaQryToolStrip
        '
        Me.EjecutaQryToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CodeToolStripLabel, Me.CodeToolStripTextBox, Me.EjecutaQryToolStripButton})
        Me.EjecutaQryToolStrip.Location = New System.Drawing.Point(3, 3)
        Me.EjecutaQryToolStrip.Name = "EjecutaQryToolStrip"
        Me.EjecutaQryToolStrip.Size = New System.Drawing.Size(1095, 25)
        Me.EjecutaQryToolStrip.TabIndex = 20
        Me.EjecutaQryToolStrip.Text = "EjecutaQryToolStrip"
        '
        'CodeToolStripLabel
        '
        Me.CodeToolStripLabel.Name = "CodeToolStripLabel"
        Me.CodeToolStripLabel.Size = New System.Drawing.Size(38, 22)
        Me.CodeToolStripLabel.Text = "Code:"
        '
        'CodeToolStripTextBox
        '
        Me.CodeToolStripTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.CodeToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CodeToolStripTextBox.Name = "CodeToolStripTextBox"
        Me.CodeToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'EjecutaQryToolStripButton
        '
        Me.EjecutaQryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EjecutaQryToolStripButton.Name = "EjecutaQryToolStripButton"
        Me.EjecutaQryToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.EjecutaQryToolStripButton.Text = "Buscar"
        '
        'DocNumTextBox
        '
        Me.DocNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OPRQBindingSource, "DocNum", True))
        Me.DocNumTextBox.Location = New System.Drawing.Point(107, 38)
        Me.DocNumTextBox.Name = "DocNumTextBox"
        Me.DocNumTextBox.ReadOnly = True
        Me.DocNumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DocNumTextBox.TabIndex = 1
        '
        'DocDateDateTimePicker
        '
        Me.DocDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OPRQBindingSource, "DocDate", True))
        Me.DocDateDateTimePicker.Enabled = False
        Me.DocDateDateTimePicker.Location = New System.Drawing.Point(462, 38)
        Me.DocDateDateTimePicker.Name = "DocDateDateTimePicker"
        Me.DocDateDateTimePicker.Size = New System.Drawing.Size(243, 20)
        Me.DocDateDateTimePicker.TabIndex = 3
        '
        'ReqNameTextBox
        '
        Me.ReqNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OPRQBindingSource, "ReqName", True))
        Me.ReqNameTextBox.Location = New System.Drawing.Point(107, 90)
        Me.ReqNameTextBox.Name = "ReqNameTextBox"
        Me.ReqNameTextBox.ReadOnly = True
        Me.ReqNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ReqNameTextBox.TabIndex = 7
        '
        'RequesterTextBox
        '
        Me.RequesterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OPRQBindingSource, "Requester", True))
        Me.RequesterTextBox.Location = New System.Drawing.Point(107, 65)
        Me.RequesterTextBox.Name = "RequesterTextBox"
        Me.RequesterTextBox.ReadOnly = True
        Me.RequesterTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RequesterTextBox.TabIndex = 9
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OPRQBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(107, 142)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.ReadOnly = True
        Me.DepartmentTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DepartmentTextBox.TabIndex = 11
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OPRQBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(107, 116)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 13
        '
        'CommentsTextBox
        '
        Me.CommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OPRQBindingSource, "Comments", True))
        Me.CommentsTextBox.Location = New System.Drawing.Point(462, 139)
        Me.CommentsTextBox.Multiline = True
        Me.CommentsTextBox.Name = "CommentsTextBox"
        Me.CommentsTextBox.ReadOnly = True
        Me.CommentsTextBox.Size = New System.Drawing.Size(243, 100)
        Me.CommentsTextBox.TabIndex = 17
        '
        'ReqDateDateTimePicker
        '
        Me.ReqDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OPRQBindingSource, "ReqDate", True))
        Me.ReqDateDateTimePicker.Enabled = False
        Me.ReqDateDateTimePicker.Location = New System.Drawing.Point(462, 64)
        Me.ReqDateDateTimePicker.Name = "ReqDateDateTimePicker"
        Me.ReqDateDateTimePicker.Size = New System.Drawing.Size(243, 20)
        Me.ReqDateDateTimePicker.TabIndex = 19
        '
        'PreMensualBindingSource
        '
        Me.PreMensualBindingSource.DataMember = "PreMensual"
        Me.PreMensualBindingSource.DataSource = Me.ReqDSET
        '
        'ReqDSET
        '
        Me.ReqDSET.DataSetName = "ReqDSET"
        Me.ReqDSET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRESTOTBindingSource
        '
        Me.PRESTOTBindingSource.DataMember = "PRESTOT"
        Me.PRESTOTBindingSource.DataSource = Me.ReqDSET
        '
        'CommLuisBindingSource
        '
        Me.CommLuisBindingSource.DataMember = "CommLuis"
        Me.CommLuisBindingSource.DataSource = Me.ReqDSET
        '
        'CommDirBindingSource
        '
        Me.CommDirBindingSource.DataMember = "CommDir"
        Me.CommDirBindingSource.DataSource = Me.ReqDSET
        '
        'CommJefeBindingSource
        '
        Me.CommJefeBindingSource.DataMember = "CommJefe"
        Me.CommJefeBindingSource.DataSource = Me.ReqDSET
        '
        'CommCompBindingSource
        '
        Me.CommCompBindingSource.DataMember = "CommComp"
        Me.CommCompBindingSource.DataSource = Me.ReqDSET
        '
        'OPCHFactBindingSource
        '
        Me.OPCHFactBindingSource.DataMember = "OPCHFact"
        Me.OPCHFactBindingSource.DataSource = Me.ReqDSET
        '
        'OPDNEmercBindingSource
        '
        Me.OPDNEmercBindingSource.DataMember = "OPDNEmerc"
        Me.OPDNEmercBindingSource.DataSource = Me.ReqDSET
        '
        'OPORPeDBindingSource
        '
        Me.OPORPeDBindingSource.DataMember = "OPORPeD"
        Me.OPORPeDBindingSource.DataSource = Me.ReqDSET
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ItemCode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ItemCode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Dscription"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dscription"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ShipDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ShipDate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'PRQ1BindingSource
        '
        Me.PRQ1BindingSource.DataMember = "PRQ1"
        Me.PRQ1BindingSource.DataSource = Me.ReqDSET
        '
        'OPRQBindingSource
        '
        Me.OPRQBindingSource.DataMember = "OPRQ"
        Me.OPRQBindingSource.DataSource = Me.ReqDSET
        '
        'OPRQ_TA
        '
        Me.OPRQ_TA.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = RequiCompras2_0.ReqDSETTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DTPRESTOT
        '
        Me.DTPRESTOT.ClearBeforeFill = True
        '
        'OPOR_TAPeD
        '
        Me.OPOR_TAPeD.ClearBeforeFill = True
        '
        'OPDNTAmerc
        '
        Me.OPDNTAmerc.ClearBeforeFill = True
        '
        'OPCHTAFact
        '
        Me.OPCHTAFact.ClearBeforeFill = True
        '
        'CommCompTA
        '
        Me.CommCompTA.ClearBeforeFill = True
        '
        'CommJefeTA
        '
        Me.CommJefeTA.ClearBeforeFill = True
        '
        'CommDirTA
        '
        Me.CommDirTA.ClearBeforeFill = True
        '
        'CommLuisTA
        '
        Me.CommLuisTA.ClearBeforeFill = True
        '
        'PRQ1TA1
        '
        Me.PRQ1TA1.ClearBeforeFill = True
        '
        'PreMensualTA
        '
        Me.PreMensualTA.ClearBeforeFill = True
        '
        'DVencidosLabel
        '
        DVencidosLabel.AutoSize = True
        DVencidosLabel.Location = New System.Drawing.Point(333, 98)
        DVencidosLabel.Name = "DVencidosLabel"
        DVencidosLabel.Size = New System.Drawing.Size(123, 13)
        DVencidosLabel.TabIndex = 42
        DVencidosLabel.Text = "Dias Desde Su Creacion"
        '
        'DVencidosTextBox
        '
        Me.DVencidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OPRQBindingSource, "DVencidos", True))
        Me.DVencidosTextBox.Location = New System.Drawing.Point(462, 94)
        Me.DVencidosTextBox.Name = "DVencidosTextBox"
        Me.DVencidosTextBox.ReadOnly = True
        Me.DVencidosTextBox.Size = New System.Drawing.Size(243, 20)
        Me.DVencidosTextBox.TabIndex = 43
        '
        'Requi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 591)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Requi"
        Me.Text = "Requisiciones"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGVDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PRQ1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EjecutaQryToolStrip.ResumeLayout(False)
        Me.EjecutaQryToolStrip.PerformLayout()
        CType(Me.PreMensualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReqDSET, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRESTOTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommLuisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommDirBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommJefeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommCompBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPCHFactBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPDNEmercBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPORPeDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRQ1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPRQBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtDirector As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtMailCompras As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtMailContacto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtContacto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtProvSugerido As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtJefeDir As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtJusti As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombSol As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNumEmp As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label14 As Label
    Friend WithEvents DGVDatos As DataGridView
    Friend WithEvents DtpFDeseada As DateTimePicker
    Friend WithEvents CbxDepartamento As ComboBox
    Friend WithEvents TCArticulo As DataGridViewComboBoxColumn
    Friend WithEvents TCDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents TCCantidad As DataGridViewTextBoxColumn
    Friend WithEvents TCPrecio As DataGridViewTextBoxColumn
    Friend WithEvents TCImpuesto As DataGridViewComboBoxColumn
    Friend WithEvents TCMoneda As DataGridViewComboBoxColumn
    Friend WithEvents ReqDSET As ReqDSET
    Friend WithEvents OPRQBindingSource As BindingSource
    Friend WithEvents OPRQ_TA As ReqDSETTableAdapters.OPRQ_TA
    Friend WithEvents TableAdapterManager As ReqDSETTableAdapters.TableAdapterManager
    Friend WithEvents DocNumTextBox As TextBox
    Friend WithEvents DocDateDateTimePicker As DateTimePicker
    Friend WithEvents ReqNameTextBox As TextBox
    Friend WithEvents RequesterTextBox As TextBox
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents CommentsTextBox As TextBox
    Friend WithEvents ReqDateDateTimePicker As DateTimePicker
    Friend WithEvents EjecutaQryToolStrip As ToolStrip
    Friend WithEvents CodeToolStripLabel As ToolStripLabel
    Friend WithEvents CodeToolStripTextBox As ToolStripTextBox
    Friend WithEvents EjecutaQryToolStripButton As ToolStripButton
    Friend WithEvents PRQ1BindingSource As BindingSource
    Friend WithEvents DocTotalTextBox As TextBox
    Friend WithEvents PRQ1DataGridView As DataGridView
    Friend WithEvents PRESTOTBindingSource As BindingSource
    Friend WithEvents DTPRESTOT As ReqDSETTableAdapters.DTPRESTOT
    Friend WithEvents TotalLabel1 As Label
    Friend WithEvents PresupuestoLabel1 As Label
    Friend WithEvents RealLabel1 As Label
    Friend WithEvents OPORPeDBindingSource As BindingSource
    Friend WithEvents OPOR_TAPeD As ReqDSETTableAdapters.OPOR_TAPeD
    Friend WithEvents PedidoTextBox As TextBox
    Friend WithEvents OPDNEmercBindingSource As BindingSource
    Friend WithEvents OPDNTAmerc As ReqDSETTableAdapters.OPDNTAmerc
    Friend WithEvents Recibo_de_EntradaTextBox As TextBox
    Friend WithEvents OPCHFactBindingSource As BindingSource
    Friend WithEvents OPCHTAFact As ReqDSETTableAdapters.OPCHTAFact
    Friend WithEvents FacturaTextBox As TextBox
    Friend WithEvents CommCompBindingSource As BindingSource
    Friend WithEvents CommCompTA As ReqDSETTableAdapters.CommCompTA
    Friend WithEvents U_CS_AutComprasLabel1 As Label
    Friend WithEvents U_CS_ComentComprasLabel1 As Label
    Friend WithEvents CommJefeBindingSource As BindingSource
    Friend WithEvents CommJefeTA As ReqDSETTableAdapters.CommJefeTA
    Friend WithEvents U_CS_AutJefeLabel1 As Label
    Friend WithEvents U_CS_ComentJefeLabel1 As Label
    Friend WithEvents CommDirBindingSource As BindingSource
    Friend WithEvents CommDirTA As ReqDSETTableAdapters.CommDirTA
    Friend WithEvents U_CS_AutDirectorLabel1 As Label
    Friend WithEvents U_CS_ComentDirectorLabel1 As Label
    Friend WithEvents CommLuisBindingSource As BindingSource
    Friend WithEvents CommLuisTA As ReqDSETTableAdapters.CommLuisTA
    Friend WithEvents U_CS_AutLuisLabel1 As Label
    Friend WithEvents U_CS_ComentLuisLabel1 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Label15 As Label
    Friend WithEvents PRQ1TA As RequiCompras2_0.ReqDSETTableAdapters.PRQ1TA
    Friend WithEvents PRQ1TA1 As ReqDSETTableAdapters.PRQ1TA
    Friend WithEvents PreMensualBindingSource As BindingSource
    Friend WithEvents PreMensualTA As ReqDSETTableAdapters.PreMensualTA
    Friend WithEvents Label16 As Label
    Friend WithEvents TotalLabel3 As Label
    Friend WithEvents PresupuestoLabel3 As Label
    Friend WithEvents RealLabel3 As Label
    Friend WithEvents DVencidosTextBox As TextBox
End Class
