   M S B A M L   `   `   `  ����G  CMaterialShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MaterialShop.uiMaterialShop.ui  5           MaterialShop.ui.uiKategori   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MaterialShop.ui     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� 
Background  �#D1C4E9 N� Title$ 
uiKategori��5      .��5      � .+�5   
   �� -   5         ��Name$ tbxNik��5      $
��Left=�6"   $��34��6=    �� TextWrapping$
 Wrap=�5      $�� ��6&   $	��266��6.   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Masukan Nama Kategori��5      $��14(�6I   $��25,29,0,417q�6W   $
��Bold"�6l   $��SimSun)�6~   �� 5   
   -   5         ��Name$ btnSave��5      $��Tambah��6"   $
��Left=�63   $��
387,29,0,0q�6N   $	��Top=�6b   $��89��6z   6�   �� 5   
   -   5        $ btnEdit��5      $
��Edit��6"   $
��Left=�61   $��
506,29,0,0q�6L   $	��Top=�6`   $��75��6x   6�   �� 5   
   -   5        $ btnDel��5      $��Hapus��6!   $
��Left=�61   $��
610,29,0,0q�6L   $	��Top=�6`   $��75��6x   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dgContent��5      $
��Left=�6&   $��
25,126,0,0q�5      $	��Top=�6'   $	��320��6?   $	��219��5         
IsReadOnly .    CanUserAddRows .  	   AutoGenerateColumns	 .  
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id Kategori��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *
idKategori+  5      $ Nama Kategori��6%    6<   �� *namaKategori+5        5   
   -   5        $ dataGrid��5      $
��Left=�6%   $��278,126,0,0q�5      $	��Top=�6(   $	��320��5       $	��407��6     .  .  	 .  5%      5(      5)      