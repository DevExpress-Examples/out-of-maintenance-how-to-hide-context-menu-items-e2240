Imports Microsoft.VisualBasic
Imports System.Windows
Imports DXPivotGrid_HidingContextMenuItems.DataSet1TableAdapters

Namespace DXPivotGrid_HidingContextMenuItems
	Partial Public Class MainWindow
		Inherits Window
		Private salesPersonDataTable As New DataSet1.SalesPersonDataTable()
		Private salesPersonDataAdapter As New SalesPersonTableAdapter()
		Public Sub New()
			InitializeComponent()
			pivotGridControl1.DataSource = salesPersonDataTable
		End Sub
		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			salesPersonDataAdapter.Fill(salesPersonDataTable)
			pivotGridControl1.CollapseAllColumns()
		End Sub
	End Class
End Namespace
