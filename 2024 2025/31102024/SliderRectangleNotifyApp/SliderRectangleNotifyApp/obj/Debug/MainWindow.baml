   M S B A M L   `   `   `  ����S  OSliderRectangleNotifyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SliderRectangleNotifyAppSliderRectangleNotifyApp  5   	   )    #SliderRectangleNotifyApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:SliderRectangleNotifyApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	      +   %SliderRectangleNotifyApp.RectangleRGB  5
   
   .��5      �  � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      �� 5      $��10 �6   �� 5      �� 5      $��10 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��.05* �6   �� 5      $��* �6   �� 5      $	��.2* �6   .+�5   
   �� -   5         ��Name$ 	Rectangle��5      $��3��6'   ��6;   �� *RectangleColor+ �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��1��6   $��R��6   $��Center=�6)   $��Center=�6K   �� 5   
   -   5         ��Name$ RSlider��5      $��1��6"   $��1��6/   $��Center=�6?    � Maximum$	 255Q�6Z    � SmallChange$ 1Q�6h   	 �� IsSnapToTickEnabled	 . 
 � Value
 6�   �� *R+�� 5   
   $��1��6   $��2��6!   $��30(�61   $��Center=�6?   $��Center=�6Z   ��6w   ��  �� ElementName$ RSlider�� �� Path$ Value� �� Mode$ OneWay=��� 5   
   $��3��6   $��G��6   $��Center=�6)   $��Center=�6K   �� 5   
   -   5        $ GSlider��5      $��3��6"   $��1��6/   $��Center=�6?   $	 255Q�6Z   $ 1Q�6h   	 . 
 6�   �� *G+�� 5    
   $��5��6   $��B��6   $��Center=�6)   $��Center=�6K   �� 5!   
   $��3��6   $��2��6!   $��30(�61   $��Center=�6?   $��Center=�6Z   ��6w   �� $ GSlider��$ Value�$ OneWay=��� 5"   
   -   5        $ BSlider��5"      $��5��6"   $��1��6/   $��Center=�6?   $	 255Q�6Z   $ 1Q�6h   	 . 
 6�   �� *B+�� 5#   
   $��5��6   $��2��6!   $��30(�61   $��Center=�6?   $��Center=�6Z   ��6w   �� $ BSlider��$ Value�$ OneWay=�5$      5%      