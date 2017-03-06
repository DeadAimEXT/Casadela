Imports DevExpress.XtraBars

Public Class MenuPrincipal

    Public Sub gestionarimagen()
        If XtraTabbedMdiManager1.Pages.Count = 0 Then
            PictureEdit1.Visible = True
        Else
            PictureEdit1.Visible = False
        End If
    End Sub

    Private Sub XtraTabbedMdiManager1_PageAdded(sender As Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageAdded
        gestionarimagen()
    End Sub

    Private Sub XtraTabbedMdiManager1_PageRemoved(sender As Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageRemoved
        gestionarimagen()
    End Sub



    Public cerrar As Boolean = False
    Private Sub Menuprincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not cerrar Then
            e.Cancel = True
            MsgBox("Cierre con el boton salir", vbInformation, "COP || Aviso")

        End If
    End Sub

    Private Sub CierroFormularioscambio()
        Dim listaformas As New List(Of Form)
        For Each Form As System.Windows.Forms.Form In System.Windows.Forms.Application.OpenForms
            If Not Form.Name = "FrmInicioSesion" Then
                listaformas.Add(Form)
            End If
        Next
        For Each Form As System.Windows.Forms.Form In listaformas.ToList()
            If Not Form.IsMdiContainer = True Then
                Form.Close()

            End If
        Next
    End Sub

    Private Sub Menuprincipal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If WindowState <> FormWindowState.Maximized Then
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Const WM_NCLBUTTONDBLCLK As Integer = &HA3

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then
            Return
        End If

        MyBase.WndProc(m)
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim da As New ListarEmpleado
        da.MdiParent = Me
        da.Show()

    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub barcerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles barcerrar.ItemClick
        cerrar = True
        If MsgBox("Esta seguro que desea finalizar la sesión", MsgBoxStyle.YesNo, "COP || AVISO") = MsgBoxResult.Yes Then
            ' AuditoriaAccesoCerrar()
            Close()
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim da As New ListarInventario
        da.MdiParent = Me
        da.Show()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim da As New ListarCliente
        da.MdiParent = Me
        da.Show()
    End Sub

    Private Sub partamento_ItemClick(sender As Object, e As ItemClickEventArgs) Handles partamento.ItemClick
        Dim da As New ListarApartamento
        da.MdiParent = Me
        da.Show()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim da As New ListarServicio
        da.MdiParent = Me
        da.Show()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Dim da As New ListarContrato
        da.MdiParent = Me
        da.Show()

    End Sub

    Private Sub PictureEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles PictureEdit1.EditValueChanged

    End Sub
End Class