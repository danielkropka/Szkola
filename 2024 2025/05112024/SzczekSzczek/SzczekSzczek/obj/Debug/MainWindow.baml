   M S B A M L   `   `   `  ����G  CSzczekSzczek, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SzczekSzczekSzczekSzczek  5   	       SzczekSzczek.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:SzczekSzczek     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	        SzczekSzczek.MultipleSign  5
   
   .��5      � $��Center=�6   $��Center=�6&    � ColumnDefinitions 5   
   �� 5      �� 5      $��10 �6   �� 5      $	��200 �6    � RowDefinitions 5   
   �� 5      �� 5      $��10 �6   �� 5      �� 5      $	��100 �6   �� 5      .+�5   
   �� $��Ilość��6   $��30(�6    �� 5   
   -   5         ��Name$ QuantityTBox��5      $��2��6(   ��68   �� *
Quantity+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��2��6   $
��Znak��6   $��30(�6,   �� 5   
   -   5        $ SignTBox��5      $��2��6$   $��2��61    �� 	MaxLength$ 1��6�   ��6A   �� *Sign+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   -   5         ��Name$ OutputTBlock��5      $��4��6*   $��3��67   $��30(�6K   $��Center=�6Y   $��Center=�6v   ��6�   �� *Output+$ OneWay=�5       5!      