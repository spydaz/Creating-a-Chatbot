
Public Class Frm_AI

    Private Userinput As String

    Private Sub Button_EnterText_Click(sender As Object, e As EventArgs) Handles Button_EnterText.Click

        'Input
        ProcessInputText()



        ' Output
        ProcessOutputText(GetResponse(Userinput))

    End Sub

    Private Sub ProcessInputText()
        'Input
        Userinput = GetUserInput()
        TextInput.Text = ""

    End Sub

    Private Sub ProcessOutputText(NewText As String)
        'Output
        SetOutputText(NewText)
    End Sub

    Public Function GetUserInput() As String
        Dim NewText As String = TextInput.Text
        Return NewText
    End Function

    Public Sub SetOutputText(NewText As String)
        TextOutput.Text = NewText
    End Sub


    Private Sub Frm_AI_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


End Class
