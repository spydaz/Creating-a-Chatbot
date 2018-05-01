
Public Class Frm_AI
    'Methods for form positioning
    Private x, y As Integer
    Private newpoint As New Point
    Private Userinput As String

    'Form Movement
    ''' <summary>
    ''' This samples solves the problem for the borderless form not being moveable.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Frm_AI_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Try
            ' Form movement set integers
            x = Control.MousePosition.X - Me.Location.X
            y = Control.MousePosition.Y - Me.Location.Y
        Catch ex As Exception
            'just in case
        End Try
    End Sub

    ''' <summary>
    ''' This samples solves the problem for the borderless form not being moveable.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Frm_AI_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Try
            ' Form movement movement
            If e.Button = Windows.Forms.MouseButtons.Left Then
                newpoint = Control.MousePosition
                newpoint.X -= (x)
                newpoint.Y -= (y)
                Me.Location = newpoint
            End If
        Catch ex As Exception
            'just in case
        End Try
    End Sub


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
