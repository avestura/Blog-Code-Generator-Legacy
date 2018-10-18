Imports System.Net
Imports System.Threading
Public Class SourceToolsForm
    Dim wc As WebClient = New WebClient
    Sub gets()
        Try
            wc.Encoding = System.Text.Encoding.UTF8
            Dim Source As String = wc.DownloadString(TextBox1.Text)
            If Source.ToString.Contains("<meta content=""disable-blogcode"" name=""aryan-software-app"">") Then
                TextBox2.Text = "در ساختار صفحه وب مورد نظر کد زیر موجود است:" & vbNewLine & _
                     "<meta content=""disable-blogcode"" name=""aryan-software-app"">" & vbNewLine & vbNewLine & _
                        "لذا دسترسی به سورس صفحه توسط این نرم افزار امکان پذیر نیست"

            Else
                TextBox2.Text = Source
                TextBox2.Text = Replace(TextBox2.Text, "    ", vbNewLine)
                TextBox2.Text = Replace(TextBox2.Text, "	", vbNewLine)

            End If

        Catch ex As Exception
            TextBox2.Text = "دریافت سورس صفحه وب امکان پذیر نبود. خطا به دلیل زیر رخ داده است:" & vbNewLine & ex.Message
        End Try
        Button3.Enabled = True
        TextBox1.Enabled = True
    End Sub

    'Private Sub ButtonEffect_MouseLeave(sender As Object, e As EventArgs)
    '    Try
    '        sender.BackgroundImage = My.Resources.bcg_RedCarpet
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub ButtonEffect_MouseMove(sender As Object, e As MouseEventArgs) Handles Button3.MouseMove
    '    Try
    '        sender.BackgroundImage = My.Resources.back_yello
    '    Catch ex As Exception

    '    End Try
    'End Sub
 

    Private Sub tools_source_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If LCase(TextBox1.Text).Contains("aryan-pc.blog.ir") OrElse LCase(TextBox1.Text).Contains("aryan-pc.ir") OrElse LCase(TextBox1.Text).Contains("myplanet.blog.ir") Then
            TextBox2.Text = "در ساختار صفحه وب مورد نظر کد زیر موجود است:" & vbNewLine & _
                "<meta content=""disable-blogcode"" name=""aryan-software-app"">" & vbNewLine & vbNewLine & _
                "لذا دسترسی به سورس صفحه توسط این نرم افزار امکان پذیر نیست"

        Else
            Button3.Enabled = False
            TextBox1.Enabled = False
            TextBox2.Text = "لطفا صبر کنید..."
            Dim t1 As Thread = New Thread(AddressOf gets)
            t1.IsBackground = True
            CheckForIllegalCrossThreadCalls = False
            t1.Start()
        End If

    End Sub

    Private Sub ButtonPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button3.Paint
        Dim Btn = DirectCast(sender, Button)
        Using P As New Pen(Me.BackColor)
            e.Graphics.DrawRectangle(P, 1, 1, Btn.Width - 3, Btn.Height - 3)
        End Using
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class