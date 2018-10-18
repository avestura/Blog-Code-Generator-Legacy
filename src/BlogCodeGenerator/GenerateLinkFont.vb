Public Class GenerateLinkFont
    Public textObj As TextBox = BaseForm.txt_genCode

    Private Sub frm_a_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        txt_A.ReadOnly = False
    End Sub
    Private Sub frm_a_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd_target.SelectedIndex = 1
        cmd_Direction.SelectedIndex = 0
    End Sub

    Private Sub btn_agen_Click(sender As Object, e As EventArgs) Handles btn_agen.Click
        Dim pGen, Classor, Idor, mText, iTarget, lHref As String
        Dim wD As String
        Select Case cmd_Direction.SelectedIndex
            Case 0
                wD = ""
            Case 1
                wD = "style=""direction:rtl"" "
            Case 2
                wD = "style=""direction:ltr"" "
        End Select
        Select Case cmd_target.SelectedIndex
            Case 0
                iTarget = "target=""_blank"""
            Case 1
                iTarget = "target=""_self"""
            Case 2
                iTarget = "target=""_parent"""
            Case 3
                iTarget = "target=""_top"""
        End Select
        If txt_Address.Text = "" Then
            lHref = ""
        Else
            lHref = "href=""" & txt_Address.Text & """ "
        End If
        mText = Replace(txt_A.Text, ControlChars.Lf, "<br>")
        If txt_Class.Text <> "" Then Classor = "class=""" & txt_Class.Text & """ "
        If txt_Id.Text <> "" Then Idor = "id=""" & txt_Id.Text & """ "
        pGen = "<a " & lHref & Classor & Idor & wD & iTarget & ">" & mText & "</a>"
        textObj.SelectedText = pGen
        Me.Close()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        BlogApp("(*blog_title*)", txt_A)
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        BlogApp("(*now*)", txt_A)
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        BlogApp("(*blog_short_description*)", txt_A)
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        BlogApp("(*blog_description*)", txt_A)
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click
        BlogApp("(*page_title*)", txt_A)
    End Sub

    Private Sub کپیToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles کپیToolStripMenuItem.Click
        CopyText(txt_A)
    End Sub

    Private Sub برشToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles برشToolStripMenuItem.Click
        CutText(txt_A)
    End Sub

    Private Sub چسباندنToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles چسباندنToolStripMenuItem.Click
        PasteText(txt_A)
    End Sub

    Private Sub DrawBottomBorder(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, sender.ClientRectangle, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid)
    End Sub
End Class