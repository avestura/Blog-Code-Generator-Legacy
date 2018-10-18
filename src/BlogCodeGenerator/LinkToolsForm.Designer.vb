<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinkToolsForm
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
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.cmd_target = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Class = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_A = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Address
        '
        Me.txt_Address.Location = New System.Drawing.Point(12, 125)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Address.Size = New System.Drawing.Size(394, 21)
        Me.txt_Address.TabIndex = 39
        Me.txt_Address.Text = "http://"
        '
        'cmd_target
        '
        Me.cmd_target.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmd_target.FormattingEnabled = True
        Me.cmd_target.Items.AddRange(New Object() {"باز شدن لینک در صفحه جدید (در یک تب جداگانه)", " باز شدن لینک در صفحه جاری", " باز شدن لینک در صفحه مادر", " باز شدن لینک در بالا"})
        Me.cmd_target.Location = New System.Drawing.Point(12, 152)
        Me.cmd_target.Name = "cmd_target"
        Me.cmd_target.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmd_target.Size = New System.Drawing.Size(394, 21)
        Me.cmd_target.TabIndex = 30
        Me.ToolTip.SetToolTip(Me.cmd_target, "مشخص میکند که پس از کلیک روی لینک , صفحه مورد نظر در کجا باز شود")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(412, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "رفتار لینک:"
        '
        'txt_Id
        '
        Me.txt_Id.Location = New System.Drawing.Point(12, 180)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Id.Size = New System.Drawing.Size(179, 21)
        Me.txt_Id.TabIndex = 37
        Me.ToolTip.SetToolTip(Me.txt_Id, "آیدی لینک - اختیاری")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(193, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "آیدی:"
        '
        'txt_Class
        '
        Me.txt_Class.Location = New System.Drawing.Point(234, 180)
        Me.txt_Class.Name = "txt_Class"
        Me.txt_Class.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Class.Size = New System.Drawing.Size(172, 21)
        Me.txt_Class.TabIndex = 35
        Me.ToolTip.SetToolTip(Me.txt_Class, "کلاس لینک - اختیاری")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(412, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "کلاس لینک:"
        '
        'ToolTip
        '
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip.ToolTipTitle = "راهنما"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 205)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(395, 21)
        Me.TextBox2.TabIndex = 43
        Me.ToolTip.SetToolTip(Me.TextBox2, "شما میتوانید شیوه نامه خود را برای تغییر ظاهر و شخصی سازی لینک وارد کنید. در صورت" & _
        " عدم تمایل این قسمت را خالی بگذارید")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(412, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "متن لینک:"
        '
        'txt_A
        '
        Me.txt_A.Location = New System.Drawing.Point(12, 46)
        Me.txt_A.Multiline = True
        Me.txt_A.Name = "txt_A"
        Me.txt_A.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_A.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_A.Size = New System.Drawing.Size(394, 72)
        Me.txt_A.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(215, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "لینک ساز"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(412, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "آدرس:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.BlogCodeGenerator.My.Resources.Resources.rightel_footer_global
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 30)
        Me.Panel1.TabIndex = 26
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.Location = New System.Drawing.Point(11, 263)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(460, 120)
        Me.TextBox1.TabIndex = 40
        Me.TextBox1.WordWrap = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Snow
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FloralWhite
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DimGray
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(11, 231)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(178, 28)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "دریافت کد لینک"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(412, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "CSS:"
        '
        'frm_tools_link
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BlogCodeGenerator.My.Resources.Resources.bcg_creamPixels
        Me.ClientSize = New System.Drawing.Size(484, 389)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.cmd_target)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Class)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_A)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_tools_link"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Address As System.Windows.Forms.TextBox
    Friend WithEvents cmd_target As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Id As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Class As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_A As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
