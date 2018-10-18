Imports System.IO
Public NotInheritable Class Splash

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        'Me.Tag += 1
        'If Me.Tag = 2 Then
        '    frm_plugin_loader.Show()
        '    Me.Hide()
        'End If
    End Sub

    Private Sub Splash_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(Me.CreateGraphics, Me.ClientRectangle, Color.FromArgb(0.6, 209, 209, 209), ButtonBorderStyle.Solid)
    End Sub
End Class
