   M S B A M L   `   `   `  ����P  LСписок книг, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Список_книгСписок_книг  5   	   +    %Список_книг.ListBooksWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Список_книг     5   	   -   5          � Title$  ListBooksWindow��5   	   $	��480��6!   $	��640��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   6*   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��RightToLeft=�6.   $��0��6J   $��0��6Z   .+�5      �� -   5         ��Name$ Button_Delete��5      $��Right=�6,   $��	15 5 15 5q�6H   $��25(�6\   $
��Bold"�6j   $��5q�6|   .��6�   Delete6�   �� 5      -   5        $ Button_Edit��5      $��Right=�6*   $��	15 5 15 5q�6F   $��25(�6Z   $
��Bold"�6h   $��5q�6z   .��6�   Edit6�   5      �� 5   
   -   5         ��Name$ ListBoxBooks��5      $��1��6(   $��0��66   
�������$��25(�6Z   5      5      