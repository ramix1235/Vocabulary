   M S B A M L   `   `   `  ����E  AVocabulary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Vocabulary
Vocabulary  5   	        Vocabulary.EducationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Vocabulary     5   	   -   5        $	��500��5      $	��700��6'     � WindowStyle$
  None=�6I    � Icon$ Resources/icon.ico��6\    � WindowStartupLocation$ CenterScreen=�6v   $��Century Gothic)�6�   ��63   Z� ��5      �� 5	   
    �� ImageSource$* $Resources/backgroundVocabularies.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ labelSelectVocabulary��5      $\��VМожно выбрать конкретный словарь для обучения:��6/   $��
10,10,10,0q�6h   $��25��6|   $	��Top=�6�   
�������6�   �� 5   
   -   5         ��Name$ comboBox��5       �� DisplayMemberPath$ Title��6&   $��
10,40,10,0q�6B   $	��Top=�6V   
�������
���   �
������� �� 
IsReadOnly . 6�   (� 5   
    (� Stretch$
 Fill=�6   .��5      �� 	 �� Orientation$	 Vertical=�6   $	��392��60   $	��492��6=   
 J� Opacity$
 0Q�6I    � Triggers 5      :� 5       :� RoutedEvent$ FrameworkElement.Loaded��6#   .[�5      �� .��5      ��  �� TargetProperty$ Opacity�6)   .��5   "   W� $ Opacity�63    W� From$ 0X�6W   	 W� To$ 1X�6`    g� Duration$ 0:0:2D�6g   5      5      5      .+�5      �� -   5         ��Name$ 	btnEngRus��5      $3��-С английского на русский��6,   $��Segoe Script)�6f   $��14(�6�   $��42��6�   $��100,150,100,5q�6�   |�.  
���������6O   Z� ��5      �� 5      $ Resources/button.png��6%    5      :� 5      $ Mouse.MouseEnter��6'   .[�5      �� .��5    "   �� .��5!   &   t� 	 t� To$ -25,175,-25,5X�5"      $ 0:0:0.5D�5#      $ Margin�5$      t� 5%   &   $ 100,150,100,5X�5&      $ 0:0:0.5D�5'      $ Margin�5(      5)   #   5*      5+      5-      �� 5.      -   5        $ 	btnRusEng��5.      $3��-С русского на английский��6,   $��Segoe Script)�6f   $��14(�6�   $��42��6�   $��100,5q�6�   |�.  
���������6O   Z� ��5/      �� 50      $ Resources/button.png��6%    52      :� 53      $ Mouse.MouseEnter��6'   .[�54      �� .��55   "   �� .��56   &   t� $ -25,30,-25,5X�57      $ 0:0:0.5D�58      $ Margin�59      t� 5:   &   $ 100,5,100,5X�5;      $ 0:0:0.5D�5<      $ Margin�5=      5>   #   5?      5@      5B      5C      5D      � 5E   
   $��	0,0,10,10q�6    � Orientation$ Vertical=�6'   $��38��6>   $��Bottom=�6J   $��Right=�6e   $��30��6�   .+�5F      �� -   5        $ 	btnCancel��5F      $��27��6W   $��Bottom=�6c   $��Right=�6~   $��27��6�   $��0q�6�   $��0,10,0,0q�6�   |�.  ��6@   Z� ��5G      �� 5H      $ Resources/exit.png��6!    j� Stretch$ Uniform=�6B   5J      5K      �� 5L   
   -   5        $ 
labelScore��5L      $��	50,0,0,10q�6$   $��35��67   $��Bottom=�6C   $
��Left=�6^   $��70��6y   $��0��6�   $��0q�6�   $��Center=�6�   
�������$��14(�6�   �� 5M   
   -   5         ��Name$ 
imageScore��5M      $
��Left=�6$   $��35��6?   $��	10,0,0,10q�6K   $��Bottom=�6^   $��Resources/coin.png��6y   $��35��6�   5N      5O      