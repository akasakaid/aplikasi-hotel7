Imports System.Data.SqlClient

Public Class UangControl

    Sub Start()
        Button1.Text = "Tambah"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Hapus"
        Button4.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Call ViewData()
    End Sub

    Sub ViewData()
        Koneksi.Open()
        Dim query As String = "SELECT * FROM tb_keuangan"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        Dim dataTable As New DataTable()
        dataTable.Load(reader)
        DataGridView1.DataSource = dataTable
        Koneksi.Close()
    End Sub
    Private Sub UangControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
