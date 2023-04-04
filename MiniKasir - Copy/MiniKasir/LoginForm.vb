
Imports System.Data.OleDb

Public Class LoginForm

    Sub terbuka()
        Form1.LoginToolStripMenuItem.Enabled = False
        Form1.LogoutToolStripMenuItem.Enabled = True
        Form1.MasterToolStripMenuItem.Enabled = True
        Form1.TransaksiToolStripMenuItem.Enabled = True
        Form1.LaporanToolStripMenuItem.Enabled = True
    End Sub
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data Belum Lengkap, Silahkan Masukkan Data Login dan Password")
        Else
            Call koneksi()
            CMD = New OleDbCommand("select * from ADMIN where KodeAdmin ='" & TextBox1.Text & "' and PasswordAdmin = '" & TextBox2.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Me.Close()
                Call terbuka()
                Form1.STLabel2.Text = DR!kodeadmin
                Form1.STLabel4.Text = DR!namaadmin
            Else
                MsgBox("Kode Admin atau Password Salah")
            End If
        End If
    End Sub
End Class