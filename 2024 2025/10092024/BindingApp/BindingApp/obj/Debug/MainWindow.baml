   M S B A M L   `   `   `  ����E  ABindingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BindingApp
BindingApp  5   	       BindingApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BindingApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ Slider��5      $��
10,210,0,0q�6%   $	��500��69   $
��Left=�6E   $	��Top=�6`    � Maximum$	 100Q�6x    � Minimum$ 1Q�6�    �� IsSnapToTickEnabled . 6�   �� 5      -   5         ��Name$ TB��5      $
��Left=�6"   $	��Top=�6=   $��10, 210, 0, 0q�6U   $��50��6l   5      �� 5   
   $ 
Horizontal=�6   .+�5      �� -   5        $ SecondSlider��5      $��
10,250,0,0q�6+   $	��500��6?   $
��Left=�6K   $	��Top=�6f   $	 100Q�6~   $ 1Q�6�    . 6�   �� 5      -   5        $ SecondTB��5      $
��Left=�6(   $	��Top=�6C   $��10, 250, 0, 0q�6[   $��50��6r   ��6}   ��  �� ElementName$ SecondSlider�� �� Path$ Value�5      �� 5   
   $ 
Horizontal=�6   .+�5      �� -   5        $ ThirdTB��5      $
��Left=�6'   $	��Top=�6B   $��10, 300, 0, 0q�6Z   $��50��6q   �� 5      -   5        $ ThirdSlider��5      $��
10,300,0,0q�6*   $	��500��6>   $
��Left=�6J   $	��Top=�6e   $	 100Q�6}   $ 1Q�6�    . 	 � Value	 6�   �� $ ThirdTB��$
 Text�5      5      5      