
Module generator

    Function StringCycle(howmuch As Integer, iString As String)
        Dim Save As String = iString
        Try
            For i = 1 To howmuch
                iString = Save + iString
            Next

        Catch ex As Exception

        End Try
        Return iString
    End Function
    Function Load(ByRef iWeb As WebBrowser, txtCode As TextBox)
        On Error Resume Next
        Dim raw As String = txtCode.Text
        ' If Form1.webView = True Then
        raw = "<html><head><title>نمایش نتیجه - کد ساز</title><link rel=""shortcut icon"" href=""fav.png""><link href=""bayanReqC.css"" rel=""stylesheet"" type=""text/css""><link href=""style.css"" rel=""stylesheet"" type=""text/css""></head><body><style>body{direction:rtl;font-family:Tahoma;font-size:11px;}</style>" + raw
        'kham = Replace(kham, "<load:css>", "<link href=""" & My.Application.Info.DirectoryPath & "\style.css" & """ rel=""stylesheet"" type=""text/css"">")
        raw = Replace(raw, "(*site_name*)", "")

        raw = Replace(raw, "(*blog_title*)", "[نام سایت]")
        raw = Replace(raw, "(*blog_link*)", "[آدرس سایت]")
        raw = Replace(raw, "(*now*)", "[زمان]")
        raw = Replace(raw, "(*blog_short_description*)", "[توضیحات کوتاه]")
        raw = Replace(raw, "(*blog_description*)", "[توضحیات بلند]")
        raw = Replace(raw, "(*rss_link*)", "[لینک خوراک خبری]")
        raw = Replace(raw, "(*blog_image*)", "[آدرس تصویر وبلاگ]")
        raw = Replace(raw, "(*page_title*)", "[نام صفحه]")
        raw = Replace(raw, "(*page_link*)", "[آدرس صفحه]")
        raw = Replace(raw, "(*post_visits*)", "[تعداد بازدید های پست فعلی]")

        loadgen = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/bayanToup_wrn.bchtml")
        raw = Replace(raw, "<!--GENVIEW-->", loadgen & "<style>#topcontrol > img {height: 64px;width: 64px;}</style>" & StringCycle(70, "<br>"))
        loadgen = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/bayanMenu_wrn.bchtml")
        raw = Replace(raw, "<!-- Right Click SCRIPT Generation View -->", loadgen)
        raw = Replace(raw, "<!-- BTVIEW -->", My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/bayanNewButtonCSS.bchtml") & vbNewLine)

        raw = raw + "</body></html>"
        'End of WMR
        'Else
        ' kham = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\data\Unabletoview")
        'End If
        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\data\preview.html", raw, False)
        'iWeb.Navigate(New Uri(My.Application.Info.DirectoryPath & "\tmphtml.html"))
        Return Nothing
    End Function
    Function BlogApp(ByRef Text As String, Textbox As TextBox)
        Textbox.SelectedText = Text
        Return Nothing
    End Function
    Function CopyText(ByRef Textbox As TextBox)
        Try

            My.Computer.Clipboard.SetText(Textbox.SelectedText)
        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    Function CutText(ByRef iTextBox As TextBox)
        Try
            My.Computer.Clipboard.SetText(iTextBox.SelectedText)
            iTextBox.SelectedText = ""
        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    Function PasteText(ByRef Textbox As TextBox)
        GetT = My.Computer.Clipboard.GetText
        Textbox.SelectedText = GetT
        Return Nothing
    End Function

    Sub VisitURL(ByVal Address As String)
        WebWarnForm.goUrl = Address
        WebWarnForm.ShowDialog()
    End Sub

    Public Class AryaniumRenderer
        Inherits System.Windows.Forms.ToolStripProfessionalRenderer

        Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)

            If e.Item.Selected Then
                '180,37,174,255
                Dim b = New SolidBrush(Color.FromArgb(150, 37, 174, 255))
                Try
                    e.Graphics.FillRectangle(b, e.Item.ContentRectangle)
                    e.Item.ForeColor = Color.White
                Finally
                    b.Dispose()
                End Try
            Else
                Dim p As New SolidBrush(Color.White)
                Try
                    e.Item.ForeColor = Color.Black
                Finally
                    p.Dispose()
                End Try
            End If
        End Sub

        'Protected Overrides Sub OnRenderSplitButtonBackground(e As ToolStripItemRenderEventArgs)
        '    If e.Item.Selected Then
        '        Dim b = New SolidBrush(Color.FromArgb(50, 37, 174, 255))
        '        Dim ConRec As Rectangle
        '        Dim ConRecPadding As Integer = 2
        '        With ConRec
        '            .X = e.Item.ContentRectangle.X - ConRecPadding
        '            .Y = e.Item.ContentRectangle.Y - ConRecPadding
        '            .Width = e.Item.ContentRectangle.Width + ConRecPadding
        '            .Height = e.Item.ContentRectangle.Height + ConRecPadding
        '        End With
        '        Try
        '            e.Graphics.FillRectangle(b, ConRec)
        '            e.Graphics.DrawRectangle(Pens.DodgerBlue, ConRec)
        '        Finally
        '            b.Dispose()

        '        End Try
        '        'Else
        '        '    Dim p As New SolidBrush(ProfessionalColors.SeparatorLight)
        '        '    Try
        '        '        e.Graphics.FillRectangle(p, e.Item.ContentRectangle)
        '        '    Finally
        '        '        p.Dispose()
        '        '    End Try
        '    End If
        '    MyBase.OnRenderSplitButtonBackground(e)
        'End Sub

        'Protected Overrides Sub OnRenderSeparator(e As ToolStripSeparatorRenderEventArgs)
        '    Try
        '        e.Graphics.DrawLine(Pens.LightGray, e.Item.ContentRectangle.X, e.Item.ContentRectangle.Y, e.Item.ContentRectangle.X + e.Item.Size.Width - 10, e.Item.ContentRectangle.Y)

        '    Finally

        '    End Try

        '    MyBase.OnRenderSeparator(e)
        'End Sub

        'Protected Overrides Sub OnRenderButtonBackground(e As ToolStripItemRenderEventArgs)
        '    Dim r As Rectangle = Rectangle.Inflate(e.Item.ContentRectangle, -2, -2)

        '    If e.Item.Selected Then
        '        Dim b = New SolidBrush(Color.FromArgb(37, 174, 255))
        '        Try
        '            e.Graphics.FillRectangle(b, e.Item.ContentRectangle)
        '        Finally
        '            b.Dispose()
        '        End Try
        '    Else
        '        Dim p As New Pen(ProfessionalColors.SeparatorLight)
        '        Try
        '            e.Graphics.DrawRectangle(p, e.Item.ContentRectangle)
        '        Finally
        '            p.Dispose()
        '        End Try
        '    End If
        'End Sub

    End Class
End Module
