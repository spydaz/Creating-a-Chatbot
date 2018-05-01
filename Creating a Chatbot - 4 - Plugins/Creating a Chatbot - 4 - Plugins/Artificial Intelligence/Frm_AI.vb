Imports System.Speech.Recognition
Imports System.Speech.Synthesis
Public Class Frm_AI
    'Methods for form positioning
    Private x, y As Integer
    Private newpoint As New Point
    Private Userinput As String

    Private Sub Frm_AI_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        End
    End Sub

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
        ProcessInputText(TextInput.Text)
        ' Output
    End Sub
    ''' <summary>
    ''' handles the various inputs
    ''' </summary>
    ''' <param name="NewText"></param>
    ''' <remarks></remarks>
    Private Sub ProcessInputText(ByVal NewText As String)
        'Input
        Userinput = NewText
        TextInput.Text = ""
        ''Executes Main Response
        ProcessOutputText(GetResponse(Userinput))
    End Sub
    ''' <summary>
    ''' used to process the output text
    ''' </summary>
    ''' <param name="NewText"></param>
    ''' <remarks></remarks>
    Private Sub ProcessOutputText(NewText As String)
        'Output
        SetOutputText(NewText)
    End Sub
    ''' <summary>
    ''' called to retrieve the user input from the text box
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetUserInput() As String
        Dim NewText As String = TextInput.Text
        Return NewText
    End Function
    ''' <summary>
    ''' called when the response has been found
    ''' </summary>
    ''' <param name="NewText"></param>
    ''' <remarks></remarks>
    Public Sub SetOutputText(NewText As String)
        TextOutput.Text = NewText
        SpeakText(NewText)
    End Sub

    ''' <summary>
    ''' called when the project loads
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Frm_AI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupRecognition()
        'SpeakText("Welcome")
    End Sub
    'Speech synthasis methods
    '------------------------------------------------------------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' enables voice recognition engine
    ''' </summary>
    ''' <remarks></remarks>
    Public WithEvents RecoEngine As New SpeechRecognitionEngine()
    ''' <summary>
    ''' Enable TexttoSpeech
    ''' </summary>
    ''' <remarks></remarks>
    Private SpeechSynth As New SpeechSynthesizer
    ''' <summary>
    ''' Sets up Speech Recognition for use
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SetupRecognition()
        RecoEngine.LoadGrammar(New DictationGrammar())
        RecoEngine.SetInputToDefaultAudioDevice()
        RecoEngine.RecognizeAsync()
    End Sub
    ''' <summary>
    ''' Activated on completion of recognition
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RecoEngine_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles RecoEngine.RecognizeCompleted
        RecoEngine.RecognizeAsync()
    End Sub
    ''' <summary>
    ''' On recogonizing speech the input is sent to the response routine
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RecoEngine_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles RecoEngine.SpeechRecognized
        'SetOutputText(e.Result.Text)
        'a call to act is required here
        ProcessInputText(e.Result.Text)
    End Sub
    ''' <summary>
    ''' Speaktext Uses the internal speech system to speak the text, using the SAPI
    ''' </summary>
    ''' <param name="NewText">String: Text to be spoken</param>
    ''' <remarks></remarks>
    Public Sub SpeakText(ByRef NewText As String)
        SpeechSynth.Speak(NewText)
    End Sub

End Class