<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditToolsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditToolsForm))
        Me.code = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Var1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.اسکریپتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.استایلCSSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.دایوToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.لینکToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'code
        '
        Me.code.AcceptsReturn = True
        Me.code.AcceptsTab = True
        Me.code.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.code.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.code.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.code.Location = New System.Drawing.Point(0, 26)
        Me.code.Multiline = True
        Me.code.Name = "code"
        Me.code.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.code.Size = New System.Drawing.Size(806, 329)
        Me.code.TabIndex = 1
        Me.code.Text = "<!-- Plugin Description -->" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<!-- Copyright / My Name / Mysite.com / BlogCode v11" & _
    " -->"
        Me.code.WordWrap = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton2, Me.ToolStripButton2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(807, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "منو اصلی"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Var1ToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem1, Me.اسکریپتToolStripMenuItem, Me.استایلCSSToolStripMenuItem, Me.دایوToolStripMenuItem, Me.لینکToolStripMenuItem, Me.AToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Margin = New System.Windows.Forms.Padding(0, 1, 1, 2)
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(81, 22)
        Me.ToolStripDropDownButton2.Text = "درج HTML"
        '
        'Var1ToolStripMenuItem
        '
        Me.Var1ToolStripMenuItem.Image = CType(resources.GetObject("Var1ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Var1ToolStripMenuItem.Name = "Var1ToolStripMenuItem"
        Me.Var1ToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.Var1ToolStripMenuItem.Text = "درج متغیر با شماره دلخواه"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(193, 22)
        Me.ToolStripMenuItem2.Text = "درج متغیر به صورت ترتیبی"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(190, 6)
        '
        'اسکریپتToolStripMenuItem
        '
        Me.اسکریپتToolStripMenuItem.Image = CType(resources.GetObject("اسکریپتToolStripMenuItem.Image"), System.Drawing.Image)
        Me.اسکریپتToolStripMenuItem.Name = "اسکریپتToolStripMenuItem"
        Me.اسکریپتToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.اسکریپتToolStripMenuItem.Text = "Script"
        '
        'استایلCSSToolStripMenuItem
        '
        Me.استایلCSSToolStripMenuItem.Image = CType(resources.GetObject("استایلCSSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.استایلCSSToolStripMenuItem.Name = "استایلCSSToolStripMenuItem"
        Me.استایلCSSToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.استایلCSSToolStripMenuItem.Text = "Style"
        '
        'دایوToolStripMenuItem
        '
        Me.دایوToolStripMenuItem.Image = CType(resources.GetObject("دایوToolStripMenuItem.Image"), System.Drawing.Image)
        Me.دایوToolStripMenuItem.Name = "دایوToolStripMenuItem"
        Me.دایوToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.دایوToolStripMenuItem.Text = "div"
        '
        'لینکToolStripMenuItem
        '
        Me.لینکToolStripMenuItem.Image = CType(resources.GetObject("لینکToolStripMenuItem.Image"), System.Drawing.Image)
        Me.لینکToolStripMenuItem.Name = "لینکToolStripMenuItem"
        Me.لینکToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.لینکToolStripMenuItem.Text = "link"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Image = CType(resources.GetObject("AToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.AToolStripMenuItem.Text = "a"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Image = Global.PluginWorkShop.My.Resources.Resources.Affirmative_check_mark_16
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripButton2.Text = "تایید و ذخیره تغییرات"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = Global.PluginWorkShop.My.Resources.Resources.Cancel_button_16
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripButton1.Text = "لغو تغییرات"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 356)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(807, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(792, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "ویرایش ابزار"
        '
        'rrm_code
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PluginWorkShop.My.Resources.Resources.Ajor
        Me.ClientSize = New System.Drawing.Size(807, 378)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.code)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "rrm_code"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ویرایش ابزار"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents code As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents اسکریپتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents استایلCSSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents دایوToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents لینکToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Var1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
End Class
