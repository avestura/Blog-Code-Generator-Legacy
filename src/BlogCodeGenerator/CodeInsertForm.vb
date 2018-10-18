Imports System.Threading
Imports System.Net
Public Class CodeInsertForm
    Public textObj As TextBox
    Dim Ps As String
    Private Sub frm_codedarg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            textObj.AppendText(TextBox1.Text)

        Catch ex As Exception

        End Try
        Me.Close()
    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click
        TextBox1.SelectedText = "<a href=""#"">" & TextBox1.SelectedText & "</a>"
    End Sub

    Private Sub PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PToolStripMenuItem.Click
        TextBox1.SelectedText = "<p>" & TextBox1.SelectedText & "</p>"
    End Sub

    Private Sub ImgToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImgToolStripMenuItem.Click
        TextBox1.SelectedText = "<img src=""" & TextBox1.SelectedText & """ alt="""" >"
    End Sub

    Private Sub DivToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DivToolStripMenuItem.Click
        TextBox1.SelectedText = "<div>" & TextBox1.SelectedText & "</div>"
    End Sub

    Private Sub BlockquoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlockquoteToolStripMenuItem.Click
        TextBox1.SelectedText = "<blockquote>" & TextBox1.SelectedText & "</blockquote>"
    End Sub

    Private Sub IframeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IframeToolStripMenuItem.Click
        TextBox1.SelectedText = "<iframe src=""" & TextBox1.SelectedText & """ height=""200px"" width=""200px"">"
    End Sub

    Private Sub SpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpanToolStripMenuItem.Click
        TextBox1.SelectedText = "<span>" & TextBox1.SelectedText & "</span>"
    End Sub

    Private Sub ScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScriptToolStripMenuItem.Click
        TextBox1.SelectedText = "<script src=""#"">" & TextBox1.SelectedText & "</script>"
    End Sub

    Private Sub LinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinkToolStripMenuItem.Click
        TextBox1.SelectedText = "<link type="""" rel="""">"
    End Sub

    Private Sub بازکردنToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles بازکردنToolStripMenuItem.Click
        chk = OpenFileDialog1.ShowDialog
        Try
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Atterbutation_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click, ToolStripMenuItem9.Click, ToolStripMenuItem7.Click, ToolStripMenuItem6.Click, ToolStripMenuItem5.Click, ToolStripMenuItem4.Click, ToolStripMenuItem3.Click, ToolStripMenuItem2.Click, ToolStripMenuItem12.Click, ToolStripMenuItem11.Click, ToolStripMenuItem10.Click, ToolStripMenuItem1.Click, ToolStripMenuItem13.Click
        TextBox1.SelectedText = " " & sender.Text & "="""" "
    End Sub

    Private Sub ButtonPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button3.Paint
        Dim Btn = DirectCast(sender, Button)
        Using P As New Pen(Color.White)
            e.Graphics.DrawRectangle(P, 1, 1, Btn.Width - 3, Btn.Height - 3)
        End Using
    End Sub
End Class