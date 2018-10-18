Public Class WebWarnForm
    Public goUrl As String
    Private Sub frm_webwarn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_UrlToGo.Text = goUrl
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Process.Start(goUrl & "?from=blog_code")
        Catch ex As Exception

        End Try
        Me.Close()
    End Sub

    Private Sub ButtonPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button3.Paint, Button1.Paint
        Dim Btn = DirectCast(sender, Button)
        Using P As New Pen(Color.White)
            e.Graphics.DrawRectangle(P, 1, 1, Btn.Width - 3, Btn.Height - 3)
        End Using
    End Sub
End Class