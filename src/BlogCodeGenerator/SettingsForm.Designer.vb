<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbBase = New System.Windows.Forms.TabControl()
        Me.CSS_TAB = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_css_inload = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tab_Code_Editor = New System.Windows.Forms.TabPage()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tab_Tools = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tab_Plugin = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabMenu = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.Panel1.SuspendLayout()
        Me.TbBase.SuspendLayout()
        Me.CSS_TAB.SuspendLayout()
        Me.Tab_Code_Editor.SuspendLayout()
        Me.Tab_Tools.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Tab_Plugin.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabMenu.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.BlogCodeGenerator.My.Resources.Resources.rightel_footer_global
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(673, 27)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(288, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "تنظیمات نرم افزار"
        '
        'TbBase
        '
        Me.TbBase.Controls.Add(Me.CSS_TAB)
        Me.TbBase.Controls.Add(Me.Tab_Code_Editor)
        Me.TbBase.Controls.Add(Me.Tab_Tools)
        Me.TbBase.Controls.Add(Me.Tab_Plugin)
        Me.TbBase.Controls.Add(Me.TabMenu)
        Me.TbBase.Location = New System.Drawing.Point(9, 33)
        Me.TbBase.Multiline = True
        Me.TbBase.Name = "TbBase"
        Me.TbBase.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TbBase.RightToLeftLayout = True
        Me.TbBase.SelectedIndex = 0
        Me.TbBase.Size = New System.Drawing.Size(652, 356)
        Me.TbBase.TabIndex = 2
        '
        'CSS_TAB
        '
        Me.CSS_TAB.BackgroundImage = Global.BlogCodeGenerator.My.Resources.Resources.bcg_Firefox
        Me.CSS_TAB.Controls.Add(Me.Button3)
        Me.CSS_TAB.Controls.Add(Me.txt_css_inload)
        Me.CSS_TAB.Controls.Add(Me.Label3)
        Me.CSS_TAB.Controls.Add(Me.Label2)
        Me.CSS_TAB.Location = New System.Drawing.Point(4, 22)
        Me.CSS_TAB.Name = "CSS_TAB"
        Me.CSS_TAB.Padding = New System.Windows.Forms.Padding(3)
        Me.CSS_TAB.Size = New System.Drawing.Size(644, 330)
        Me.CSS_TAB.TabIndex = 0
        Me.CSS_TAB.Text = "پیش نمایش"
        Me.CSS_TAB.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FloralWhite
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DimGray
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(6, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(164, 28)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "ثبت"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txt_css_inload
        '
        Me.txt_css_inload.Location = New System.Drawing.Point(6, 43)
        Me.txt_css_inload.Multiline = True
        Me.txt_css_inload.Name = "txt_css_inload"
        Me.txt_css_inload.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_css_inload.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_css_inload.Size = New System.Drawing.Size(632, 247)
        Me.txt_css_inload.TabIndex = 2
        Me.txt_css_inload.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(366, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(270, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "کد های CSS زیر به پیش نمایش نرم افزار اضافه خواهد شد"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(421, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "درج شیوه نامه اختصاصی به پیش نمایش"
        '
        'Tab_Code_Editor
        '
        Me.Tab_Code_Editor.BackgroundImage = Global.BlogCodeGenerator.My.Resources.Resources.bcg_Firefox
        Me.Tab_Code_Editor.Controls.Add(Me.Label18)
        Me.Tab_Code_Editor.Controls.Add(Me.Button5)
        Me.Tab_Code_Editor.Controls.Add(Me.Button4)
        Me.Tab_Code_Editor.Controls.Add(Me.Label4)
        Me.Tab_Code_Editor.Controls.Add(Me.Label5)
        Me.Tab_Code_Editor.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Code_Editor.Name = "Tab_Code_Editor"
        Me.Tab_Code_Editor.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Code_Editor.Size = New System.Drawing.Size(644, 330)
        Me.Tab_Code_Editor.TabIndex = 1
        Me.Tab_Code_Editor.Text = "ویرایشگر کد"
        Me.Tab_Code_Editor.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(579, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "انتخاب قلم:"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Snow
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FloralWhite
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DimGray
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(6, 296)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(164, 28)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "ثبت"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Snow
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FloralWhite
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DimGray
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(412, 60)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(164, 28)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "انتخاب قلم"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(429, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(208, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "تغییر قلم و رنگ ویرایشگر کد اصلی نرم افزار"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(485, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "شخصی سازی ویرایشگر کد"
        '
        'Tab_Tools
        '
        Me.Tab_Tools.BackgroundImage = Global.BlogCodeGenerator.My.Resources.Resources.bcg_Firefox
        Me.Tab_Tools.Controls.Add(Me.GroupBox2)
        Me.Tab_Tools.Controls.Add(Me.Label6)
        Me.Tab_Tools.Controls.Add(Me.Label7)
        Me.Tab_Tools.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Tools.Name = "Tab_Tools"
        Me.Tab_Tools.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Tools.Size = New System.Drawing.Size(644, 330)
        Me.Tab_Tools.TabIndex = 2
        Me.Tab_Tools.Text = "جعبه ابزار"
        Me.Tab_Tools.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(626, 258)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(223, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(180, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "تغییر تنظیمات جعبه ابزار موجود نیست"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(505, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "تنظیمات مربوط به جعبه ابزار"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(579, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "جعبه ابزار"
        '
        'Tab_Plugin
        '
        Me.Tab_Plugin.BackgroundImage = Global.BlogCodeGenerator.My.Resources.Resources.bcg_Firefox
        Me.Tab_Plugin.Controls.Add(Me.GroupBox1)
        Me.Tab_Plugin.Controls.Add(Me.Label9)
        Me.Tab_Plugin.Controls.Add(Me.Label10)
        Me.Tab_Plugin.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Plugin.Name = "Tab_Plugin"
        Me.Tab_Plugin.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Plugin.Size = New System.Drawing.Size(644, 330)
        Me.Tab_Plugin.TabIndex = 3
        Me.Tab_Plugin.Text = "افزونه ها"
        Me.Tab_Plugin.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(626, 268)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Enabled = False
        Me.CheckBox5.Location = New System.Drawing.Point(362, 66)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox5.Size = New System.Drawing.Size(258, 17)
        Me.CheckBox5.TabIndex = 11
        Me.CheckBox5.Text = "به طور خودکار افزونه های نسخه جدید تر را نصب کن"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Enabled = False
        Me.CheckBox4.Location = New System.Drawing.Point(361, 42)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox4.Size = New System.Drawing.Size(259, 17)
        Me.CheckBox4.TabIndex = 10
        Me.CheckBox4.Text = "افزونه های موجود در زیر پوشه ها را نیز بارگذاری کن"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Location = New System.Drawing.Point(433, 89)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox3.Size = New System.Drawing.Size(187, 17)
        Me.CheckBox3.TabIndex = 9
        Me.CheckBox3.Text = "خطا های افزونه را به من گوشزد کن"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(453, 20)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox2.Size = New System.Drawing.Size(167, 17)
        Me.CheckBox2.TabIndex = 8
        Me.CheckBox2.Text = "تمامی افزونه ها را بارگذاری کن"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(464, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(171, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "تنظیمات مربوط به بارگذاری افزونه ها"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(579, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "افزونه ها"
        '
        'TabMenu
        '
        Me.TabMenu.BackgroundImage = Global.BlogCodeGenerator.My.Resources.Resources.bcg_Firefox
        Me.TabMenu.Controls.Add(Me.GroupBox3)
        Me.TabMenu.Controls.Add(Me.Label11)
        Me.TabMenu.Controls.Add(Me.Label12)
        Me.TabMenu.Location = New System.Drawing.Point(4, 22)
        Me.TabMenu.Name = "TabMenu"
        Me.TabMenu.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMenu.Size = New System.Drawing.Size(644, 330)
        Me.TabMenu.TabIndex = 4
        Me.TabMenu.Text = "منو اصلی"
        Me.TabMenu.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(626, 268)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(223, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label13.Size = New System.Drawing.Size(172, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "تغییر تنظیمات منو ابزار موجود نیست"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(502, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(133, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "ویرایش آیتم های منو اصلی"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(579, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "منو اصلی"
        '
        'FontDialog
        '
        Me.FontDialog.Color = System.Drawing.SystemColors.ControlText
        '
        'frm_setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(673, 408)
        Me.Controls.Add(Me.TbBase)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_setting"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TbBase.ResumeLayout(False)
        Me.CSS_TAB.ResumeLayout(False)
        Me.CSS_TAB.PerformLayout()
        Me.Tab_Code_Editor.ResumeLayout(False)
        Me.Tab_Code_Editor.PerformLayout()
        Me.Tab_Tools.ResumeLayout(False)
        Me.Tab_Tools.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Tab_Plugin.ResumeLayout(False)
        Me.Tab_Plugin.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabMenu.ResumeLayout(False)
        Me.TabMenu.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbBase As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Code_Editor As System.Windows.Forms.TabPage
    Friend WithEvents CSS_TAB As System.Windows.Forms.TabPage
    Friend WithEvents txt_css_inload As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Tab_Tools As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Plugin As System.Windows.Forms.TabPage
    Friend WithEvents TabMenu As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
