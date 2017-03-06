<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestiónContrato
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
        Dim IdContratoLabel As System.Windows.Forms.Label
        Dim ConditionValidationRule6 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim FechaInicioLabel As System.Windows.Forms.Label
        Dim ConditionValidationRule7 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim FechaFinalLabel As System.Windows.Forms.Label
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim MensualidadLabel As System.Windows.Forms.Label
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim IdApartamentoLabel As System.Windows.Forms.Label
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataSetcasadela = New Casadela_System.DataSetcasadela()
        Me.CONTRATOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTRATOTableAdapter = New Casadela_System.DataSetcasadelaTableAdapters.CONTRATOTableAdapter()
        Me.TableAdapterManager = New Casadela_System.DataSetcasadelaTableAdapters.TableAdapterManager()
        Me.IdContratoSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.FechaInicioDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.FechaFinalDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.MensualidadSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.IdApartamentoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IdClienteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        IdContratoLabel = New System.Windows.Forms.Label()
        FechaInicioLabel = New System.Windows.Forms.Label()
        FechaFinalLabel = New System.Windows.Forms.Label()
        MensualidadLabel = New System.Windows.Forms.Label()
        IdApartamentoLabel = New System.Windows.Forms.Label()
        IdClienteLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataSetcasadela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRATOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdContratoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaInicioDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaInicioDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaFinalDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaFinalDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MensualidadSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdApartamentoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(IdContratoLabel)
        Me.Panel1.Controls.Add(Me.IdContratoSpinEdit)
        Me.Panel1.Controls.Add(FechaInicioLabel)
        Me.Panel1.Controls.Add(Me.FechaInicioDateEdit)
        Me.Panel1.Controls.Add(FechaFinalLabel)
        Me.Panel1.Controls.Add(Me.FechaFinalDateEdit)
        Me.Panel1.Controls.Add(MensualidadLabel)
        Me.Panel1.Controls.Add(Me.MensualidadSpinEdit)
        Me.Panel1.Controls.Add(IdApartamentoLabel)
        Me.Panel1.Controls.Add(Me.IdApartamentoTextEdit)
        Me.Panel1.Controls.Add(IdClienteLabel)
        Me.Panel1.Controls.Add(Me.IdClienteTextEdit)
        Me.Panel1.Location = New System.Drawing.Point(22, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(653, 272)
        Me.Panel1.TabIndex = 0
        '
        'DataSetcasadela
        '
        Me.DataSetcasadela.DataSetName = "DataSetcasadela"
        Me.DataSetcasadela.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONTRATOBindingSource
        '
        Me.CONTRATOBindingSource.DataMember = "CONTRATO"
        Me.CONTRATOBindingSource.DataSource = Me.DataSetcasadela
        '
        'CONTRATOTableAdapter
        '
        Me.CONTRATOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.APARTAMENTOTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTETableAdapter = Nothing
        Me.TableAdapterManager.CONTRATOTableAdapter = Me.CONTRATOTableAdapter
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.INVENTARIOTableAdapter = Nothing
        Me.TableAdapterManager.SERVICIOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Casadela_System.DataSetcasadelaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdContratoLabel
        '
        IdContratoLabel.AutoSize = True
        IdContratoLabel.Location = New System.Drawing.Point(3, 71)
        IdContratoLabel.Name = "IdContratoLabel"
        IdContratoLabel.Size = New System.Drawing.Size(67, 13)
        IdContratoLabel.TabIndex = 0
        IdContratoLabel.Text = "Id Contrato:"
        '
        'IdContratoSpinEdit
        '
        Me.IdContratoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONTRATOBindingSource, "IdContrato", True))
        Me.IdContratoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IdContratoSpinEdit.Location = New System.Drawing.Point(94, 68)
        Me.IdContratoSpinEdit.Name = "IdContratoSpinEdit"
        Me.IdContratoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdContratoSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.IdContratoSpinEdit.TabIndex = 1
        ConditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule6.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.IdContratoSpinEdit, ConditionValidationRule6)
        '
        'FechaInicioLabel
        '
        FechaInicioLabel.AutoSize = True
        FechaInicioLabel.Location = New System.Drawing.Point(236, 75)
        FechaInicioLabel.Name = "FechaInicioLabel"
        FechaInicioLabel.Size = New System.Drawing.Size(68, 13)
        FechaInicioLabel.TabIndex = 2
        FechaInicioLabel.Text = "Fecha Inicio:"
        '
        'FechaInicioDateEdit
        '
        Me.FechaInicioDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONTRATOBindingSource, "FechaInicio", True))
        Me.FechaInicioDateEdit.EditValue = Nothing
        Me.FechaInicioDateEdit.Location = New System.Drawing.Point(325, 72)
        Me.FechaInicioDateEdit.Name = "FechaInicioDateEdit"
        Me.FechaInicioDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaInicioDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaInicioDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.FechaInicioDateEdit.TabIndex = 3
        ConditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule7.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.FechaInicioDateEdit, ConditionValidationRule7)
        '
        'FechaFinalLabel
        '
        FechaFinalLabel.AutoSize = True
        FechaFinalLabel.Location = New System.Drawing.Point(449, 79)
        FechaFinalLabel.Name = "FechaFinalLabel"
        FechaFinalLabel.Size = New System.Drawing.Size(65, 13)
        FechaFinalLabel.TabIndex = 4
        FechaFinalLabel.Text = "Fecha Final:"
        '
        'FechaFinalDateEdit
        '
        Me.FechaFinalDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONTRATOBindingSource, "FechaFinal", True))
        Me.FechaFinalDateEdit.EditValue = Nothing
        Me.FechaFinalDateEdit.Location = New System.Drawing.Point(539, 76)
        Me.FechaFinalDateEdit.Name = "FechaFinalDateEdit"
        Me.FechaFinalDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaFinalDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaFinalDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.FechaFinalDateEdit.TabIndex = 5
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.FechaFinalDateEdit, ConditionValidationRule1)
        '
        'MensualidadLabel
        '
        MensualidadLabel.AutoSize = True
        MensualidadLabel.Location = New System.Drawing.Point(124, 146)
        MensualidadLabel.Name = "MensualidadLabel"
        MensualidadLabel.Size = New System.Drawing.Size(70, 13)
        MensualidadLabel.TabIndex = 6
        MensualidadLabel.Text = "Mensualidad:"
        '
        'MensualidadSpinEdit
        '
        Me.MensualidadSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONTRATOBindingSource, "Mensualidad", True))
        Me.MensualidadSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MensualidadSpinEdit.Location = New System.Drawing.Point(200, 143)
        Me.MensualidadSpinEdit.Name = "MensualidadSpinEdit"
        Me.MensualidadSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MensualidadSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.MensualidadSpinEdit.TabIndex = 7
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.MensualidadSpinEdit, ConditionValidationRule2)
        '
        'IdApartamentoLabel
        '
        IdApartamentoLabel.AutoSize = True
        IdApartamentoLabel.Location = New System.Drawing.Point(347, 146)
        IdApartamentoLabel.Name = "IdApartamentoLabel"
        IdApartamentoLabel.Size = New System.Drawing.Size(87, 13)
        IdApartamentoLabel.TabIndex = 8
        IdApartamentoLabel.Text = "Id Apartamento:"
        '
        'IdApartamentoTextEdit
        '
        Me.IdApartamentoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONTRATOBindingSource, "IdApartamento", True))
        Me.IdApartamentoTextEdit.Location = New System.Drawing.Point(440, 143)
        Me.IdApartamentoTextEdit.Name = "IdApartamentoTextEdit"
        Me.IdApartamentoTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.IdApartamentoTextEdit.TabIndex = 9
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.IdApartamentoTextEdit, ConditionValidationRule3)
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Location = New System.Drawing.Point(243, 201)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(57, 13)
        IdClienteLabel.TabIndex = 10
        IdClienteLabel.Text = "Id Cliente:"
        '
        'IdClienteTextEdit
        '
        Me.IdClienteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CONTRATOBindingSource, "IdCliente", True))
        Me.IdClienteTextEdit.Location = New System.Drawing.Point(325, 198)
        Me.IdClienteTextEdit.Name = "IdClienteTextEdit"
        Me.IdClienteTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.IdClienteTextEdit.TabIndex = 11
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "This value is not valid"
        Me.DxValidationProvider1.SetValidationRule(Me.IdClienteTextEdit, ConditionValidationRule4)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(780, 49)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 423)
        Me.barDockControlBottom.Size = New System.Drawing.Size(780, 26)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 49)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 374)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(780, 49)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 374)
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Herramientas"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Menú principal"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Menú principal"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Barra de estado"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Barra de estado"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Agregar"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'GestiónContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 449)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "GestiónContrato"
        Me.Text = "GestiónContrato"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataSetcasadela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRATOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdContratoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaInicioDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaInicioDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaFinalDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaFinalDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MensualidadSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdApartamentoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataSetcasadela As DataSetcasadela
    Friend WithEvents CONTRATOBindingSource As BindingSource
    Friend WithEvents CONTRATOTableAdapter As DataSetcasadelaTableAdapters.CONTRATOTableAdapter
    Friend WithEvents TableAdapterManager As DataSetcasadelaTableAdapters.TableAdapterManager
    Friend WithEvents IdContratoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FechaInicioDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FechaFinalDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents MensualidadSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents IdApartamentoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IdClienteTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
