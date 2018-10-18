Public Class MarqueeToolsForm

    Private Sub tools_marquee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd_target.SelectedIndex = 0
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button3_Click(sender, e)
        generator.Load(WebBrowser1, TextBox1)
        Try
            Process.Start(My.Application.Info.DirectoryPath & "\tmphtml.html")
        Catch ex As Exception
            MsgBox("نرم افزار نتوانست کد را در مرورگر نمایش دهد. این خطا ممکن است به دلیل نداشتن مجوز برای اجرای فایل ها در برنامه باشد", vbExclamation + vbOKOnly + vbMsgBoxRight, "خطا")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        code = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/tools/marquee.html")

        code = Replace(code, "(*amount*)", NumericUpDown2.Value)
        code = Replace(code, "(*text*)", Replace(txt_A.Text, ControlChars.CrLf, "<br>"))

        If ComboBox1.SelectedIndex = 0 Then
            code = Replace(code, "(*loop*)", Nothing)
        Else
            code = Replace(code, "(*loop*)", " loop=""" & NumericUpDown1.Value & """")
        End If

        Select Case cmd_target.SelectedIndex 'alternate
            Case 0
                code = Replace(code, "(*behave*)", "scroll")
            Case 1
                code = Replace(code, "(*behave*)", "slide")
            Case 2
                code = Replace(code, "(*behave*)", "alternate")
        End Select

        Select Case ComboBox2.SelectedIndex 'alternate
            Case 0
                code = Replace(code, "(*direction*)", "left")
            Case 1
                code = Replace(code, "(*direction*)", "right")
            Case 2
                code = Replace(code, "(*direction*)", "up")
            Case 3
                code = Replace(code, "(*direction*)", "down")
        End Select

        TextBox1.Text = code
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            NumericUpDown1.Enabled = False
        Else
            NumericUpDown1.Enabled = True

        End If
    End Sub

    Private Sub ButtonPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button3.Paint, Button1.Paint
        Dim Btn = DirectCast(sender, Button)
        Using P As New Pen(Color.White)
            e.Graphics.DrawRectangle(P, 1, 1, Btn.Width - 3, Btn.Height - 3)
        End Using
    End Sub

    Private Sub DrawBottomBorder(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, sender.ClientRectangle, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid)
    End Sub
End Class