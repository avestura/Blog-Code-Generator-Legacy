Public Class GenerateParagraphForm

    Private Sub frm_add_p_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd_Direction.SelectedIndex = 0
    End Sub

    Private Sub افزودنپاراگرافبهکدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles افزودنپاراگرافبهکدToolStripMenuItem.Click
        Dim pGen, Classor, Idor, mText, stylish, cDefiner As String
        Dim wD As String
        Select Case cmd_Direction.SelectedIndex
            Case 0
                wD = ""
            Case 1
                wD = "direction:rtl"
            Case 2
                wD = "direction:ltr"
        End Select
        If cmd_Color.Text <> "" Then
            cDefiner = "color:" & cmd_Color.Text
        Else
            cDefiner = ""
        End If
        If cmd_Color.Text = "" AndAlso cmd_Direction.SelectedIndex = 0 Then
            stylish = ""
        Else
            If cmd_Color.Text <> "" Then
                stylish = "style=""" & cDefiner & ";" & wD & """"""
            Else
                stylish = "style=""" & wD & """"
            End If
        End If
        mText = Replace(txt_P.Text, ControlChars.Lf, "<br>")
        If txt_Class.Text <> "" Then Classor = "class=""" & txt_Class.Text & """ "
        If txt_Id.Text <> "" Then Idor = "id=""" & txt_Id.Text & """ "
        pGen = "<p " & Classor & Idor & stylish & ">" & mText & "</p>"
        BaseForm.txt_genCode.SelectedText = pGen
        Me.Close()
    End Sub

    Private Sub cmd_Direction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmd_Direction.SelectedIndexChanged

    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        BlogApp("(*blog_title*)", txt_P)
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        BlogApp("(*now*)", txt_P)
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        BlogApp("(*blog_short_description*)", txt_P)
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        BlogApp("(*blog_description*)", txt_P)
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click
        BlogApp("(*page_title*)", txt_P)
    End Sub

    Private Sub کپیToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles کپیToolStripMenuItem.Click
        CopyText(txt_P)
    End Sub

    Private Sub برشToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles برشToolStripMenuItem.Click
        CutText(txt_P)
    End Sub

    Private Sub چسباندنToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles چسباندنToolStripMenuItem.Click
        PasteText(txt_P)
    End Sub

    Private Sub DrawBottomBorder(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, sender.ClientRectangle, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid)
    End Sub
End Class