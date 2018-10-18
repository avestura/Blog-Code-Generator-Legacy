Public Class AboutForm


    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Process.Start("http://aryan-pc.blog.ir/?from=blogcode_about")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Try
            Process.Start("mailto:aryanebrahimpour@gmail.com?subject=کدساز&body=من در رابطه با نرم افزار کد ساز ایمیل میزنم")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) 
        Process.Start("http://aryanshadowhunter.github.io/blogcode-dev/")
    End Sub

    Private Sub DrawBottomBorder(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, sender.ClientRectangle, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid)
    End Sub

    Private Sub DrawTopBorder(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, sender.ClientRectangle, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None)
    End Sub
End Class