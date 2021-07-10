Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tb_username.Text = "Admin" And tb_password.Text = "Admin" Then

            Form2.ShowDialog()
            Me.Close()
        ElseIf tb_username.Text = "Siswa" And tb_password.Text = "Siswa" Then

            Form4.ShowDialog()
            Me.Close()
        Else
            If tb_username.Text = "" And tb_password.Text = "" Then
                MsgBox("Maaf Username atau Password Anda Salah!", MsgBoxStyle.Critical, "Login")
            Else
                If tb_username.Text = "" Then
                    MsgBox("Username Tidak Ditemukan!", MsgBoxStyle.Critical, "Error")
                Else
                    If tb_password.Text = "" Then
                        MsgBox("Password Salah!", MsgBoxStyle.Critical, "Error")
                    Else
                        MsgBox("Username atau Password Salah!", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
