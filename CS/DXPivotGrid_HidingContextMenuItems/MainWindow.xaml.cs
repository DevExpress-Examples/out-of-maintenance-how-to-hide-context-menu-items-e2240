using System.Windows;
using DXPivotGrid_HidingContextMenuItems.DataSet1TableAdapters;

namespace DXPivotGrid_HidingContextMenuItems {
    public partial class MainWindow : Window {
        DataSet1.SalesPersonDataTable salesPersonDataTable = new DataSet1.SalesPersonDataTable();
        SalesPersonTableAdapter salesPersonDataAdapter = new SalesPersonTableAdapter();
        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = salesPersonDataTable;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            salesPersonDataAdapter.Fill(salesPersonDataTable);
            pivotGridControl1.CollapseAllColumns();
        }
    }
}
