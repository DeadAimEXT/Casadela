Imports System.Data.SqlClient
Public Class FrmInicioSesion
    Public idusuario As Integer
    Public IdUsuarioActual As Integer
    Public NombreUsuario As String
    Public Property EsInicio As Boolean = True
    Private Sub FrmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function ExisteRegistro() As Boolean

        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        Dim state As Boolean
        Try
            con.Open()

            Dim ListaUsuario As New SqlCommand("Sp_ExisteUsuario", con)
            ListaUsuario.CommandType = CommandType.StoredProcedure
            ListaUsuario.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = Trim(TextEdit1.Text)
            ListaUsuario.Parameters.Add("@Contraseña", SqlDbType.NVarChar, 50).Value = Trim(TextEdit2.Text)
            ListaUsuario.Connection = con


            IdUsuarioActual = Convert.ToInt32(ListaUsuario.ExecuteScalar())


            If IdUsuarioActual > 0 Then
                state = True
            Else
                state = False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
        Return state
    End Function

    Public Sub MostrarID()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try

            con.Open()

            Dim ListaUsuario As New SqlCommand("Sp_MostraID", con)
            ListaUsuario.CommandType = CommandType.StoredProcedure
            ListaUsuario.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = TextEdit1.Text

            Dim ListaUsuarios As SqlDataReader

            ListaUsuarios = ListaUsuario.ExecuteReader()

            If ListaUsuarios.Read Then
                NombreUsuario = ListaUsuarios("NombreUsuario").ToString
            End If

            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub TextEdit1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextEdit1.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try

            If ExisteRegistro() = False Then

                MsgBox("Usuario o contraseña incorrecta", MsgBoxStyle.Information, "CADELA || Aviso")
                TextEdit2.Text = Nothing
                TextEdit1.Text = Nothing
                TextEdit1.Focus()
            Else
                MostrarID()


                NombreUsuarioActual = NombreUsuario
                IdUsuarioSistemaActual = IdUsuarioActual

                DialogResult = DialogResult.OK

                If EsInicio = True Then
                    Hide()
                    verificarPermisos()

                    'AuditoriaAccesoEntrar()

                End If

                Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub verificarPermisos()


        'FrmMenuPrincipal.barnombreusuario.Caption = NombreUsuarioActual

        MenuPrincipal.Show()

    End Sub

End Class