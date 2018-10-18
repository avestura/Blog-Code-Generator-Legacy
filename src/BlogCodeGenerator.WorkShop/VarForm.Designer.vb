<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VarForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VarForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.txt_VarText = New System.Windows.Forms.TextBox()
        Me.txt_VarInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_reset = New System.Windows.Forms.PictureBox()
        Me.btn_removeI = New System.Windows.Forms.PictureBox()
        Me.btn_addI = New System.Windows.Forms.PictureBox()
        Me.list_Suggst = New System.Windows.Forms.ListBox()
        Me.check_SuggestVar = New System.Windows.Forms.CheckBox()
        Me.combo_RtlReading = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_SubmitVar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btn_reset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_removeI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_addI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PluginWorkShop.My.Resources.Resources.rightel_footer_global
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 29)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(274, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "تعریف یک متغیر جدید به صورت جعبه متنی"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(376, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(98, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "متن کوتاه متغیر:"
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(475, 43)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox11.TabIndex = 4
        Me.PictureBox11.TabStop = False
        '
        'txt_VarText
        '
        Me.txt_VarText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_VarText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_VarText.Location = New System.Drawing.Point(12, 42)
        Me.txt_VarText.Name = "txt_VarText"
        Me.txt_VarText.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_VarText.Size = New System.Drawing.Size(358, 21)
        Me.txt_VarText.TabIndex = 5
        Me.txt_VarText.Text = "متغیر"
        '
        'txt_VarInput
        '
        Me.txt_VarInput.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_VarInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_VarInput.Location = New System.Drawing.Point(12, 65)
        Me.txt_VarInput.Name = "txt_VarInput"
        Me.txt_VarInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_VarInput.Size = New System.Drawing.Size(358, 21)
        Me.txt_VarInput.TabIndex = 8
        Me.txt_VarInput.Text = "در این جعبه متن چیزی بنویسید"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(376, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "محتوای جعبه متن:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(475, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btn_reset)
        Me.GroupBox1.Controls.Add(Me.btn_removeI)
        Me.GroupBox1.Controls.Add(Me.btn_addI)
        Me.GroupBox1.Controls.Add(Me.list_Suggst)
        Me.GroupBox1.Controls.Add(Me.check_SuggestVar)
        Me.GroupBox1.Controls.Add(Me.combo_RtlReading)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(479, 193)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "تنظیمات جعبه متنی"
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.Transparent
        Me.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reset.Image = Global.PluginWorkShop.My.Resources.Resources.Refresh_arrow_16
        Me.btn_reset.Location = New System.Drawing.Point(61, 69)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(16, 16)
        Me.btn_reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_reset.TabIndex = 13
        Me.btn_reset.TabStop = False
        Me.btn_reset.Visible = False
        '
        'btn_removeI
        '
        Me.btn_removeI.BackColor = System.Drawing.Color.Transparent
        Me.btn_removeI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_removeI.Image = Global.PluginWorkShop.My.Resources.Resources.Negative_sign_Button_16
        Me.btn_removeI.Location = New System.Drawing.Point(39, 69)
        Me.btn_removeI.Name = "btn_removeI"
        Me.btn_removeI.Size = New System.Drawing.Size(16, 16)
        Me.btn_removeI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_removeI.TabIndex = 12
        Me.btn_removeI.TabStop = False
        Me.btn_removeI.Visible = False
        '
        'btn_addI
        '
        Me.btn_addI.BackColor = System.Drawing.Color.Transparent
        Me.btn_addI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addI.Image = Global.PluginWorkShop.My.Resources.Resources.Add_button_inside_black_circle_16
        Me.btn_addI.Location = New System.Drawing.Point(18, 69)
        Me.btn_addI.Name = "btn_addI"
        Me.btn_addI.Size = New System.Drawing.Size(16, 16)
        Me.btn_addI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_addI.TabIndex = 11
        Me.btn_addI.TabStop = False
        Me.btn_addI.Visible = False
        '
        'list_Suggst
        '
        Me.list_Suggst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.list_Suggst.FormattingEnabled = True
        Me.list_Suggst.Location = New System.Drawing.Point(16, 88)
        Me.list_Suggst.Name = "list_Suggst"
        Me.list_Suggst.Size = New System.Drawing.Size(447, 95)
        Me.list_Suggst.TabIndex = 10
        '
        'check_SuggestVar
        '
        Me.check_SuggestVar.AutoSize = True
        Me.check_SuggestVar.Location = New System.Drawing.Point(116, 69)
        Me.check_SuggestVar.Name = "check_SuggestVar"
        Me.check_SuggestVar.Size = New System.Drawing.Size(347, 17)
        Me.check_SuggestVar.TabIndex = 9
        Me.check_SuggestVar.Text = "در هنگام نوشتن متن، نرم افزار کلمات پیشنهادی را به کاربر نمایش دهد"
        Me.check_SuggestVar.UseVisualStyleBackColor = True
        '
        'combo_RtlReading
        '
        Me.combo_RtlReading.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_RtlReading.FormattingEnabled = True
        Me.combo_RtlReading.Items.AddRange(New Object() {"راست به چپ باشد (برای متون فارسی)", "چپ به راست باشد (برای متون انگلیسی یا آدرس های اینترنتی)"})
        Me.combo_RtlReading.Location = New System.Drawing.Point(16, 29)
        Me.combo_RtlReading.Name = "combo_RtlReading"
        Me.combo_RtlReading.Size = New System.Drawing.Size(326, 21)
        Me.combo_RtlReading.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(340, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "جهت پر شدن جعبه متن:"
        '
        'btn_SubmitVar
        '
        Me.btn_SubmitVar.BackgroundImage = Global.PluginWorkShop.My.Resources.Resources.menu_bg_gray
        Me.btn_SubmitVar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SubmitVar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_SubmitVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SubmitVar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_SubmitVar.ForeColor = System.Drawing.Color.Gray
        Me.btn_SubmitVar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_SubmitVar.Location = New System.Drawing.Point(12, 295)
        Me.btn_SubmitVar.Name = "btn_SubmitVar"
        Me.btn_SubmitVar.Size = New System.Drawing.Size(163, 28)
        Me.btn_SubmitVar.TabIndex = 49
        Me.btn_SubmitVar.Text = "ثبت متغیر"
        Me.btn_SubmitVar.UseVisualStyleBackColor = True
        '
        'frm_Var
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PluginWorkShop.My.Resources.Resources.kashi
        Me.ClientSize = New System.Drawing.Size(507, 334)
        Me.Controls.Add(Me.btn_SubmitVar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_VarInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_VarText)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Var"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btn_reset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_removeI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_addI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_VarText As System.Windows.Forms.TextBox
    Friend WithEvents txt_VarInput As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents combo_RtlReading As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents list_Suggst As System.Windows.Forms.ListBox
    Friend WithEvents check_SuggestVar As System.Windows.Forms.CheckBox
    Friend WithEvents btn_SubmitVar As System.Windows.Forms.Button
    Friend WithEvents btn_addI As System.Windows.Forms.PictureBox
    Friend WithEvents btn_removeI As System.Windows.Forms.PictureBox
    Friend WithEvents btn_reset As System.Windows.Forms.PictureBox
End Class
