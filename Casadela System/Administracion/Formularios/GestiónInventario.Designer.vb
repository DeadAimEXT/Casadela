<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestiónInventario
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
        Dim IdMuebleLabel As System.Windows.Forms.Label
        Dim CostoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim IdApartamentoLabel As System.Windows.Forms.Label
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.DataSetcasadela = New Casadela_System.DataSetcasadela()
        Me.INVENTARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVENTARIOTableAdapter = New Casadela_System.DataSetcasadelaTableAdapters.INVENTARIOTableAdapter()
        Me.TableAdapterManager = New Casadela_System.DataSetcasadelaTableAdapters.TableAdapterManager()
        Me.IdMuebleSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.CostoSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DescripcionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IdApartamentoTextEdit = New DevExpress.XtraEditors.TextEdit()
        IdMuebleLabel = New System.Windows.Forms.Label()
        CostoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        IdApartamentoLabel = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.DataSetcasadela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdMuebleSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescripcionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdApartamentoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(IdMuebleLabel)
        Me.PanelControl1.Controls.Add(Me.IdMuebleSpinEdit)
        Me.PanelControl1.Controls.Add(CostoLabel)
        Me.PanelControl1.Controls.Add(Me.CostoSpinEdit)
        Me.PanelControl1.Controls.Add(DescripcionLabel)
        Me.PanelControl1.Controls.Add(Me.DescripcionTextEdit)
        Me.PanelControl1.Controls.Add(IdApartamentoLabel)
        Me.PanelControl1.Controls.Add(Me.IdApartamentoTextEdit)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(651, 403)
        Me.PanelControl1.TabIndex = 0
        '
        'DataSetcasadela
        '
        Me.DataSetcasadela.DataSetName = "DataSetcasadela"
        Me.DataSetcasadela.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INVENTARIOBindingSource
        '
        Me.INVENTARIOBindingSource.DataMember = "INVENTARIO"
        Me.INVENTARIOBindingSource.DataSource = Me.DataSetcasadela
        '
        'INVENTARIOTableAdapter
        '
        Me.INVENTARIOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.APARTAMENTOTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTETableAdapter = Nothing
        Me.TableAdapterManager.CONTRATOTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.INVENTARIOTableAdapter = Me.INVENTARIOTableAdapter
        Me.TableAdapterManager.SERVICIOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Casadela_System.DataSetcasadelaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdMuebleLabel
        '
        IdMuebleLabel.AutoSize = True
        IdMuebleLabel.Location = New System.Drawing.Point(37, 57)
        IdMuebleLabel.Name = "IdMuebleLabel"
        IdMuebleLabel.Size = New System.Drawing.Size(58, 13)
        IdMuebleLabel.TabIndex = 0
        IdMuebleLabel.Text = "Id Mueble:"
        '
        'IdMuebleSpinEdit
        '
        Me.IdMuebleSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INVENTARIOBindingSource, "IdMueble", True))
        Me.IdMuebleSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IdMuebleSpinEdit.Location = New System.Drawing.Point(130, 54)
        Me.IdMuebleSpinEdit.Name = "IdMuebleSpinEdit"
        Me.IdMuebleSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdMuebleSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.IdMuebleSpinEdit.TabIndex = 1
        '
        'CostoLabel
        '
        CostoLabel.AutoSize = True
        CostoLabel.Location = New System.Drawing.Point(37, 83)
        CostoLabel.Name = "CostoLabel"
        CostoLabel.Size = New System.Drawing.Size(39, 13)
        CostoLabel.TabIndex = 2
        CostoLabel.Text = "Costo:"
        '
        'CostoSpinEdit
        '
        Me.CostoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INVENTARIOBindingSource, "Costo", True))
        Me.CostoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CostoSpinEdit.Location = New System.Drawing.Point(130, 80)
        Me.CostoSpinEdit.Name = "CostoSpinEdit"
        Me.CostoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CostoSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.CostoSpinEdit.TabIndex = 3
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(37, 109)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(65, 13)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextEdit
        '
        Me.DescripcionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INVENTARIOBindingSource, "Descripcion", True))
        Me.DescripcionTextEdit.Location = New System.Drawing.Point(130, 106)
        Me.DescripcionTextEdit.Name = "DescripcionTextEdit"
        Me.DescripcionTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextEdit.TabIndex = 5
        '
        'IdApartamentoLabel
        '
        IdApartamentoLabel.AutoSize = True
        IdApartamentoLabel.Location = New System.Drawing.Point(37, 135)
        IdApartamentoLabel.Name = "IdApartamentoLabel"
        IdApartamentoLabel.Size = New System.Drawing.Size(87, 13)
        IdApartamentoLabel.TabIndex = 6
        IdApartamentoLabel.Text = "Id Apartamento:"
        '
        'IdApartamentoTextEdit
        '
        Me.IdApartamentoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INVENTARIOBindingSource, "IdApartamento", True))
        Me.IdApartamentoTextEdit.Location = New System.Drawing.Point(130, 132)
        Me.IdApartamentoTextEdit.Name = "IdApartamentoTextEdit"
        Me.IdApartamentoTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.IdApartamentoTextEdit.TabIndex = 7
        '
        'GestiónInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 415)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "GestiónInventario"
        Me.Text = "GestiónInventario"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.DataSetcasadela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdMuebleSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescripcionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdApartamentoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DataSetcasadela As DataSetcasadela
    Friend WithEvents INVENTARIOBindingSource As BindingSource
    Friend WithEvents INVENTARIOTableAdapter As DataSetcasadelaTableAdapters.INVENTARIOTableAdapter
    Friend WithEvents TableAdapterManager As DataSetcasadelaTableAdapters.TableAdapterManager
    Friend WithEvents IdMuebleSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CostoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DescripcionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IdApartamentoTextEdit As DevExpress.XtraEditors.TextEdit
End Class
