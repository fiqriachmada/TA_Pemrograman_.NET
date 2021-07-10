Public Class Form2
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub AbsensiSiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsensiSiswaToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        sender = MsgBox("Absensi Siswa 2021", MsgBoxStyle.Information, "Pembuatan")
    End Sub
End Class