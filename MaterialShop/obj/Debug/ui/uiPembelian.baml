   M S B A M L   `   `   `  ����G  CMaterialShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MaterialShop.uiMaterialShop.ui  5      !    MaterialShop.ui.uiPembelian   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MaterialShop.ui     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� 
Background  �#D1C4E9 N� Title$ uiPembelian��5      .��5      � .+�5   
   �� -   5         ��Name$ tbxNamaBeli��5      $
��Left=�6'   $��33��6B   $��	10,23,0,0q�5       �� TextWrapping$
 Wrap=�6%   $�� ��69   $	��Top=�5      $	��253��6*   $��16(�66   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Masukan Nama Pembelian��5      �� 5   
   -   5         ��Name$ btnSave��5      $
��Save��6"   $
��Left=�61   $��	10,61,0,0q�5      $	��Top=�6$   $��75��6<   $��16(�5      $��33��6   6+   �� 5   
   -   5        $ btnEdit��5      $
��Edit��6"   $
��Left=�61   $��
106,61,0,0q�5      $	��Top=�6%   $��75��6=   $��16(�5      $��33��6   6+   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgPembelian��5      $
��Left=�6(   $��
10,104,0,0q�6C   $	��Top=�5      $	��172��6+   $	��313��68      
IsReadOnly .    CanUserAddRows .  	   AutoGenerateColumns	 .  
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *idPembelian+  5      $ Nama Pembelian��6%   $	 140 6=    6I   �� *namaPembelian+  5      $ Tanggal��6%   $ 80 66    6A   �� *	tglBeli+5!      �� 5#   
   -   5         ��Name$ pnlCariBarang��5%      $
��Left=�5#      $	��276��60   $��	350,0,0,0q�6=   $	��Top=�5$      $	��348��6-    �� Orientation$ Vertical=�69   .+�5&      �� -   5        $ tbxNamaBarang��5&      $��43��6-   $
 Wrap=�69   $�� ��5'      $��16(�6   $��10q�6,   $ Masukan nama Barang��5(      �� 5)      $ 
Horizontal=�6   $
��Left=�62   $��
10,0,10,10q�5*      .+�5+      �� -   5        $ btnCari��5+   (   $
��Cari��6   69   5,        5-      -   5        $ dgBarang��5-   $   $	��170��6    .   . 	 .  
 51        52      $ Nama Barang��6)   $	 140 6>    6J   �� *
namaBarang+  53      $ Harga��6)   $	 100 68    6D   �� *harga+  54      $
 Stok��6)   $ 80 67    6B   �� *stok+57      58      �� 59   
   $
��Left=�6   $	��189��60   $��
10,281,0,0q�5:      $	��Top=�6)   $	��688��5;      $ 
Horizontal=�6!   .+�5<      �� -	   5        $ pnlDetilBarang��5<   %   $	��270��6   .+�5=        -
   5        $ dgDetailBeli��5=   <   $��
0,10,10,10q�6   $	��170��6/   	 .   .   . 
 5@        5A      $ ID��6-   $ 50 69    6D   �� *idBarangRefId+  5B      $ Nama Barang��6-   $	 150 6B    6N   �� *
namaBarang+  5C      $	 QTY��6-   $ 50 6:    6E   �� *	jmlBeli+5E      5G      �� 5H      -   5        $ pnlDetilJml��5H   <   $	��418��6   $ Vertical=�6%   .+�5I      �� $ 
Horizontal=�6   .+�5J      �� -   5        $ tbxBarangDetil��5L   ,    �� 
IsReadOnly . $	��185��5J   0   $ nama barang��5K      $��16(�5L      6,   �� 5M      -   5         ��Name$ cbxSupplier��5M   1   $��20,0,0,0q�6   $��16(�5N      $	��211��6-    �� DisplayMemberPath$ supplierName��5O       �� SelectedValuePath$ 
idSupplier��5P      5Q      �� 5S      $ 
Horizontal=�6   .+�5T      �� -   5        $ 
tbxJmlBeli��5T      $��16(�62   $ jumlah dibeli��5U      $��
0,10,10,10q�5V      63   �� 5W      -   5        $ btnTambahDetail��5X      $��Tambah��5W      $��10q�6.   $��16(�6:   5Y      �� 5Z      -   5        $ btnEditDetail��5[      $
��Edit��5Z      $��10q�6,   $��16(�68   5[      5\      �� 5^      $ 
Horizontal=�6   .+�5_      �� -   5        $ tbxTotalItem��5a   8   $ 
total item��5_      {�.   . $��16(�5a      $	��100��6,   68   �� 5b      -   5        $ tbxTotalBayar��5d      $ total bayar��5b      $��16(�5c      $��20,0,0,0q�5e       . {�.  $	��297��5g      5h      �� 5i      -   5        $ btnPushDetailBeli��5k      $��10q�5i      $��16(�6%   $��Tambah Pembelian��5j      5l      5m      5o      5q      5r      