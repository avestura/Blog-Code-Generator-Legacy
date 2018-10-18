Public Class LinkToolsForm

    Private Sub tools_a_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd_target.SelectedIndex = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        code = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/tools/link_generator.html")

        code = Replace(code, "(*href*)", txt_Address.Text)
        code = Replace(code, "(*text*)", Replace(txt_A.Text, ControlChars.CrLf, "<br>"))

        If cmd_target.SelectedIndex = 1 Then
            code = Replace(code, "(*target*)", Nothing)
        Else
            Select Case cmd_target.SelectedIndex
                Case 0
                    code = Replace(code, "(*target*)", " target=""_blank"" ")
                Case 2
                    code = Replace(code, "(*target*)", " target=""_parent"" ")
                Case 3
                    code = Replace(code, "(*target*)", " target=""_top"" ")
            End Select

        End If
        If TextBox2.Text <> "" Then code = Replace(code, "(*style*)", " style=""" & TextBox2.Text & """ ") Else code = Replace(code, "(*style*)", Nothing)
        If txt_Id.Text <> "" Then code = Replace(code, "(*id*)", " id=""" & txt_Id.Text & """ ") Else code = Replace(code, "(*id*)", Nothing)
        If txt_Class.Text <> "" Then code = Replace(code, "(*class*)", " class=""" & txt_Class.Text & """ ") Else code = Replace(code, "(*class*)", Nothing)

        TextBox1.Text = code
    End Sub

    Private Sub ButtonPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button3.Paint
        Dim Btn = DirectCast(sender, Button)
        Using P As New Pen(Color.White)
            e.Graphics.DrawRectangle(P, 1, 1, Btn.Width - 3, Btn.Height - 3)
        End Using
    End Sub

    Private Sub DrawBottomBorder(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, sender.ClientRectangle, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid)
    End Sub
End Class