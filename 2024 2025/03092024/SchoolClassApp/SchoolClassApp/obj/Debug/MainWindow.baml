   M S B A M L   `   `   `  ����I  ESchoolClassApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SchoolClassAppSchoolClassApp  5   	       SchoolClassApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SchoolClassApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ ClassesList��5
      $
��Left=�6'   $��Center=�6B   $��10,0,0,0q�6]   $	��381��6o   $	��134��6|   6�   �� 5   
   -   5         ��Name$ 	ClassData��5      $��
Dane klasy��6&   $��162,27,24,217q�6:   .��5      ��  �� Orientation$ Vertical=�6   .+�5      �� -   5         ��Name$ NameTB��5      $
��Left=�6,   $	��Top=�6G   $��10, 25, 0, 0q�6_   $
��Wrap=�6u   $��Nazwa klasy��6�   �� 5      -   5        $ 	TeacherTB��5      $
��Left=�6/   $	��Top=�6J   $��10, 25, 0, 0q�6b   $
��Wrap=�6x   $��
Wychowawca��6�   �� 5      -   5        $ 	ProfileTB��5      $
��Left=�6/   $	��Top=�6J   $��10, 25, 0, 0q�6b   $
��Wrap=�6x   $��Profil��6�   �� 5      -   5        $ 
StudentsTB��5      $
��Left=�60   $	��Top=�6K   $��10, 25, 0, 0q�6c   $
��Wrap=�6y   $��Ilość uczniów��6�   5      5      �� 5   
   $
��Left=�6   $	��Top=�6.   $��Dodaj klasę��6F   $��162,222,0,0q�6[   $	��186��6p   $	��614��6}   .��5      �� $ 
Horizontal=�6   $��	0,0,-12,0q�62   .+�5      �� .+�5      �� -   5        $ 
NameTBlock��5       $
��Left=�64   $��
10,10,0,10q�6O   $
��Wrap=�6c   $��Nazwa klasy��6w   $��85��6�   $��25��6�   �� 5      -   5        $ TeacherTBlock��5       $
��Left=�67   $��	10,0,0,10q�6R   $
��Wrap=�6e   $��
Wychowawca��6y   $��85��6�   $��25��6�   �� 5      -	   5        $ ProfileTBlock��5       $
��Left=�67   $��	10,0,0,10q�6R   $
��Wrap=�6e   $��Profil��6y   $��85��6�   $��25��6�   �� 5      -
   5        $ StudentsTBlock��5       $
��Left=�68   $��10,0,0,0q�6S   $
��Wrap=�6e   $��Ilość uczniów��6y   $��85��6�   $��25��6�   5      �� 5      .+�5      �� -   5         ��Name$ NameTBox��5      $	��100��60   $��20��6<   $��	10,10,0,5q�6H   6[   �� 5      -   5        $ TeacherTBox��5      $	��100��63   $��20��6?   $��	10,10,0,5q�6K   6^   �� 5      -   5        $ ProfileTBox��5      $	��100��63   $��20��6?   $��	10,10,0,5q�6K   6^   �� 5      -   5        $ StudentsTBox��5      $	��100��64   $��20��6@   $��
10,10,0,10q�6L   6`   5       �� 5!      -   5         ��Name$ AddBtn��5!      $��Dodaj��6>   $��	30, 0,0,0q�6N   $��35��6a   $��50��6m   {�.  6x   5"      5#      5$      5%      