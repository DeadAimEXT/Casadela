Public Class ListarInventario
    Private Sub ListarInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetcasadela.INVENTARIO' Puede moverla o quitarla según sea necesario.
        Me.INVENTARIOTableAdapter.Fill(Me.DataSetcasadela.INVENTARIO)

    End Sub
End Class