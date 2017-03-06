Public Class ListarEmpleado
    Private Sub ListarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargardatos()
    End Sub

    Public Sub cargardatos()
        'TODO: esta línea de código carga datos en la tabla 'DataSetcasadela.Sp_MostrarEmpleado' Puede moverla o quitarla según sea necesario.
        Me.Sp_MostrarEmpleadoTableAdapter.Fill(Me.DataSetcasadela.Sp_MostrarEmpleado)
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        PasameValores()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim frm As New GestionEmpleado

        If frm.ShowDialog = DialogResult.OK Then
            cargardatos()
        End If
    End Sub

    Public Sub PasameValores()

        Try
            Dim Form As New GestionEmpleado


            Form.esnuevo = False

            Form.Id = CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdEmpleado)) 'AQUI EL NOMBRE DE LA COLUMNA


            If Form.ShowDialog = DialogResult.OK Then
                cargardatos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
End Class