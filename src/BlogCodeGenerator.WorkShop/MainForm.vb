Imports Ionic.Zip
Public Class MainForm
    Public readT As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        plug_js.SelectedIndex = 0
    End Sub

    Sub XAPIA(ByVal a As String, b As String)
        readT = Replace(readT, a, b)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click, Label27.Click
        Dim pluglongrep As String = plug_long.Text
        Dim content As String = Nothing
        Dim alternative As String = Nothing
        If plug_name.Text <> "" Then
            pluglongrep = Replace(pluglongrep, ControlChars.NewLine, "        ")
            Dim strjs As String = "false"
            readT = My.Resources._STRUCTURE.ToString
            If plug_js.SelectedIndex = 0 Then strjs = "false" Else strjs = "true"
            XAPIA("(*pname*)", plug_name.Text)
            XAPIA("(*pshort*)", plug_short.Text)
            XAPIA("(*plong*)", pluglongrep)
            XAPIA("(*pdev*)", plug_developer.Text)
            XAPIA("(*pload*)", plug_save.Text & ".txt")
            XAPIA("(*pver*)", plug_version.Text)
            XAPIA("(*pgen*)", plug_alt.Text)
            XAPIA("(*pjs*)", strjs)
            If txtCopyTo.Text <> "مثال: بین دو تگ body" Then XAPIA("(*copy_area*)", txtCopyTo.Text) Else XAPIA("(*copy_area*)", Nothing)

            If txtWebPage.Text <> "mysite.com نمونه" Then
                XAPIA("(*plugin_page*)", Replace(txtWebPage.Text, "http://", Nothing))
            Else

                XAPIA("(*plugin_page*)", "")
            End If

            Dim SUGS_OF_LISTS As String
            For Each itm As ListViewItem In List.Items

                Dim strDirection As String
                If itm.SubItems(4).Text = "راست به چپ" Then
                    strDirection = "true"
                Else
                    strDirection = "false"
                End If

                If itm.Text = "جعبه متنی" Then

                    alternative = "<lbl>" & vbNewLine &
                        vbTab & "<text>" & itm.SubItems(1).Text & "</text>" & vbNewLine &
                        vbTab & "<input>" & itm.SubItems(2).Text & "</input>" & vbNewLine &
                        vbTab & "<sug>" & itm.SubItems(3).Text & "</sug>" & vbNewLine &
                        vbTab & "<rtl>" & strDirection & "</rtl>" & vbNewLine &
                        "</lbl>" & vbNewLine

                    content = content & alternative

                Else

                    SUGS_OF_LISTS = itm.SubItems(2).Text.Replace(">", "{toleft;")
                    SUGS_OF_LISTS = SUGS_OF_LISTS.ToString.Replace("<", "{toright;")

                    alternative = "<lbl>" & vbNewLine &
                        vbTab & "<text>" & itm.SubItems(1).Text & "</text>" & vbNewLine &
                        vbTab & "<type>combo</type>" &
                        vbTab & "<input>" & Split(itm.SubItems(3).Text, "|")(0) & "</input>" & vbNewLine &
                        vbTab & "<alts>" & itm.SubItems(3).Text & "</alts>" & vbNewLine &
                        vbTab & "<sug>" & SUGS_OF_LISTS & "</sug>" & vbNewLine &
                        vbTab & "<rtl>" & strDirection & "</rtl>" & vbNewLine &
                        "</lbl>" & vbNewLine

                    content = content & alternative

                End If

            Next

            XAPIA("(*content*)", content)
            savename = Replace(plug_save.Text, ".xml", Nothing) & ".xml"
            loadname = Replace(plug_save.Text, ".xml", Nothing) & ".txt"
            zipname = Replace(plug_save.Text, ".xml", Nothing) & ".zip"
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "\alt")
            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\alt\" & savename, readT, False)
            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\alt\" & loadname, EditToolsForm.Tag, False)

            Using zip As ZipFile = New ZipFile()
                zip.Comment = "Blog Code Generator Plugin - Aryan Software [http://aryan-pc.blog.ir]" & vbNewLine & "Plugin Author: " & plug_developer.Text & vbNewLine & "Type: Aryan Software Plugin"
                zip.AddFile(My.Application.Info.DirectoryPath & "\alt\" & savename, "")
                zip.AddFile(My.Application.Info.DirectoryPath & "\alt\" & loadname, "")
                iSaveFile.FileName = zipname
                Dim m = iSaveFile.ShowDialog()
                If m = vbOK Then
                    Try
                        zip.Save(iSaveFile.FileName)
                    Catch ex As Exception
                        MsgBox("در ذخیره سازی افزونه مشکلی به وجود آمد. پس از رفع آن دوباره امتحان کنید", vbExclamation, "خطا در ذخیره سازی")
                    End Try
                End If
            End Using

        Else
            MsgBox("افزونه شما هیچ نامی ندارد. پیشنهاد میکنیم ابتدا نامی برای افزونه انتخاب کنید", MsgBoxStyle.MsgBoxRight + vbExclamation, "افزونه")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EditToolsForm.ShowDialog()
    End Sub

    Private Sub lbl_BorderBottom_Click(sender As Object, e As EventArgs) Handles lbl_BorderBottom.Click

    End Sub

    Private Sub lbl_BorderBottom_Paint(sender As Object, e As PaintEventArgs) Handles lbl_BorderBottom.Paint
        ControlPaint.DrawBorder(e.Graphics, sender.ClientRectangle, Color.Black, 0, ButtonBorderStyle.None, Color.Black, 0, ButtonBorderStyle.None, Color.Black, 0, ButtonBorderStyle.None, Color.DarkGray, 1, ButtonBorderStyle.Solid)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        VarForm.ShowDialog()
    End Sub

    Private Sub btn_SubmitVar_MouseLeave(sender As Object, e As EventArgs) Handles btn_addVar.MouseLeave, btn_EditVar.MouseLeave, Button2.MouseLeave, Button1.MouseLeave
        sender.BackgroundImage = My.Resources.menu_bg_gray
        sender.ForeColor = Color.Gray
    End Sub

    Private Sub btn_SubmitVar_MouseMove(sender As Object, e As MouseEventArgs) Handles btn_addVar.MouseMove, btn_EditVar.MouseMove, Button2.MouseMove, Button1.MouseMove
        sender.BackgroundImage = My.Resources.menu_bg_blue
        sender.ForeColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub btn_addVar_Click(sender As Object, e As EventArgs) Handles btn_addVar.Click
        ContexAdditention.Show(MousePosition.X - ContexAdditention.Size.Width, MousePosition.Y)

    End Sub

    Private Sub btn_EditVar_Click(sender As Object, e As EventArgs) Handles btn_EditVar.Click
        If List.SelectedItems.Count <> 0 Then

            If List.SelectedItems(0).Text = "جعبه متنی" Then
                VarForm.EditIsFalseSubmitIsTrue = False
                VarForm.ShowDialog()
            Else
                VarComboForm.EditIsFalseSubmitIsTrue = False
                VarComboForm.ShowDialog()

            End If

        Else
            MsgBox("برای ویرایش متغیر ها ابتدا متغیری را انتخاب کنید", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight + vbOKOnly, "ویرایش")
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If List.SelectedItems.Count <> 0 Then
            List.Items.Remove(List.SelectedItems.Item(0))

        Else
            MsgBox("متغیری برای حذف شدن انتخاب نشده است. لطفا پس از انتخاب متغیر اقدام به حذف یا ویرایش آن کنید", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight + vbOKOnly, "ویرایش")
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles txtWebPage.GotFocus
        If txtWebPage.Text = "mysite.com نمونه" Then
            txtWebPage.Text = Nothing
            txtWebPage.ForeColor = Color.Black

        End If
    End Sub

    Private Sub txtcopyto_LostFocus(sender As Object, e As EventArgs) Handles txtWebPage.LostFocus
        If txtWebPage.Text = Nothing Then

            txtWebPage.Text = "mysite.com نمونه"
            txtWebPage.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBoxcopyto_GotFocus(sender As Object, e As EventArgs) Handles txtCopyTo.GotFocus
        If txtCopyTo.Text = "مثال: بین دو تگ body" Then
            txtCopyTo.Text = Nothing
            txtCopyTo.ForeColor = Color.Black

        End If
    End Sub

    Private Sub txtWebPage_LostFocus(sender As Object, e As EventArgs) Handles txtCopyTo.LostFocus
        If txtCopyTo.Text = Nothing Then

            txtCopyTo.Text = "مثال: بین دو تگ body"
            txtCopyTo.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtWebPage_TextChanged(sender As Object, e As EventArgs) Handles txtWebPage.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox1.Paint, GroupBox2.Paint
        sender.BackColor = Color.FromArgb(120, 255, 255, 255)
    End Sub

    Private Sub DrawBottomBorder(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, sender.ClientRectangle, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid)
    End Sub

    Private Sub plug_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles plug_name.KeyPress, plug_alt.KeyPress, plug_developer.KeyPress, plug_version.KeyPress, txtCopyTo.KeyPress, plug_long.KeyPress, plug_short.KeyPress, plug_save.KeyPress, txtWebPage.KeyPress
        If e.KeyChar = "<" Or e.KeyChar = ">" Then
            e.Handled = True
        End If
    End Sub

    Private Sub جعبهمتنیToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles جعبهمتنیToolStripMenuItem.Click
        VarForm.EditIsFalseSubmitIsTrue = True
        VarForm.ShowDialog()
    End Sub

    Private Sub جعبهلیستیToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles جعبهلیستیToolStripMenuItem.Click
        VarComboForm.EditIsFalseSubmitIsTrue = True
        VarComboForm.ShowDialog()
    End Sub
End Class
