   M S B A M L   `   `   `  ����  	Bookshelf    Bookshelf.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Bookshelf Application��5   	   $	��250��6'   $	��300��64    � 	Resources 5       �� 
TargetType �� Property �� Value��%�  '��       '�� G     '�� �     �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   5      �� 5	   
   " ��6   .�5
      ��  � ��
 �����6+   �� 5       � ��$ 5 5 5 0q�6'   �� 5       � ��$ 5q�6(   5      �� 5   
   " ��6   .�5      ��  � ��$ Right=�64   �� 5       � ��$ 5q�6'   �� 5       � ��$ 90��6&   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5"   
   �� .��6   Title6   �� 5#   
   $��1��6   ��5$      �� *Title+ �� UpdateSourceTrigger$ PropertyChanged=��� 5&   
   $��1��6   .��6   Author6%   �� 5'   
   $��1��6   $��1��6"   ��5(      �� *Author+$ PropertyChanged=��� 5*   
   $��2��6   $��2��6)    �� Orientation$ 
Horizontal=�66   $��Right=�5+      .+�5,      �� ��6   �� *AddBookCommand+��68   �� *.+.��6W   Add6\   �� 5-      ��6   �� *RemoveBookCommand+��6;   �� *.+.��6Z   Remove6b   5.      �� 50   
   $��3��6   .��6   Books6$   �� 51   
   $��1��6   $��3��6"   $	��5 0q�52   ;   
���������51   /   �� *Books+	 �� SelectedItem	 52      �� *SelectedBook+6H   54      55      