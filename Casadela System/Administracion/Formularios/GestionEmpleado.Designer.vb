<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionEmpleado
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
        Dim IdEmpleadoLabel As System.Windows.Forms.Label
        Dim NombreEmpleadoLabel As System.Windows.Forms.Label
        Dim ApellidoEmpleadoLabel As System.Windows.Forms.Label
        Dim CodigoEmpleadoLabel As System.Windows.Forms.Label
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DataSetcasadela = New Casadela_System.DataSetcasadela()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New Casadela_System.DataSetcasadelaTableAdapters.EmpleadoTableAdapter()
        Me.TableAdapterManager = New Casadela_System.DataSetcasadelaTableAdapters.TableAdapterManager()
        Me.IdEmpleadoSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.NombreEmpleadoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ApellidoEmpleadoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CodigoEmpleadoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        IdEmpleadoLabel = New System.Windows.Forms.Label()
        NombreEmpleadoLabel = New System.Windows.Forms.Label()
        ApellidoEmpleadoLabel = New System.Windows.Forms.Label()
        CodigoEmpleadoLabel = New System.Windows.Forms.Label()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetcasadela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdEmpleadoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreEmpleadoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApellidoEmpleadoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigoEmpleadoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdEmpleadoLabel
        '
        IdEmpleadoLabel.AutoSize = True
        IdEmpleadoLabel.Location = New System.Drawing.Point(381, 88)
        IdEmpleadoLabel.Name = "IdEmpleadoLabel"
        IdEmpleadoLabel.Size = New System.Drawing.Size(70, 13)
        IdEmpleadoLabel.TabIndex = 6
        IdEmpleadoLabel.Text = "Id Empleado:"
        '
        'NombreEmpleadoLabel
        '
        NombreEmpleadoLabel.AutoSize = True
        NombreEmpleadoLabel.Location = New System.Drawing.Point(5, 33)
        NombreEmpleadoLabel.Name = "NombreEmpleadoLabel"
        NombreEmpleadoLabel.Size = New System.Drawing.Size(97, 13)
        NombreEmpleadoLabel.TabIndex = 8
        NombreEmpleadoLabel.Text = "Nombre Empleado:"
        '
        'ApellidoEmpleadoLabel
        '
        ApellidoEmpleadoLabel.AutoSize = True
        ApellidoEmpleadoLabel.Location = New System.Drawing.Point(5, 59)
        ApellidoEmpleadoLabel.Name = "ApellidoEmpleadoLabel"
        ApellidoEmpleadoLabel.Size = New System.Drawing.Size(97, 13)
        ApellidoEmpleadoLabel.TabIndex = 10
        ApellidoEmpleadoLabel.Text = "Apellido Empleado:"
        '
        'CodigoEmpleadoLabel
        '
        CodigoEmpleadoLabel.AutoSize = True
        CodigoEmpleadoLabel.Location = New System.Drawing.Point(5, 85)
        CodigoEmpleadoLabel.Name = "CodigoEmpleadoLabel"
        CodigoEmpleadoLabel.Size = New System.Drawing.Size(93, 13)
        CodigoEmpleadoLabel.TabIndex = 12
        CodigoEmpleadoLabel.Text = "Codigo Empleado:"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Herramientas"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Barra de estado"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Barra de estado"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Guardar"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(607, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 217)
        Me.barDockControlBottom.Size = New System.Drawing.Size(607, 26)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 193)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(607, 24)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 193)
        '
        'DataSetcasadela
        '
        Me.DataSetcasadela.DataSetName = "DataSetcasadela"
        Me.DataSetcasadela.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.DataSetcasadela
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpleadoTableAdapter = Me.EmpleadoTableAdapter
        Me.TableAdapterManager.UpdateOrder = Casadela_System.DataSetcasadelaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdEmpleadoSpinEdit
        '
        Me.IdEmpleadoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpleadoBindingSource, "IdEmpleado", True))
        Me.IdEmpleadoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IdEmpleadoSpinEdit.Location = New System.Drawing.Point(384, 104)
        Me.IdEmpleadoSpinEdit.MenuManager = Me.BarManager1
        Me.IdEmpleadoSpinEdit.Name = "IdEmpleadoSpinEdit"
        Me.IdEmpleadoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdEmpleadoSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.IdEmpleadoSpinEdit.TabIndex = 7
        '
        'NombreEmpleadoTextEdit
        '
        Me.NombreEmpleadoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpleadoBindingSource, "NombreEmpleado", True))
        Me.NombreEmpleadoTextEdit.Location = New System.Drawing.Point(108, 30)
        Me.NombreEmpleadoTextEdit.MenuManager = Me.BarManager1
        Me.NombreEmpleadoTextEdit.Name = "NombreEmpleadoTextEdit"
        Me.NombreEmpleadoTextEdit.Size = New System.Drawing.Size(184, 20)
        Me.NombreEmpleadoTextEdit.TabIndex = 9
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Ingresar Nombre Empleado"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.DxValidationProvider1.SetValidationRule(Me.NombreEmpleadoTextEdit, ConditionValidationRule1)
        '
        'ApellidoEmpleadoTextEdit
        '
        Me.ApellidoEmpleadoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpleadoBindingSource, "ApellidoEmpleado", True))
        Me.ApellidoEmpleadoTextEdit.Location = New System.Drawing.Point(108, 56)
        Me.ApellidoEmpleadoTextEdit.MenuManager = Me.BarManager1
        Me.ApellidoEmpleadoTextEdit.Name = "ApellidoEmpleadoTextEdit"
        Me.ApellidoEmpleadoTextEdit.Size = New System.Drawing.Size(184, 20)
        Me.ApellidoEmpleadoTextEdit.TabIndex = 11
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Ingresar Apellido"
        ConditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.DxValidationProvider1.SetValidationRule(Me.ApellidoEmpleadoTextEdit, ConditionValidationRule2)
        '
        'CodigoEmpleadoTextEdit
        '
        Me.CodigoEmpleadoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmpleadoBindingSource, "CodigoEmpleado", True))
        Me.CodigoEmpleadoTextEdit.Location = New System.Drawing.Point(108, 82)
        Me.CodigoEmpleadoTextEdit.MenuManager = Me.BarManager1
        Me.CodigoEmpleadoTextEdit.Name = "CodigoEmpleadoTextEdit"
        Me.CodigoEmpleadoTextEdit.Size = New System.Drawing.Size(184, 20)
        Me.CodigoEmpleadoTextEdit.TabIndex = 13
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Ingresar Codigo Empleado"
        ConditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.DxValidationProvider1.SetValidationRule(Me.CodigoEmpleadoTextEdit, ConditionValidationRule3)
        '
        'DxValidationProvider1
        '
        '
        'GestionEmpleado
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 243)
        Me.Controls.Add(IdEmpleadoLabel)
        Me.Controls.Add(Me.IdEmpleadoSpinEdit)
        Me.Controls.Add(NombreEmpleadoLabel)
        Me.Controls.Add(Me.NombreEmpleadoTextEdit)
        Me.Controls.Add(ApellidoEmpleadoLabel)
        Me.Controls.Add(Me.ApellidoEmpleadoTextEdit)
        Me.Controls.Add(CodigoEmpleadoLabel)
        Me.Controls.Add(Me.CodigoEmpleadoTextEdit)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "GestionEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CS || Gestión Empleado"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetcasadela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdEmpleadoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreEmpleadoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApellidoEmpleadoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigoEmpleadoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents DataSetcasadela As DataSetcasadela
    Friend WithEvents EmpleadoTableAdapter As DataSetcasadelaTableAdapters.EmpleadoTableAdapter
    Friend WithEvents TableAdapterManager As DataSetcasadelaTableAdapters.TableAdapterManager
    Friend WithEvents IdEmpleadoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents NombreEmpleadoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ApellidoEmpleadoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CodigoEmpleadoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
