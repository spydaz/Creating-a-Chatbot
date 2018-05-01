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
        Me.components = New System.ComponentModel.Container()
        Dim QUESTIONLabel As System.Windows.Forms.Label
        Dim AnswerLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_AI))
        Me.TextInput = New System.Windows.Forms.TextBox()
        Me.TextOutput = New System.Windows.Forms.TextBox()
        Me.Button_EnterText = New System.Windows.Forms.Button()
        Me.GrpBoxQA = New System.Windows.Forms.GroupBox()
        Me.QA_MINDBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.QA_MINDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QADataSet = New Artificial_Intelligence.QADataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QA_MINDBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.QUESTIONTextBox = New System.Windows.Forms.TextBox()
        Me.QA_MINDTableAdapter = New Artificial_Intelligence.QADataSetTableAdapters.QA_MINDTableAdapter()
        Me.TableAdapterManager = New Artificial_Intelligence.QADataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdPluginCreator = New System.Windows.Forms.Button()
        Me.cmdBrainEditor = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMemUserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMemPrevUserSentence = New System.Windows.Forms.ComboBox()
        Me.TxtMemPreviousResponse = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtBotCreator = New System.Windows.Forms.TextBox()
        Me.TxtBotAge = New System.Windows.Forms.TextBox()
        Me.txtBotName = New System.Windows.Forms.TextBox()
        QUESTIONLabel = New System.Windows.Forms.Label()
        AnswerLabel = New System.Windows.Forms.Label()
        Me.GrpBoxQA.SuspendLayout()
        CType(Me.QA_MINDBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QA_MINDBindingNavigator.SuspendLayout()
        CType(Me.QA_MINDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'QUESTIONLabel
        '
        QUESTIONLabel.AutoSize = True
        QUESTIONLabel.Location = New System.Drawing.Point(16, 52)
        QUESTIONLabel.Name = "QUESTIONLabel"
        QUESTIONLabel.Size = New System.Drawing.Size(66, 13)
        QUESTIONLabel.TabIndex = 0
        QUESTIONLabel.Text = "QUESTION:"
        '
        'AnswerLabel
        '
        AnswerLabel.AutoSize = True
        AnswerLabel.Location = New System.Drawing.Point(37, 83)
        AnswerLabel.Name = "AnswerLabel"
        AnswerLabel.Size = New System.Drawing.Size(45, 13)
        AnswerLabel.TabIndex = 2
        AnswerLabel.Text = "Answer:"
        '
        'TextInput
        '
        Me.TextInput.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextInput.Location = New System.Drawing.Point(48, 221)
        Me.TextInput.Name = "TextInput"
        Me.TextInput.Size = New System.Drawing.Size(431, 38)
        Me.TextInput.TabIndex = 0
        '
        'TextOutput
        '
        Me.TextOutput.Location = New System.Drawing.Point(214, 54)
        Me.TextOutput.Multiline = True
        Me.TextOutput.Name = "TextOutput"
        Me.TextOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextOutput.Size = New System.Drawing.Size(265, 124)
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
        'GrpBoxQA
        '
        Me.GrpBoxQA.Controls.Add(Me.QA_MINDBindingNavigator)
        Me.GrpBoxQA.Controls.Add(AnswerLabel)
        Me.GrpBoxQA.Controls.Add(Me.AnswerTextBox)
        Me.GrpBoxQA.Controls.Add(QUESTIONLabel)
        Me.GrpBoxQA.Controls.Add(Me.QUESTIONTextBox)
        Me.GrpBoxQA.Location = New System.Drawing.Point(48, 54)
        Me.GrpBoxQA.Name = "GrpBoxQA"
        Me.GrpBoxQA.Size = New System.Drawing.Size(160, 19)
        Me.GrpBoxQA.TabIndex = 3
        Me.GrpBoxQA.TabStop = False
        Me.GrpBoxQA.Text = "GrpBoxQA"
        '
        'QA_MINDBindingNavigator
        '
        Me.QA_MINDBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.QA_MINDBindingNavigator.BindingSource = Me.QA_MINDBindingSource
        Me.QA_MINDBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.QA_MINDBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.QA_MINDBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.QA_MINDBindingNavigatorSaveItem})
        Me.QA_MINDBindingNavigator.Location = New System.Drawing.Point(3, 16)
        Me.QA_MINDBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.QA_MINDBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.QA_MINDBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.QA_MINDBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.QA_MINDBindingNavigator.Name = "QA_MINDBindingNavigator"
        Me.QA_MINDBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.QA_MINDBindingNavigator.Size = New System.Drawing.Size(154, 25)
        Me.QA_MINDBindingNavigator.TabIndex = 4
        Me.QA_MINDBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'QA_MINDBindingSource
        '
        Me.QA_MINDBindingSource.DataMember = "QA-MIND"
        Me.QA_MINDBindingSource.DataSource = Me.QADataSet
        '
        'QADataSet
        '
        Me.QADataSet.DataSetName = "QADataSet"
        Me.QADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'QA_MINDBindingNavigatorSaveItem
        '
        Me.QA_MINDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QA_MINDBindingNavigatorSaveItem.Image = CType(resources.GetObject("QA_MINDBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.QA_MINDBindingNavigatorSaveItem.Name = "QA_MINDBindingNavigatorSaveItem"
        Me.QA_MINDBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.QA_MINDBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QA_MINDBindingSource, "Answer", True))
        Me.AnswerTextBox.Location = New System.Drawing.Point(88, 80)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnswerTextBox.TabIndex = 3
        '
        'QUESTIONTextBox
        '
        Me.QUESTIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QA_MINDBindingSource, "QUESTION", True))
        Me.QUESTIONTextBox.Location = New System.Drawing.Point(88, 49)
        Me.QUESTIONTextBox.Name = "QUESTIONTextBox"
        Me.QUESTIONTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QUESTIONTextBox.TabIndex = 1
        '
        'QA_MINDTableAdapter
        '
        Me.QA_MINDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.QA_MINDTableAdapter = Me.QA_MINDTableAdapter
        Me.TableAdapterManager.UpdateOrder = Artificial_Intelligence.QADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.cmdPluginCreator)
        Me.GroupBox1.Controls.Add(Me.cmdBrainEditor)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 37)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'cmdPluginCreator
        '
        Me.cmdPluginCreator.BackColor = System.Drawing.Color.Black
        Me.cmdPluginCreator.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdPluginCreator.Location = New System.Drawing.Point(88, 11)
        Me.cmdPluginCreator.Name = "cmdPluginCreator"
        Me.cmdPluginCreator.Size = New System.Drawing.Size(86, 23)
        Me.cmdPluginCreator.TabIndex = 0
        Me.cmdPluginCreator.Text = "Plugin Creator"
        Me.cmdPluginCreator.UseVisualStyleBackColor = False
        '
        'cmdBrainEditor
        '
        Me.cmdBrainEditor.BackColor = System.Drawing.Color.Black
        Me.cmdBrainEditor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdBrainEditor.Location = New System.Drawing.Point(7, 11)
        Me.cmdBrainEditor.Name = "cmdBrainEditor"
        Me.cmdBrainEditor.Size = New System.Drawing.Size(75, 23)
        Me.cmdBrainEditor.TabIndex = 0
        Me.cmdBrainEditor.Text = "Brain Editor"
        Me.cmdBrainEditor.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtMemUserName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtMemPrevUserSentence)
        Me.GroupBox2.Controls.Add(Me.TxtMemPreviousResponse)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(45, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 13)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GrpWorkingMemory"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "UserName"
        '
        'TxtMemUserName
        '
        Me.TxtMemUserName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Artificial_Intelligence.My.MySettings.Default, "UserName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TxtMemUserName.Location = New System.Drawing.Point(15, 99)
        Me.TxtMemUserName.Name = "TxtMemUserName"
        Me.TxtMemUserName.Size = New System.Drawing.Size(121, 20)
        Me.TxtMemUserName.TabIndex = 4
        Me.TxtMemUserName.Text = Global.Artificial_Intelligence.My.MySettings.Default.UserName
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PreviousResponse"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PreviousUserSentence"
        '
        'TxtMemPrevUserSentence
        '
        Me.TxtMemPrevUserSentence.FormattingEnabled = True
        Me.TxtMemPrevUserSentence.Location = New System.Drawing.Point(14, 65)
        Me.TxtMemPrevUserSentence.Name = "TxtMemPrevUserSentence"
        Me.TxtMemPrevUserSentence.Size = New System.Drawing.Size(121, 21)
        Me.TxtMemPrevUserSentence.TabIndex = 1
        Me.TxtMemPrevUserSentence.Text = Global.Artificial_Intelligence.My.MySettings.Default.PrevUserSent
        '
        'TxtMemPreviousResponse
        '
        Me.TxtMemPreviousResponse.FormattingEnabled = True
        Me.TxtMemPreviousResponse.Location = New System.Drawing.Point(14, 27)
        Me.TxtMemPreviousResponse.Name = "TxtMemPreviousResponse"
        Me.TxtMemPreviousResponse.Size = New System.Drawing.Size(121, 21)
        Me.TxtMemPreviousResponse.TabIndex = 0
        Me.TxtMemPreviousResponse.Text = Global.Artificial_Intelligence.My.MySettings.Default.PreviousResp
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtBotCreator)
        Me.GroupBox3.Controls.Add(Me.TxtBotAge)
        Me.GroupBox3.Controls.Add(Me.txtBotName)
        Me.GroupBox3.Location = New System.Drawing.Point(45, 121)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(106, 17)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Personality Traits"
        '
        'txtBotCreator
        '
        Me.txtBotCreator.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Artificial_Intelligence.My.MySettings.Default, "BotCreator", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBotCreator.Location = New System.Drawing.Point(10, 64)
        Me.txtBotCreator.Name = "txtBotCreator"
        Me.txtBotCreator.Size = New System.Drawing.Size(181, 20)
        Me.txtBotCreator.TabIndex = 2
        Me.txtBotCreator.Text = Global.Artificial_Intelligence.My.MySettings.Default.BotCreator
        '
        'TxtBotAge
        '
        Me.TxtBotAge.Location = New System.Drawing.Point(9, 42)
        Me.TxtBotAge.Name = "TxtBotAge"
        Me.TxtBotAge.Size = New System.Drawing.Size(182, 20)
        Me.TxtBotAge.TabIndex = 1
        Me.TxtBotAge.Text = Global.Artificial_Intelligence.My.MySettings.Default.BotAge
        '
        'txtBotName
        '
        Me.txtBotName.Location = New System.Drawing.Point(10, 19)
        Me.txtBotName.Name = "txtBotName"
        Me.txtBotName.Size = New System.Drawing.Size(181, 20)
        Me.txtBotName.TabIndex = 0
        Me.txtBotName.Text = Global.Artificial_Intelligence.My.MySettings.Default.BotName
        '
        'Frm_AI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.Artificial_Intelligence.My.Resources.Resources.interface_1g1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(531, 336)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpBoxQA)
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
        Me.GrpBoxQA.ResumeLayout(False)
        Me.GrpBoxQA.PerformLayout()
        CType(Me.QA_MINDBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QA_MINDBindingNavigator.ResumeLayout(False)
        Me.QA_MINDBindingNavigator.PerformLayout()
        CType(Me.QA_MINDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextInput As System.Windows.Forms.TextBox
    Friend WithEvents TextOutput As System.Windows.Forms.TextBox
    Friend WithEvents Button_EnterText As System.Windows.Forms.Button
    Friend WithEvents GrpBoxQA As System.Windows.Forms.GroupBox
    Friend WithEvents QADataSet As Artificial_Intelligence.QADataSet
    Friend WithEvents QA_MINDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QA_MINDTableAdapter As Artificial_Intelligence.QADataSetTableAdapters.QA_MINDTableAdapter
    Friend WithEvents TableAdapterManager As Artificial_Intelligence.QADataSetTableAdapters.TableAdapterManager
    Friend WithEvents QA_MINDBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QA_MINDBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AnswerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QUESTIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPluginCreator As System.Windows.Forms.Button
    Friend WithEvents cmdBrainEditor As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtMemPrevUserSentence As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMemPreviousResponse As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMemUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBotAge As System.Windows.Forms.TextBox
    Friend WithEvents txtBotName As System.Windows.Forms.TextBox
    Friend WithEvents txtBotCreator As System.Windows.Forms.TextBox

End Class
