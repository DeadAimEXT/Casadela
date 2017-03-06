Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors.ViewInfo
Public Class GestionEmpleado

    Public esnuevo As Boolean = True
    Public Id As Integer
    Private Sub GestionEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If esnuevo Then
            EmpleadoBindingSource.AddNew()

        Else
            EmpleadoTableAdapter.Fill(DataSetcasadela.Empleado, Id)
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Validate()
        If Not DxValidationProvider1.Validate() Then
            Exit Sub
        End If

        EmpleadoBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSetcasadela)

        DialogResult = DialogResult.OK
        Close()

    End Sub

    Private Sub validationProvider1_ValidationFailed(ByVal sender As Object, ByVal e As ValidationFailedEventArgs) Handles DxValidationProvider1.ValidationFailed
        Dim edit As BaseEdit = TryCast(e.InvalidControl, BaseEdit)
        If edit Is Nothing Then
            Return
        End If

        Dim viewInfo As BaseEditViewInfo = TryCast(edit.GetViewInfo(), BaseEditViewInfo)
        If viewInfo Is Nothing Then
            Return
        End If

        If edit.ToolTipController Is Nothing Then
            edit.ToolTipController = New ToolTipControllerDefault()
        End If

        Dim info As New ToolTipControlInfo(e.InvalidControl, e.ErrorText)
        info.ToolTipPosition = edit.PointToScreen(viewInfo.ErrorIconBounds.Location)

        edit.ToolTipController.InitialDelay = 0
        edit.ToolTipController.ShowHint(info)
    End Sub
End Class