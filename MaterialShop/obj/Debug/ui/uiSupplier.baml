   M S B A M L   `   `   `  ����G  CMaterialShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MaterialShop.uiMaterialShop.ui  5           MaterialShop.ui.uiSupplier   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MaterialShop.ui     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� 
Background  �#D1C4E9 N� Title$ 
uiSupplier��5      .��5      � .+�5   
   �� -   5         ��Name$ tbxSupplier��5      $
��Left=�6'   $��36��6B   $��	30,26,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $�� ��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Masukan nama supplier��6   $	��Top=�6Q   $	��213��6i   $��16(�6u   �� 5   
   -   5         ��Name$ 	btnTambah��5      $��Tambah��6$   $
��Left=�65   $��
280,30,0,0q�6P   $	��Top=�6d   $	��108��6|   6�   �� 5   
   -   5        $ btnEdit��5      $
��Edit��6"   $
��Left=�61   $��
430,30,0,0q�5      $	��Top=�6%   $��84��6=   5      �� 5   
   -   5        $ btnHapus��5      $��Hapus��6#   $
��Left=�63   $��
549,30,0,0q�5      $	��Top=�6%   $��93��6=   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgSupplier��5      $
��Left=�6'   $��	30,96,0,0q�6B   $	��Top=�5      $	��355��6+   $	��265��68      
IsReadOnly .    CanUserAddRows .  	   AutoGenerateColumns	 .  
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
idSupplier+  5      $ Nama Supplier��6%    6<   �� *supplierName+5         5!   
   -   5        $ dgBarang��5!      $
��Left=�6%   $��
322,96,0,0q�6@   $	��Top=�5"      $	��355��6+   $	��356��68   5$      5%      