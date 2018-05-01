Imports System.CodeDom.Compiler
Imports PluginInterface
Public Class FrmPluginTester
    Dim plugins As ICollection(Of IPlugin)
    Private UserInput As String = ""
    Private Mresponse As String
    Private Sub CmdCompile_Click(sender As Object, e As EventArgs) Handles CmdCompile.Click
        ConsoleCodeCompile(PlugInText.Text)
    End Sub
    Public Shared Sub ConsoleCodeCompile(CodeBlock As String, Optional ByRef CompileType As String = "Dll", Optional ByRef Lang As String = "VisualBasic")
        'The CreateProvider method returns a CodeDomProvider instance for the specificed language name.
        'This instance is later used when we have finished specifying the parmameter values.
        Dim Compiler As CodeDomProvider = CodeDomProvider.CreateProvider(Lang)
        'Optionally, this could be called Parameters.
        'Think of parameters as settings or specific values passed to a method (later passsed to CompileAssemblyFromSource method).
        Dim Settings As New CompilerParameters
        'The CompileAssemblyFromSource method returns a CompilerResult that will be stored in this variable.
        Dim Result As CompilerResults = Nothing
        Dim ExecuteableName As String = ""
        Select Case Lang
            Case "VisualBasic"
                'Set assemblies referenced by the source code.
                Settings.ReferencedAssemblies.Add("System.dll")
                Settings.ReferencedAssemblies.Add("System.Windows.Forms.dll")
                Settings.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
                Settings.ReferencedAssemblies.Add(Application.StartupPath & "\PluginContracts.dll")
            Case "CSharp"
                'Set assemblies referenced by the source code.
                Settings.ReferencedAssemblies.Add("System.dll")
                Settings.ReferencedAssemblies.Add("System.Windows.Forms.dll")
                Settings.ReferencedAssemblies.Add("Microsoft.CSharp.dll")
            Case "Jscript"
                Settings.ReferencedAssemblies.Add("System.dll")
                Settings.ReferencedAssemblies.Add("System.Windows.Forms.dll")
                Settings.ReferencedAssemblies.Add("Microsoft.Jscript.dll")
            Case "VisualC"
                Settings.ReferencedAssemblies.Add("System.dll")
                Settings.ReferencedAssemblies.Add("System.Windows.Forms.dll")
                Settings.ReferencedAssemblies.Add("Microsoft.VisualC.dll")
        End Select
        Select Case CompileType
            Case "EXE"
                Dim S As New SaveFileDialog
                With S

                    .Filter = "Executable (*.exe)|*.exe"
                    If (.ShowDialog() = DialogResult.OK) Then
                        ExecuteableName = .FileName
                    End If
                End With
                'Library type options : /target:library, /target:win, /target:winexe
                'Generates an executable instead of a class library.
                'Compiles in memory.
                Settings.GenerateInMemory = False
                Settings.GenerateExecutable = True
                Settings.CompilerOptions = " /target:winexe"
                'Set the assembly file name / path
                Settings.OutputAssembly = ExecuteableName
                'Read the documentation for the result again variable.
                'Calls the CompileAssemblyFromSource that will compile the specified source code using the parameters specified in the settings variable.
                Result = Compiler.CompileAssemblyFromSource(Settings, CodeBlock)
            Case "MEM"
                'Compiles in memory.
                Settings.GenerateInMemory = True
                'Read the documentation for the result again variable.
                'Calls the CompileAssemblyFromSource that will compile the specified source code using the parameters specified in the settings variable.
                Result = Compiler.CompileAssemblyFromSource(Settings, CodeBlock)
                'Creates assembly
                Dim objAssembly As System.Reflection.Assembly = Result.CompiledAssembly
                Dim objTheClass As Object = objAssembly.CreateInstance("MainClass")
                If objTheClass Is Nothing Then
                    MsgBox("Can't load class...")
                    Exit Sub
                End If
                'Trys to excute
                Try
                    objTheClass.GetType.InvokeMember("ExecuteCode",
                        System.Reflection.BindingFlags.InvokeMethod, Nothing, objTheClass, Nothing)
                Catch ex As Exception
                    MsgBox("Error:" & ex.Message)
                End Try
            Case "Dll"
                Dim S As New SaveFileDialog
                With S
                    .Filter = "Plugin (*.Dll)|*.Dll"
                    If (.ShowDialog() = DialogResult.OK) Then
                        ExecuteableName = .FileName
                    End If
                End With
                'Library type options : /target:library, /target:win, /target:winexe
                'Generates an executable instead of a class library.
                'Compiles in memory.
                Settings.GenerateInMemory = False
                Settings.GenerateExecutable = False
                Settings.CompilerOptions = " /target:library"
                'Set the assembly file name / path
                Settings.OutputAssembly = ExecuteableName
                'Read the documentation for the result again variable.
                'Calls the CompileAssemblyFromSource that will compile the specified source code using the parameters specified in the settings variable.
                Result = Compiler.CompileAssemblyFromSource(Settings, CodeBlock)
        End Select
        'Determines if we have any errors when compiling if so loops through all of the CompileErrors in the Reults variable and displays their ErrorText property.
        If (Result.Errors.Count <> 0) Then
            MessageBox.Show("Exception Occured!", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            For Each E As CompilerError In Result.Errors
                MessageBox.Show(E.ErrorText)
            Next
        ElseIf (Result.Errors.Count = 0) And CompileType = "EXE" Or CompileType = "DLL" Then
            MsgBox("file saved at " & ExecuteableName)
        End If
    End Sub
    Private Sub CmdExecutePlugins_Click(sender As Object, e As EventArgs) Handles CmdExecutePlugins.Click
        'LoadPlugins to Listboxes
        LoadPlugins()
        For i = 0 To UBound(plugins)
            If LstPlugins.SelectedIndex = i Then txtOUT.Text = plugins(i).GetResponse(txtIN.Text)
        Next
    End Sub
    Public Sub LoadPlugins()
        ''Load Plugins from folder Using "Plugin Loader"
        plugins = PluginLoader.LoadPlugins(Application.StartupPath & "\Plugins")
        For Each item In plugins
            LstPlugins.Items.Add(item.Name)
            LstResponses.Items.Add(item.GetResponse(txtIN.Text))
            txtOUT.AppendText(item.GetResponse(txtIN.Text))
        Next

    End Sub
    Private Sub CmdNew_Click(sender As Object, e As EventArgs) Handles CmdNew.Click

    End Sub
End Class