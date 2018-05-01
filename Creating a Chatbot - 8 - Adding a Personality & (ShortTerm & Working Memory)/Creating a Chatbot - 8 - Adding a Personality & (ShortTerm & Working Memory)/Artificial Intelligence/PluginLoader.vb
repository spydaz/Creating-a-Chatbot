Imports PluginInterface
Imports System.IO
Imports System.Reflection
Module PluginLoader
    ''' <summary>
    ''' searches the given path for assemblies of type dll, and Iplugin(interface to be used for all plugins)
    ''' </summary>
    ''' <param name="path"></param>
    ''' <returns>Collection of plugin objects</returns>
    ''' <remarks></remarks>
    Public Function LoadPlugins(path As String) As ICollection(Of IPlugin)
        Dim dllFileNames As String()
        If Directory.Exists(path) Then
            dllFileNames = Directory.GetFiles(path, "*.dll")

            Dim assemblies As ICollection(Of Assembly) = New List(Of Assembly)(dllFileNames.Length)
            For Each dllFile As String In dllFileNames
                Dim an As AssemblyName = AssemblyName.GetAssemblyName(dllFile)
                Dim assembly As Assembly = assembly.Load(an)
                assemblies.Add(assembly)
            Next
            Dim pluginType As Type = GetType(IPlugin)
            Dim pluginTypes As ICollection(Of Type) = New List(Of Type)
            For Each assembly As Assembly In assemblies
                If assembly <> Nothing Then
                    Dim types As Type() = assembly.GetTypes()
                    For Each type As Type In types
                        If type.IsInterface Or type.IsAbstract Then
                            Continue For
                        Else
                            If type.GetInterface(pluginType.FullName) <> Nothing Then
                                pluginTypes.Add(type)
                            End If
                        End If
                    Next
                End If
            Next
            Dim plugins As ICollection(Of IPlugin) = New List(Of IPlugin)(pluginTypes.Count)
            For Each type As Type In pluginTypes
                Dim plugin As IPlugin = Activator.CreateInstance(type)
                plugins.Add(plugin)
            Next
            Return plugins
        End If
        Return Nothing
    End Function
End Module