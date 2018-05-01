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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_AI))
        Dim QUESTIONLabel As System.Windows.Forms.Label
        Dim AnswerLabel As System.Windows.Forms.Label
        Me.TextInput = New System.Windows.Forms.TextBox()
        Me.TextOutput = New System.Windows.Forms.TextBox()
        Me.Button_EnterText = New System.Windows.Forms.Button()
        Me.GrpBoxQA = New System.Windows.Forms.GroupBox()
        Me.QADataSet = New Artificial_Intelligence.QADataSet()
        Me.QA_MINDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QA_MINDTableAdapter = New Artificial_Intelligence.QADataSetTableAdapters.QA_MINDTableAdapter()
        Me.TableAdapterManager = New Artificial_Intelligence.QADataSetTableAdapters.TableAdapterManager()
        Me.QA_MINDBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.QA_MINDBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.QUESTIONTextBox = New System.Windows.Forms.TextBox()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        QUESTIONLabel = New System.Windows.Forms.Label()
        AnswerLabel = New System.Windows.Forms.Label()
        Me.GrpBoxQA.SuspendLayout()
        CType(Me.QADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QA_MINDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QA_MINDBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QA_MINDBindingNavigator.SuspendLayout()
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
        'QADataSet
        '
        Me.QADataSet.DataSetName = "QADataSet"
        Me.QADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QA_MINDBindingSource
        '
        Me.QA_MINDBindingSource.DataMember = "QA-MIND"
        Me.QA_MINDBindingSource.DataSource = Me.QADataSet
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'QA_MINDBindingNavigatorSaveItem
        '
        Me.QA_MINDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QA_MINDBindingNavigatorSaveItem.Image = CType(resources.GetObject("QA_MINDBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.QA_MINDBindingNavigatorSaveItem.Name = "QA_MINDBindingNavigatorSaveItem"
        Me.QA_MINDBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.QA_MINDBindingNavigatorSaveItem.Text = "Save Data"
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
        'QUESTIONTextBox
        '
        Me.QUESTIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QA_MINDBindingSource, "QUESTION", True))
        Me.QUESTIONTextBox.Location = New System.Drawing.Point(88, 49)
        Me.QUESTIONTextBox.Name = "QUESTIONTextBox"
        Me.QUESTIONTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QUESTIONTextBox.TabIndex = 1
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
        'AnswerTextBox
        '
        Me.AnswerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QA_MINDBindingSource, "Answer", True))
        Me.AnswerTextBox.Location = New System.Drawing.Point(88, 80)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnswerTextBox.TabIndex = 3
        '
        'Frm_AI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.Artificial_Intelligence.My.Resources.Resources.interface_1g1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(531, 329)
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
        CType(Me.QADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QA_MINDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QA_MINDBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QA_MINDBindingNavigator.ResumeLayout(False)
        Me.QA_MINDBindingNavigator.PerformLayout()
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

End Class
