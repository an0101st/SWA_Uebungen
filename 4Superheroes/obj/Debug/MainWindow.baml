   M S B A M L   `   `   `  ����F  BSuperheroes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperheroesSuperheroes  5   	   ?$clr-namespace:Superheroes.ViewModelsSuperheroes.ViewModels  5   	       Superheroes.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Superheroes     5   	   ;
ViewModels$clr-namespace:Superheroes.ViewModels     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   ��5
      �� 5       �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6)   .��5      �  � Color$ Black��6    � Offset$ 0Q�6    � 5      $ 	#FF791C1C��6   $ 1Q�6$   5      .��5      �  � ShowGridLines .  J� OpacityMask 5      �� 5      $ 0.5,1&�6   $ 0.5,0&�6*   .��5      � $ Black��6   $ 0Q�6!   � 5      $ 	#FF520707��6   $ 1Q�6%   5       � ColumnDefinitions 5      �� 5      $	��250 �6   �� 5      $��* �6   .+�5      � $��0��6	   $��0��6    � RowDefinitions 5       �� 5!      $��* �6   �� 5"      $��30 �6   �� 5#      $��30 �6   �� 5$      $��30 �6   �� 5%      $��30 �6   �� 5&      $��30 �6   �� 5'      $��30 �6   �� 5(      $��30 �6   �� 5)      $��* �6    5+      �� 5,      $	��100 �6   �� 5-      $��* �6   .+�50      �� $��1��6   $��Center=�6   $
��Left=�63   $��Bezeichnung��6N   
�������6d   �� 51      $��1��6   $��1��6   $��Center=�6C   $��5q�6^   ��6*   �� *	NewName+.��6i   	 � DataContext	 52      *   $Superheroes.ViewModels.MainViewModel  53      .��54      55      �� 57      $��2��6   $��Center=�6   $
��Left=�63   $��Geschwindigkeit��6N   
�������6h   �� 58      $��2��6   $��1��6   $��Center=�6D   $��Stretch=�6_   $��5q�6}   ��6*   �� *
NewSpeed+.��6�   	 59        5:      .��5;      5<      �� 5>      $��3��6   $��Center=�6   $
��Left=�63   $��Kräfte��6N   
�������6_   �� 5?      $��3��6   $��1��6   $��Center=�6D   $��5q�6_   ��6*   �� *
NewPower+.��6k   	 5@        5A      .��5B      5C      �� 5F      $��4��6   $��
Geschlecht��6!   $��Center=�66   $
��Left=�6Q   
�������6l   �� 5G      $��4��6   $��1��6$   $��Center=�65   $��5q�6Q   ��6\   �� *
GenderList+
 �� SelectedItem
 6   �� *SelectedGender+	 5H        5I      5K      �� 5M      $��5��6   $��	Universum��6!   $��Center=�65   $
��Left=�6P   
�������6k   �� 5N      $��5��6   $��1��6$   $��Center=�65   $��Stretch=�6P   $��5q�6n   ��6y   �� *UniverseList+
 6�   �� *SelectedUniverse+	 5O        5P      5R      �� 5T      $��6��6   $��1��6"   $��	Speichern��62   $	��5,5q�6F   ��6S   �� *SaveBtnClickedCmd+	 5U        5V      5X      5Y      � 5Z      $��1��6	    5[      �� 5\      $��50 �6   �� 5]      $��* �6   �� 5^      $��50 �6   .+�5`      �� $��SuperheldenApp��6   $��Center=�6$   $��Center=�6?   $��20(�6\   $
��Bold"�6j   ���	#00000000
�������6�   &   System.Windows.Controls.DataGrid  5a      $��1��6   $��5q�6$   ���	#FFDADADA��6F   �� *Heroes+	 5b        5c      5e      �� 5f      $��2��6   $	��100��6"   $��20��6.   $��Löschen��6:   $��Right=�6L   $
��20,5q�6h   $��Center=�6v   5g      5h      5i      