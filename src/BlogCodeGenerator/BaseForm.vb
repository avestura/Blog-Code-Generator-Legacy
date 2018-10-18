Imports System.Net
Imports System.Threading
Imports Ionic.Zip
Public Class BaseForm
    Public ThisVersion As Integer = 12
    Public ServerVersion As Integer
    Public ServerLink As String
    Public webView As Boolean = True
    Public iChanged As Boolean = False
    Dim cursorAdr As String = "def"
    Dim toupAdr As String = "def"
    Dim aryanClass As Integer = 1
    Dim maindrop As Boolean = False
    Dim WebString As WebClient = New WebClient()
    Public loccus As Boolean = False
    Public goingToUpdate As Integer

    Dim nMona As Monitor

    Sub CheckForUpdate()
        itm_CheckForUpdate_.Enabled = False
        ToolUpUpdate.Visible = False
        ToolDownUpdate.Visible = True
        ToolDownUpdate.Image = My.Resources.spinner
        ToolDownUpdate.Text = "در حال بررسی به روز رسانی..."
        ToolDownUpdate.Tag = "در حال بررسی برای به روز رسانی نرم افزار..."
        Try

            WebString.CachePolicy = New System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore)

            cString = WebString.DownloadString("http://aryan-pc.ir/blogcode-updates/update.txt")

            ServerVersion = Val(Split(cString, "[<|>]")(0))
            ServerLink = Split(cString, "[<|>]")(1)

            If ServerVersion > ThisVersion Then

                ToolUpUpdate.Visible = True
                ToolDownUpdate.Image = My.Resources.UPDATE_
                ToolDownUpdate.Text = "به روزرسانی موجود است"
                ToolDownUpdate.Tag = "نسخه جدیدتری از نرم افزار کد ساز موجود است. برای دریافت از گزینه موجود در منوی بالا استفاده کنید"
            Else
                ToolDownUpdate.Image = Nothing
                ToolDownUpdate.Text = "نسخه به روز"
                ToolDownUpdate.Tag = "شما از آخرین نسخه انتشار داده شده استفاده می کنید"
            End If
        Catch ex As Exception
            ToolDownUpdate.Image = My.Resources.bcg_warn
            ToolDownUpdate.Text = "اشکال در بررسی"
            ToolDownUpdate.Tag = "مشکلی در بررسی به روزرسانی نرم افزار رخ داده است"

        End Try
        itm_CheckForUpdate_.Enabled = True
    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles txt_genCode.Click
        'TextBox1.SelectionStart = 0
        'TextBox1.SelectionLength = Len(TextBox1.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_genCode.TextChanged
        'webView = True
        'loadexp(WebBrowser1, txt_genCode)
    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.ButtonClick
        ToolStripSplitButton1.ShowDropDown()
    End Sub

    Private Sub ورودبهسایتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ورودبهسایتToolStripMenuItem.Click
        WebWarnForm.goUrl = "http://aryan-pc.blog.ir/"
        WebWarnForm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        webView = True
        Dim brad As String = Nothing
        Dim m_type, w_style, h_style, ispx, toprint, linkcss As String
        If BlogComboBox.SelectedIndex = 0 Then linkcss = Nothing Else linkcss = "<link type=""text/css"" rel=""stylesheet"" href=""http://bayanbox.ir/download/1195291758497724830/message.css"">" & vbNewLine
        If BlogComboBox.SelectedIndex = 2 Then linkcss = My.Resources.style & vbNewLine

        If rad_err.Checked = True Then m_type = "err"
        If rad_wrn.Checked = True Then m_type = "wrn"
        If rad_success.Checked = True Then m_type = "success"
        If rad_w_auto.Checked = True Then
            w_style = "auto"
            ispx = Nothing
        Else
            w_style = wid_me.Value.ToString
            ispx = "px"
        End If

        If rad_h_auto.Checked = True Then
            h_style = "auto"
            ispx = Nothing
        Else
            h_style = hid_me.Value.ToString
            ispx = "px"
        End If
        toprint = msg_text.Text
        If chk_1_isborder_rad.Checked = True Then brad = "border-radius:0px"
        If msg_text.Text = "" Then toprint = "ابتدا متنی را وارد کنید"
        toprint = Replace(toprint, ControlChars.Lf, "<br>")
        txt_genCode.Text = linkcss & "<div style=""width:" & w_style & ispx & "; height:" & h_style & ispx & ";" & brad & """ class=""item_" & m_type & """><div class=""icon""></div>" & toprint & "</div>"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        webView = True
        code = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/bayanMenuReq.bchtml")
        code = Replace(code, "(*home_text*)", s_1.Text)
        code = Replace(code, "(*home_adr*)", s_1_adr.Text)
        code = Replace(code, "(*link_text*)", s_2.Text)
        code = Replace(code, "(*link_adr*)", s_2_adr.Text)
        code = Replace(code, "(*prof_text*)", s_3.Text)
        code = Replace(code, "(*prof_adr*)", s_3_adr.Text)
        code = Replace(code, "(*chat_text*)", s_4.Text)
        code = Replace(code, "(*chat_id*)", s_4_adr.Text)
        txt_genCode.Text = code
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        webView = False
        code = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/bayanScoringReq.bchtml")
        code = Replace(code, "(*attach_text*)", TextBox2.Text)
        code = Replace(code, ControlChars.Lf, " ")

        txt_genCode.Text = code
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        webView = True
        code = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/bayanFixedReq.bchtml")
        Dim iPx, iPy As String
        If rad_left.Checked = True Then
            iPx = "left"
        Else
            iPx = "right"
        End If
        If rad_bottom.Checked = True Then
            iPy = "bottom"
        Else
            iPy = "top"
        End If
        code = Replace(code, "(*img_source*)", img_src.Text)
        code = Replace(code, "(*img_desc*)", img_desc.Text)
        code = Replace(code, "(*img_alt*)", img_alt.Text)
        code = Replace(code, "(*img_w*)", img_w.Text)
        code = Replace(code, "(*img_h*)", img_h.Text)
        code = Replace(code, "(*l_or_r*)", iPx)
        code = Replace(code, "(*t_or_b*)", iPy)
        txt_genCode.Text = code
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        webView = False
        txt_genCode.Text = "<meta itemprop=""image"" content=""" & TextBox7.Text & """>" & vbNewLine & "<link rel=""shortcut icon"" href=""" & TextBox7.Text & """>"
    End Sub

    Private Sub دربارهنرمافزارToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles دربارهنرمافزارToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub پیامسازToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles پیامسازToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub منوسازToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles منوسازToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub ToolStripSplitButton2_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripSplitButton2.ButtonClick

        ToolStripSplitButton2.ShowDropDown()

    End Sub

    Private Sub تغییرمتنرایگیریبلاگToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تغییرمتنرایگیریبلاگToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub تصویرثابتدرگوشهبلاگToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تصویرثابتدرگوشهبلاگToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub ایجادآیکونبرایسایتFaviconToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ایجادآیکونبرایسایتFaviconToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub تغییرشکلماوسToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تغییرشکلماوسToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        r1.Checked = False
        r2.Checked = False
        r3.Checked = False
        r4.Checked = False
        cursorAdr = "cus"
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        r1.Checked = False
        r2.Checked = False
        r3.Checked = False
        r4.Checked = False
        r5.Checked = False
        r6.Checked = False
        r7.Checked = False
        cursorAdr = "cus"
    End Sub

    Private Sub r1_CheckedChanged(sender As Object, e As EventArgs) Handles r1.CheckedChanged
        cursorAdr = "def"
    End Sub

    Private Sub r2_CheckedChanged(sender As Object, e As EventArgs) Handles r2.CheckedChanged
        cursorAdr = "def"
    End Sub

    Private Sub r3_CheckedChanged(sender As Object, e As EventArgs) Handles r3.CheckedChanged
        cursorAdr = "def"
    End Sub

    Private Sub r4_CheckedChanged(sender As Object, e As EventArgs) Handles r4.CheckedChanged
        cursorAdr = "def"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        webView = True
        If cursorAdr = "def" Then
            If r1.Checked = True Then txt_genCode.Text = "<style>body{cursor: url(""http://aryan-pc.ir/blog/b.cur""), default !important;}</style>"
            If r2.Checked = True Then txt_genCode.Text = "<style>body{cursor: url(""http://aryan-pc.ir/blog/c.cur""), default !important;}</style>"
            If r3.Checked = True Then txt_genCode.Text = "<style>body{cursor: url(""http://aryan-pc.ir/blog/d.cur""), default !important;}</style>"
            If r4.Checked = True Then txt_genCode.Text = "<style>body{cursor: url(""http://aryan-pc.ir/blog/a.cur""), default !important;}</style>"
            If r5.Checked = True Then txt_genCode.Text = "<style>body{cursor: url(""http://aryan-pc.ir/blog/e.cur""), default !important;}</style>"
            If r6.Checked = True Then txt_genCode.Text = "<style>body{cursor: url(""http://aryan-pc.ir/blog/k.cur""), default !important;}</style>"
            If r7.Checked = True Then txt_genCode.Text = "<style>body{cursor: url(""http://aryan-pc.ir/blog/j.cur""), default !important;}</style>"

        Else
            txt_genCode.Text = "<style>body{cursor:url(""" & TextBox3.Text & """),default !important;}</style>"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://aryan-pc.blog.ir/post/blog-text-static-edit")
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            Dim txtEx As TextBox = New TextBox
            txtEx.Text = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\data\Unabletoview.aryanhtm")
            generator.Load(WebBrowser1, txtEx)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '        AddHandler Button3.Paint, AddressOf ButtonPaint
        '===================================
        '[INFO: READY FOR PROPERTIES]
        BlogComboBox.SelectedIndex = 0
        CheckForIllegalCrossThreadCalls = False
        txt_genCode.BringToFront()
        RadioButton1.Checked = True

        'Dim SendersFont As Array = {ToolStrip2, ToolStrip1}
        'Aryanium.FontChanger.ChangeSenderFont_byArray(SendersFont, 0, 10)

        '[INFO: RENDERS FOR TOP MENU]

        ToolStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode
        ToolStrip1.Renderer = New AryaniumRenderer
        ToolStrip2.RenderMode = ToolStripRenderMode.ManagerRenderMode
        ToolStrip2.Renderer = New AryaniumRenderer
        ContexAdditention.RenderMode = ToolStripRenderMode.ManagerRenderMode
        ContexAdditention.Renderer = New AryaniumRenderer
        ContexMSG.RenderMode = ToolStripRenderMode.ManagerRenderMode
        ContexMSG.Renderer = New AryaniumRenderer
        txt_Right.RenderMode = ToolStripRenderMode.ManagerRenderMode
        txt_Right.Renderer = New AryaniumRenderer

        '===================================

        '[INFO: FONT CHANGER FOR BLOGCODE EDITOR]
        Dim fc As FontConverter = New FontConverter
        'If GetSetting("BlogCode", "config", "donateitem") = "hide" Then
        'Else
        'End If
        Try
            txt_genCode.Font = fc.ConvertFromString(GetSetting("BlogCode", "config", "font"))
        Catch ex As Exception
            txt_genCode.Font = fc.ConvertFromString("Segoe UI, 9.75pt")
        End Try
        '===================================

        '[INFO: LOADING PLUGINS, READY, STEADY, GO...]
        PluginLoaderForm.ShowDialog()

    End Sub

    '[INFO: RIGHT-CLICK READIER]
    Private Sub txt_Right_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_Right.Opening
        If txt_genCode.SelectedText = Nothing Then
            rtool_copy.Enabled = False
            rtool_cut.Enabled = False

        Else
            rtool_copy.Enabled = True
            rtool_cut.Enabled = True

        End If

        If Len(My.Computer.Clipboard.GetText) > 0 Then
            rtool_paste.Enabled = True
        Else
            rtool_paste.Enabled = False
        End If
        If Len(txt_genCode.Text) > 0 Then
            rtool_copyAll.Enabled = True
        Else
            rtool_copyAll.Enabled = False
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles rtool_copyAll.Click, Button7.Click
        Try
            My.Computer.Clipboard.SetText(txt_genCode.Text)
            MsgBox("ابزار با موفقیت کپی شد. کد تولید شده را در بخش مناسب از قالب خود قرار دهید", vbOKOnly + vbMsgBoxRight + vbInformation, "کپی")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rtool_cut_Click(sender As Object, e As EventArgs) Handles rtool_cut.Click
        My.Computer.Clipboard.SetText(txt_genCode.Text)
        txt_genCode.SelectedText = Nothing
    End Sub

    Private Sub rtool_paste_Click(sender As Object, e As EventArgs) Handles rtool_paste.Click
        txt_genCode.SelectedText = My.Computer.Clipboard.GetText
    End Sub

    Private Sub rtool_copy_Click(sender As Object, e As EventArgs) Handles rtool_copy.Click
        My.Computer.Clipboard.SetText(txt_genCode.SelectedText)
    End Sub

    Private Sub rtool_add_p_Click(sender As Object, e As EventArgs) Handles rtool_add_p.Click, ایجادیکپاراگرافدلخواهToolStripMenuItem.Click
        GenerateParagraphForm.ShowDialog()
    End Sub

    Private Sub rtool_add_div_Click(sender As Object, e As EventArgs) Handles rtool_add_div.Click, دایوToolStripMenuItem.Click
        txt_genCode.SelectedText = "<div class=""Class" & aryanClass & """>" & txt_genCode.SelectedText & "</div>"
        aryanClass += 1
    End Sub

    Private Sub rtool_add_link_Click(sender As Object, e As EventArgs) Handles rtool_add_link.Click, ایجادیکلینکدلخوToolStripMenuItem.Click
        GenerateLinkFont.textObj = Me.txt_genCode
        GenerateLinkFont.ShowDialog()
    End Sub

    Private Sub انتخابهمهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles انتخابهمهToolStripMenuItem.Click
        txt_genCode.SelectionStart = 0
        txt_genCode.SelectionLength = Len(txt_genCode.Text)
    End Sub

    Private Sub rtool_add_img_Click(sender As Object, e As EventArgs) Handles rtool_add_img.Click, افزودنکدتصویرToolStripMenuItem.Click
        GenerateImageForm.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        WebWarnForm.goUrl = "http://pay.aryan-pc.ir"
        WebWarnForm.ShowDialog()
    End Sub

    Private Sub r5_CheckedChanged(sender As Object, e As EventArgs) Handles r5.CheckedChanged
        cursorAdr = "def"
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click, Label29.Click, Button13.Click
        ContexAdditention.Show(MousePosition.X, MousePosition.Y)
    End Sub

    Private Sub bb_name_Click(sender As Object, e As EventArgs) Handles bb_name.Click, ToolStripMenuItem2.Click
        BlogApp("(*blog_title*)", txt_genCode)
    End Sub

    Private Sub bb_href_Click(sender As Object, e As EventArgs) Handles bb_href.Click, ToolStripMenuItem3.Click
        BlogApp("(*blog_link*)", txt_genCode)
    End Sub

    Private Sub bb_time_Click(sender As Object, e As EventArgs) Handles bb_time.Click, ToolStripMenuItem5.Click
        BlogApp("(*now*)", txt_genCode)
    End Sub

    Private Sub bb_des_short_Click(sender As Object, e As EventArgs) Handles bb_des_short.Click, ToolStripMenuItem6.Click
        BlogApp("(*blog_short_description*)", txt_genCode)
    End Sub

    Private Sub bb_des_long_Click(sender As Object, e As EventArgs) Handles bb_des_long.Click, ToolStripMenuItem7.Click
        BlogApp("(*blog_description*)", txt_genCode)
    End Sub

    Private Sub bb_rss_Click(sender As Object, e As EventArgs) Handles bb_rss.Click, ToolStripMenuItem8.Click
        BlogApp("(*rss_link*)", txt_genCode)
    End Sub

    Private Sub bb_img_Click(sender As Object, e As EventArgs) Handles bb_img.Click, ToolStripMenuItem9.Click
        BlogApp("(*blog_image*)", txt_genCode)
    End Sub

    Private Sub bb_page_title_Click(sender As Object, e As EventArgs) Handles bb_page_title.Click, ToolStripMenuItem10.Click
        BlogApp("(*page_title*)", txt_genCode)
    End Sub

    Private Sub bb_page_link_Click(sender As Object, e As EventArgs) Handles bb_page_link.Click, ToolStripMenuItem11.Click
        BlogApp("(*page_link*)", txt_genCode)
    End Sub

    Private Sub bb_page_visit_Click(sender As Object, e As EventArgs) Handles bb_page_visit.Click, ToolStripMenuItem12.Click
        BlogApp("(*post_visits*)", txt_genCode)
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        BlogApp("(*blog_title*)", msg_text)
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        BlogApp("(*now*)", msg_text)
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        BlogApp("(*blog_short_description*)", msg_text)
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        BlogApp("(*blog_description*)", msg_text)
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click
        BlogApp("(*page_title*)", msg_text)
    End Sub

    Private Sub کپیToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles کپیToolStripMenuItem.Click
        CopyText(msg_text)
    End Sub

    Private Sub برشToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles برشToolStripMenuItem.Click
        CutText(msg_text)
    End Sub

    Private Sub چسباندنToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles چسباندنToolStripMenuItem.Click
        PasteText(msg_text)
    End Sub

    Private Sub ساختکدخوشآمدگوییToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ساختکدخوشآمدگوییToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage7
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        webView = False
        code = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/bayanWelReq.bchtml")

        code = Replace(code, "(*text_head*)", txt_7_head.Text)
        code = Replace(code, "(*text_des*)", txt_7_desc.Text)
        code = Replace(code, "(*prof_href*)", txt_7_link_1_href.Text)
        code = Replace(code, "(*prof_text*)", txt_7_link_1_name.Text)
        code = Replace(code, "(*link_href*)", txt_7_link_2_hraf.Text)
        code = Replace(code, "(*link_text*)", txt_7_link_2_name.Text)
        txt_genCode.Text = code
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        code = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/bayanReqSearch.bchtml")

        code = Replace(code, "(*text_alt*)", txt_8_alt.Text)

        code = Replace(code, "(*btn_text*)", txt_8_value.Text)

        txt_genCode.Text = code
    End Sub

    Private Sub VScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar2.Scroll
        If e.Type = ScrollEventType.EndScroll Then
            txt_9_c_1.Top = 53 - VScrollBar2.Value
            txt_9_t_1.Top = 27 - VScrollBar2.Value
            Label46.Top = 32 - VScrollBar2.Value
            Label44.Top = 53 - VScrollBar2.Value

            txt_9_c_2.Top = 145 - VScrollBar2.Value
            txt_9_t_2.Top = 119 - VScrollBar2.Value
            Label47.Top = 124 - VScrollBar2.Value
            Label45.Top = 145 - VScrollBar2.Value

            txt_9_c_3.Top = 241 - VScrollBar2.Value
            txt_9_t_3.Top = 215 - VScrollBar2.Value
            Label49.Top = 220 - VScrollBar2.Value
            Label48.Top = 241 - VScrollBar2.Value

            txt_9_t_4.Top = 311 - VScrollBar2.Value
            txt_9_c_4.Top = 337 - VScrollBar2.Value
            Label51.Top = 316 - VScrollBar2.Value
            Label50.Top = 342 - VScrollBar2.Value
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        code = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/bayanSectionReq.bchtml")
        cn1 = Replace(txt_9_c_1.Text, ControlChars.Lf, "<br>")
        cn2 = Replace(txt_9_c_2.Text, ControlChars.Lf, "<br>")
        cn3 = Replace(txt_9_c_3.Text, ControlChars.Lf, "<br>")
        cn4 = Replace(txt_9_c_4.Text, ControlChars.Lf, "<br>")

        code = Replace(code, "(*title_1*)", txt_9_t_1.Text)
        code = Replace(code, "(*content_1*)", cn1)
        code = Replace(code, "(*title_2*)", txt_9_t_2.Text)
        code = Replace(code, "(*content_2*)", cn2)
        code = Replace(code, "(*title_3*)", txt_9_t_3.Text)
        code = Replace(code, "(*content_3*)", cn3)
        code = Replace(code, "(*title_4*)", txt_9_t_4.Text)
        code = Replace(code, "(*content_4*)", cn4)
        txt_genCode.Text = code
    End Sub

    Private Sub منوسازآبشاریToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles منوسازآبشاریToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage9
    End Sub

    'Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
    '    On Error Resume Next
    '    Select Case ListView1.SelectedItems.Item(0).Tag
    '        Case "a1"
    '            TabControl1.SelectedTab = TabPage1
    '        Case "a2"
    '            TabControl1.SelectedTab = TabPage2
    '        Case "a3"
    '            TabControl1.SelectedTab = TabPage3
    '        Case "a4"
    '            TabControl1.SelectedTab = TabPage4
    '        Case "a5"
    '            TabControl1.SelectedTab = TabPage5
    '        Case "a6"
    '            TabControl1.SelectedTab = TabPage6
    '        Case "a7"
    '            TabControl1.SelectedTab = TabPage9
    '        Case "a8"
    '            TabControl1.SelectedTab = TabPage10
    '        Case "b1"
    '            TabControl1.SelectedTab = TabPage7
    '        Case "b2"
    '            TabControl1.SelectedTab = TabPage8
    '        Case "b3"
    '            TabControl1.SelectedTab = TabPage11
    '        Case "b4"
    '            TabControl1.SelectedTab = TabPage12
    '        Case "b5"
    '            TabControl1.SelectedTab = TabPage13
    '        Case "a9"
    '            TabControl1.SelectedTab = TabPage14
    '        Case "b6"
    '            TabControl1.SelectedTab = TabPage15
    '    End Select

    'End Sub

    Private Sub جستجوگرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles جستجوگرToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage8
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        code = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/bayanMenuFly.bchtml")

        code = Replace(code, "(*text_1*)", txt_10_t_1.Text)
        code = Replace(code, "(*text_2*)", txt_10_t_2.Text)
        code = Replace(code, "(*text_3*)", txt_10_t_3.Text)
        code = Replace(code, "(*text_4*)", txt_10_t_4.Text)

        code = Replace(code, "(*url_1*)", txt_10_a_1.Text)
        code = Replace(code, "(*url_2*)", txt_10_a_2.Text)
        code = Replace(code, "(*url_3*)", txt_10_a_3.Text)
        code = Replace(code, "(*url_4*)", txt_10_a_4.Text)

        txt_genCode.Text = code
    End Sub

    Private Sub منوسازپردهایToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles منوسازپردهایToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage10
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click, Label60.Click, Button12.Click
        generator.Load(WebBrowser1, txt_genCode)
        Try
            Process.Start(My.Application.Info.DirectoryPath & "\data\preview.html")
        Catch ex As Exception
            MsgBox("نرم افزار نتوانست کد را در مرورگر نمایش دهد. این خطا ممکن است به دلیل نداشتن مجوز برای اجرای فایل ها در برنامه باشد", vbExclamation + vbOKOnly + vbMsgBoxRight, "خطا")
        End Try
    End Sub

    Private Sub r_11_2_CheckedChanged(sender As Object, e As EventArgs) Handles r_11_2.CheckedChanged, r_11_7.CheckedChanged, r_11_31.CheckedChanged, r_11_17.CheckedChanged
        toupAdr = "def"
    End Sub

    Private Sub TextBox1_Click1(sender As Object, e As EventArgs) Handles txt_11_src.Click
        r_11_17.Checked = False
        r_11_2.Checked = False
        r_11_31.Checked = False
        r_11_7.Checked = False
        toupAdr = "cus"
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txt_11_src.TextChanged
        r_11_17.Checked = False
        r_11_2.Checked = False
        r_11_31.Checked = False
        r_11_7.Checked = False
        toupAdr = "cus"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        code = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/bayanReqUp.bchtml")
        If toupAdr = "def" Then
            If r_11_2.Checked = True Then code = Replace(code, "(*icon_src*)", "http://avazak.ir/Java/up/?icon=02")
            If r_11_7.Checked = True Then code = Replace(code, "(*icon_src*)", "http://avazak.ir/Java/up/?icon=07")
            If r_11_17.Checked = True Then code = Replace(code, "(*icon_src*)", "http://avazak.ir/Java/up/?icon=17")
            If r_11_31.Checked = True Then code = Replace(code, "(*icon_src*)", "http://avazak.ir/Java/up/?icon=31")

        Else
            code = Replace(code, "(*icon_src*)", txt_11_src.Text)
        End If
        txt_genCode.Text = code
    End Sub

    Private Sub TabPage11_GotFocus(sender As Object, e As EventArgs) Handles TabPage11.GotFocus
        r_11_2.Checked = True
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Me.maindrop = False
        If TabControl1.SelectedTab.Text = "  هدایت به بالای صفحه  " Then r_11_2.Checked = True
    End Sub

    Private Sub هدایتبهبالایصفحهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles هدایتبهبالایصفحهToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage11
    End Sub

    Private Sub کتابخانهکدهاToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles کتابخانهکدهاToolStripMenuItem.Click
        CopyrightForm.ShowDialog()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        code = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/bayanRightMenu.bchtml")
        Dim chk1, chk2, chk3, chk4 As String
        chk1 = Nothing
        chk2 = Nothing
        chk3 = Nothing
        chk4 = Nothing

        code = Replace(code, "(*title1*)", txt_12_txt_1.Text)
        code = Replace(code, "(*title2*)", txt_12_txt_2.Text)
        code = Replace(code, "(*title3*)", txt_12_txt_3.Text)
        code = Replace(code, "(*title4*)", txt_12_txt_4.Text)

        code = Replace(code, "(*link1*)", txt_12_a_1.Text)
        code = Replace(code, "(*link2*)", txt_12_a_2.Text)
        code = Replace(code, "(*link3*)", txt_12_a_3.Text)
        code = Replace(code, "(*link4*)", txt_12_a_4.Text)

        If chk_12_1.Checked = True Then chk1 = "<hr>"
        If chk_12_2.Checked = True Then chk2 = "<hr>"
        If chk_12_3.Checked = True Then chk3 = "<hr>"
        If chk_12_4.Checked = True Then chk4 = "<hr>"

        code = Replace(code, "(*hr_1*)", chk1)
        code = Replace(code, "(*hr_2*)", chk2)
        code = Replace(code, "(*hr_3*)", chk3)
        code = Replace(code, "(*hr_4*)", chk4)

        code = Replace(code, "(*fixed_text*)", txt_12_fixed.Text)

        txt_genCode.Text = code
    End Sub

    Private Sub شخصیسازیراستکلیکToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles شخصیسازیراستکلیکToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage12
    End Sub

    Private Sub r6_CheckedChanged(sender As Object, e As EventArgs) Handles r6.CheckedChanged
        cursorAdr = "def"
    End Sub

    Private Sub r7_CheckedChanged(sender As Object, e As EventArgs) Handles r7.CheckedChanged
        cursorAdr = "def"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        code = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/bayanNewJSMenu.bchtml")

        code = Replace(code, "(*text_1*)", txt_13_text_1.Text)
        code = Replace(code, "(*text_2*)", txt_13_text_2.Text)
        code = Replace(code, "(*text_3*)", txt_13_text_3.Text)
        code = Replace(code, "(*text_4*)", txt_13_text_4.Text)
        code = Replace(code, "(*text_5*)", txt_13_text_5.Text)

        code = Replace(code, "(*link_1*)", txt_13_link_1.Text)
        code = Replace(code, "(*link_2*)", txt_13_link_2.Text)
        code = Replace(code, "(*link_3*)", txt_13_link_3.Text)
        code = Replace(code, "(*email*)", txt_13_link_4.Text)
        code = Replace(code, "(*yahoo_id*)", txt_13_link_5.Text)

        txt_genCode.Text = code
    End Sub

    Private Sub منوکشویینوعدومToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles منوکشویینوعدومToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage13
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim imycol, istyle, stylefile As String
        If CheckBox1.Checked = True Then
            stylefile = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/bayanNewButtonCSS.bchtml") & vbNewLine
        Else
            stylefile = "<!-- BTVIEW -->"
        End If
        code = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/bayanNewButton.bchtml")

        code = Replace(code, "(*bt_text*)", txt_14_text.Text)
        code = Replace(code, "(*linkurl*)", txt_14_url.Text)

        If rad_14_black.Checked = True Then imycol = "black"
        If rad_14_blue.Checked = True Then imycol = "blue"
        If rad_14_red.Checked = True Then imycol = "red"
        If rad_14_pink.Checked = True Then imycol = "pink"
        If rad_14_green.Checked = True Then imycol = "green"
        If rad_14_orange.Checked = True Then imycol = "orange"
        If rad_14_purple.Checked = True Then imycol = "purple"

        If normal.Checked = True Then istyle = "normal"
        If rad_14_criss_cross.Checked = True Then istyle = "criss-cross"
        If rad_14_shield.Checked = True Then istyle = "shield"
        If rad_14_one_corner.Checked = True Then istyle = "one-corner"
        If rad_14_rectangular.Checked = True Then istyle = "rectangular"

        code = Replace(code, "(*bt_color*)", imycol)
        code = Replace(code, "(*bt_style*)", istyle)
        code = stylefile & code
        txt_genCode.Text = code
    End Sub

    Private Sub دکمهسازگرافیکیToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles دکمهسازگرافیکیToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage14
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim imgURL As String

        code = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/bayanJSPrint.bchtml")

        If loccus = False Then
            If RadioButton1.Checked = True Then
                imgURL = "http://bayanbox.ir/id/4072110786201239621?view"
            Else
                If RadioButton2.Checked = True Then
                    imgURL = "http://bayanbox.ir/id/6499575022236352856?view"
                Else
                    imgURL = "http://bayanbox.ir/id/562495496507979543?view"
                End If
            End If

        Else
            imgURL = txt_15.Text
        End If
        code = Replace(code, "(*img_url*)", imgURL)
        txt_genCode.Text = code
    End Sub

    Private Sub txt_15_TextChanged(sender As Object, e As EventArgs) Handles txt_15.TextChanged
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton4.Checked = False
        loccus = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton4.CheckedChanged, RadioButton2.CheckedChanged
        If sender.Checked = True Then
            loccus = False
        End If
    End Sub

    Private Sub TabPage15_Click(sender As Object, e As EventArgs) Handles TabPage15.Click

    End Sub

    Private Sub چاپصفحهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles چاپصفحهToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage15
    End Sub

    Sub BTN_PLUGIN_plugin_info(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        Dim tagArr As Array = Split(sender.Tag, ",")
        Try
            code = My.Computer.FileSystem.ReadAllText(tagArr(0))
        Catch ex As Exception
            whatToDo = MsgBox("در افزونه ساخته شده به هیچ فایل متنی برای بارگذاری آدرس داده نشده است برای اطلاعات بیشتر مایلید وارد آرین نرم افزار شوید؟", vbExclamation + vbYesNo + vbMsgBoxRight, "اخطار")
            If whatToDo = vbYes Then
                Process.Start("http://aryan-pc.blog.ir/post/how-to-make-plugin")
            End If
            Exit Sub
        End Try

        Dim nums As Integer = (TabControl1.TabPages.Count - 1) - (PluginLoaderForm.cToUp - Val(tagArr(1)) - 1)
        Dim tArray As Collection = New Collection

        For Each CurrentTabPageControl As Control In TabControl1.TabPages(nums).Controls.Item(1).Controls

            'If ttt.GetType.ToString = "System.Windows.Forms.TextBox" OrElse "System.Windows.Forms.ComboBox" Then

            If CurrentTabPageControl.Tag = "input" Or CurrentTabPageControl.GetType.ToString = "System.Windows.Forms.ComboBox" Then

                tArray.Add(CurrentTabPageControl)

            End If

        Next

        For i = 1 To 100
            Try
                Dim WhatToAppend As String

                If tArray(i).Tag.ToString.Contains("[%20_ar!combo]") Then

                    WhatToAppend = Split(tArray(i).Tag, "|")(tArray(i).SelectedIndex + 1)
                    WhatToAppend = Replace(WhatToAppend, "{toleft;", ">")
                    WhatToAppend = Replace(WhatToAppend, "{toright;", "<")
                Else
                    WhatToAppend = tArray(i).Text
                End If
                code = Replace(code, "(*var" & i & "*)", WhatToAppend)
            Catch ex As Exception

                Exit For
            End Try
        Next

        txt_genCode.Text = code
    End Sub

    Sub BTN_PLUGIN_generate(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click
        Dim iArryayInfo As Array = Split(sender.Tag, ",")
        PluginInfoForm.lbl_name.Text = iArryayInfo(3)
        PluginInfoForm.lbl_version.Text = "نسخه: " & iArryayInfo(1)
        PluginInfoForm.lbl_madeof.Text = iArryayInfo(0)
        PluginInfoForm.lbl_des.Text = iArryayInfo(2)
        PluginInfoForm.Button1.Tag = iArryayInfo(4)
        If iArryayInfo(5) <> Nothing Then
            PluginInfoForm.lbl_copyto.Text = iArryayInfo(5)
        Else
            PluginInfoForm.lbl_copyto.Text = "نامشخص"
        End If

        If Trim(iArryayInfo(4)) = "" Then
            PluginInfoForm.Button1.Visible = False
        Else
            PluginInfoForm.Button1.Visible = True
        End If
        PluginInfoForm.ShowDialog()
    End Sub

    Sub goOnTAB_Click(sender As Object, e As EventArgs) Handles goOnTAB.Click
        Try
            TabControl1.SelectedIndex = (TabControl1.TabPages.Count - 1) - (PluginLoaderForm.cToUp - Val(sender.Tag) - 1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub آموزشساختافزونهبرایایننرمافزارToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles آموزشساختافزونهبرایایننرمافزارToolStripMenuItem.Click
        WebWarnForm.goUrl = "http://aryan-pc.blog.ir/post/how-to-make-plugin"
        WebWarnForm.ShowDialog()
    End Sub

    Private Sub plugmenu_Click(sender As Object, e As EventArgs) Handles plugmenu.Click
        If plugmenu.DropDownItems.Count = 0 Then
            MsgBox("شما تا کنون هیچ افزونه ای نصب نکرده اید. میتوانید خود اقدام به ساخت افزونه کنید و یا افزونه های آماده را از آرین نرم افزار دانلود کنید", vbInformation + vbOKOnly + vbMsgBoxRight, "افزونه")
        End If
    End Sub

    Private Sub err_rep_item_strip_Click(sender As Object, e As EventArgs) Handles err_rep_item_strip.Click
        WebWarnForm.goUrl = "http://aryan-pc.blog.ir/page/error-report"
        WebWarnForm.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        msg_text.SelectedText = "<hr>"
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        msg_text.SelectedText = "<b>" & msg_text.SelectedText & "</b>"
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        msg_text.SelectedText = "<strike>" & msg_text.SelectedText & "</strike>"
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        msg_text.SelectedText = "<i>" & msg_text.SelectedText & "</i>"
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        msg_text.SelectedText = "<u>" & msg_text.SelectedText & "</u>"
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If msg_text.SelectedText <> Nothing Then
            GenerateLinkFont.txt_A.ReadOnly = True
            GenerateLinkFont.txt_A.Text = msg_text.SelectedText
        End If
        GenerateLinkFont.textObj = Me.msg_text
        GenerateLinkFont.ShowDialog()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        msg_text.TextAlign = HorizontalAlignment.Left
        msg_text.RightToLeft = Windows.Forms.RightToLeft.Yes
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        msg_text.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        msg_text.TextAlign = HorizontalAlignment.Left
        msg_text.RightToLeft = Windows.Forms.RightToLeft.No
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        CodeInsertForm.textObj = msg_text
        CodeInsertForm.ShowDialog()
    End Sub

    Private Sub پاککردنهمهمتنToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles پاککردنهمهمتنToolStripMenuItem.Click
        msg_text.Text = Nothing
    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        msg_text.Text = Nothing
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Header.Paint
        ControlPaint.DrawBorder(e.Graphics, pnl_Header.ClientRectangle, Color.Black, 0, ButtonBorderStyle.None, Color.Black, 0, ButtonBorderStyle.None, Color.Black, 0, ButtonBorderStyle.None, Color.DarkGray, 1, ButtonBorderStyle.Solid)
    End Sub

    Private Sub خروجToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles خروجToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub اجرایمجددToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اجرایمجددToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub پیشرفتهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles پیشرفتهToolStripMenuItem.Click

        SettingsForm.ShowDialog()

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles لینکسازToolStripMenuItem.Click
        LinkToolsForm.ShowDialog()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles تصویرسازToolStripMenuItem.Click
        ImageToolsForm.ShowDialog()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles متحرکسازToolStripMenuItem.Click
        MarqueeToolsForm.ShowDialog()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles سورسگیرToolStripMenuItem.Click
        SourceToolsForm.ShowDialog()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles لینکدونیToolStripMenuItem.Click
        Try
            LinkListForm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PluginDownload_Click(sender As Object, e As EventArgs) Handles دانلودافزونهToolStripMenuItem.Click
        WebWarnForm.goUrl = "http://aryan-pc.blog.ir/post/plugins"
        WebWarnForm.ShowDialog()
    End Sub

    Private Sub CreateNewPlugin_Click(sender As Object, e As EventArgs) Handles ساختافزونهجدیدToolStripMenuItem.Click
        Try
            Process.Start(My.Application.Info.DirectoryPath & "/PluginWorkShop.exe")

        Catch ex As Exception
            MsgBox("نرم افزار افزونه ساز پیدا نشد. نصب دوباره نرم افزار میتواند این مشکل را حل کند", MsgBoxStyle.MsgBoxRight + vbExclamation + vbOKOnly, "خطا")
        End Try
    End Sub

    Private Sub ToolStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub

    Private Sub InstallPlugin_Click(sender As Object, e As EventArgs) Handles نصبافزونهToolStripMenuItem.Click
        Dim m = iOpenFile.ShowDialog
        If m = vbOK Then
            Dim ZipToUnpack As String = iOpenFile.FileName
            Dim UnpackDirectory As String = My.Application.Info.DirectoryPath & "\plugins"
            Try
                Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
                    If zip1.Comment.Contains("Type: Aryan Software Plugin") Then
                        Dim iFiler As ZipEntry
                        ' here, we extract every entry, but we could extract conditionally,
                        ' based on entry name, size, date, checkbox status, etc.
                        For Each iFiler In zip1
                            iFiler.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
                        Next
                        Dim msgResult As MsgBoxResult = MsgBox("افزونه مورد نظر با موفقیت نصب شد. مایلید برای ساخت کد نرم افزار را مجددا اجرا کنید؟", MsgBoxStyle.MsgBoxRtlReading + vbQuestion + vbYesNo + vbMsgBoxRight, "انجام شد")
                        If msgResult = vbYes Then
                            Application.Restart()
                        End If
                    Else
                        MsgBox("نرم افزار نمی تواند این فایل را به عنوان یک فایل افزونه بپذیرد. لطفا یک فایل افزونه انتخاب کنید", vbExclamation + vbOKOnly + vbMsgBoxRight, "خطا")
                    End If

                End Using
            Catch ex As Exception
                MsgBox("نرم افزار نمی تواند این فایل را به عنوان یک فایل افزونه بپذیرد. لطفا یک فایل افزونه انتخاب کنید", vbExclamation + MsgBoxStyle.MsgBoxRight + vbOKOnly, "خطا")
            End Try

        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles قالبسازToolStripMenuItem.Click
        MsgBox("نرم افزار حساب کاربری شما را به عنوان کاربر عادی تشخیص داده است. لذا در این نسخه به قالب ساز دسترسی ندارید. در نسخه های بعدی این امکان برای شما نیز موجود خواهد بود", vbOKOnly + vbExclamation + vbMsgBoxRight, "عدم دسترسی")
    End Sub

    Private Sub ازایننرمافزاررایگانحمایتکنیدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ازایننرمافزاررایگانحمایتکنیدToolStripMenuItem.Click
        VisitURL("http://pay.aryan-pc.ir")
    End Sub

    Private Sub بهروزرسانیفایلهاToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles itm_CheckForUpdate_.Click
        TBASE = New Thread(AddressOf CheckForUpdate)
        TBASE.IsBackground = True
        TBASE.Start()
    End Sub

    Private Sub TabPage8_Click(sender As Object, e As EventArgs) Handles TabPage8.Click

    End Sub

    Private Sub ToolDownUpdate_Click(sender As Object, e As EventArgs) Handles ToolDownUpdate.Click
        MsgBox(ToolDownUpdate.Tag, vbOKOnly + MsgBoxStyle.MsgBoxRight + vbInformation, "اطلاعات")

    End Sub

    Private Sub ToolUpUpdate_Click(sender As Object, e As EventArgs) Handles ToolUpUpdate.Click
        UpdateForm.ShowDialog()
    End Sub

    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        VisitURL("http://aryan-pc.blog.ir/post/article-using-ui-buttons-in-blog-posts")
    End Sub

    Private Sub frm_base_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        '[INFO: CHECK FOR UPDATES]
        TBASE = New Thread(AddressOf CheckForUpdate)
        TBASE.IsBackground = True
        TBASE.Start()

    End Sub

    Public Sub ButtonPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button9.Paint, Button8.Paint, Button6.Paint, Button5.Paint, Button4.Paint, Button3.Paint, Button2.Paint, Button19.Paint, Button18.Paint, Button17.Paint, Button16.Paint, Button15.Paint, Button14.Paint, Button11.Paint, Button10.Paint, Button1.Paint, Button7.Paint, Button13.Paint, Button12.Paint
        Dim Btn = DirectCast(sender, Button)
        Using P As New Pen(Me.BackColor)
            e.Graphics.DrawRectangle(P, 1, 1, Btn.Width - 3, Btn.Height - 3)
        End Using
    End Sub

End Class

