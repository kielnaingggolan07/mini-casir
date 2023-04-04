Imports System.Data.OleDb

Public Class KategoriBarangForm
    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        munculgird()
    End Sub
    Sub munculgird()
        Call koneksi()
        DA = New OleDbDataAdapter("select KodeKategori,NamaKategori,KeteranganKategori from Kategori", CONN)
        DS = New DataSet
        DA.Fill(DS, "Kategori")
        DataGridView1.DataSource = DS.Tables("Kategori")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "Batal" Then
            Call kondisiawal()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            TextBox1.Focus()
            Call NomorOtomatis()
            TextBox1.Enabled = False
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Pastikan data diisi dengan lengkap!")
                Call kondisiawal()
            Else
                Call koneksi()
                Dim simpandata As String = "Insert into Kategori values ('" & TextBox1.Text & "', '" & TextBox2.Text & "','" & TextBox3.Text & "')"
                CMD = New OleDbCommand(simpandata, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di Tambahkan")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            CMD = New OleDbCommand("select * from Kategori where KodeKategori ='" & TextBox1.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                TextBox2.Text = DR.Item("NamaKategori")
                TextBox3.Text = DR.Item("KeteranganKategori")
            Else
                MsgBox("Data Tidak Ada")
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button2.Text = "Simpan"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Pastikan data diisi dengan lengkap!")
                Call kondisiawal()
            Else
                Call koneksi()
                Dim editdata As String = "Update Kategori set NamaKategori = '" & TextBox2.Text & "', KeteranganKategori='" & TextBox3.Text & "' where KodeKategori='" & TextBox1.Text & "'"
                CMD = New OleDbCommand(editdata, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di Update")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "Hapus" Then
            Button3.Text = "Hapus Data"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "Batal"
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Pastikan data diisi dengan lengkap!")
                Call kondisiawal()
            Else
                Call koneksi()
                Dim deletedata As String = "Delete from Kategori where KodeKategori='" & TextBox1.Text & "'"
                CMD = New OleDbCommand(deletedata, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di Delete")
                Call kondisiawal()
            End If
        End If
    End Sub
    Private Sub KategoriBarangForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub

    Sub NomorOtomatis()
        Call koneksi()
        CMD = New OleDbCommand("select * from Kategori where KodeKategori in (select max(KodeKategori) from Kategori)", CONN)
        Dim UrutanKode As String
        Dim Hitung As Integer
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            UrutanKode = "DR" + "0001"
        Else
            Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 4) + 1
            UrutanKode = "DR" + Microsoft.VisualBasic.Right("000" & Hitung, 4)
        End If
        TextBox1.Text = UrutanKode
    End Sub
End Class