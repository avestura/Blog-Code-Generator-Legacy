Public Class CopyrightForm

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked, LinkLabel4.LinkClicked, LinkLabel3.LinkClicked, LinkLabel2.LinkClicked, LinkLabel9.LinkClicked, LinkLabel7.LinkClicked, LinkLabel5.LinkClicked, LinkLabel10.LinkClicked
        Try

            Process.Start("http://" & LCase(sender.Text) & "?from=aryan_pc_copyright")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_copyright_Load(sender As Object, e As EventArgs) Handles MyBase.Load
  
    End Sub

    Private Sub DrawBottomBorder(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, sender.ClientRectangle, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid)
    End Sub
End Class