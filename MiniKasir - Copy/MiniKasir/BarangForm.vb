Imports System.Data.OleDb
Public Class BarangForm
    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Label4.Text = ""
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        munculgird()
        Call munculkodekategori()
        Call munculsatuanbarang()
    End Sub
    Sub munculgird()
        Call koneksi()
        DA = New OleDbDataAdapter("select * from Barang", CONN)
        DS = New DataSet
        DA.Fill(DS, "Barang")
        DataGridView1.DataSource = DS.Tables("Barang")
    End Sub

    Private Sub BarangForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub
    Sub munculkodekategori()
        Call koneksi()
        'DA = New OleDbDataAdapter("select * from Kategori", CONN)
        'DS = New DataSet
        'DS.Clear()
        'DA.Fill(DS, "Kategori")
        ComboBox1.Items.Clear()
        CMD = New OleDbCommand("select * from Kategori", CONN)
        DR = CMD.ExecuteReader
        Do While DR.Read
            ComboBox1.Items.Add(DR.Item(0))
        Loop
    End Sub
    Sub munculsatuanbarang()
        Call koneksi()
        ComboBox2.Items.Clear()
        CMD = New OleDbCommand("select Distinct SatuanBarang from Barang", CONN)
        DR = CMD.ExecuteReader
        Do While DR.Read
            ComboBox2.Items.Add(DR.Item("SatuanBarang"))
        Loop
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
                MsgBox("Pastikan data diisi dengan lengkap!")
                Call kondisiawal()
            Else
                Call koneksi()
                Dim simpandata As String = "Insert into Barang values ('" & TextBox1.Text & "', '" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox2.Text & "')"
                CMD = New OleDbCommand(simpandata, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di Tambahkan")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call koneksi()
        CMD = New OleDbCommand("select * from Kategori where KodeKategori ='" & ComboBox1.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Label4.Text = DR.Item("NamaKategori")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button2.Text = "Simpan"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
                MsgBox("Pastikan data diisi dengan lengkap!")
                Call kondisiawal()
            Else
                Call koneksi()
                Dim editdata As String = "Update Barang set NamaBarang = '" & TextBox2.Text & "', KodeKategori='" & ComboBox1.Text & "', HargaBarang = '" & TextBox3.Text & "', JumlahBarang = '" & TextBox4.Text & "', SatuanBarang = '" & ComboBox2.Text & "' where KodeBarang='" & TextBox1.Text & "'"
                CMD = New OleDbCommand(editdata, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di Update")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            CMD = New OleDbCommand("select * from Barang where KodeBarang ='" & TextBox1.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                TextBox2.Text = DR.Item("NamaBarang")
                TextBox3.Text = DR.Item("HargaBarang")
                TextBox4.Text = DR.Item("JumlahBarang")
                ComboBox2.Text = DR.Item("SatuanBarang")
                ComboBox1.Text = DR.Item("KodeKategori")
            Else
                MsgBox("Data Tidak Ada")
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
                MsgBox("Pastikan data diisi dengan lengkap!")
                Call kondisiawal()
            Else
                Call koneksi()
                Dim deletedata As String = "Delete from Barang where KodeBarang='" & TextBox1.Text & "'"
                CMD = New OleDbCommand(deletedata, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di Delete")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "Batal" Then
            Call kondisiawal()
        Else
            Me.Close()
        End If
    End Sub

    Sub NomorOtomatis()
        Call koneksi()
        CMD = New OleDbCommand("select * from Barang where KodeBarang in (select max(KodeBarang) from Barang)", CONN)
        Dim UrutanKode As String
        Dim Hitung As Integer
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            UrutanKode = "SR" + "0001"
        Else
            Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 4) + 1
            UrutanKode = "SR" + Microsoft.VisualBasic.Right("000" & Hitung, 4)
        End If
        TextBox1.Text = UrutanKode
    End Sub
End Class