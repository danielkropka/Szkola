   M S B A M L   `   `   `  ����B  >Sideeye, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:SideeyeSideeye  5   	       Sideeye.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Sideeye     5   	     � Title$  
MainWindow��5   	   $	��170��6   $	��250��6)    � 
ResizeMode$ NoResize=�5	   	   .��5
      �� .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $	��100��6.   .+�5      �� $ 
Horizontal=�6   $��Center=�62   .+�5      �� $ Vertical=�6   $��Center=�64   $��60��6O   .+�5      �� $
��Dane��6   $��Right=�6+   5      � 5       � ColumnDefinitions 5      �� 5      $
��Auto �6+   �� 5      $
��Auto �6+    � RowDefinitions 5      �� 5      $
��Auto �6(   �� 5      $��5 �6(   �� 5      $
��Auto �6(   .+�5      �� $��Imię:��6   $��0��6,   $��0��69   $��Right=�6I   �� 5      $��	Nazwisko:��6   $��2��60   $��0��6=   $��Right=�6M   �� 5      $��0��6   $��1��6+   $��80��6;   $
��Left=�6F   �� 5      $��2��6   $��1��6+   $	��100��6;   $
��Left=�6G   5      5       5!      � 5"   
   $��Center=�6    5#      �� 5$      $��70 �6#   �� 5%      $��50 �6#   �� 5&      $��70 �6#    5(      �� 5)      $
��Auto �6    .+�5,      �� $��OK��6   $��0��6"   �� 5-      $��Anuluj��6   $��2��6&   5.      5/      50      