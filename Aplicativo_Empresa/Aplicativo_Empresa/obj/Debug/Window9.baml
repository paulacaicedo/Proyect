   M S B A M L   `   `   `  ����M  IAplicativo_Empresa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Aplicativo_EmpresaAplicativo_Empresa  5   	        Aplicativo_Empresa.Window9   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Aplicativo_Empresa     5   	     � Title$  Informe��5   	   $	��450��6   $	��800��6&    � Icon$ SM.png��62    � 
ResizeMode$ NoResize=�6@   .��5	      � .+�5
   
   �  � ColumnDefinitions 5      �� 5      $
��149* �6#   �� 5      $	��49* �6#   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF8C8D8F��6#    � Offset$ 0Q�65   � 5      $ 	#FF6A6B6E��6#   $ 1Q�65   5      .+�5      �� $��INFORME DE COMPRA��6   $
��Left=�60   $��
249,12,0,0q�6K   $	��Top=�6_   $	��323��6w   $��Times New Roman)�6�   $��25(�6�   �� 5      $��10,10,501,332q�6   $��SM.png��6+   $
��Fill=�6;   �� 5      -   5         ��Name$ button_atras��5      $��Atrás��6+   $
��Left=�6;   $��
82,0,0,386q�6V   $��75��6j   $��Times New Roman)�6u   $��15(�6�   $��23��6�   $��Bottom=�6�   $��1��6�   &   System.Windows.Controls.DataGrid  5      -   5        	  Name$	 datagrid_client��5      
   
IsReadOnly
 . $
��Left=�6C   $	��257��6^   $��
65,113,0,0q�6k   $	��Top=�6   $	��667��6�      	RowHeight$ 30Q�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   $��2��6�      CanUserReorderColumns .     CanUserResizeColumns .     CanUserSortColumns .  
�������   RowBackground# � ��6?  5      5      5      