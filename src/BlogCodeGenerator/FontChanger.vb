
Imports System.Drawing.Text
Namespace BlogCodeGenerator
    Module FontChanger

        Public PrivateFontCollection_Controler As New PrivateFontCollection()

        Public Function NameToUrl_byFont(ByVal FontName As String)

            Dim FontURLBase As String = My.Application.Info.DirectoryPath.ToString() & "\data\fonts\" & FontName
            Return FontURLBase
        End Function

        Private Sub IMP_LOAD_FONTS()

            PrivateFontCollection_Controler.AddFontFile(NameToUrl_byFont("Droid.Arabic.Naskh.ttf"))

        End Sub

        Public Sub ChangeSenderFont_byArray(ByVal sender As Array, FontID As Integer, FontSize As Integer)
            Try
                IMP_LOAD_FONTS()
            Catch ex As Exception
                Exit Sub
            End Try

            Try
                For Each itm As Object In sender
                    Try
                        itm.Font = New Font(PrivateFontCollection_Controler.Families(FontID), FontSize, FontStyle.Regular, GraphicsUnit.Pixel)
                    Catch ex As Exception
                        Continue For
                    End Try

                Next

            Catch ex As Exception

            End Try

        End Sub

    End Module

End Namespace
