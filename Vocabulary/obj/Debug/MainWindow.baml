   M S B A M L   `   `   `  ����E  AVocabulary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Vocabulary
Vocabulary  5   	       Vocabulary.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Vocabulary     5   	   -   5        $	��500��5      $	��600��6'     � Icon$  Resources/icon.ico��63    � WindowStartupLocation$ CenterScreen=�6c   $��Segoe Script)�6�   $��16(�6�   ��6M   Z�  J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5	   
   -   5        	BlrEffect��   Radius$ 0Q�5	   (      RenderingBias$ Quality=�63   ��5      �� 5   
    �� ImageSource$ Resources/background.jpg��6   .��5      � $��0,0,0,0q�6   .+�5   
   (� $��0q�6    (� Stretch$
 Fill=�6   .��5      �� $	��469��6   $	��592��6&    J� Opacity$ 0Q�62    � Triggers 5      :� 5      	 :� RoutedEvent$	 FrameworkElement.Loaded��6#   .[�5      �� .��5      �� 
 �� TargetProperty$
 Opacity�6)   .��5   "   W� $
 Opacity�63    W� From$ 0X�6W   	 W� To$ 1X�6`    g� Duration$ 0:0:2D�6g   5      5      5      .+�5      �� -   5         ��Name$ btnVocabularies��5      $��14(�6P   
�������$��Center=�6�   $��Center=�6�   $��Словари��6�   $��0q�6�   $��150,100,150,5q�6  $��43��6  |�.  ��6^   Z�  J� OpacityMask 6�   Z� ��5      �� 5      $ Resources/button.png��6%    5      :� 5      $	 Mouse.MouseEnter��6'   .[�5       �� .��5!   "   �� .��5"   &   t� 	 t� To$ 25,125,25,5X�5#      $ 0:0:0.5D�5$      $
 Margin�5%      t� 5&   &   $ 150,100,150,5X�5'      $ 0:0:0.5D�5(      $
 Margin�5)      5*   #   5+      5,      5.      �� 5/      -   5        $ btnTraining��5/      $��Обучение��6.   $��14(�6A   
�������$��150,5q�6y   $��43��6�   $��0q�6�   |�.  ��6O   Z� ��50      �� 51      $ Resources/button.png��6%    53      :� 54      $	 Mouse.MouseEnter��6'   .[�55      �� .��56   "   �� .��57   &   t� $ 
25,30,25,5X�58      $ 0:0:0.5D�59      $
 Margin�5:      t� 5;   &   $ 150,5,150,5X�5<      $ 0:0:0.5D�5=      $
 Margin�5>      5?   #   5@      5A      5C      �� 5D      -   5        $ btnShop��5D      $��Магазин��6*   $��14(�6<   
�������$��150,5q�6�   $��43��6�   $��0q�6�   |�.  ��6J   Z�  6t   Z� ��5E      �� 5F      $ Resources/button.png��6%    5H      :� 5I      $	 Mouse.MouseEnter��6'   .[�5J      �� .��5K   "   �� .��5L   &   t� $ 
25,30,25,5X�5M      $ 0:0:0.5D�5N      $
 Margin�5O      t� 5P   &   $ 150,5,150,5X�5Q      $ 0:0:0.5D�5R      $
 Margin�5S      5T   #   5U      5V      5X      �� 5Y      -   5        $ btnStatistic��5Y      $��Отчеты��6/   $��14(�6@   
�������$��150,5q�6x   $��43��6�   $��0q�6�   |�.  ��6N   Z� ��5Z      �� 5[      $ Resources/button.png��6%    5]      :� 5^      $	 Mouse.MouseEnter��6'   .[�5_      �� .��5`   "   �� .��5a   &   t� $ 
25,30,25,5X�5b      $ 0:0:0.5D�5c      $
 Margin�5d      t� 5e   &   $ 150,5,150,5X�5f      $ 0:0:0.5D�5g      $
 Margin�5h      5i   #   5j      5k      5m      5n      5o      5p      5q      