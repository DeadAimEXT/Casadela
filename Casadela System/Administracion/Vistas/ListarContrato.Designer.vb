<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarContrato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListarContrato))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.CONTRATOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetcasadela = New Casadela_System.DataSetcasadela()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdContrato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaInicio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaFinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMensualidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdApartamento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CONTRATOTableAdapter = New Casadela_System.DataSetcasadelaTableAdapters.CONTRATOTableAdapter()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRATOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetcasadela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.GridControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(13, 33)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(622, 298)
        Me.PanelControl1.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(5, 18)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(101, 39)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Agregar"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.CONTRATOBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(0, 70)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(622, 211)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CONTRATOBindingSource
        '
        Me.CONTRATOBindingSource.DataMember = "CONTRATO"
        Me.CONTRATOBindingSource.DataSource = Me.DataSetcasadela
        '
        'DataSetcasadela
        '
        Me.DataSetcasadela.DataSetName = "DataSetcasadela"
        Me.DataSetcasadela.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdContrato, Me.colFechaInicio, Me.colFechaFinal, Me.colMensualidad, Me.colIdApartamento, Me.colIdCliente})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colIdContrato
        '
        Me.colIdContrato.FieldName = "IdContrato"
        Me.colIdContrato.Name = "colIdContrato"
        Me.colIdContrato.Visible = True
        Me.colIdContrato.VisibleIndex = 0
        '
        'colFechaInicio
        '
        Me.colFechaInicio.FieldName = "FechaInicio"
        Me.colFechaInicio.Name = "colFechaInicio"
        Me.colFechaInicio.Visible = True
        Me.colFechaInicio.VisibleIndex = 1
        '
        'colFechaFinal
        '
        Me.colFechaFinal.FieldName = "FechaFinal"
        Me.colFechaFinal.Name = "colFechaFinal"
        Me.colFechaFinal.Visible = True
        Me.colFechaFinal.VisibleIndex = 2
        '
        'colMensualidad
        '
        Me.colMensualidad.FieldName = "Mensualidad"
        Me.colMensualidad.Name = "colMensualidad"
        Me.colMensualidad.Visible = True
        Me.colMensualidad.VisibleIndex = 3
        '
        'colIdApartamento
        '
        Me.colIdApartamento.FieldName = "IdApartamento"
        Me.colIdApartamento.Name = "colIdApartamento"
        Me.colIdApartamento.Visible = True
        Me.colIdApartamento.VisibleIndex = 4
        '
        'colIdCliente
        '
        Me.colIdCliente.FieldName = "IdCliente"
        Me.colIdCliente.Name = "colIdCliente"
        Me.colIdCliente.Visible = True
        Me.colIdCliente.VisibleIndex = 5
        '
        'CONTRATOTableAdapter
        '
        Me.CONTRATOTableAdapter.ClearBeforeFill = True
        '
        'ListarContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 343)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "ListarContrato"
        Me.Text = "ListarContrato"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRATOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetcasadela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataSetcasadela As DataSetcasadela
    Friend WithEvents CONTRATOBindingSource As BindingSource
    Friend WithEvents CONTRATOTableAdapter As DataSetcasadelaTableAdapters.CONTRATOTableAdapter
    Friend WithEvents colIdContrato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaInicio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMensualidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdApartamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdCliente As DevExpress.XtraGrid.Columns.GridColumn
End Class
