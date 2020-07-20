<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listview))
        Dim Member_IDLabel As System.Windows.Forms.Label
        Me.Tech_Army_MIS_databaseDataSet2 = New TechArmyMIS.Tech_Army_MIS_databaseDataSet2()
        Me.IddBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IddTableAdapter = New TechArmyMIS.Tech_Army_MIS_databaseDataSet2TableAdapters.iddTableAdapter()
        Me.TableAdapterManager = New TechArmyMIS.Tech_Army_MIS_databaseDataSet2TableAdapters.TableAdapterManager()
        Me.IddBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.IddBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Member_IDTextBox = New System.Windows.Forms.TextBox()
        Member_IDLabel = New System.Windows.Forms.Label()
        CType(Me.Tech_Army_MIS_databaseDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IddBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IddBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IddBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tech_Army_MIS_databaseDataSet2
        '
        Me.Tech_Army_MIS_databaseDataSet2.DataSetName = "Tech_Army_MIS_databaseDataSet2"
        Me.Tech_Army_MIS_databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IddBindingSource
        '
        Me.IddBindingSource.DataMember = "idd"
        Me.IddBindingSource.DataSource = Me.Tech_Army_MIS_databaseDataSet2
        '
        'IddTableAdapter
        '
        Me.IddTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdministratorsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Church_Member_FinancesTableAdapter = Nothing
        Me.TableAdapterManager.Church_MembersTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = TechArmyMIS.Tech_Army_MIS_databaseDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IddBindingNavigator
        '
        Me.IddBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.IddBindingNavigator.BindingSource = Me.IddBindingSource
        Me.IddBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.IddBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.IddBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.IddBindingNavigatorSaveItem})
        Me.IddBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.IddBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.IddBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.IddBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.IddBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.IddBindingNavigator.Name = "IddBindingNavigator"
        Me.IddBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.IddBindingNavigator.Size = New System.Drawing.Size(293, 25)
        Me.IddBindingNavigator.TabIndex = 0
        Me.IddBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
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
        'IddBindingNavigatorSaveItem
        '
        Me.IddBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IddBindingNavigatorSaveItem.Enabled = False
        Me.IddBindingNavigatorSaveItem.Image = CType(resources.GetObject("IddBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.IddBindingNavigatorSaveItem.Name = "IddBindingNavigatorSaveItem"
        Me.IddBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.IddBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Member_IDLabel
        '
        Member_IDLabel.AutoSize = True
        Member_IDLabel.Location = New System.Drawing.Point(105, 71)
        Member_IDLabel.Name = "Member_IDLabel"
        Member_IDLabel.Size = New System.Drawing.Size(62, 13)
        Member_IDLabel.TabIndex = 1
        Member_IDLabel.Text = "Member ID:"
        '
        'Member_IDTextBox
        '
        Me.Member_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IddBindingSource, "Member ID", True))
        Me.Member_IDTextBox.Location = New System.Drawing.Point(173, 68)
        Me.Member_IDTextBox.Name = "Member_IDTextBox"
        Me.Member_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Member_IDTextBox.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 261)
        Me.Controls.Add(Member_IDLabel)
        Me.Controls.Add(Me.Member_IDTextBox)
        Me.Controls.Add(Me.IddBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Tech_Army_MIS_databaseDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IddBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IddBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IddBindingNavigator.ResumeLayout(False)
        Me.IddBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tech_Army_MIS_databaseDataSet2 As Tech_Army_MIS_databaseDataSet2
    Friend WithEvents IddBindingSource As BindingSource
    Friend WithEvents IddTableAdapter As Tech_Army_MIS_databaseDataSet2TableAdapters.iddTableAdapter
    Friend WithEvents TableAdapterManager As Tech_Army_MIS_databaseDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents IddBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents IddBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Member_IDTextBox As TextBox
End Class
