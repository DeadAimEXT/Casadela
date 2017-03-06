<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestiónCliente
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim PrimerApellidoLabel As System.Windows.Forms.Label
        Dim SegundoApellidoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim IdTipoClienteLabel As System.Windows.Forms.Label
        Dim IdGeneroLabel As System.Windows.Forms.Label
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule5 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule6 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule7 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.IdClienteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetcasadela = New Casadela_System.DataSetcasadela()
        Me.NombreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PrimerApellidoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SegundoApellidoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CorreoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TelefonoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DireccionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IdTipoClienteSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.IdGeneroSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.CLIENTETableAdapter = New Casadela_System.DataSetcasadelaTableAdapters.CLIENTETableAdapter()
        Me.TableAdapterManager = New Casadela_System.DataSetcasadelaTableAdapters.TableAdapterManager()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        IdClienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        PrimerApellidoLabel = New System.Windows.Forms.Label()
        SegundoApellidoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        IdTipoClienteLabel = New System.Windows.Forms.Label()
        IdGeneroLabel = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.IdClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetcasadela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimerApellidoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SegundoApellidoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CorreoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DireccionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdTipoClienteSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdGeneroSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Location = New System.Drawing.Point(48, 12)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(57, 13)
        IdClienteLabel.TabIndex = 0
        IdClienteLabel.Text = "Id Cliente:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(48, 54)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(48, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'PrimerApellidoLabel
        '
        PrimerApellidoLabel.AutoSize = True
        PrimerApellidoLabel.Location = New System.Drawing.Point(48, 92)
        PrimerApellidoLabel.Name = "PrimerApellidoLabel"
        PrimerApellidoLabel.Size = New System.Drawing.Size(81, 13)
        PrimerApellidoLabel.TabIndex = 4
        PrimerApellidoLabel.Text = "Primer Apellido:"
        '
        'SegundoApellidoLabel
        '
        SegundoApellidoLabel.AutoSize = True
        SegundoApellidoLabel.Location = New System.Drawing.Point(48, 122)
        SegundoApellidoLabel.Name = "SegundoApellidoLabel"
        SegundoApellidoLabel.Size = New System.Drawing.Size(93, 13)
        SegundoApellidoLabel.TabIndex = 6
        SegundoApellidoLabel.Text = "Segundo Apellido:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Location = New System.Drawing.Point(48, 148)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(44, 13)
        CorreoLabel.TabIndex = 8
        CorreoLabel.Text = "Correo:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(52, 200)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(53, 13)
        TelefonoLabel.TabIndex = 10
        TelefonoLabel.Text = "Telefono:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(51, 174)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(54, 13)
        DireccionLabel.TabIndex = 12
        DireccionLabel.Text = "Direccion:"
        '
        'IdTipoClienteLabel
        '
        IdTipoClienteLabel.AutoSize = True
        IdTipoClienteLabel.Location = New System.Drawing.Point(48, 230)
        IdTipoClienteLabel.Name = "IdTipoClienteLabel"
        IdTipoClienteLabel.Size = New System.Drawing.Size(67, 13)
        IdTipoClienteLabel.TabIndex = 14
        IdTipoClienteLabel.Text = "Tipo Cliente:"
        '
        'IdGeneroLabel
        '
        IdGeneroLabel.AutoSize = True
        IdGeneroLabel.Location = New System.Drawing.Point(48, 256)
        IdGeneroLabel.Name = "IdGeneroLabel"
        IdGeneroLabel.Size = New System.Drawing.Size(46, 13)
        IdGeneroLabel.TabIndex = 16
        IdGeneroLabel.Text = "Genero:"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(IdClienteLabel)
        Me.PanelControl1.Controls.Add(Me.IdClienteTextEdit)
        Me.PanelControl1.Controls.Add(NombreLabel)
        Me.PanelControl1.Controls.Add(Me.NombreTextEdit)
        Me.PanelControl1.Controls.Add(PrimerApellidoLabel)
        Me.PanelControl1.Controls.Add(Me.PrimerApellidoTextEdit)
        Me.PanelControl1.Controls.Add(SegundoApellidoLabel)
        Me.PanelControl1.Controls.Add(Me.SegundoApellidoTextEdit)
        Me.PanelControl1.Controls.Add(CorreoLabel)
        Me.PanelControl1.Controls.Add(Me.CorreoTextEdit)
        Me.PanelControl1.Controls.Add(TelefonoLabel)
        Me.PanelControl1.Controls.Add(Me.TelefonoTextEdit)
        Me.PanelControl1.Controls.Add(DireccionLabel)
        Me.PanelControl1.Controls.Add(Me.DireccionTextEdit)
        Me.PanelControl1.Controls.Add(IdTipoClienteLabel)
        Me.PanelControl1.Controls.Add(Me.IdTipoClienteSpinEdit)
        Me.PanelControl1.Controls.Add(IdGeneroLabel)
        Me.PanelControl1.Controls.Add(Me.IdGeneroSpinEdit)
        Me.PanelControl1.Location = New System.Drawing.Point(33, 64)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(837, 329)
        Me.PanelControl1.TabIndex = 0
        '
        'IdClienteTextEdit
        '
        Me.IdClienteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTEBindingSource, "IdCliente", True))
        Me.IdClienteTextEdit.Location = New System.Drawing.Point(152, 9)
        Me.IdClienteTextEdit.Name = "IdClienteTextEdit"
        Me.IdClienteTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.IdClienteTextEdit.TabIndex = 1
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.IdClienteTextEdit, ConditionValidationRule1)
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
        'NombreTextEdit
        '
        Me.NombreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTEBindingSource, "Nombre", True))
        Me.NombreTextEdit.Location = New System.Drawing.Point(152, 51)
        Me.NombreTextEdit.Name = "NombreTextEdit"
        Me.NombreTextEdit.Size = New System.Drawing.Size(284, 20)
        Me.NombreTextEdit.TabIndex = 3
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.NombreTextEdit, ConditionValidationRule2)
        '
        'PrimerApellidoTextEdit
        '
        Me.PrimerApellidoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTEBindingSource, "PrimerApellido", True))
        Me.PrimerApellidoTextEdit.Location = New System.Drawing.Point(152, 89)
        Me.PrimerApellidoTextEdit.Name = "PrimerApellidoTextEdit"
        Me.PrimerApellidoTextEdit.Size = New System.Drawing.Size(284, 20)
        Me.PrimerApellidoTextEdit.TabIndex = 5
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsBlank
        ConditionValidationRule3.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.PrimerApellidoTextEdit, ConditionValidationRule3)
        '
        'SegundoApellidoTextEdit
        '
        Me.SegundoApellidoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTEBindingSource, "SegundoApellido", True))
        Me.SegundoApellidoTextEdit.Location = New System.Drawing.Point(152, 119)
        Me.SegundoApellidoTextEdit.Name = "SegundoApellidoTextEdit"
        Me.SegundoApellidoTextEdit.Size = New System.Drawing.Size(284, 20)
        Me.SegundoApellidoTextEdit.TabIndex = 7
        '
        'CorreoTextEdit
        '
        Me.CorreoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTEBindingSource, "Correo", True))
        Me.CorreoTextEdit.Location = New System.Drawing.Point(152, 145)
        Me.CorreoTextEdit.Name = "CorreoTextEdit"
        Me.CorreoTextEdit.Size = New System.Drawing.Size(284, 20)
        Me.CorreoTextEdit.TabIndex = 9
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.CorreoTextEdit, ConditionValidationRule4)
        '
        'TelefonoTextEdit
        '
        Me.TelefonoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTEBindingSource, "Telefono", True))
        Me.TelefonoTextEdit.Location = New System.Drawing.Point(152, 197)
        Me.TelefonoTextEdit.Name = "TelefonoTextEdit"
        Me.TelefonoTextEdit.Size = New System.Drawing.Size(129, 20)
        Me.TelefonoTextEdit.TabIndex = 11
        '
        'DireccionTextEdit
        '
        Me.DireccionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTEBindingSource, "Direccion", True))
        Me.DireccionTextEdit.Location = New System.Drawing.Point(152, 171)
        Me.DireccionTextEdit.Name = "DireccionTextEdit"
        Me.DireccionTextEdit.Size = New System.Drawing.Size(284, 20)
        Me.DireccionTextEdit.TabIndex = 13
        ConditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule5.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.DireccionTextEdit, ConditionValidationRule5)
        '
        'IdTipoClienteSpinEdit
        '
        Me.IdTipoClienteSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTEBindingSource, "IdTipoCliente", True))
        Me.IdTipoClienteSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IdTipoClienteSpinEdit.Location = New System.Drawing.Point(152, 227)
        Me.IdTipoClienteSpinEdit.Name = "IdTipoClienteSpinEdit"
        Me.IdTipoClienteSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdTipoClienteSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.IdTipoClienteSpinEdit.TabIndex = 15
        ConditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule6.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.IdTipoClienteSpinEdit, ConditionValidationRule6)
        '
        'IdGeneroSpinEdit
        '
        Me.IdGeneroSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTEBindingSource, "IdGenero", True))
        Me.IdGeneroSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IdGeneroSpinEdit.Location = New System.Drawing.Point(152, 253)
        Me.IdGeneroSpinEdit.Name = "IdGeneroSpinEdit"
        Me.IdGeneroSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdGeneroSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.IdGeneroSpinEdit.TabIndex = 17
        ConditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule7.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.IdGeneroSpinEdit, ConditionValidationRule7)
        '
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.APARTAMENTOTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTETableAdapter = Me.CLIENTETableAdapter
        Me.TableAdapterManager.CONTRATOTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.INVENTARIOTableAdapter = Nothing
        Me.TableAdapterManager.SERVICIOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Casadela_System.DataSetcasadelaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2})
        Me.BarManager1.MaxItemId = 2
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Barra de estado"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Agregar"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(923, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 400)
        Me.barDockControlBottom.Size = New System.Drawing.Size(923, 26)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 376)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(923, 24)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 376)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Agregar"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'GestiónCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 426)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "GestiónCliente"
        Me.Text = "GestiónCliente"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.IdClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetcasadela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimerApellidoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SegundoApellidoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CorreoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DireccionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdTipoClienteSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdGeneroSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DataSetcasadela As DataSetcasadela
    Friend WithEvents CLIENTEBindingSource As BindingSource
    Friend WithEvents CLIENTETableAdapter As DataSetcasadelaTableAdapters.CLIENTETableAdapter
    Friend WithEvents TableAdapterManager As DataSetcasadelaTableAdapters.TableAdapterManager
    Friend WithEvents IdClienteTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents NombreTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PrimerApellidoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SegundoApellidoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CorreoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TelefonoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DireccionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IdTipoClienteSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents IdGeneroSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
