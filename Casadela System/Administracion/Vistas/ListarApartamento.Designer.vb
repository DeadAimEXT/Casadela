<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarApartamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListarApartamento))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DataSetcasadela = New Casadela_System.DataSetcasadela()
        Me.APARTAMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APARTAMENTOTableAdapter = New Casadela_System.DataSetcasadelaTableAdapters.APARTAMENTOTableAdapter()
        Me.colIdApartamento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumCuartos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisponibilidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdMunicipio = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetcasadela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APARTAMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.GridControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 30)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(651, 297)
        Me.PanelControl1.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(29, 5)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(89, 40)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Agregar"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.APARTAMENTOBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(5, 67)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(641, 225)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdApartamento, Me.colNumCuartos, Me.colDisponibilidad, Me.colDescripcion, Me.colIdMunicipio})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'DataSetcasadela
        '
        Me.DataSetcasadela.DataSetName = "DataSetcasadela"
        Me.DataSetcasadela.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'APARTAMENTOBindingSource
        '
        Me.APARTAMENTOBindingSource.DataMember = "APARTAMENTO"
        Me.APARTAMENTOBindingSource.DataSource = Me.DataSetcasadela
        '
        'APARTAMENTOTableAdapter
        '
        Me.APARTAMENTOTableAdapter.ClearBeforeFill = True
        '
        'colIdApartamento
        '
        Me.colIdApartamento.FieldName = "IdApartamento"
        Me.colIdApartamento.Name = "colIdApartamento"
        Me.colIdApartamento.Visible = True
        Me.colIdApartamento.VisibleIndex = 0
        '
        'colNumCuartos
        '
        Me.colNumCuartos.FieldName = "NumCuartos"
        Me.colNumCuartos.Name = "colNumCuartos"
        Me.colNumCuartos.Visible = True
        Me.colNumCuartos.VisibleIndex = 1
        '
        'colDisponibilidad
        '
        Me.colDisponibilidad.FieldName = "Disponibilidad"
        Me.colDisponibilidad.Name = "colDisponibilidad"
        Me.colDisponibilidad.Visible = True
        Me.colDisponibilidad.VisibleIndex = 2
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 3
        '
        'colIdMunicipio
        '
        Me.colIdMunicipio.FieldName = "IdMunicipio"
        Me.colIdMunicipio.Name = "colIdMunicipio"
        Me.colIdMunicipio.Visible = True
        Me.colIdMunicipio.VisibleIndex = 4
        '
        'ListarApartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 339)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "ListarApartamento"
        Me.Text = "ListarApartamento"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetcasadela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APARTAMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSetcasadela As DataSetcasadela
    Friend WithEvents APARTAMENTOBindingSource As BindingSource
    Friend WithEvents APARTAMENTOTableAdapter As DataSetcasadelaTableAdapters.APARTAMENTOTableAdapter
    Friend WithEvents colIdApartamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumCuartos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisponibilidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdMunicipio As DevExpress.XtraGrid.Columns.GridColumn
End Class
