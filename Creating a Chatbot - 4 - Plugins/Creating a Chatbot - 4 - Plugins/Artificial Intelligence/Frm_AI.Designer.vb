<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AI
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
        Me.TextInput = New System.Windows.Forms.TextBox()
        Me.TextOutput = New System.Windows.Forms.TextBox()
        Me.Button_EnterText = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextInput
        '
        Me.TextInput.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextInput.Location = New System.Drawing.Point(48, 221)
        Me.TextInput.Name = "TextInput"
        Me.TextInput.Size = New System.Drawing.Size(431, 35)
        Me.TextInput.TabIndex = 0
        '
        'TextOutput
        '
        Me.TextOutput.Location = New System.Drawing.Point(214, 54)
        Me.TextOutput.Multiline = True
        Me.TextOutput.Name = "TextOutput"
        Me.TextOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextOutput.Size = New System.Drawing.Size(265, 150)
        Me.TextOutput.TabIndex = 1
        '
        'Button_EnterText
        '
        Me.Button_EnterText.ForeColor = System.Drawing.Color.Black
        Me.Button_EnterText.Location = New System.Drawing.Point(404, 262)
        Me.Button_EnterText.Name = "Button_EnterText"
        Me.Button_EnterText.Size = New System.Drawing.Size(75, 23)
        Me.Button_EnterText.TabIndex = 2
        Me.Button_EnterText.Text = "Enter"
        Me.Button_EnterText.UseVisualStyleBackColor = True
        '
        'Frm_AI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.Artificial_Intelligence.My.Resources.Resources.interface_1g1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(531, 329)
        Me.Controls.Add(Me.Button_EnterText)
        Me.Controls.Add(Me.TextOutput)
        Me.Controls.Add(Me.TextInput)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Frm_AI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Artificial Intelligence"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextInput As System.Windows.Forms.TextBox
    Friend WithEvents TextOutput As System.Windows.Forms.TextBox
    Friend WithEvents Button_EnterText As System.Windows.Forms.Button

End Class
