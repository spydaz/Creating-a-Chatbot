Public Class FrmBrainEditor

    Private Sub QA_MINDBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles QA_MINDBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.QA_MINDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QADataSet)

    End Sub

    Private Sub FrmBrainEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QADataSet._QA_MIND' table. You can move, or remove it, as needed.
        Me.QA_MINDTableAdapter.Fill(Me.QADataSet._QA_MIND)

    End Sub
End Class