<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetcasadela = New Casadela_System.DataSetcasadela()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrimerApellido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSegundoApellido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCorreo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdTipoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdGenero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENTETableAdapter = New Casadela_System.DataSetcasadelaTableAdapters.CLIENTETableAdapter()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetcasadela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelControl1.Controls.Add(Me.GridControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 112)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(606, 329)
        Me.PanelControl1.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.CLIENTEBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(73, 82)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(400, 200)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.DataSetcasadela
        '
        'DataSetcasadela
        '
        Me.DataSetcasadela.DataSetName = "DataSetcasadela"
        Me.DataSetcasadela.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdCliente, Me.colNombre, Me.colPrimerApellido, Me.colSegundoApellido, Me.colCorreo, Me.colTelefono, Me.colDireccion, Me.colIdTipoCliente, Me.colIdGenero})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gestor De Cliente"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        '
        'colIdCliente
        '
        Me.colIdCliente.FieldName = "IdCliente"
        Me.colIdCliente.Name = "colIdCliente"
        Me.colIdCliente.Visible = True
        Me.colIdCliente.VisibleIndex = 0
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        '
        'colPrimerApellido
        '
        Me.colPrimerApellido.FieldName = "PrimerApellido"
        Me.colPrimerApellido.Name = "colPrimerApellido"
        Me.colPrimerApellido.Visible = True
        Me.colPrimerApellido.VisibleIndex = 2
        '
        'colSegundoApellido
        '
        Me.colSegundoApellido.FieldName = "SegundoApellido"
        Me.colSegundoApellido.Name = "colSegundoApellido"
        Me.colSegundoApellido.Visible = True
        Me.colSegundoApellido.VisibleIndex = 3
        '
        'colCorreo
        '
        Me.colCorreo.FieldName = "Correo"
        Me.colCorreo.Name = "colCorreo"
        Me.colCorreo.Visible = True
        Me.colCorreo.VisibleIndex = 4
        '
        'colTelefono
        '
        Me.colTelefono.FieldName = "Telefono"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.Visible = True
        Me.colTelefono.VisibleIndex = 5
        '
        'colDireccion
        '
        Me.colDireccion.FieldName = "Direccion"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 6
        '
        'colIdTipoCliente
        '
        Me.colIdTipoCliente.FieldName = "IdTipoCliente"
        Me.colIdTipoCliente.Name = "colIdTipoCliente"
        Me.colIdTipoCliente.Visible = True
        Me.colIdTipoCliente.VisibleIndex = 7
        '
        'colIdGenero
        '
        Me.colIdGenero.FieldName = "IdGenero"
        Me.colIdGenero.Name = "colIdGenero"
        Me.colIdGenero.Visible = True
        Me.colIdGenero.VisibleIndex = 8
        '
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 453)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmClientes"
        Me.Text = "FrmGestiónCliente"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetcasadela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSetcasadela As DataSetcasadela
    Friend WithEvents CLIENTEBindingSource As BindingSource
    Friend WithEvents CLIENTETableAdapter As DataSetcasadelaTableAdapters.CLIENTETableAdapter
    Friend WithEvents colIdCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrimerApellido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSegundoApellido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCorreo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdTipoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdGenero As DevExpress.XtraGrid.Columns.GridColumn
End Class
