   M S B A M L   `   `   `  ����B  >ExamApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ExamAppExamApp  5   	       ExamApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ExamApp     5   	     � Title$  
MainWindow��5   	   $	��300��6   $
��1300��6)   .��5	      � 
���W�.� � ColumnDefinitions 5
   
   �� 5      �� 5      $	��950 �6   �� 5      .+�5   
   �� -   5         ��Name$ PreviousRecordButton��5      $��Center=�6/   $��Center=�6L   $��70��6g   .��5      �� $��Images/arrow_left.png��6   5      �� 5   
   $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �  � RowDefinitions 5      �� 5      �� 5      $��20 �6,   �� 5      .+�5      �� $��Images/record.png��6    $	��190��6;   $��Center=�6G   � 5      $��2��6   $	��300��6,   $��Center=�68    5      �� 5   "   �� 5   "   .+�5       �� -   5         ��Name$ NumberOfDownloads��5    $   $��
1212121212��6?   ���#61D918$��20(�6i   �� 5!      -   5        $��2��5!   %   $��Pobierz��65   $��90��6G   $
��Bold"�6R   ���#61d918$��20(�6y   6�   5"      5#      �� 5$      .+�5%      �� -   5        $ NameOfArtist��5%       $��Gorilazz��66   $��50(�6I   
�������6W   �� 5&      -   5        $ NameOfAlbum��5&       $��"The Black Parade"��65   $��30(�6R   
�������$��Italic$�6s   �� 5'      $ 
Horizontal=�6%   .+�5(      �� -   5        $ CountOfSongs��5(   $   $��14 utworów��6:   ���#61D918$��20(�6d   �� 5)      -   5        $ YearOfRelease��5)   $   $
��2006��6;   ���#61D918$��20(�6_   $	��100��6m   $��Center=�6y   5*      5+      5,      5-      �� 5.   
   -   5        $ NextRecordButton��5.   !   $��2��6   $��Center=�6;   $��Center=�6X   $��70��6s   .��5/      �� $��Images/arrow_right.png��6   50      51      52      