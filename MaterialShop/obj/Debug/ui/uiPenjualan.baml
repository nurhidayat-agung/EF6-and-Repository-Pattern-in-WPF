   M S B A M L   `   `   `  ����G  CMaterialShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MaterialShop.uiMaterialShop.ui  5      !    MaterialShop.ui.uiPenjualan   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MaterialShop.ui     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� 
Background  �#D1C4E9 N� Title$ uiPenjualan��5      .��5      � .+�5   
   �� -   5         ��Name$ cbxCustomer��5      $
��Left=�6(   $��
416,10,0,0q�5      $	��Top=�6'   $	��252��5      $��16(�6    �� DisplayMemberPath$ namaCustomer��5       �� SelectedValuePath$ 
idCustomer��5      �� 5   
   -   5         ��Name$ tbxNamaBarang��5      $
��Left=�6)   $��31��5      $��	10,10,0,0q�6    �� TextWrapping$
 Wrap=�61   $	��Top=�5      $	��229��6+   $��16(�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Cari Nama Barang��6    �� 5   
   -   5         ��Name$ btnCari��5      $
��Cari��6"   $
��Left=�5      $��	259,9,0,0q�6,   $	��Top=�5      $��75��6)   $��16(�64   5      &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dgCariBarang��5      $
��Left=�6)   $��	10,46,0,0q�5      $	��Top=�6&   $	��198��5      $	��387��6    
   AutoGenerateColumns
 .     
IsReadOnly .    CanUserAddRows .     Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Nama Barang��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 5"   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5#   %   �� *
namaBarang+  5$      $
 Stok��6%   $ 60 5%   %    5&   %   �� *stok+  5'      $ Nama Kategori��6%   $	 120 5(   %    5)   %   ��  �� Path$ kategori.namaKategori�  5*      $ harga��6%   $	 120 5+   %    5,   %   �� *harga+5.      �� 5/   
   -   5        $ tbxNamaDetail��5/      $
��Left=�6)   $��31��50      $��
416,52,0,0q�6   $
 Wrap=�6-   $	��Top=�51      $	��252��6%   $��16(�52      $ Nama Barang��6    �� 
IsReadOnly . 53      �� 54   
   -   5        $ 	btnToCart��54      $
��Cart��6$   $
��Left=�55      $��416,0,0,324q�6(   $��Bottom=�56      $	��252��6(   $��16(�64   57        58   
   -   5        $	 dgCart��58      $
��Left=�6#   $��
10,266,0,0q�59      $	��Top=�6!   $	��204��5:      $	��324��6   
 .   .  .   5=        5>      $ Nama Barang��6%   $	 140 5?   %    5@   %   �� *
namaBarang+  5A      $	 Qty��6%   $ 60 5B   %    5C   %   �� *	jmlJual+  5D      $ Harga��6%   $	 150 5E   %    5F   %   �� *hargaBarang+5J      �� 5K   
   -   5        $ tbxTotalBayar��5K      $
��Left=�6)   $��31��5L      $��374,266,0,0q�6   $
 Wrap=�6.   $	��Top=�5M      $	��252��6%   $��16(�5N      $ Harga Total��6    . {�.  5O      �� 5P   
   -	   5        $ 
tbxDibayar��5P      $
��Left=�6&   $��31��5Q      $��374,302,0,0q�6   $
 Wrap=�6.   $	��Top=�5R      $	��252��6%   $��16(�5S      $ Uang DIterima��6   5T      �� 5U   
   -
   5        $ 
tbxKembali��5U      $
��Left=�6&   $��31��5V      $��374,338,0,0q�6   $
 Wrap=�6.   $	��Top=�5W      $	��252��6%   $��16(�5X      $ Uang Kembali��6    . {�.  5Y      �� 5Z   
   -   5        $ btnJual��5Z      $��Proses��6"   $
��Left=�5[      $��374,374,0,0q�6(   $	��Top=�5\      $	��252��6%   $��16(�61   6?   �� 5]   
   -   5        $ 
tbxJmlbeli��5]      $
��Left=�6&   $��31��5^      $��
416,88,0,0q�6   $
 Wrap=�6-   $	��Top=�5_      $	��252��6%   $��16(�5`      $ Jumlah Beli��6   5b      5c      