Imports PluginInterface
''' <summary>
''' This is the sample plugin, Implementing Iplugin, contained in the PluginInterface
''' </summary>
''' <remarks></remarks>
Public Class SamplePlugin
    Implements IPlugin
    Dim Mresponse As String = ""
    ''' <summary>
    ''' This is the main response "Handles Iplugin.etResponse"
    ''' </summary>
    ''' <param name="UserInput"></param>
    ''' <returns>TRUE : If response is detected</returns>
    ''' <remarks></remarks>
    Public Function GetResponse(UserInput As String) As Boolean Implements IPlugin.GetResponse
        GetResponse = False
        Mresponse = "SamplePlugin Response"
        GetResponse = True
    End Function
    ''' <summary>
    ''' This is the name of the plugin created
    ''' </summary>
    ''' <value></value>
    ''' <returns>String Name</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Name As String Implements IPlugin.Name
        Get
            Name = "SamplePlugin"
        End Get
    End Property
    ''' <summary>
    ''' Response to be returned to the main script
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Response As String Implements IPlugin.Response
        Get
            Return Mresponse
        End Get
        Set(value As String)
            Mresponse = value
        End Set
    End Property
End Class