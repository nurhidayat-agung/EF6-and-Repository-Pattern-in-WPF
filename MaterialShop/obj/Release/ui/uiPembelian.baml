   M S B A M L   `   `   `  ���� G  CMaterialShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MaterialShop.uiMaterialShop.ui  !    MaterialShop.ui.uiPembelian   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:MaterialShop.ui     U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
Background  �#D1C4E9 N� Title$ uiPembelian��.��� .+��� -    ��Name$ tbxNamaBeli��$
��Left=�$��33��$��	10,23,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��253��$��16(�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Masukan Nama Pembelian���� -    ��Name$ btnSave��$
��Save��$
��Left=�$��	10,61,0,0q�$	��Top=�$��75��$��16(�$��33���� -   $ btnEdit��$
��Edit��$
��Left=�$��
106,61,0,0q�$	��Top=�$��75��$��16(�$��33��&   System.Windows.Controls.DataGrid  -     Name$ dgPembelian��$
��Left=�$��
10,104,0,0q�$	��Top=�$	��172��$	��313��   
IsReadOnly .    CanUserAddRows .  	   AutoGenerateColumns	 .  
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Id��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *idPembelian+  $ Nama Pembelian��$	 140  �� *namaPembelian+  $ Tanggal��$ 80  �� *	tglBeli+�� -    ��Name$ pnlCariBarang��$
��Left=�$	��276��$��	350,0,0,0q�$	��Top=�$	��348�� �� Orientation$ Vertical=�.+��� -   $ tbxNamaBarang��$��43��$
 Wrap=�$�� ��$��16(�$��10q�$ Masukan nama Barang���� $ 
Horizontal=�$
��Left=�$��
10,0,10,10q�.+��� -   $ btnCari��$
��Cari��  -   $ dgBarang��$	��170�� .   . 	 .  
   $ Nama Barang��$	 140  �� *
idBarang+  $ Kategori��$	 100  �� *
namaBarang+  $
 Stok��$ 80  �� *stok+�� $
��Left=�$	��189��$��
10,281,0,0q�$	��Top=�$	��688��$ 
Horizontal=�.+��� -	   $ pnlDetilBarang��$	��350��.+�  -
   $ dgDetailBeli��$��
0,10,10,10q�$	��170��
   $ ID��$ 50  �� *idPembelian+  $ Nama Barang��$	 150  �� *namaPembelian+  $ Jumlah��$ 80  �� *	tglBeli+�� -   $ pnlDetilJml��$	��330��$ Vertical=�.+��� -    ��Name$ cbxSupplier��$��10q�$��16(��� $ 
Horizontal=�.+��� -   $ 
tbxJmlBeli��$��16(�$ jumlah dibeli��$��10q��� -   $ btnTambahDetail��$��Tambah��$��10q�$��16(��� -   $ btnEditDetail��$
��Edit��$��10q�$��16(�