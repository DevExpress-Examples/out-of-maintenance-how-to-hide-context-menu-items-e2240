<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXPivotGrid_HidingContextMenuItems/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/DXPivotGrid_HidingContextMenuItems/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/DXPivotGrid_HidingContextMenuItems/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXPivotGrid_HidingContextMenuItems/MainWindow.xaml.vb))
<!-- default file list end -->
# How to Hide Context Menu Items


<p>This example shows how to remove items from the PivoGridControl context menu.</p><p>In this sample, the 'Show Prefilter', 'Show Field List' and 'Refresh Data' items are removed from the field headers' context menu. For this purpose, three RemoveBarItemAndLinkAction objects are added to the control's HeaderMenuCustomizations collection. Their ItemName properties are set to DefaultMenuItemNames.ShowPrefilter, DefaultMenuItemNames.ShowFieldList and DefaultMenuItemNames.RefreshData, respectively.</p>

<br/>


