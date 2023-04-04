<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        MasterToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        KategoriBarangToolStripMenuItem = New ToolStripMenuItem()
        BarangToolStripMenuItem = New ToolStripMenuItem()
        TransaksiToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        STLabel1 = New ToolStripStatusLabel()
        STLabel2 = New ToolStripStatusLabel()
        STLabel3 = New ToolStripStatusLabel()
        STLabel4 = New ToolStripStatusLabel()
        STLabel6 = New ToolStripStatusLabel()
        STLabel7 = New ToolStripStatusLabel()
        STLabel8 = New ToolStripStatusLabel()
        STLabel9 = New ToolStripStatusLabel()
        STLabel10 = New ToolStripStatusLabel()
        Timer1 = New Timer(components)
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, MasterToolStripMenuItem, TransaksiToolStripMenuItem, LaporanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LoginToolStripMenuItem, LogoutToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "File"' 
        ' LoginToolStripMenuItem
        ' 
        LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        LoginToolStripMenuItem.Size = New Size(171, 34)
        LoginToolStripMenuItem.Text = "Login"' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(171, 34)
        LogoutToolStripMenuItem.Text = "Logout"' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(171, 34)
        ExitToolStripMenuItem.Text = "Exit"' 
        ' MasterToolStripMenuItem
        ' 
        MasterToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AdminToolStripMenuItem, KategoriBarangToolStripMenuItem, BarangToolStripMenuItem})
        MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        MasterToolStripMenuItem.Size = New Size(82, 29)
        MasterToolStripMenuItem.Text = "Master"' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(240, 34)
        AdminToolStripMenuItem.Text = "Admin"' 
        ' KategoriBarangToolStripMenuItem
        ' 
        KategoriBarangToolStripMenuItem.Name = "KategoriBarangToolStripMenuItem"
        KategoriBarangToolStripMenuItem.Size = New Size(240, 34)
        KategoriBarangToolStripMenuItem.Text = "Kategori Barang"' 
        ' BarangToolStripMenuItem
        ' 
        BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        BarangToolStripMenuItem.Size = New Size(240, 34)
        BarangToolStripMenuItem.Text = "Barang"' 
        ' TransaksiToolStripMenuItem
        ' 
        TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        TransaksiToolStripMenuItem.Size = New Size(98, 29)
        TransaksiToolStripMenuItem.Text = "Transaksi"' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(92, 29)
        LaporanToolStripMenuItem.Text = "Laporan"' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {STLabel1, STLabel2, STLabel3, STLabel4, STLabel6, STLabel7, STLabel8, STLabel9, STLabel10})
        StatusStrip1.Location = New Point(0, 418)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 32)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"' 
        ' STLabel1
        ' 
        STLabel1.Name = "STLabel1"
        STLabel1.Size = New Size(66, 25)
        STLabel1.Text = "KODE :"' 
        ' STLabel2
        ' 
        STLabel2.Name = "STLabel2"
        STLabel2.Size = New Size(0, 25)
        ' 
        ' STLabel3
        ' 
        STLabel3.Name = "STLabel3"
        STLabel3.Size = New Size(71, 25)
        STLabel3.Text = "NAME :"' 
        ' STLabel4
        ' 
        STLabel4.Name = "STLabel4"
        STLabel4.Size = New Size(0, 25)
        ' 
        ' STLabel6
        ' 
        STLabel6.Name = "STLabel6"
        STLabel6.Size = New Size(0, 25)
        ' 
        ' STLabel7
        ' 
        STLabel7.Name = "STLabel7"
        STLabel7.Size = New Size(55, 25)
        STLabel7.Text = "JAM :"' 
        ' STLabel8
        ' 
        STLabel8.Name = "STLabel8"
        STLabel8.Size = New Size(0, 25)
        ' 
        ' STLabel9
        ' 
        STLabel9.Name = "STLabel9"
        STLabel9.Size = New Size(98, 25)
        STLabel9.Text = "TANGGAL :"' 
        ' STLabel10
        ' 
        STLabel10.Name = "STLabel10"
        STLabel10.Size = New Size(0, 25)
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MenuMiniKasir"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KategoriBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents STLabel1 As ToolStripStatusLabel
    Friend WithEvents STLabel2 As ToolStripStatusLabel
    Friend WithEvents STLabel3 As ToolStripStatusLabel
    Friend WithEvents STLabel4 As ToolStripStatusLabel
    Friend WithEvents STLabel6 As ToolStripStatusLabel
    Friend WithEvents STLabel7 As ToolStripStatusLabel
    Friend WithEvents STLabel8 As ToolStripStatusLabel
    Friend WithEvents STLabel9 As ToolStripStatusLabel
    Friend WithEvents STLabel10 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
End Class
