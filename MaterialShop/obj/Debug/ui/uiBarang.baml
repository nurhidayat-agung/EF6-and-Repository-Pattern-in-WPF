   M S B A M L   `   `   `  ����G  CMaterialShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MaterialShop.uiMaterialShop.ui  5          MaterialShop.ui.uiBarang   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MaterialShop.ui     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� 
Background  �#D1C4E9 N� Title$ uiBarang��5      .��5      � .+�5   
   �� -   5         ��Name$ tbxIdBarang��5      $
��Left=�6'   $��34��6B   $��	31,10,0,0q�5       �� TextWrapping$
 Wrap=�6%   $�� ��69   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Masukan Id Barang��5      $	��Top=�5      $	��239��6*   $��16(�66    �� 
IsReadOnly . {�.  5   $   �� 5   
   -   5        $ tbxNamaBarang��5      $
��Left=�6)   $��34��5      $��	31,49,0,0q�6   $
 Wrap=�61   $�� ��5      $	��Top=�6   $	��239��62   $��16(�5      $ Masukan Nama Barang��6    �� 5   
   -   5        $ tbxHargaBarang��5      $
��Left=�6*   $��34��6E   $��	31,88,0,0q�5      $
 Wrap=�6%   $�� ��69   $	��Top=�6A   $	��239��5      $��16(�6   $ masukan Harga Barang��5      �� 5   
   -   5        $ tbxStok��5      $
��Left=�6#   $��34��6>   $��
485,10,0,0q�5      $
 Wrap=�6&   $��0��6:   $	��Top=�5      $	��182��6*   $��16(�66   $ masukn stok barang��5      �� 5    
   -   5         ��Name$ cbxKategori��5       $
��Left=�6(   $��
428,52,0,0q�6C   $	��Top=�5!      $	��239��6+   $��16(�67   �� 5"   
   -   5         ��Name$ btnSave��5"      $��Tambah��6"   $
��Left=�63   $��351,100,0,0q�6N   $	��Top=�5#      $	��103��6)   $��16(�65   $��39��6C   6O   �� 5$   
   -   5        $ btnEdit��5$      $
��Edit��6"   $
��Left=�61   $��485,100,0,0q�6L   $	��Top=�5%      $��75��6)   $��16(�64   $��39��6B   6N   �� 5&   
   -   5        $ btnHapus��5&      $��Hapus��6#   $
��Left=�63   $��592,100,0,0q�6N   $	��Top=�5'      $��75��6)   $��16(�64   $��39��6B   6N   �� 5(   
   -	   5        $ tbxCariBarang��5(      $
��Left=�6)   $��34��6D   $��
31,163,0,0q�5)      $
 Wrap=�6!   $�� ��65   $	��Top=�6=   $	��239��5*      $��16(�6   $ Cari Nama Barang��5+      �� 5,   
   -
   5        $ btnCari��5,      $
��Cari��6"   $
��Left=�61   $��307,161,0,0q�5-      $	��Top=�6&   $	��103��6>   $��16(�5.      $��39��6   6+   &   System.Windows.Controls.DataGrid  5/   
   -   5          Name$ dgBarang��5/      $
��Left=�6%   $��
10,205,0,0q�6@   $	��Top=�50      $	��265��6+   $	��688��68   	   CanUserAddRows	 .  
   
IsReadOnly
 .    AutoGenerateColumns .     Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Id Barang��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *
idBarang+  56      $ Nama Barang��6%   $	 140 6:    6F   �� *
namaBarang+  57      $ Harga��6%   $	 100 64    6@   �� *harga+  58      $ 
idKategori��6%   $	 100 69    6E   �� *idKategoriRefId+  59      $
 Stok��6%   $ 80 63    6>   �� *stok+  5:      $ Create Date��6%   $ 80 6:    6E   �� *
createDate+  5;      $ Update Date��6%   $ 80 6:    6E   �� *	UpdDate+5=      �� 5>   
   -   5         ��Name$ label��5>      $
��Stok��6   $
��Left=�6.   $��
428,15,0,0q�6I   $	��Top=�6]   $��16(�6u   5@      5A      