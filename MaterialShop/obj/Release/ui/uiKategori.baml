   M S B A M L   `   `   `  ���� G  CMaterialShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MaterialShop.uiMaterialShop.ui       MaterialShop.ui.uiKategori   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:MaterialShop.ui     U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
Background  �#D1C4E9 N� Title$ 
uiKategori��.��� .+��� -    ��Name$ tbxNik��$
��Left=�$��34�� �� TextWrapping$
 Wrap=�$�� ��$	��266��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Masukan Nama Kategori��$��14(�$��25,29,0,417q�$
��Bold"�$��SimSun)��� -    ��Name$ btnSave��$��Tambah��$
��Left=�$��
387,29,0,0q�$	��Top=�$��89���� -   $ btnEdit��$
��Edit��$
��Left=�$��
506,29,0,0q�$	��Top=�$��75���� -   $ btnDel��$��Hapus��$
��Left=�$��
610,29,0,0q�$	��Top=�$��75��&   System.Windows.Controls.DataGrid  -     Name$ 	dgContent��$
��Left=�$��
25,126,0,0q�$	��Top=�$	��320��$	��219��   
IsReadOnly .    CanUserAddRows .  	   AutoGenerateColumns	 .  
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Id Kategori��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
idKategori+  $ Nama Kategori�� �� *namaKategori+  -   $ dataGrid��$
��Left=�$��278,126,0,0q�$	��Top=�$	��320��$	��407�� .  .  	 .  