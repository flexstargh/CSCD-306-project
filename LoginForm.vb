Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click


        HomePage.Show()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub AdministratorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AdministratorsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdministratorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tech_Army_MIS_databaseDataSet)

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Tech_Army_MIS_databaseDataSet.Administrators' table. You can move, or remove it, as needed.
        Me.AdministratorsTableAdapter.Fill(Me.Tech_Army_MIS_databaseDataSet.Administrators)

    End Sub
End Class
