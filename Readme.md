<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128578719/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2240)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXPivotGrid_HidingContextMenuItems/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXPivotGrid_HidingContextMenuItems/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXPivotGrid_HidingContextMenuItems/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXPivotGrid_HidingContextMenuItems/MainWindow.xaml.vb))
<!-- default file list end -->
# How to Hide Context Menu Items


<p>This example shows how to remove items from the PivoGridControl context menu.</p><p>In this sample, the 'Show Prefilter', 'Show Field List' and 'Refresh Data' items are removed from the field headers' context menu. For this purpose, three RemoveBarItemAndLinkAction objects are added to the control's HeaderMenuCustomizations collection. Their ItemName properties are set to DefaultMenuItemNames.ShowPrefilter, DefaultMenuItemNames.ShowFieldList and DefaultMenuItemNames.RefreshData, respectively.</p>

<br/>


