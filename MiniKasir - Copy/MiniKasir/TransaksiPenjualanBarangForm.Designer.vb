<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransaksiPenjualanBarangForm
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
        Label1 = New Label()
        LBNomorJual = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        LBTanggal = New Label()
        LBJam = New Label()
        LBAdmin = New Label()
        Label16 = New Label()
        Label9 = New Label()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        LBSisa = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label8 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        LBNamaBarang = New Label()
        LBHargaBarang = New Label()
        Button4 = New Button()
        Timer1 = New Timer(components)
        ComboBox1 = New ComboBox()
        TBJumlahBarang = New TextBox()
        Label4 = New Label()
        LBitem = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Location = New Point(32, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 35)
        Label1.TabIndex = 0
        Label1.Text = "Nomor Jual"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LBNomorJual
        ' 
        LBNomorJual.BorderStyle = BorderStyle.Fixed3D
        LBNomorJual.Location = New Point(221, 23)
        LBNomorJual.Name = "LBNomorJual"
        LBNomorJual.Size = New Size(190, 35)
        LBNomorJual.TabIndex = 5
        LBNomorJual.Text = "LBNomorJual"' 
        ' Label10
        ' 
        Label10.BorderStyle = BorderStyle.Fixed3D
        Label10.Location = New Point(602, 93)
        Label10.Name = "Label10"
        Label10.Size = New Size(169, 35)
        Label10.TabIndex = 10
        Label10.Text = "Tanggal"' 
        ' Label11
        ' 
        Label11.BorderStyle = BorderStyle.Fixed3D
        Label11.Location = New Point(602, 128)
        Label11.Name = "Label11"
        Label11.Size = New Size(169, 35)
        Label11.TabIndex = 11
        Label11.Text = "Jam"' 
        ' Label12
        ' 
        Label12.BorderStyle = BorderStyle.Fixed3D
        Label12.Location = New Point(602, 160)
        Label12.Name = "Label12"
        Label12.Size = New Size(169, 35)
        Label12.TabIndex = 12
        Label12.Text = "Admin"' 
        ' LBTanggal
        ' 
        LBTanggal.BorderStyle = BorderStyle.Fixed3D
        LBTanggal.Location = New Point(799, 93)
        LBTanggal.Name = "LBTanggal"
        LBTanggal.Size = New Size(190, 35)
        LBTanggal.TabIndex = 13
        LBTanggal.Text = "LBTanggal"' 
        ' LBJam
        ' 
        LBJam.BorderStyle = BorderStyle.Fixed3D
        LBJam.Location = New Point(799, 128)
        LBJam.Name = "LBJam"
        LBJam.Size = New Size(190, 35)
        LBJam.TabIndex = 14
        LBJam.Text = "LBJam"' 
        ' LBAdmin
        ' 
        LBAdmin.BorderStyle = BorderStyle.Fixed3D
        LBAdmin.Location = New Point(799, 162)
        LBAdmin.Name = "LBAdmin"
        LBAdmin.Size = New Size(190, 35)
        LBAdmin.TabIndex = 15
        LBAdmin.Text = "LBAdmin"' 
        ' Label16
        ' 
        Label16.BorderStyle = BorderStyle.Fixed3D
        Label16.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(432, 23)
        Label16.Name = "Label16"
        Label16.Size = New Size(159, 58)
        Label16.TabIndex = 16
        Label16.Text = "TOTAL : Rp."
        Label16.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.BorderStyle = BorderStyle.Fixed3D
        Label9.Font = New Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(602, 23)
        Label9.Name = "Label9"
        Label9.Size = New Size(387, 58)
        Label9.TabIndex = 17
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(32, 234)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(957, 246)
        DataGridView1.TabIndex = 18
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(32, 504)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 52)
        Button1.TabIndex = 19
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(169, 504)
        Button2.Name = "Button2"
        Button2.Size = New Size(113, 52)
        Button2.TabIndex = 20
        Button2.Text = "Batal"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(308, 504)
        Button3.Name = "Button3"
        Button3.Size = New Size(113, 52)
        Button3.TabIndex = 21
        Button3.Text = "Tutup"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Location = New Point(602, 504)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 35)
        Label2.TabIndex = 22
        Label2.Text = "Di Bayar"' 
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Location = New Point(602, 539)
        Label3.Name = "Label3"
        Label3.Size = New Size(169, 35)
        Label3.TabIndex = 23
        Label3.Text = "Sisa"' 
        ' LBSisa
        ' 
        LBSisa.BorderStyle = BorderStyle.Fixed3D
        LBSisa.Location = New Point(799, 539)
        LBSisa.Name = "LBSisa"
        LBSisa.Size = New Size(190, 35)
        LBSisa.TabIndex = 24
        LBSisa.Text = "LBSisa"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(799, 504)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(190, 31)
        TextBox1.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Location = New Point(32, 58)
        Label5.Name = "Label5"
        Label5.Size = New Size(172, 35)
        Label5.TabIndex = 26
        Label5.Text = "Kode Barang"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.BorderStyle = BorderStyle.Fixed3D
        Label8.Location = New Point(32, 93)
        Label8.Name = "Label8"
        Label8.Size = New Size(172, 35)
        Label8.TabIndex = 28
        Label8.Text = "Nama Barang"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label18
        ' 
        Label18.BorderStyle = BorderStyle.Fixed3D
        Label18.Location = New Point(32, 128)
        Label18.Name = "Label18"
        Label18.Size = New Size(172, 35)
        Label18.TabIndex = 30
        Label18.Text = "Harga Barang"
        Label18.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label19
        ' 
        Label19.BorderStyle = BorderStyle.Fixed3D
        Label19.Location = New Point(32, 163)
        Label19.Name = "Label19"
        Label19.Size = New Size(172, 35)
        Label19.TabIndex = 31
        Label19.Text = "Jumlah Barang"
        Label19.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LBNamaBarang
        ' 
        LBNamaBarang.BorderStyle = BorderStyle.Fixed3D
        LBNamaBarang.Location = New Point(221, 94)
        LBNamaBarang.Name = "LBNamaBarang"
        LBNamaBarang.Size = New Size(190, 35)
        LBNamaBarang.TabIndex = 29
        LBNamaBarang.Text = "LBNamaBarang"' 
        ' LBHargaBarang
        ' 
        LBHargaBarang.BorderStyle = BorderStyle.Fixed3D
        LBHargaBarang.Location = New Point(221, 128)
        LBHargaBarang.Name = "LBHargaBarang"
        LBHargaBarang.Size = New Size(190, 35)
        LBHargaBarang.TabIndex = 32
        LBHargaBarang.Text = "LBHargaBarang"' 
        ' Button4
        ' 
        Button4.Location = New Point(432, 93)
        Button4.Name = "Button4"
        Button4.Size = New Size(159, 105)
        Button4.TabIndex = 35
        Button4.Text = "Insert"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(221, 61)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(190, 33)
        ComboBox1.TabIndex = 36
        ' 
        ' TBJumlahBarang
        ' 
        TBJumlahBarang.Location = New Point(221, 167)
        TBJumlahBarang.Name = "TBJumlahBarang"
        TBJumlahBarang.Size = New Size(190, 31)
        TBJumlahBarang.TabIndex = 37
        ' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Location = New Point(432, 507)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 32)
        Label4.TabIndex = 38
        Label4.Text = "Item"' 
        ' LBitem
        ' 
        LBitem.AutoEllipsis = True
        LBitem.BorderStyle = BorderStyle.Fixed3D
        LBitem.Location = New Point(517, 507)
        LBitem.Name = "LBitem"
        LBitem.Size = New Size(74, 32)
        LBitem.TabIndex = 39
        ' 
        ' TransaksiPenjualanBarangForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1018, 602)
        Controls.Add(LBitem)
        Controls.Add(Label4)
        Controls.Add(TBJumlahBarang)
        Controls.Add(ComboBox1)
        Controls.Add(Button4)
        Controls.Add(LBHargaBarang)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(LBNamaBarang)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(LBSisa)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label9)
        Controls.Add(Label16)
        Controls.Add(LBAdmin)
        Controls.Add(LBJam)
        Controls.Add(LBTanggal)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(LBNomorJual)
        Controls.Add(Label1)
        Name = "TransaksiPenjualanBarangForm"
        Text = "Transkasi Penjualan Barang"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LBNomorJual As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LBTanggal As Label
    Friend WithEvents LBJam As Label
    Friend WithEvents LBAdmin As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBSisa As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents LBNamaBarang As Label
    Friend WithEvents LBHargaBarang As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TBJumlahBarang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LBitem As Label
End Class