   M S B A M L   `   `   `  ����M  IAplicativo_Empresa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Aplicativo_EmpresaAplicativo_Empresa  5   	        Aplicativo_Empresa.Window7   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Aplicativo_Empresa     5   	     � Title$  Informe��5   	   $	��450��6   $	��800��6&    � 
ResizeMode$ NoResize=�62    � Icon$ SM.png��6H   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF8C8D8F��6    � Offset$ 0Q�61   � 5      $ 	#FF6A6B6E��6   $ 1Q�61   5      .+�5   
   �� $��INFORME DE SALIDA��6   $
��Left=�6,   $��
267,40,0,0q�6G   $	��Top=�6[   $	��274��6s   $��Times New Roman)�6   $��25(�6�   �� 5   
   $��0,0,714,333q�6   $��SM.png��6%   $
��Fill=�65   �� 5   
   -   5         ��Name$ button_atras��5      $��Atrás��6'   $
��Left=�67   $��
678,10,0,0q�6R   $	��Top=�6f   $��75��6~   $��23��6�   $��Times New Roman)�6�   $��15(�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagrid_report��5      	   
IsReadOnly	 . $
��Left=�6>   $	��277��6Y   $��	37,93,0,0q�6f   $	��Top=�6y   $	��716��6�   
   CanUserReorderColumns
 .     CanUserResizeColumns .     CanUserSortColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�      RowBackground# � ��6  ���	#FFF7F2F2   AlternatingRowBackground 5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ White��6#   $ 0Q�61   � 5      $ White��6#   $ 1Q�61   5      5      5      5      