Module Response


    Public Function GetResponse(Userinput As String) As String



        'Step one : Gather Knowledge from sentence

        ' try to determine the: 
        ' subject - Verb - Object
        ' Number of words, Number of sentences
        ' Keywords, Sentence meaning, Sentiment, 
        '-----------------------------------------


        Dim ResponseFound As Boolean = False
        Dim OutputText As String = Userinput

        '------------------------------------------
        '001 Check Blank input
        'Looks for a null input and requests data
        '------------------------------------------
        If CheckBlankInput(Userinput) = True Then
            OutputText = "Please enter some text"
            ResponseFound = True
        Else
            ResponseFound = False
        End If




        'Step Two::: Search Data base based on knowledge found
        '-------------------------------------------------------

        'Step Three::: Evaluate What needs to be saved:
        '-------------------------------------------------------

        'Step Four::: Create Response
        '-------------------------------------------------------


        'Old  Functions go here:
        '::: These are used when no response has been generated or found from the data base :
        '::: This is a non intelligent response :
        '::: Chatbrain_Response ::: Keyword / Response & Question / Answer Response :
        '------------------------------------------------------------------------------









        '------------------------------------------------------------------------------





        'Final OutputStage
        '------------------------------------------------------------------------------

        'Display_Output 



        Return OutputText
    End Function

    Public Function CheckBlankInput(SomeText As String) As Boolean
        'Decription:    checks input for a null 
        'returns:       True / False
        'Implemetation : 

        'If CheckBlankInput(Userinput) = True Then
        '   OutputText = "Please enter some text"
        '   ResponseFound = True
        'Else
        'ResponseFound = False
        'End If

        Dim CheckBlank As Boolean
        'Check Blank input
        If SomeText = "" Then

            CheckBlank = True
        Else

            CheckBlank = False
        End If

        Return CheckBlank
    End Function
End Module
