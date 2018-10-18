Imports System.IO
Public Class PluginLoaderForm
    Dim allowClose As Boolean = False
    Public cToUp As Integer = 1
    Public PluginURL As String = My.Application.Info.DirectoryPath & "\plugins\"
    Dim showErrForm As Boolean = False
    Dim errFiles As String = Nothing
    Dim errLOGS As String = Nothing
    Private Sub frm_plugin_loader_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If allowClose = False Then e.Cancel = True

    End Sub

    Private Sub frm_plugin_loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        ' Try
        If Not Directory.Exists(PluginURL) Then
            Directory.CreateDirectory(PluginURL)
        End If

        ' Here Say Get Notes
        Dim Files() As String = Directory.GetFiles(PluginURL, "*.xml", SearchOption.AllDirectories)



        For Each File In Files


            Dim xDoc As XDocument = New XDocument

            Try
                xDoc = XDocument.Load(New IO.StringReader(My.Computer.FileSystem.ReadAllText(File, System.Text.Encoding.UTF8)))
            Catch ex As Exception
                showErrForm = True
                Dim getLastofit As Array = Split(File, "\")
                errFiles = errFiles & getLastofit(getLastofit.Length - 1) & ","
                errLOGS = errLOGS + "● " & getLastofit(getLastofit.Length - 1) & ": " & ErrorToString() & vbNewLine
                Continue For
            End Try

            Try
                BaseForm.TabControl1.TabPages.Add("  " & Mid(xDoc.<base>.<data>.<name>.Value, 1, 28) & "  ")
            Catch ex As Exception
                BaseForm.TabControl1.TabPages.Add("  بدون نام  ")
            End Try
            Dim tabpg As TabPage = BaseForm.TabControl1.TabPages(BaseForm.TabControl1.TabPages.Count - 1)


            Dim picbox As PictureBox = New PictureBox
            If xDoc.<base>.<data>.<fav>.Value <> Nothing Then
                Try

                    If LCase(xDoc.<base>.<data>.<fav>.Value).Contains(".png") Then picbox.Load(My.Application.Info.DirectoryPath & "\plugins\" & xDoc.<base>.<data>.<fav>.Value) Else picbox.Image = My.Resources.Puzzle_piece_plugin_16

                Catch ex As Exception
                    picbox.Image = My.Resources.Puzzle_piece_plugin_16
                End Try
            Else
                picbox.Image = My.Resources.Puzzle_piece_plugin_16
            End If

            Dim subitm As ToolStripMenuItem = BaseForm.plugmenu.DropDownItems.Add(xDoc.<base>.<data>.<name>.Value, picbox.Image)
            subitm.Tag = cToUp
            cToUp += 1
            AddHandler subitm.Click, AddressOf BaseForm.goOnTAB_Click

            tabpg.BackgroundImage = My.Resources.bcg_creamPixels

            If xDoc.<base>.<data>.<name>.Value <> Nothing Then
                Dim head As Label = New Label
                tabpg.Controls.Add(head)
                head.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
                Try
                    head.Location = New Point(20, 17)
                    head.ForeColor = Color.DimGray
                    head.AutoSize = False
                    head.BackColor = Color.Transparent
                    head.Size = New Size(464, 13)

                    head.Text = xDoc.<base>.<data>.<short_text>.Value

                Catch ex As Exception
                    head.Text = "بدون توضیح کوتاه"
                End Try
            End If



            'Crating a new flow WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW

            Dim flew As FlowLayoutPanel = New FlowLayoutPanel
            With flew
                .Location = New Point(15, 40)
                .Size = New Point(464, 248)
                .WrapContents = True
                .Padding = New Padding(3, 5, 3, 5)
                .AutoScroll = True
                .BackColor = Color.Transparent
                .Margin = New Padding(3)
            End With
            tabpg.Controls.Add(flew)

            'Here we see how much <lbl> node exists in the plugin



            For i = 0 To (xDoc.<base>.<options>.Elements.Count) - 2

                Try
                    Dim SenarioLabel As Label = New Label
                    With SenarioLabel
                        .AutoSize = False
                        .Size = New Point(100, 13)
                        .Margin = New Padding(3, 6, 3, 0)
                        .BackColor = Color.Transparent
                        .Text = xDoc.<base>.<options>.<lbl>.ElementAt(i).<text>.Value
                        .TextAlign = ContentAlignment.MiddleLeft
                    End With
                    BaseForm.ToolTip.SetToolTip(SenarioLabel, SenarioLabel.Text)
                    flew.Controls.Add(SenarioLabel)

                    'Text Box or Combo? This is the problem!
                    Dim TYPE_FOUNDER As String
                    Try
                        TYPE_FOUNDER = xDoc.<base>.<options>.<lbl>.ElementAt(i).<type>.Value.ToString.ToLower
                    Catch ex As Exception
                        TYPE_FOUNDER = Nothing
                    End Try

                    Select Case TYPE_FOUNDER
                        Case ""
                            GoTo CaseElseOperations
                        Case "combo"

                            Dim SenarioCombo As ComboBox = New ComboBox
                            With SenarioCombo
                                .Items.Clear()
                                .DropDownStyle = ComboBoxStyle.DropDownList

                                .Size = New Point(322, 21)
                                .Tag = "input;[%20_ar!combo]"
                            End With

                            If xDoc.<base>.<options>.<lbl>.ElementAt(i).<rtl>.Value = "true" Then SenarioCombo.RightToLeft = Windows.Forms.RightToLeft.Yes Else SenarioCombo.RightToLeft = Windows.Forms.RightToLeft.No




                            Dim SuggestItms As Array = Split(xDoc.<base>.<options>.<lbl>.ElementAt(i).<alts>.Value, "|")
                            For Each sugItm In SuggestItms
                                SenarioCombo.Items.Add(sugItm)
                            Next

                            Dim ContentItms As Array = Split(xDoc.<base>.<options>.<lbl>.ElementAt(i).<sug>.Value, "|")
                            For Each cntItm In ContentItms
                                SenarioCombo.Tag = SenarioCombo.Tag & "|" & cntItm
                            Next

                            Try
                                SenarioCombo.SelectedIndex = 0
                            Catch ex As Exception

                            End Try

                            flew.Controls.Add(SenarioCombo)
                            '################## END OF TEXT BOX

                        Case Else
CaseElseOperations:         '#################### FOR TEXT BOX
                            Dim SenarioTextBox As TextBox = New TextBox
                            With SenarioTextBox
                                .Size = New Point(322, 21)
                                .Text = xDoc.<base>.<options>.<lbl>.ElementAt(i).<input>.Value
                                .Tag = "input"
                            End With

                            If xDoc.<base>.<options>.<lbl>.ElementAt(i).<rtl>.Value = "true" Then SenarioTextBox.RightToLeft = Windows.Forms.RightToLeft.Yes Else SenarioTextBox.RightToLeft = Windows.Forms.RightToLeft.No

                            If Not xDoc.<base>.<options>.<lbl>.ElementAt(i).<sug>.Value = Nothing Then
                                SenarioTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
                                SenarioTextBox.AutoCompleteMode = AutoCompleteMode.Suggest
                                Dim SuggestItms As Array = Split(xDoc.<base>.<options>.<lbl>.ElementAt(i).<sug>.Value, "|")
                                For Each sugItm In SuggestItms
                                    SenarioTextBox.AutoCompleteCustomSource.Add(sugItm)
                                Next

                            End If

                            flew.Controls.Add(SenarioTextBox)
                            '################## END OF TEXT BOX

                    End Select

                Catch ex As Exception

                    Exit For
                End Try

            Next
            Dim pnlShot As Panel = New Panel
            pnlShot.Size = New Point(300, 20)
            flew.Controls.Add(pnlShot)


            Dim iiURL As String
            Try
                iiURL = My.Application.Info.DirectoryPath & "\plugins\" & xDoc.<base>.<data>.<load>.Value
            Catch ex As Exception

            End Try
            Dim btngen As Button = New Button
            tabpg.Controls.Add(btngen)
            AddHandler btngen.Click, AddressOf BaseForm.BTN_PLUGIN_plugin_info
            AddHandler btngen.Paint, AddressOf BaseForm.ButtonPaint
            'AddHandler btngen.MouseLeave, AddressOf frm_base.ButtonChangeView_MouseLeave
            'AddHandler btngen.MouseMove, AddressOf frm_base.ButtonChangeView_MouseMove
            btngen.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
            Try
                With btngen
                    .ImageAlign = ContentAlignment.MiddleLeft
                    .FlatStyle = FlatStyle.Flat
                    .Location = New Point(5, 298)
                    .ForeColor = Color.DimGray
                    .BackColor = Color.Snow
                    .FlatAppearance.BorderColor = Color.Gainsboro
                    .FlatAppearance.BorderSize = 1
                    .FlatAppearance.MouseDownBackColor = Color.FloralWhite
                    .FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
                    .Size = New Size(164, 28)

                    .Text = xDoc.<base>.<options>.<gen_text>.Value
                    .Tag = iiURL & "," & cToUp - 1
                End With

            Catch ex As Exception
                btngen.Text = "کد بساز"
            End Try

            Dim iAuthor, iVersion, iInfo, iBName, iWebPage, iCopyArea As String

            Try
                iAuthor = xDoc.<base>.<data>.<author>.Value

            Catch ex As Exception
                iAuthor = "نامعلوم"
            End Try

            Try
                iWebPage = xDoc.<base>.<data>.<page>.Value

            Catch ex As Exception
                iWebPage = Nothing
            End Try

            Try
                iVersion = xDoc.<base>.<data>.<version>.Value
            Catch ex As Exception
                iVersion = "نامعلوم"
            End Try

            Try
                iInfo = xDoc.<base>.<data>.<info>.Value
                iInfo = Replace(iInfo, "        ", vbNewLine)
            Catch ex As Exception
                iInfo = "بدون اطلاعات"
            End Try
            Try
                iBName = xDoc.<base>.<data>.<name>.Value
            Catch ex As Exception
                iBName = "فاقد نام"
            End Try
            Try
                iCopyArea = xDoc.<base>.<data>.<copyto>.Value
            Catch ex As Exception
                iCopyArea = Nothing
            End Try

            Dim btninfo As Button = New Button
            tabpg.Controls.Add(btninfo)
            AddHandler btninfo.Click, AddressOf BaseForm.BTN_PLUGIN_generate
            AddHandler btninfo.Paint, AddressOf BaseForm.ButtonPaint
            'AddHandler btninfo.MouseLeave, AddressOf frm_base.ButtonChangeView_MouseLeave
            'AddHandler btninfo.MouseMove, AddressOf frm_base.ButtonChangeView_MouseMove
            btninfo.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
            Try
                With btninfo
                    .FlatStyle = FlatStyle.Flat
                    .Location = New Point(345, 296)

                    .ForeColor = Color.DimGray
                    .BackColor = Color.Snow
                    .FlatAppearance.BorderColor = Color.Gainsboro
                    .FlatAppearance.BorderSize = 1
                    .FlatAppearance.MouseDownBackColor = Color.FloralWhite
                    .FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
                    .Size = New Size(146, 28)
                    .Text = "توضیحات افزونه"
                    .Tag = iAuthor & "," & iVersion & "," & iInfo & "," & iBName & "," & iWebPage & "," & iCopyArea
                End With
  
            Catch ex As Exception

            End Try

            If xDoc.<base>.<data>.<js>.Value = "true" Then

                btngen.Image = My.Resources.Code_16

            End If
            Try
                If Val(xDoc.<base>.<data>.<app_version>.Value) > BaseForm.ThisVersion Then
                    Dim warn_lbl As Label = New Label
                    tabpg.Controls.Add(warn_lbl)
                    warn_lbl.BackColor = Color.Transparent
                    warn_lbl.AutoSize = True
                    warn_lbl.Location = New Point(17, 265)
                    warn_lbl.Text = "این افزونه برای نسخه " & Val(xDoc.<base>.<data>.<app_version>.Value).ToString & " نرم افزار کد ساز ساخته شده است و ممکن است با این نسخه ناسازگار باشد"
                End If
            Catch ex As Exception

            End Try


        Next

        ' Catch ex As Exception
        ' MsgBox(ErrorToString)
        'End Try
        allowClose = True
        If showErrForm = True Then

            PluginErrorForm.ListBox1.Items.Clear()
            PluginErrorForm.TextBox1.Clear()

            errFiles = Mid(errFiles, 1, Len(errFiles) - 1)

            Dim iERRfileArr As Array = Split(errFiles, ",")

            For Each item In iERRfileArr
                PluginErrorForm.ListBox1.Items.Add(item)
            Next

            PluginErrorForm.TextBox1.Text = errLOGS

            PluginErrorForm.ShowDialog()

        End If

        Me.Close()

    End Sub

End Class

