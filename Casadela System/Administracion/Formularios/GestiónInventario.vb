Public Class GestiónInventario
    Private Sub INVENTARIOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.INVENTARIOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetcasadela)

    End Sub

    Private Sub GestiónInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetcasadela.INVENTARIO' Puede moverla o quitarla según sea necesario.
        Me.INVENTARIOTableAdapter.Fill(Me.DataSetcasadela.INVENTARIO)

    End Sub
End Class