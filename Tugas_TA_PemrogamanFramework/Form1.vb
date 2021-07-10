Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tb_username.Text = "admin" And tb_password.Text = "admin" Then
            MsgBox("Berhasil Masuk!", MsgBoxStyle.Information, "Login")
            Form2.ShowDialog()
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
