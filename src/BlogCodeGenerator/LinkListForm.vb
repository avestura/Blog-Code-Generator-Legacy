Imports System.Net
Imports System.Threading
Imports System.Text

Public Class LinkListForm
    Dim web As WebClient = New WebClient
    Sub getlist()
        Dim fornowDoc As XDocument = New XDocument
        Dim itm As ListViewItem = New ListViewItem

        Try
            web.CachePolicy = New System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore)

            web.Encoding = Encoding.Default
            SS = web.DownloadString("http://aryan-pc.ir/getvalue/list.xml")
            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\list.xml", SS, False)
            fornowDoc = XDocument.Load(My.Application.Info.DirectoryPath & "\list.xml")
        Catch ex As Exception
            MsgBox("لیست نتوانست دریافت شود. از اتصال به اینترنت مطمعا شوید و یا بعدا دوباره امتحان کنید", vbOKOnly + MsgBoxStyle.MsgBoxRight + vbExclamation, "بی نتیجه")
            Me.Close()
            'MsgBox(ErrorToString)
            a.Visible = False
            aa.Visible = False
            Exit Sub
        End Try
        a.Visible = False
        aa.Visible = False

        i = 0
        For Each item As XNode In fornowDoc.<site>.<item>
            Try

                itm = List.Items.Add(fornowDoc.<site>.<item>.ElementAt(i).<name>.Value, 0)
                itm.SubItems.Add(fornowDoc.<site>.<item>.ElementAt(i).<href>.Value)
                itm.SubItems.Add(fornowDoc.<site>.<item>.ElementAt(i).<cat>.Value)
                itm.SubItems.Add(fornowDoc.<site>.<item>.ElementAt(i).<des>.Value)
            Catch ex As Exception

            End Try
            i += 1
        Next

        i = 0
    End Sub


    Private Sub tools_links_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        List.Items.Clear()
        CheckForIllegalCrossThreadCalls = False
        Dim tt As Thread = New Thread(AddressOf getlist)
        tt.IsBackground = False
        tt.Start()
    End Sub
  

    Private Sub List_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles List.MouseDoubleClick

        Try
            Process.Start("http://" & List.SelectedItems(0).SubItems(1).Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List.SelectedIndexChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebWarnForm.goUrl = "http://aryan-pc.blog.ir/post/add-site-req"
        WebWarnForm.ShowDialog()
    End Sub

    Private Sub ButtonPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button7.Paint
        Dim Btn = DirectCast(sender, Button)
        Using P As New Pen(Color.White)
            e.Graphics.DrawRectangle(P, 1, 1, Btn.Width - 3, Btn.Height - 3)
        End Using
    End Sub
End Class