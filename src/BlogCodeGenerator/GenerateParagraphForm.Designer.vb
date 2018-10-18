<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateParagraphForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerateParagraphForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_P = New System.Windows.Forms.TextBox()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_Color = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.افزودنپاراگرافبهکدToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_Class = New System.Windows.Forms.TextBox()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.cmd_Direction = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.ContexMSG.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.BackgroundImage = Global.BlogCodeGenerator.My.Resources.Resources.rightel_footer_global
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(492, 30)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(193, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ایجاد پاراگراف جدید"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(412, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "متن پاراگراف:"
        '
        'txt_P
        '
        Me.txt_P.ContextMenuStrip = Me.ContexMSG
        Me.txt_P.Location = New System.Drawing.Point(12, 51)
        Me.txt_P.Multiline = True
        Me.txt_P.Name = "txt_P"
        Me.txt_P.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_P.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_P.Size = New System.Drawing.Size(394, 72)
        Me.txt_P.TabIndex = 2
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(412, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "رنــــــگ متن:"
        '
        'cmd_Color
        '
        Me.cmd_Color.FormattingEnabled = True
        Me.cmd_Color.Items.AddRange(New Object() {"Red", "Green", "Blue", "Purple", "White", "Black", "Yellow", "Gray", "Gold", "Pink"})
        Me.cmd_Color.Location = New System.Drawing.Point(245, 129)
        Me.cmd_Color.Name = "cmd_Color"
        Me.cmd_Color.Size = New System.Drawing.Size(161, 21)
        Me.cmd_Color.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.cmd_Color, "میتوانید از کد های رنگ اچ تی ام ال نیز استفاده کنید")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.افزودنپاراگرافبهکدToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 196)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(492, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'افزودنپاراگرافبهکدToolStripMenuItem
        '
        Me.افزودنپاراگرافبهکدToolStripMenuItem.Image = Global.BlogCodeGenerator.My.Resources.Resources.Plus_sign_16
        Me.افزودنپاراگرافبهکدToolStripMenuItem.Name = "افزودنپاراگرافبهکدToolStripMenuItem"
        Me.افزودنپاراگرافبهکدToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.افزودنپاراگرافبهکدToolStripMenuItem.Size = New System.Drawing.Size(185, 20)
        Me.افزودنپاراگرافبهکدToolStripMenuItem.Text = "ساخت پاراگراف و افزودن آن به کد"
        '
        'ToolTip
        '
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip.ToolTipTitle = "راهنما"
        '
        'txt_Class
        '
        Me.txt_Class.Location = New System.Drawing.Point(245, 157)
        Me.txt_Class.Name = "txt_Class"
        Me.txt_Class.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Class.Size = New System.Drawing.Size(161, 21)
        Me.txt_Class.TabIndex = 9
        Me.ToolTip.SetToolTip(Me.txt_Class, "کلاس یک ویژگی انتخابی است. میتوانید آن را خالی بگذارید")
        '
        'txt_Id
        '
        Me.txt_Id.Location = New System.Drawing.Point(12, 157)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Id.Size = New System.Drawing.Size(177, 21)
        Me.txt_Id.TabIndex = 11
        Me.ToolTip.SetToolTip(Me.txt_Id, "آیدی یک ویژگی انتخابی است. میتوانید آن را خالی بگذارید")
        '
        'cmd_Direction
        '
        Me.cmd_Direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmd_Direction.FormattingEnabled = True
        Me.cmd_Direction.Items.AddRange(New Object() {"خودکار", "راست به چپ", "چپ به راست"})
        Me.cmd_Direction.Location = New System.Drawing.Point(12, 129)
        Me.cmd_Direction.Name = "cmd_Direction"
        Me.cmd_Direction.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmd_Direction.Size = New System.Drawing.Size(177, 21)
        Me.cmd_Direction.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(195, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "چیدمان:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(412, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "کلاس متن:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(195, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "آیدی:"
        '
        'frm_generate_paragraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BlogCodeGenerator.My.Resources.Resources.bcg_creamPixels
        Me.ClientSize = New System.Drawing.Size(492, 220)
        Me.Controls.Add(Me.txt_Id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Class)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmd_Direction)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmd_Color)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_P)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_generate_paragraph"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ایجاد پاراگراف"
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_P As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_Color As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents افزودنپاراگرافبهکدToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmd_Direction As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Class As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Id As System.Windows.Forms.TextBox
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
