Imports System.Windows
Imports DXPivotGrid_HidingContextMenuItems.DataSet1TableAdapters

Namespace DXPivotGrid_HidingContextMenuItems

    Public Partial Class MainWindow
        Inherits Window

        Private salesPersonDataTable As DataSet1.SalesPersonDataTable = New DataSet1.SalesPersonDataTable()

        Private salesPersonDataAdapter As SalesPersonTableAdapter = New SalesPersonTableAdapter()

        Public Sub New()
            Me.InitializeComponent()
            Me.pivotGridControl1.DataSource = salesPersonDataTable
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            salesPersonDataAdapter.Fill(salesPersonDataTable)
            Me.pivotGridControl1.CollapseAllColumns()
        End Sub
    End Class
End Namespace
