Public Class FrmClientes
    Private Sub FrmGestiónCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetcasadela.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.DataSetcasadela.CLIENTE)

    End Sub
End Class