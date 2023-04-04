
Imports System.Data.OleDb
Public Class TransaksiPenjualanBarangForm
    Sub KondisiAwal()
        LBNamaBarang.Text = ""
        LBHargaBarang.Text = ""
        TBJumlahBarang.Text = ""
        LBTanggal.Text = Today
        LBAdmin.Text = Form1.STLabel4.Text
        LBSisa.Text = ""
        LBJam.Text = TimeOfDay
        LBitem.Text = ""
        Call MunculKodebarang()
        Call BuatData()
        Label9.Text = "0"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LBSisa.Text = "" Or Label9.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Transaksi Tidak Ada, Silakukan Transaksi Terlebih Dahulu")
        Else
            Dim simpanjual As String = "insert into Penjualan values ('" & LBNomorJual.Text & "', '" & LBTanggal.Text & "','" & LBJam.Text & "','" & LBitem.Text & "','" & Label9.Text & "','" & TextBox1.Text & "','" & LBSisa.Text & "','" & LBAdmin.Text & "')"
            CMD = New OleDbCommand(simpanjual, CONN)
            CMD.ExecuteNonQuery()

            Call KondisiAwal()
            MsgBox("Transaksi Berhasil Disimoan")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBJam.Text = TimeOfDay
    End Sub

    Private Sub TransaksiPenjualanBarangForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call NomorOtomatis()

    End Sub

    Sub MunculKodebarang()
        Call koneksi()
        CMD = New OleDbCommand("select * from Barang", CONN)
        DR = CMD.ExecuteReader
        Do While DR.Read
            ComboBox1.Items.Add(DR.Item(0))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call koneksi()
        CMD = New OleDbCommand("select * from Barang where KodeBarang ='" & ComboBox1.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            LBNamaBarang.Text = DR!NamaBarang
            LBHargaBarang.Text = DR!HargaBarang
            'LBJumlahBarang.Text = DR!JumlahBarang
        Else
            MsgBox("Data Barang Tidak Ada!")
        End If
    End Sub

    Sub NomorOtomatis()
        Call koneksi()
        CMD = New OleDbCommand("select * from Penjualan where NoJual in (select max(NoJual) from Penjualan)", CONN)
        Dim UrutanKode As String
        Dim Hitung As Integer
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            UrutanKode = "J" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 3) + 1
            UrutanKode = "J" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBNomorJual.Text = UrutanKode
    End Sub
    Sub BuatData()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode")
        DataGridView1.Columns.Add("Nama", "Nama Barang")
        DataGridView1.Columns.Add("Harga", "Harga Barang")
        DataGridView1.Columns.Add("Jumlah", "Jumlah Barang")
        DataGridView1.Columns.Add("Subtotal", "Subtotal")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ComboBox1.Text = "" Or TBJumlahBarang.Text = "" Then
            MsgBox("Silahkan Pilih Kode Barang dan Masukkan Jumlah Barang!")
        Else
            DataGridView1.Rows.Add(New String() {ComboBox1.Text, LBNamaBarang.Text, LBHargaBarang.Text, TBJumlahBarang.Text, Val(LBHargaBarang.Text) * Val(TBJumlahBarang.Text)})
            Call RumusSubtotal()
            LBNamaBarang.Text = ""
            LBHargaBarang.Text = ""
            TBJumlahBarang.Text = ""
            Call rumuscariitem()
        End If
    End Sub

    Sub RumusSubtotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(4).Value
            Label9.Text = hitung
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox1.Text) < Val(Label9.Text) Then
                MsgBox("Pembayaran Kurang!")
            ElseIf Val(TextBox1.Text) = Val(Label9.Text) Then
                LBSisa.Text = 0
            ElseIf Val(TextBox1.Text) > Val(Label9.Text) Then
                LBSisa.Text = Val(TextBox1.Text) - Val(Label9.Text)
                Button1.Focus()
            End If
        End If
    End Sub

    Sub rumuscariitem()
        Dim hitungitem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitungitem = hitungitem + DataGridView1.Rows(i).Cells(3).Value
            LBitem.Text = hitungitem
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class