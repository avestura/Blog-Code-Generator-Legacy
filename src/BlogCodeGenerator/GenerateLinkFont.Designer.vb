<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateLinkFont
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerateLinkFont))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_A = New System.Windows.Forms.TextBox()
        Me.ContexMSG = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.کپیToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.برشToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.چسباندنToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripSeparator()
        Me.افزودنToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btn_agen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmd_target = New System.Windows.Forms.ComboBox()
        Me.cmd_Direction = New System.Windows.Forms.ComboBox()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Class = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.ContexMSG.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.BlogCodeGenerator.My.Resources.Resources.rightel_footer_global
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(492, 30)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(203, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ایجاد لینک جدید"
        '
        'txt_A
        '
        Me.txt_A.ContextMenuStrip = Me.ContexMSG
        Me.txt_A.Location = New System.Drawing.Point(12, 48)
        Me.txt_A.Multiline = True
        Me.txt_A.Name = "txt_A"
        Me.txt_A.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_A.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_A.Size = New System.Drawing.Size(394, 72)
        Me.txt_A.TabIndex = 14
        '
        'ContexMSG
        '
        Me.ContexMSG.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContexMSG.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.کپیToolStripMenuItem, Me.برشToolStripMenuItem, Me.چسباندنToolStripMenuItem, Me.ToolStripMenuItem13, Me.افزودنToolStripMenuItem})
        Me.ContexMSG.Name = "ContexMSG"
        Me.ContexMSG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContexMSG.Size = New System.Drawing.Size(117, 98)
        '
        'کپیToolStripMenuItem
        '
        Me.کپیToolStripMenuItem.Image = Global.BlogCodeGenerator.My.Resources.Resources.bcg_Copy
        Me.کپیToolStripMenuItem.Name = "کپیToolStripMenuItem"
        Me.کپیToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.کپیToolStripMenuItem.Text = "کپی"
        '
        'برشToolStripMenuItem
        '
        Me.برشToolStripMenuItem.Image = Global.BlogCodeGenerator.My.Resources.Resources.bcg_cut
        Me.برشToolStripMenuItem.Name = "برشToolStripMenuItem"
        Me.برشToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.برشToolStripMenuItem.Text = "برش"
        '
        'چسباندنToolStripMenuItem
        '
        Me.چسباندنToolStripMenuItem.Image = Global.BlogCodeGenerator.My.Resources.Resources.bcg_paste
        Me.چسباندنToolStripMenuItem.Name = "چسباندنToolStripMenuItem"
        Me.چسباندنToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.چسباندنToolStripMenuItem.Text = "چسباندن"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(113, 6)
        '
        'افزودنToolStripMenuItem
        '
        Me.افزودنToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem14, Me.ToolStripMenuItem15, Me.ToolStripMenuItem16, Me.ToolStripMenuItem17, Me.ToolStripMenuItem18})
        Me.افزودنToolStripMenuItem.Image = Global.BlogCodeGenerator.My.Resources.Resources.bcg_Add
        Me.افزودنToolStripMenuItem.Name = "افزودنToolStripMenuItem"
        Me.افزودنToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.افزودنToolStripMenuItem.Text = "افزودن"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Image = CType(resources.GetObject("ToolStripMenuItem14.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(167, 22)
        Me.ToolStripMenuItem14.Text = "نام سایت"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Image = CType(resources.GetObject("ToolStripMenuItem15.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(167, 22)
        Me.ToolStripMenuItem15.Text = "زمان کنونی"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Image = CType(resources.GetObject("ToolStripMenuItem16.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(167, 22)
        Me.ToolStripMenuItem16.Text = "توضیحات کوتاه وبلاگ"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Image = CType(resources.GetObject("ToolStripMenuItem17.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(167, 22)
        Me.ToolStripMenuItem17.Text = "توضیحات بلند وبلاگ"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Image = CType(resources.GetObject("ToolStripMenuItem18.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(167, 22)
        Me.ToolStripMenuItem18.Text = "عنوان صفحه فعلی"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(412, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "متن لینک:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_agen})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 223)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(492, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btn_agen
        '
        Me.btn_agen.Image = Global.BlogCodeGenerator.My.Resources.Resources.Plus_sign_16
        Me.btn_agen.Name = "btn_agen"
        Me.btn_agen.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_agen.Size = New System.Drawing.Size(171, 20)
        Me.btn_agen.Text = "ساخت لینک و افزودن آن به کد"
        '
        'ToolTip
        '
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip.ToolTipTitle = "راهنما"
        '
        'cmd_target
        '
        Me.cmd_target.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmd_target.FormattingEnabled = True
        Me.cmd_target.Items.AddRange(New Object() {"باز شدن لینک در صفحه جدید", "باز شدن لینک در صفحه جاری", "باز شدن لینک در صفحه مادر", "باز شدن لینک در بالا"})
        Me.cmd_target.Location = New System.Drawing.Point(245, 154)
        Me.cmd_target.Name = "cmd_target"
        Me.cmd_target.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmd_target.Size = New System.Drawing.Size(161, 21)
        Me.cmd_target.TabIndex = 16
        Me.ToolTip.SetToolTip(Me.cmd_target, "مشخص میکند که پس از کلیک روی لینک , صفحه مورد نظر در کجا باز شود")
        '
        'cmd_Direction
        '
        Me.cmd_Direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmd_Direction.FormattingEnabled = True
        Me.cmd_Direction.Items.AddRange(New Object() {"خودکار", "راست به چپ", "چپ به راست"})
        Me.cmd_Direction.Location = New System.Drawing.Point(12, 154)
        Me.cmd_Direction.Name = "cmd_Direction"
        Me.cmd_Direction.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmd_Direction.Size = New System.Drawing.Size(177, 21)
        Me.cmd_Direction.TabIndex = 19
        '
        'txt_Id
        '
        Me.txt_Id.Location = New System.Drawing.Point(12, 182)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Id.Size = New System.Drawing.Size(177, 21)
        Me.txt_Id.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(195, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "آیدی:"
        '
        'txt_Class
        '
        Me.txt_Class.Location = New System.Drawing.Point(245, 182)
        Me.txt_Class.Name = "txt_Class"
        Me.txt_Class.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Class.Size = New System.Drawing.Size(161, 21)
        Me.txt_Class.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(412, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "کلاس لینک:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(195, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "چیدمان:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(412, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "رفتار لینک:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(412, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "آدرس:"
        '
        'txt_Address
        '
        Me.txt_Address.Location = New System.Drawing.Point(12, 127)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Address.Size = New System.Drawing.Size(394, 21)
        Me.txt_Address.TabIndex = 25
        Me.txt_Address.Text = "http://"
        '
        'frm_generate_link
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BlogCodeGenerator.My.Resources.Resources.bcg_creamPixels
        Me.ClientSize = New System.Drawing.Size(492, 247)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmd_target)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_A)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txt_Id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Class)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmd_Direction)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_generate_link"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "افزودن لینک"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContexMSG.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents txt_A As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btn_agen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmd_Direction As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Id As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Class As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_target As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Address As System.Windows.Forms.TextBox
    Friend WithEvents ContexMSG As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents کپیToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents برشToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents چسباندنToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents افزودنToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
End Class
