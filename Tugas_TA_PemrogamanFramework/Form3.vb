Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_adminDataSet1.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter1.Fill(Me.Db_adminDataSet1.Table1)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        On Error GoTo SaveErr
        Table1BindingSource1.EndEdit()
        Table1TableAdapter1.Update(Db_adminDataSet1.Table1)
        MsgBox("Data Telah Tersimpan")
SaveErr:
        Exit Sub
    End Sub


    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Table1BindingSource1.AddNew()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Table1BindingSource1.RemoveCurrent()
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        Table1BindingSource1.MovePrevious()
    End Sub

    Private Sub btn_lanjut_Click(sender As Object, e As EventArgs) Handles btn_lanjut.Click
        Table1BindingSource1.MoveNext()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form_Enter(sender As Object, e As EventArgs) Handles Form.Enter

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class