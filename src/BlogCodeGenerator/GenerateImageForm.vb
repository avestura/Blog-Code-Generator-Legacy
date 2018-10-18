Public Class GenerateImageForm

    Private Sub btn_imgGen_Click(sender As Object, e As EventArgs) Handles btn_imgGen.Click
        Dim imgGen, iAlt, iDes As String
        If txt_alt.Text <> "" Then
            iAlt = "alt=""" & txt_alt.Text & """ "
        Else
            iAlt = ""
        End If

        If txt_des.Text <> "" Then
            iDes = "title=""" & txt_des.Text & """ "
        Else
            iDes = ""
        End If

        imgGen = "<img src=""" & txt_src.Text & """ style=""width:" & txt_width.Text & ";height:" & txt_height.Text & """ " & iAlt & iDes & ">"
        BaseForm.txt_genCode.SelectedText = imgGen
        Me.Close()
    End Sub

    Private Sub DrawBottomBorder(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, sender.ClientRectangle, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid)
    End Sub
End Class