   M S B A M L   `   `   `  ���� G  CMaterialShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MaterialShop.uiMaterialShop.ui       MaterialShop.ui.uiSupplier   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:MaterialShop.ui     U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
Background  �#D1C4E9 N� Title$ 
uiSupplier��.��� .+��� -    ��Name$ tbxSupplier��$
��Left=�$��36��$��	30,26,0,0q� �� TextWrapping$
 Wrap=�$�� ��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Masukan nama supplier��$	��Top=�$	��213��$��16(��� -    ��Name$ 	btnTambah��$��Tambah��$
��Left=�$��
280,30,0,0q�$	��Top=�$	��108���� -   $ btnEdit��$
��Edit��$
��Left=�$��
430,30,0,0q�$	��Top=�$��84���� -   $ btnHapus��$��Hapus��$
��Left=�$��
549,30,0,0q�$	��Top=�$��93��&   System.Windows.Controls.DataGrid  -     Name$ 
dgSupplier��$
��Left=�$��	30,96,0,0q�$	��Top=�$	��355��$	��265��   
IsReadOnly .    CanUserAddRows .  	   AutoGenerateColumns	 .  
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
idSupplier+  $ Nama Supplier�� �� *supplierName+  -   $ dgBarang��$
��Left=�$��
322,96,0,0q�$	��Top=�$	��355��$	��356��