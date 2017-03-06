Public Class ListarApartamento
    Private Sub ListarApartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetcasadela.APARTAMENTO' Puede moverla o quitarla según sea necesario.
        Me.APARTAMENTOTableAdapter.Fill(Me.DataSetcasadela.APARTAMENTO)

    End Sub
End Class