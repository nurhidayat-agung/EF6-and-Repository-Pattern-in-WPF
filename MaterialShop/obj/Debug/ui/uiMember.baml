   M S B A M L   `   `   `  ����G  CMaterialShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MaterialShop.uiMaterialShop.ui  5          MaterialShop.ui.uiMember   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MaterialShop.ui     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� 
Background  �#D1C4E9 N� Title$ uiMember��5      .��5      � .+�5   
   �� -   5         ��Name$ tbxNamaCustomer��5      $
��Left=�6+   $��41��5      $��	27,24,0,0q�6    �� TextWrapping$
 Wrap=�61   $�� ��5      $	��Top=�6   $	��208��62   $��16(�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ nama kustomer��6    &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgCustomer��5      $
��Left=�6'   $��	27,70,0,0q�5      $	��Top=�6&   $	��144��5      $	��328��6       
IsReadOnly .    CanUserAddRows .     AutoGenerateColumns .  	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
idCustomer+  5      $
 Nama Customer��6%    6<   �� *namaCustomer+5      �� 5   
   -   5         ��Name$ 	btnTambah��5      $��Tambah��6$   $
��Left=�65   $��
259,33,0,0q�5      $	��Top=�6%   $��96��6=   5      5      5       