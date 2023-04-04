
Imports System.Data.OleDb
Module Module1
    Public CONN As OleDbConnection
    Public DA As OleDbDataAdapter
    Public DS As DataSet
    Public DR As OleDbDataReader
    Public CMD As OleDbCommand
    Public lokasidata As String
    Public Sub koneksi()
        lokasidata = "provider=Microsoft.ACE.OLEDB.12.0;data source=DB_Minimarket.accdb"
        CONN = New OleDbConnection(lokasidata)
        If CONN.State = ConnectionState.Closed Then CONN.Open()
    End Sub
End Module
