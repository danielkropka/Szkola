   M S B A M L   `   `   `  ����@  <PanDa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PanDaPanDa  5   	       PanDa.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PanDa     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	      #  PanDa.IntToTextConverterClass   IntToTextConverter&   PanDa.TextToBinaryConverterClass  TextToBinaryConverter��%:   &	        &	        5
   
   6(     5   
   6+   5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ NumberTB��5      $��Center=�6$   $��Center=�6A   $	��150��6\   $��80��6h   
�������$��1��6�   �� 5   
   -   5         ��Name$ NumberCB��5      $��1��6%   $��Center=�62   $��Center=�6O   $	��100��6j    �� Text 6v   ��  �� ElementName$ NumberTB�� �� Path$
 Text� �� 	Converter# [  	 �� Mode$	 OneWay=�.@�5      �� $��Jeden��6   �� 5      $	��Dwa��6   �� 5      $
��Trzy��6   �� 5      $��Cztery��6   �� 5      $��Pięć��6   5      �� 5   
   $��2��6   $��Center=�6!   $��Center=�6>   $	��150��6Y   $��80��6e   
���������6�   �� $ NumberCB��$
 Text�# [ $	 OneWay=�5      5      