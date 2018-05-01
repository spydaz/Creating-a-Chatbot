<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPluginTester
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPluginTester))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PlugInText = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdExecutePlugins = New System.Windows.Forms.Button()
        Me.txtIN = New System.Windows.Forms.TextBox()
        Me.LstPlugins = New System.Windows.Forms.ListBox()
        Me.LstResponses = New System.Windows.Forms.ListBox()
        Me.CmdNew = New System.Windows.Forms.Button()
        Me.CmdCompile = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtOUT = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PlugInText)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 436)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plugin Script"
        '
        'PlugInText
        '
        Me.PlugInText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlugInText.Location = New System.Drawing.Point(3, 16)
        Me.PlugInText.Multiline = True
        Me.PlugInText.Name = "PlugInText"
        Me.PlugInText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.PlugInText.Size = New System.Drawing.Size(798, 417)
        Me.PlugInText.TabIndex = 0
        Me.PlugInText.Text = Global.Artificial_Intelligence.My.MySettings.Default.SamplePlugin
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.LstPlugins)
        Me.GroupBox2.Controls.Add(Me.LstResponses)
        Me.GroupBox2.Controls.Add(Me.CmdNew)
        Me.GroupBox2.Controls.Add(Me.CmdCompile)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(0, 452)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(804, 245)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Compiler"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(391, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Loaded Plugins"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(549, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Plugin Responses"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 452)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Plugins Response"
        '
        'CmdExecutePlugins
        '
        Me.CmdExecutePlugins.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdExecutePlugins.Location = New System.Drawing.Point(290, 108)
        Me.CmdExecutePlugins.Name = "CmdExecutePlugins"
        Me.CmdExecutePlugins.Size = New System.Drawing.Size(57, 31)
        Me.CmdExecutePlugins.TabIndex = 5
        Me.CmdExecutePlugins.Text = "Execute "
        Me.CmdExecutePlugins.UseVisualStyleBackColor = False
        '
        'txtIN
        '
        Me.txtIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIN.Location = New System.Drawing.Point(32, 106)
        Me.txtIN.Name = "txtIN"
        Me.txtIN.Size = New System.Drawing.Size(256, 31)
        Me.txtIN.TabIndex = 4
        '
        'LstPlugins
        '
        Me.LstPlugins.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstPlugins.FormattingEnabled = True
        Me.LstPlugins.Location = New System.Drawing.Point(391, 29)
        Me.LstPlugins.Name = "LstPlugins"
        Me.LstPlugins.Size = New System.Drawing.Size(151, 199)
        Me.LstPlugins.TabIndex = 3
        '
        'LstResponses
        '
        Me.LstResponses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstResponses.FormattingEnabled = True
        Me.LstResponses.Location = New System.Drawing.Point(548, 29)
        Me.LstResponses.Name = "LstResponses"
        Me.LstResponses.Size = New System.Drawing.Size(251, 199)
        Me.LstResponses.TabIndex = 2
        '
        'CmdNew
        '
        Me.CmdNew.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdNew.Location = New System.Drawing.Point(12, 16)
        Me.CmdNew.Name = "CmdNew"
        Me.CmdNew.Size = New System.Drawing.Size(75, 23)
        Me.CmdNew.TabIndex = 1
        Me.CmdNew.Text = "New"
        Me.CmdNew.UseVisualStyleBackColor = False
        '
        'CmdCompile
        '
        Me.CmdCompile.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdCompile.Location = New System.Drawing.Point(93, 16)
        Me.CmdCompile.Name = "CmdCompile"
        Me.CmdCompile.Size = New System.Drawing.Size(75, 23)
        Me.CmdCompile.TabIndex = 0
        Me.CmdCompile.Text = "Compile"
        Me.CmdCompile.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(15, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(278, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Plugins are to be saved in the Applications \Plugins folder"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.BackgroundImage = Global.Artificial_Intelligence.My.Resources.Resources.interface_1g
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.CmdExecutePlugins)
        Me.GroupBox3.Controls.Add(Me.txtOUT)
        Me.GroupBox3.Controls.Add(Me.txtIN)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Location = New System.Drawing.Point(6, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(379, 163)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        '
        'txtOUT
        '
        Me.txtOUT.Location = New System.Drawing.Point(148, 19)
        Me.txtOUT.Multiline = True
        Me.txtOUT.Name = "txtOUT"
        Me.txtOUT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOUT.Size = New System.Drawing.Size(197, 81)
        Me.txtOUT.TabIndex = 7
        '
        'FrmPluginTester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(804, 697)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPluginTester"
        Me.Text = "Plugin Creator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PlugInText As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmdExecutePlugins As System.Windows.Forms.Button
    Friend WithEvents txtIN As System.Windows.Forms.TextBox
    Friend WithEvents LstPlugins As System.Windows.Forms.ListBox
    Friend WithEvents LstResponses As System.Windows.Forms.ListBox
    Friend WithEvents CmdNew As System.Windows.Forms.Button
    Friend WithEvents CmdCompile As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOUT As System.Windows.Forms.TextBox
End Class
