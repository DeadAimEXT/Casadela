Public Class ListarContrato
    Private Sub ListarContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetcasadela.CONTRATO' Puede moverla o quitarla según sea necesario.
        Me.CONTRATOTableAdapter.Fill(Me.DataSetcasadela.CONTRATO)

    End Sub
End Class