   M S B A M L   `   `   `  ����Q  McasoEstudioVaraApi2021, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:casoEstudioVaraApi2021casoEstudioVaraApi2021  5   	   +    %casoEstudioVaraApi2021.MisVaramientos   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:casoEstudioVaraApi2021     5   	     � Title$  MisVaramientos��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridInventario��5
      $
��Left=�6/   $	��250��6K   $��	10,80,0,0q�6X   $	��Top=�6k   $	��764��6�   ���	#FF080808$��18(�6�   ���	#FF0A0A09   AutoGenerateColumns .     CanUserResizeRows .    CanUserSortColumns .  $��Arial)�6  ��5      �� 5       �� Color$ 	#FF939292��6"    �� Opacity$	 0.5Q�64      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        ColumnNombreInformante��,  &System.Windows.Controls.DataGridColumn   Header$ Nombre Informante��5   E   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 120 6`   
   
IsReadOnly
 .    
Foreground �	#FF0A0A0A   
FontFamily$ Arial)�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6�   �� *Id+6�     5      -   5        
ColumnPais��$
 Pais��5   9   $	 80 6G   
 .  �	#FF040404 6{   �� *nombre+  5      -   5        ColumnEstado��$ Estado��5   ;   $		 100 6K   
 . 
 �   � 6|   �� *unidadMedida+  5      -   5        ColumFinalizado��$ 
Finalizado��5   >   $		 100 6R   
 . 
 �   � 6�   �� *	ubicacion+  5      -   5        ColumnFechaAvistamiento��$ Fecha avistamiento��5   F   $		 100 6b   
 .  �	#FF060606 6�   �� *costoUnitario+  5      -   5        ColumnCondAnimal��$ Condición animal��5   ?   $		 100 6Y   
 . 
 �   � 6�   �� *stockMinimo+  5      -   5        ColumnNumAnimales��$ Num Animales��5   @   $		 100 6V   
 .   �	#FF040404 6�   �� *noExistencias+5      �� 5   
   $��Mis Varamientos��6   $
��Left=�6*   $��
267,11,0,0q�6E   $	��Top=�6Y   $��36(�6q   �� 5   
   $��Delete��6   $
��Left=�6"   $��
30,343,0,0q�6=   $	��Top=�6Q   $	��105��6i   $��39��6u   ���	#FFFDFDFD���	#FF830A04$��20(�6�   $��Lucida Sans)�6�   �� 5   
   $
��Back��6   $
��Left=�6    $��	30,28,0,0q�6;   $	��Top=�6N   $	��105��6f   $��39��6r   ���	#FFFDFDFD���	#FF042483$��20(�6�   $��Lucida Sans)�6�   �� 5   
   $��
Finalizado��6   $
��Left=�6&   $��650,343,0,0q�6A   $	��Top=�6V   $	��105��6n   $��39��6z   ���	#FFFDFDFD���	#FF042483$��20(�6�   $��Lucida Sans)�6�   5      5      