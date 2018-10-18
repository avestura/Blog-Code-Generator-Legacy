Public Class VarForm
    Public EditIsFalseSubmitIsTrue As Boolean

    Public GetSelectedItem As ListViewItem

    Private Sub CollapseClosed()
        list_Suggst.Visible = False
        btn_addI.Visible = False
        btn_reset.Visible = False
        btn_removeI.Visible = False
        GroupBox1.Size = New Size(GroupBox1.Width, 100)
        Me.Size = New Size(Me.Width, 280)
        btn_SubmitVar.Location = New Point(12, 205)
    End Sub

    Private Sub CollapseOpen()

        list_Suggst.Visible = True
        btn_addI.Visible = True
        btn_reset.Visible = True
        btn_removeI.Visible = True
        GroupBox1.Size = New Size(GroupBox1.Width, 193)
        Me.Size = New Size(Me.Width, 373)
        btn_SubmitVar.Location = New Point(12, 295)
    End Sub

    Private Sub DrawBottomBorder(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, sender.ClientRectangle, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid)
    End Sub

    Private Sub GroupBox_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox1.Paint
        sender.BackColor = Color.FromArgb(50, 255, 255, 255)
    End Sub

    Private Sub frm_Var_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            GetSelectedItem = MainForm.List.SelectedItems.Item(0)
        Catch ex As Exception

        End Try
        combo_RtlReading.SelectedIndex = 0

        If EditIsFalseSubmitIsTrue = True Then
            btn_SubmitVar.Text = "ثبت متغیر"

        Else
            btn_SubmitVar.Text = "ویرایش متغیر"


        End If


        If EditIsFalseSubmitIsTrue = False Then

            list_Suggst.Items.Clear()
            txt_VarText.Text = GetSelectedItem.SubItems(1).Text
            txt_VarInput.Text = GetSelectedItem.SubItems(2).Text

            Dim aLotOfSuggestions As Array = Nothing
            If Trim(GetSelectedItem.SubItems(3).Text) <> Nothing Then
                CollapseOpen()
                check_SuggestVar.Checked = True
                aLotOfSuggestions = Split(GetSelectedItem.SubItems(3).Text, "|")
                For Each itTm As Object In aLotOfSuggestions
                    list_Suggst.Items.Add(itTm)
                Next
            Else
                CollapseClosed()
                check_SuggestVar.Checked = False
            End If

            If GetSelectedItem.SubItems(4).Text = "راست به چپ" Then
                combo_RtlReading.SelectedIndex = 0
            Else
                combo_RtlReading.SelectedIndex = 1

            End If

        Else
            CollapseClosed()

        End If



    End Sub

    Private Sub btn_SubmitVar_Click(sender As Object, e As EventArgs) Handles btn_SubmitVar.Click


        If EditIsFalseSubmitIsTrue = True Then


            Dim SuggestWhatQ As String
            Dim lstItm As ListViewItem = MainForm.List.Items.Add("جعبه متنی")
            lstItm.SubItems.Add(txt_VarText.Text)
            lstItm.SubItems.Add(txt_VarInput.Text)

            If check_SuggestVar.Checked = True Then
                Try
                    Dim strSuggests As String = Nothing

                    For Each itm As Object In list_Suggst.Items
                        strSuggests = strSuggests + itm + "|"
                    Next
                    strSuggests = Mid(strSuggests, 1, Len(strSuggests) - 1)
                    SuggestWhatQ = strSuggests

                Catch ex As Exception
                    SuggestWhatQ = Nothing

                End Try

            Else
                SuggestWhatQ = Nothing


            End If
            lstItm.SubItems.Add(SuggestWhatQ)

            If combo_RtlReading.SelectedIndex = 0 Then lstItm.SubItems.Add("راست به چپ") Else lstItm.SubItems.Add("چپ به راست")

        Else
            Dim SuggestWhatQ As String


            MainForm.List.SelectedItems.Item(0).Text = "جعبه متنی"
            MainForm.List.SelectedItems.Item(0).SubItems(1).Text = txt_VarText.Text
            MainForm.List.SelectedItems.Item(0).SubItems(2).Text = txt_VarInput.Text


            If check_SuggestVar.Checked = True Then
                Try
                    Dim strSuggests As String = Nothing

                    For Each itm As Object In list_Suggst.Items
                        strSuggests = strSuggests + itm + "|"
                    Next
                    strSuggests = Mid(strSuggests, 1, Len(strSuggests) - 1)
                    SuggestWhatQ = strSuggests

                Catch ex As Exception
                    SuggestWhatQ = Nothing

                End Try

            Else
                SuggestWhatQ = Nothing


            End If
            MainForm.List.SelectedItems.Item(0).SubItems(3).Text = SuggestWhatQ

            If combo_RtlReading.SelectedIndex = 0 Then MainForm.List.SelectedItems.Item(0).SubItems(4).Text = "راست به چپ" Else MainForm.List.SelectedItems.Item(0).SubItems(4).Text = "چپ به راست"

        End If
       

        Me.Close()
    End Sub

    Private Sub btn_SubmitVar_MouseLeave(sender As Object, e As EventArgs) Handles btn_SubmitVar.MouseLeave
        sender.BackgroundImage = My.Resources.menu_bg_gray
        sender.ForeColor = Color.Gray
    End Sub

    Private Sub btn_SubmitVar_MouseMove(sender As Object, e As MouseEventArgs) Handles btn_SubmitVar.MouseMove
        sender.BackgroundImage = My.Resources.menu_bg_blue
        sender.ForeColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles btn_removeI.Click
        Try
            list_Suggst.Items.Remove(list_Suggst.SelectedItem)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btn_addI.Click
        Dim str As String = InputBox("متنی را برای پینهاد به کاربر وارد کنید", "افزودن پیشنهاد", "پیشنهاد")
        str = Replace(str, ">", Nothing)
        str = Replace(str, "<", Nothing)
        str = Replace(str, "|", Nothing)
        If Trim(str) <> Nothing Then
            list_Suggst.Items.Add(str)
        End If
    End Sub

    Private Sub check_SuggestVar_CheckedChanged(sender As Object, e As EventArgs) Handles check_SuggestVar.CheckedChanged
        Select Case check_SuggestVar.Checked
            Case False


                CollapseClosed()

            Case True
                CollapseOpen()
 
        End Select
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        list_Suggst.Items.Clear()
    End Sub

  
End Class