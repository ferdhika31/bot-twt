<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.btnLogout = New System.Windows.Forms.Button
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.btnTambah = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnBaru = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.btnEmail = New System.Windows.Forms.Button
        Me.txtIds = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblProses = New System.Windows.Forms.Label
        Me.lblSelesai = New System.Windows.Forms.Label
        Me.btnProf = New System.Windows.Forms.Button
        Me.txtUrl = New System.Windows.Forms.TextBox
        Me.lbHasil = New System.Windows.Forms.ListBox
        Me.btnCopy = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.sf1 = New System.Windows.Forms.SaveFileDialog
        Me.lblNama = New System.Windows.Forms.Label
        Me.lblBio = New System.Windows.Forms.Label
        Me.lblUrl = New System.Windows.Forms.Label
        Me.lblLokasi = New System.Windows.Forms.Label
        Me.lblAkun1 = New System.Windows.Forms.Label
        Me.lblAkun2 = New System.Windows.Forms.Label
        Me.lblTweet1 = New System.Windows.Forms.Label
        Me.lblAuto = New System.Windows.Forms.Label
        Me.cbAuto = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.btnAbout = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lblTweet2 = New System.Windows.Forms.Label
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(148, 81)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(397, 9)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(546, 363)
        Me.WebBrowser1.TabIndex = 1
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnTambah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(266, 106)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 2
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(118, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(223, 21)
        Me.TextBox1.TabIndex = 3
        '
        'btnBaru
        '
        Me.btnBaru.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBaru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBaru.FlatAppearance.BorderSize = 0
        Me.btnBaru.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnBaru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.btnBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaru.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaru.ForeColor = System.Drawing.Color.White
        Me.btnBaru.Location = New System.Drawing.Point(266, 101)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(75, 23)
        Me.btnBaru.TabIndex = 4
        Me.btnBaru.Text = "Daftar"
        Me.btnBaru.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(118, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(223, 21)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(118, 71)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(223, 21)
        Me.TextBox3.TabIndex = 6
        '
        'btnEmail
        '
        Me.btnEmail.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmail.FlatAppearance.BorderSize = 0
        Me.btnEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmail.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmail.ForeColor = System.Drawing.Color.White
        Me.btnEmail.Location = New System.Drawing.Point(11, 26)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(176, 32)
        Me.btnEmail.TabIndex = 8
        Me.btnEmail.Text = "Yopmail Verificator"
        Me.btnEmail.UseVisualStyleBackColor = False
        '
        'txtIds
        '
        Me.txtIds.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIds.Location = New System.Drawing.Point(11, 106)
        Me.txtIds.Name = "txtIds"
        Me.txtIds.Size = New System.Drawing.Size(224, 21)
        Me.txtIds.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Email"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblProses)
        Me.GroupBox1.Controls.Add(Me.lblSelesai)
        Me.GroupBox1.Controls.Add(Me.btnLogout)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(714, 378)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 110)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'lblProses
        '
        Me.lblProses.AutoSize = True
        Me.lblProses.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProses.ForeColor = System.Drawing.Color.Maroon
        Me.lblProses.Location = New System.Drawing.Point(6, 37)
        Me.lblProses.Name = "lblProses"
        Me.lblProses.Size = New System.Drawing.Size(0, 13)
        Me.lblProses.TabIndex = 22
        '
        'lblSelesai
        '
        Me.lblSelesai.AutoSize = True
        Me.lblSelesai.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelesai.ForeColor = System.Drawing.Color.Maroon
        Me.lblSelesai.Location = New System.Drawing.Point(6, 18)
        Me.lblSelesai.Name = "lblSelesai"
        Me.lblSelesai.Size = New System.Drawing.Size(136, 13)
        Me.lblSelesai.TabIndex = 21
        Me.lblSelesai.Text = "Ngadagoan Browser :)"
        '
        'btnProf
        '
        Me.btnProf.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnProf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProf.FlatAppearance.BorderSize = 0
        Me.btnProf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnProf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.btnProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProf.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProf.ForeColor = System.Drawing.Color.White
        Me.btnProf.Location = New System.Drawing.Point(202, 26)
        Me.btnProf.Name = "btnProf"
        Me.btnProf.Size = New System.Drawing.Size(148, 32)
        Me.btnProf.TabIndex = 18
        Me.btnProf.Text = "Pengaturan"
        Me.btnProf.UseVisualStyleBackColor = False
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(72, 112)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.ReadOnly = True
        Me.txtUrl.Size = New System.Drawing.Size(311, 20)
        Me.txtUrl.TabIndex = 19
        '
        'lbHasil
        '
        Me.lbHasil.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHasil.FormattingEnabled = True
        Me.lbHasil.Location = New System.Drawing.Point(11, 21)
        Me.lbHasil.Name = "lbHasil"
        Me.lbHasil.Size = New System.Drawing.Size(224, 69)
        Me.lbHasil.TabIndex = 22
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCopy.FlatAppearance.BorderSize = 0
        Me.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopy.ForeColor = System.Drawing.Color.White
        Me.btnCopy.Location = New System.Drawing.Point(266, 55)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 23
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnSimpan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(266, 22)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 24
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(796, 9)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(45, 13)
        Me.lblNama.TabIndex = 25
        Me.lblNama.Text = "lblNama"
        Me.lblNama.Visible = False
        '
        'lblBio
        '
        Me.lblBio.AutoSize = True
        Me.lblBio.Location = New System.Drawing.Point(796, 90)
        Me.lblBio.Name = "lblBio"
        Me.lblBio.Size = New System.Drawing.Size(32, 13)
        Me.lblBio.TabIndex = 26
        Me.lblBio.Text = "lblBio"
        Me.lblBio.Visible = False
        '
        'lblUrl
        '
        Me.lblUrl.AutoSize = True
        Me.lblUrl.Location = New System.Drawing.Point(796, 38)
        Me.lblUrl.Name = "lblUrl"
        Me.lblUrl.Size = New System.Drawing.Size(30, 13)
        Me.lblUrl.TabIndex = 27
        Me.lblUrl.Text = "lblUrl"
        Me.lblUrl.Visible = False
        '
        'lblLokasi
        '
        Me.lblLokasi.AutoSize = True
        Me.lblLokasi.Location = New System.Drawing.Point(796, 64)
        Me.lblLokasi.Name = "lblLokasi"
        Me.lblLokasi.Size = New System.Drawing.Size(48, 13)
        Me.lblLokasi.TabIndex = 28
        Me.lblLokasi.Text = "lblLokasi"
        Me.lblLokasi.Visible = False
        '
        'lblAkun1
        '
        Me.lblAkun1.AutoSize = True
        Me.lblAkun1.Location = New System.Drawing.Point(841, 200)
        Me.lblAkun1.Name = "lblAkun1"
        Me.lblAkun1.Size = New System.Drawing.Size(48, 13)
        Me.lblAkun1.TabIndex = 29
        Me.lblAkun1.Text = "lblAkun1"
        Me.lblAkun1.Visible = False
        '
        'lblAkun2
        '
        Me.lblAkun2.AutoSize = True
        Me.lblAkun2.Location = New System.Drawing.Point(841, 217)
        Me.lblAkun2.Name = "lblAkun2"
        Me.lblAkun2.Size = New System.Drawing.Size(48, 13)
        Me.lblAkun2.TabIndex = 30
        Me.lblAkun2.Text = "lblAkun2"
        Me.lblAkun2.Visible = False
        '
        'lblTweet1
        '
        Me.lblTweet1.AutoSize = True
        Me.lblTweet1.Location = New System.Drawing.Point(796, 179)
        Me.lblTweet1.Name = "lblTweet1"
        Me.lblTweet1.Size = New System.Drawing.Size(53, 13)
        Me.lblTweet1.TabIndex = 31
        Me.lblTweet1.Text = "lblTweet1"
        Me.lblTweet1.Visible = False
        '
        'lblAuto
        '
        Me.lblAuto.AutoSize = True
        Me.lblAuto.Location = New System.Drawing.Point(796, 205)
        Me.lblAuto.Name = "lblAuto"
        Me.lblAuto.Size = New System.Drawing.Size(39, 13)
        Me.lblAuto.TabIndex = 33
        Me.lblAuto.Text = "lblAuto"
        Me.lblAuto.Visible = False
        '
        'cbAuto
        '
        Me.cbAuto.AutoSize = True
        Me.cbAuto.Enabled = False
        Me.cbAuto.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAuto.Location = New System.Drawing.Point(118, 105)
        Me.cbAuto.Name = "cbAuto"
        Me.cbAuto.Size = New System.Drawing.Size(117, 17)
        Me.cbAuto.TabIndex = 34
        Me.cbAuto.Text = "Otomatis Daftar"
        Me.cbAuto.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.cbAuto)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnBaru)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 139)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daftar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbHasil)
        Me.GroupBox3.Controls.Add(Me.txtIds)
        Me.GroupBox3.Controls.Add(Me.btnTambah)
        Me.GroupBox3.Controls.Add(Me.btnSimpan)
        Me.GroupBox3.Controls.Add(Me.btnCopy)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(23, 288)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 140)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hasil"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(23, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(360, 103)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TwitteCreatebyLangit.My.Resources.Resources.Langit_Application
        Me.PictureBox1.Location = New System.Drawing.Point(6, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(349, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Visit :"
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnKeluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(868, 494)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 37
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Location = New System.Drawing.Point(714, 494)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 38
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnEmail)
        Me.GroupBox5.Controls.Add(Me.btnProf)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(23, 441)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(360, 76)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tools"
        '
        'lblTweet2
        '
        Me.lblTweet2.AutoSize = True
        Me.lblTweet2.Location = New System.Drawing.Point(645, 162)
        Me.lblTweet2.Name = "lblTweet2"
        Me.lblTweet2.Size = New System.Drawing.Size(53, 13)
        Me.lblTweet2.TabIndex = 39
        Me.lblTweet2.Text = "lblTweet2"
        Me.lblTweet2.Visible = False
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(623, 179)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(191, 154)
        Me.WebBrowser2.TabIndex = 40
        Me.WebBrowser2.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(406, 378)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(302, 139)
        Me.GroupBox6.TabIndex = 15
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Notice"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(276, 104)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(955, 527)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.lblTweet2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblAuto)
        Me.Controls.Add(Me.lblTweet1)
        Me.Controls.Add(Me.lblAkun2)
        Me.Controls.Add(Me.lblAkun1)
        Me.Controls.Add(Me.lblLokasi)
        Me.Controls.Add(Me.lblUrl)
        Me.Controls.Add(Me.lblBio)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.txtUrl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Twitter Akun Create Apps Ver 1.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnBaru As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents btnEmail As System.Windows.Forms.Button
    Friend WithEvents txtIds As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnProf As System.Windows.Forms.Button
    Friend WithEvents txtUrl As System.Windows.Forms.TextBox
    Friend WithEvents lblSelesai As System.Windows.Forms.Label
    Friend WithEvents lbHasil As System.Windows.Forms.ListBox
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents sf1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblBio As System.Windows.Forms.Label
    Friend WithEvents lblUrl As System.Windows.Forms.Label
    Friend WithEvents lblLokasi As System.Windows.Forms.Label
    Friend WithEvents lblAkun1 As System.Windows.Forms.Label
    Friend WithEvents lblAkun2 As System.Windows.Forms.Label
    Friend WithEvents lblTweet1 As System.Windows.Forms.Label
    Friend WithEvents lblAuto As System.Windows.Forms.Label
    Friend WithEvents cbAuto As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTweet2 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblProses As System.Windows.Forms.Label

End Class
