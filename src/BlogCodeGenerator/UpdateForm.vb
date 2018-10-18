Imports System.Net

Public Class UpdateForm

    Private Sub UpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_AppVer.Text = "نسخه نرم افزار شما: " & BaseForm.ThisVersion
        lbl_SevVer.Text = "آخرین نسخه منتشر شده: " & BaseForm.ServerVersion
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_GoUpdate.Click
        Try
            Process.Start(BaseForm.ServerLink & "?from=blogcode_" & BaseForm.ThisVersion)

        Catch ex As Exception

        End Try
        Me.Close()
    End Sub
    Private Sub ButtonPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles btn_GoUpdate.Paint
        Dim Btn = DirectCast(sender, Button)
        Using P As New Pen(Color.White)
            e.Graphics.DrawRectangle(P, 1, 1, Btn.Width - 3, Btn.Height - 3)
        End Using
    End Sub

    Private Sub DrawBottomBorder(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, sender.ClientRectangle, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid)
    End Sub
End Class