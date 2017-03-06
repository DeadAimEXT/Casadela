Public Class ListarServicio
    Private Sub ListarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetcasadela.SERVICIO' Puede moverla o quitarla según sea necesario.
        Me.SERVICIOTableAdapter.Fill(Me.DataSetcasadela.SERVICIO)

    End Sub
End Class