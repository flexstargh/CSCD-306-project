Public Class listview
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Tech_Army_MIS_databaseDataSet2.idd' table. You can move, or remove it, as needed.
        Me.IddTableAdapter.Fill(Me.Tech_Army_MIS_databaseDataSet2.idd)

    End Sub
End Class