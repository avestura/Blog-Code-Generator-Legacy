Imports System.Net
Imports System.Threading
Public Class SettingsForm
    Dim q As WebClient = New WebClient
    Dim fstring As String
    Dim fc As FontConverter = New FontConverter
    Sub xzTab(ByRef Tab As TabPage)
        TbBase.SelectedTab = Tab
    End Sub

    Private Sub frm_setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        q.CachePolicy = New System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore)
        CSS_TAB_Enter(sender, e)

    End Sub

    Private Sub CSS_TAB_Click(sender As Object, e As EventArgs) Handles CSS_TAB.Click

    End Sub

    Private Sub CSS_TAB_Enter(sender As Object, e As EventArgs) Handles CSS_TAB.Enter
        Try
            txt_css_inload.Text = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\data\style.css")

        Catch ex As Exception
            txt_css_inload.Text = "/* Error loading css file */" & vbNewLine * "/* " & ErrorToString() & " */"
        End Try
        txt_css_inload.Select(txt_css_inload.Text.Length, 0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\data\style.css", txt_css_inload.Text, False)
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs)
        xzTab(Tab_Code_Editor)
    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs)
        xzTab(Tab_Tools)
    End Sub

    Private Sub ButtonItem4_Click(sender As Object, e As EventArgs)
        xzTab(Tab_Plugin)
    End Sub

    Private Sub ButtonItem5_Click(sender As Object, e As EventArgs)
        xzTab(CSS_TAB)
    End Sub

    Private Sub ButtonItem3_Click(sender As Object, e As EventArgs)
        xzTab(TabMenu)
    End Sub

    Private Sub ButtonItem7_Click(sender As Object, e As EventArgs)
        xzTab(Tabrep)
    End Sub

    Private Sub ButtonItem6_Click(sender As Object, e As EventArgs)
        WebWarnForm.goUrl = "http://aryan-pc.blog.ir/post/AryanAll"
        WebWarnForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Select Case itmChck.Checked
        '    Case True
        '        SaveSetting("BlogCode", "config", "donateitem", "hide")
        '    Case False
        '        SaveSetting("BlogCode", "config", "donateitem", "show")
        'End Select
        Me.Close()
    End Sub

    Private Sub TabMenu_Click(sender As Object, e As EventArgs) Handles TabMenu.Click

    End Sub

    Private Sub TabMenu_Enter(sender As Object, e As EventArgs) Handles TabMenu.Enter
        'If GetSetting("BlogCode", "config", "donateitem") = "hide" Then
        '    itmChck.Checked = True
        'Else
        '    itmChck.Checked = False
        'End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            FontDialog.Font = fc.ConvertFromString(GetSetting("BlogCode", "config", "font"))
        Catch ex As Exception

        End Try
        f = FontDialog.ShowDialog()
        If f = vbOK Then
            fstring = fc.ConvertToString(FontDialog.Font)
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            SaveSetting("BlogCode", "config", "font", fstring)
            Try
                BaseForm.txt_genCode.Font = fc.ConvertFromString(GetSetting("BlogCode", "config", "font"))
            Catch ex As Exception
                BaseForm.txt_genCode.Font = fc.ConvertFromString("Segoe UI, 9.75pt")
            End Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button3.Paint, Button5.Paint, Button4.Paint
        Dim Btn = DirectCast(sender, Button)
        Using P As New Pen(Color.White)
            e.Graphics.DrawRectangle(P, 1, 1, Btn.Width - 3, Btn.Height - 3)
        End Using
    End Sub

    Private Sub DrawBottomBorder(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, sender.ClientRectangle, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid)
    End Sub
End Class