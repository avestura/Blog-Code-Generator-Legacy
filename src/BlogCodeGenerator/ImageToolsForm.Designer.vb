<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageToolsForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_src = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_height = New System.Windows.Forms.TextBox()
        Me.txt_width = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txt_alt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.BlogCodeGenerator.My.Resources.Resources.rightel_footer_global
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 30)
        Me.Panel1.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(213, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "تصویر ساز"
        '
        'txt_src
        '
        Me.txt_src.Location = New System.Drawing.Point(12, 48)
        Me.txt_src.Name = "txt_src"
        Me.txt_src.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_src.Size = New System.Drawing.Size(394, 21)
        Me.txt_src.TabIndex = 30
        Me.txt_src.Text = "http://"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(412, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "آدرس تصویر:"
        '
        'ToolTip
        '
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip.ToolTipTitle = "راهنما"
        '
        'txt_height
        '
        Me.txt_height.Location = New System.Drawing.Point(12, 148)
        Me.txt_height.Name = "txt_height"
        Me.txt_height.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_height.Size = New System.Drawing.Size(171, 21)
        Me.txt_height.TabIndex = 35
        Me.txt_height.Text = "auto"
        Me.ToolTip.SetToolTip(Me.txt_height, "میتوانید از واحد هایی چون پیکسل استفادع کنید. مثل" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "100px" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'txt_width
        '
        Me.txt_width.Location = New System.Drawing.Point(259, 148)
        Me.txt_width.Name = "txt_width"
        Me.txt_width.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_width.Size = New System.Drawing.Size(147, 21)
        Me.txt_width.TabIndex = 33
        Me.txt_width.Text = "auto"
        Me.ToolTip.SetToolTip(Me.txt_width, "میتوانید از واحد هایی چون پیکسل استفادع کنید. مثل" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "100px")
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 122)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(394, 21)
        Me.TextBox2.TabIndex = 45
        Me.ToolTip.SetToolTip(Me.TextBox2, "شما میتوانید شیوه نامه خود را برای تغییر ظاهر و شخصی سازی لینک وارد کنید. در صورت" &
        " عدم تمایل این قسمت را خالی بگذارید")
        '
        'txt_alt
        '
        Me.txt_alt.Location = New System.Drawing.Point(12, 98)
        Me.txt_alt.Name = "txt_alt"
        Me.txt_alt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_alt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_alt.Size = New System.Drawing.Size(394, 21)
        Me.txt_alt.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(414, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "متن جایگزین:"
        '
        'txt_des
        '
        Me.txt_des.Location = New System.Drawing.Point(12, 73)
        Me.txt_des.Name = "txt_des"
        Me.txt_des.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_des.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_des.Size = New System.Drawing.Size(394, 21)
        Me.txt_des.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(412, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "توضح تصویر:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(189, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "عرض تصویر:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(412, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "طول تصویر:"
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
        Me.Button3.Location = New System.Drawing.Point(14, 179)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(169, 28)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "دریافت کد تصویر"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.Location = New System.Drawing.Point(14, 212)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(460, 120)
        Me.TextBox1.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(412, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "CSS:"
        '
        'frm_tools_image
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BlogCodeGenerator.My.Resources.Resources.bcg_creamPixels
        Me.ClientSize = New System.Drawing.Size(488, 341)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_src)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_alt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_des)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_height)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_width)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_tools_image"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_src As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents txt_height As System.Windows.Forms.TextBox
    Friend WithEvents txt_width As System.Windows.Forms.TextBox
    Friend WithEvents txt_alt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_des As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
