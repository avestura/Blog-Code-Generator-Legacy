<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VarComboForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VarComboForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_VarText = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.List = New System.Windows.Forms.ListView()
        Me.varAlt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.varContent = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_reset = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_removeI = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_addI = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combo_RtlReading = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_SubmitVar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(290, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "تعریف یک متغیر جدید به صورت لیستی"
        '
        'txt_VarText
        '
        Me.txt_VarText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_VarText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_VarText.Location = New System.Drawing.Point(14, 42)
        Me.txt_VarText.Name = "txt_VarText"
        Me.txt_VarText.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_VarText.Size = New System.Drawing.Size(371, 21)
        Me.txt_VarText.TabIndex = 8
        Me.txt_VarText.Text = "متغیر لیستی"
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
        Me.Label11.TabIndex = 6
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
        Me.PictureBox11.TabIndex = 7
        Me.PictureBox11.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.List)
        Me.GroupBox1.Controls.Add(Me.btn_reset)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btn_removeI)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_addI)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.combo_RtlReading)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(479, 217)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "تنظیمات جعبه متنی"
        '
        'List
        '
        Me.List.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.varAlt, Me.varContent})
        Me.List.FullRowSelect = True
        Me.List.GridLines = True
        Me.List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.List.HideSelection = False
        Me.List.Location = New System.Drawing.Point(16, 91)
        Me.List.MultiSelect = False
        Me.List.Name = "List"
        Me.List.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.List.RightToLeftLayout = True
        Me.List.Size = New System.Drawing.Size(447, 120)
        Me.List.TabIndex = 17
        Me.List.UseCompatibleStateImageBehavior = False
        Me.List.View = System.Windows.Forms.View.Details
        '
        'varAlt
        '
        Me.varAlt.Text = "نام نمایشی"
        Me.varAlt.Width = 210
        '
        'varContent
        '
        Me.varContent.Text = "محتوای جایگزین شونده"
        Me.varContent.Width = 210
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.Transparent
        Me.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reset.Image = Global.PluginWorkShop.My.Resources.Resources.Refresh_arrow_16
        Me.btn_reset.Location = New System.Drawing.Point(277, 69)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(16, 16)
        Me.btn_reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_reset.TabIndex = 13
        Me.btn_reset.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.ForeColor = System.Drawing.Color.Purple
        Me.Label5.Location = New System.Drawing.Point(205, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "پاک کردن همه"
        '
        'btn_removeI
        '
        Me.btn_removeI.BackColor = System.Drawing.Color.Transparent
        Me.btn_removeI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_removeI.Image = Global.PluginWorkShop.My.Resources.Resources.Negative_sign_Button_16
        Me.btn_removeI.Location = New System.Drawing.Point(360, 69)
        Me.btn_removeI.Name = "btn_removeI"
        Me.btn_removeI.Size = New System.Drawing.Size(16, 16)
        Me.btn_removeI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_removeI.TabIndex = 12
        Me.btn_removeI.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.ForeColor = System.Drawing.Color.IndianRed
        Me.Label4.Location = New System.Drawing.Point(304, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "حذف گزینه"
        '
        'btn_addI
        '
        Me.btn_addI.BackColor = System.Drawing.Color.Transparent
        Me.btn_addI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addI.Image = Global.PluginWorkShop.My.Resources.Resources.Add_button_inside_black_circle_16
        Me.btn_addI.Location = New System.Drawing.Point(447, 69)
        Me.btn_addI.Name = "btn_addI"
        Me.btn_addI.Size = New System.Drawing.Size(16, 16)
        Me.btn_addI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_addI.TabIndex = 11
        Me.btn_addI.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(385, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "افزودن گزینه"
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
        Me.btn_SubmitVar.Location = New System.Drawing.Point(12, 294)
        Me.btn_SubmitVar.Name = "btn_SubmitVar"
        Me.btn_SubmitVar.Size = New System.Drawing.Size(163, 28)
        Me.btn_SubmitVar.TabIndex = 50
        Me.btn_SubmitVar.Text = "ثبت متغیر"
        Me.btn_SubmitVar.UseVisualStyleBackColor = True
        '
        'frm_Var_Combovb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PluginWorkShop.My.Resources.Resources.kashi
        Me.ClientSize = New System.Drawing.Size(507, 334)
        Me.Controls.Add(Me.btn_SubmitVar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_VarText)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Var_Combovb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txt_VarText As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_reset As System.Windows.Forms.PictureBox
    Friend WithEvents btn_removeI As System.Windows.Forms.PictureBox
    Friend WithEvents btn_addI As System.Windows.Forms.PictureBox
    Friend WithEvents combo_RtlReading As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_SubmitVar As System.Windows.Forms.Button
    Friend WithEvents List As System.Windows.Forms.ListView
    Friend WithEvents varAlt As System.Windows.Forms.ColumnHeader
    Friend WithEvents varContent As System.Windows.Forms.ColumnHeader
End Class
