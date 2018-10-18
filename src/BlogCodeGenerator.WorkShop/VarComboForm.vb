Public Class VarComboForm
    Public EditIsFalseSubmitIsTrue As Boolean
    Private Sub DrawBottomBorder(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ControlPaint.DrawBorder(e.Graphics, sender.ClientRectangle, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid)
    End Sub

    Private Sub btn_SubmitVar_MouseLeave(sender As Object, e As EventArgs) Handles btn_SubmitVar.MouseLeave
        sender.BackgroundImage = My.Resources.menu_bg_gray
        sender.ForeColor = Color.Gray
    End Sub

    Private Sub btn_SubmitVar_MouseMove(sender As Object, e As MouseEventArgs) Handles btn_SubmitVar.MouseMove
        sender.BackgroundImage = My.Resources.menu_bg_blue
        sender.ForeColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub frm_Var_Combovb_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        combo_RtlReading.SelectedIndex = 0

        If EditIsFalseSubmitIsTrue = True Then
            btn_SubmitVar.Text = "ثبت متغیر"

        Else
            btn_SubmitVar.Text = "ویرایش متغیر"


        End If


        If EditIsFalseSubmitIsTrue = False Then
            GetSelectedItem = MainForm.List.SelectedItems.Item(0)
            List.Items.Clear()
            txt_VarText.Text = GetSelectedItem.SubItems(1).Text



            If Trim(GetSelectedItem.SubItems(2).Text) <> Nothing AndAlso Trim(GetSelectedItem.SubItems(3).Text) <> Nothing Then


                Dim aLotOfIems As Array = Split(GetSelectedItem.SubItems(3).Text, "|")
                Dim cntArray As Array = Split(GetSelectedItem.SubItems(2).Text, "|")
                Dim i As Integer = 0
                For Each itTm As Object In aLotOfIems

                    Dim Itemadded As ListViewItem = New ListViewItem
                    Itemadded = List.Items.Add(itTm)

                    Itemadded.SubItems.Add(cntArray(i))
                    i += 1
                Next

            Else
                List.Items.Clear()
            End If

            If GetSelectedItem.SubItems(4).Text = "راست به چپ" Then
                combo_RtlReading.SelectedIndex = 0
            Else
                combo_RtlReading.SelectedIndex = 1

            End If

        Else
            txt_VarText.Text = "متغیر لیستی"
            List.Items.Clear()
            combo_RtlReading.SelectedIndex = 0
        End If
    End Sub

    Private Sub btn_SubmitVar_Click(sender As Object, e As EventArgs) Handles btn_SubmitVar.Click
        If List.Items.Count > 1 Then
            If EditIsFalseSubmitIsTrue = True Then


                Dim SuggestWhatQ As String = Nothing
                Dim strSuggests As String = Nothing
                Dim lstItm As ListViewItem = MainForm.List.Items.Add("جعبه لیستی")
                lstItm.SubItems.Add(txt_VarText.Text)



                '###########################
                Dim strAlts As String = Nothing

                For Each itm As ListViewItem In List.Items
                    strSuggests = strSuggests + itm.SubItems(1).Text + "|"
                Next
                strSuggests = Mid(strSuggests, 1, Len(strSuggests) - 1)
                SuggestWhatQ = strSuggests

                lstItm.SubItems.Add(SuggestWhatQ)

                '###########################
                Dim strContents As String = Nothing
                strSuggests = Nothing
                SuggestWhatQ = Nothing
                For Each itm As ListViewItem In List.Items
                    strSuggests = strSuggests + itm.Text + "|"
                Next
                strSuggests = Mid(strSuggests, 1, Len(strSuggests) - 1)
                SuggestWhatQ = strSuggests

                lstItm.SubItems.Add(SuggestWhatQ)



                If combo_RtlReading.SelectedIndex = 0 Then lstItm.SubItems.Add("راست به چپ") Else lstItm.SubItems.Add("چپ به راست")

                Me.Close()
            Else
                '/// ########## ELSE #################

                Dim SuggestWhatQ As String
                Dim strSuggests As String = Nothing

                MainForm.List.SelectedItems.Item(0).Text = "جعبه لیستی"
                MainForm.List.SelectedItems.Item(0).SubItems(1).Text = txt_VarText.Text





                Dim strAlts As String = Nothing

                For Each itm As ListViewItem In List.Items
                    strSuggests = strSuggests + itm.SubItems(1).Text + "|"
                Next
                strSuggests = Mid(strSuggests, 1, Len(strSuggests) - 1)
                SuggestWhatQ = strSuggests

                MainForm.List.SelectedItems.Item(0).SubItems(2).Text = SuggestWhatQ

                Dim strContents As String = Nothing
                strSuggests = Nothing
                SuggestWhatQ = Nothing
                For Each itm As ListViewItem In List.Items
                    strSuggests = strSuggests + itm.Text + "|"
                Next
                strSuggests = Mid(strSuggests, 1, Len(strSuggests) - 1)
                SuggestWhatQ = strSuggests

                MainForm.List.SelectedItems.Item(0).SubItems(3).Text = SuggestWhatQ

                If combo_RtlReading.SelectedIndex = 0 Then MainForm.List.SelectedItems.Item(0).SubItems(4).Text = "راست به چپ" Else MainForm.List.SelectedItems.Item(0).SubItems(4).Text = "چپ به راست"




                Me.Close()




            End If
            '################################ ELSE
        Else



            MsgBox("لیست آیتم ها باید بیشتر از دو گزینه داشته باشد. لطفا حداقل دو گزینه اضافه کنید", MsgBoxStyle.MsgBoxRight + vbExclamation + vbOKOnly, "خطا")
        End If

    End Sub

    Private Sub btn_addI_Click(sender As Object, e As EventArgs) Handles btn_addI.Click, Label2.Click
        Dim _ReqAlt As String
        Dim _ReqContent As String
        _ReqAlt = InputBox("لطفا نام نمایشی آیتم را وارد کنید:", "نام نمایشی")
        _ReqAlt = Replace(_ReqAlt, "<", Nothing)
        _ReqAlt = Replace(_ReqAlt, ">", Nothing)
        _ReqAlt = Replace(_ReqAlt, "|", Nothing)


        If Trim(_ReqAlt) <> Nothing Then

            _ReqContent = InputBox("لطفا محتوای جایگزین شونده آیتم را وارد کنید:", "محتوای آیتم")

            _ReqAlt = Replace(_ReqAlt, "|", Nothing)


            If Trim(_ReqAlt) <> Nothing Then
                Dim ItemAddedTo As ListViewItem = List.Items.Add(_ReqAlt)
                ItemAddedTo.SubItems.Add(_ReqContent)
            Else
                MsgBox("محتوای آیتم نمی تواند خالی باشد", MsgBoxStyle.MsgBoxRight + vbExclamation + vbOKOnly, "خطا")
                Exit Sub
            End If



        Else
            MsgBox("نام نمایشی نمی تواند خالی باشد", MsgBoxStyle.MsgBoxRight + vbExclamation + vbOKOnly, "خطا")
            Exit Sub
        End If


    End Sub

    Private Sub btn_removeI_Click(sender As Object, e As EventArgs) Handles btn_removeI.Click, Label4.Click
        Try
            List.SelectedItems(0).Remove()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click, Label5.Click
        List.Items.Clear()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)


    End Sub
End Class