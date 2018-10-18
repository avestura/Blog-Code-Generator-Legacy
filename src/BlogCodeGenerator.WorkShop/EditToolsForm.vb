Public Class EditToolsForm
    Dim VarCount As Integer = 1
    Private Sub اسکریپتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اسکریپتToolStripMenuItem.Click
        code.SelectedText = "<script>" & code.SelectedText & "</script>"
    End Sub

    Private Sub استایلCSSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles استایلCSSToolStripMenuItem.Click
        code.SelectedText = "<style>" & code.SelectedText & "</style>"
    End Sub

    Private Sub دایوToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles دایوToolStripMenuItem.Click
        code.SelectedText = "<div>" & code.SelectedText & "</div>"
    End Sub

    Private Sub لینکToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles لینکToolStripMenuItem.Click
        code.SelectedText = "<link att=""" & code.SelectedText & """>"
    End Sub

    Private Sub Var1ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub rrm_code_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rrm_code_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Tag = code.Text
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        code.Text = Me.Tag
        Me.Hide()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Tag = code.Text
        Me.Hide()
    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click
        code.SelectedText = "<a href="""">" & code.SelectedText & "</a>"
    End Sub

    Private Sub Var1ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles Var1ToolStripMenuItem.Click
        code.SelectedText = "(*var?*)"
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        code.SelectedText = "(*var" & VarCount & "*)"
        VarCount += 1
    End Sub
End Class