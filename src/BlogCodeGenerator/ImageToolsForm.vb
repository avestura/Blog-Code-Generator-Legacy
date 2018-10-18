Public Class ImageToolsForm

    Private Sub tools_img_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        code = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "/data/tools/img_generator.html")

        code = Replace(code, "(*src*)", txt_src.Text)
        code = Replace(code, "(*width*)", txt_width.Text)
        code = Replace(code, "(*height*)", txt_height.Text)
        code = Replace(code, "(*height*)", txt_height.Text)
        code = Replace(code, "(*othercss*)", TextBox2.Text)

        If txt_alt.Text <> "" Then code = Replace(code, "(*alt*)", " alt=""" & txt_alt.Text & """ ") Else code = Replace(code, "(*alt*)", Nothing)
        If txt_des.Text <> "" Then code = Replace(code, "(*title*)", " title=""" & txt_des.Text & """") Else code = Replace(code, "(*title*)", Nothing)

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