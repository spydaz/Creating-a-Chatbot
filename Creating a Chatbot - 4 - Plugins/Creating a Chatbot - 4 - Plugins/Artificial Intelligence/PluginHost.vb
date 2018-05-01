Imports PluginInterface
Public Class PluginHost
    Private _Plugins As Dictionary(Of String, IPlugin)
    Private UserInput As String = ""
    Private Mresponse As String
    ''' <summary>
    ''' response held in the class
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Response As String
        Get
            Return Mresponse
        End Get
    End Property
    ''' <summary>
    ''' Executes plugins in folder \plugins, adds subsequent responses to response
    ''' </summary>
    ''' <param name="_UserInput"></param>
    ''' <remarks></remarks>
    Private Sub ExecutePlugin(ByVal _UserInput As String)
        _Plugins = New Dictionary(Of String, IPlugin)
        Dim plugins As ICollection(Of IPlugin) = PluginLoader.LoadPlugins(Application.StartupPath & "\Plugins")
        If plugins Is Nothing Then

            Return
        End If
        For Each item In plugins
            If item.GetResponse(_UserInput) = True Then
                SetResponse(item.Response)
            End If
        Next
    End Sub
    ''' <summary>
    ''' hee responses are chained together
    ''' </summary>
    ''' <param name="Response"></param>
    ''' <remarks></remarks>
    Private Sub SetResponse(ByVal Response As String)
        Mresponse = LTrim(Mresponse) & " " & Response
    End Sub
    ''' <summary>
    ''' executes all plugins returning the chained response
    ''' </summary>
    ''' <param name="_UserInput"></param>
    ''' <returns>response string</returns>
    ''' <remarks></remarks>
    Public Function Execute(ByVal _UserInput As String) As String
        ExecutePlugin(_UserInput)
        Return Mresponse
    End Function
End Class