   M S B A M L   `   `   `  ����E  AVocabulary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Vocabulary
Vocabulary  5   	   $    Vocabulary.EducationTestWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Vocabulary     5   	   -   5        $	��500��5      $	��700��6'     � WindowStyle$
  None=�6I    � Icon$ Resources/icon.ico��6\    � WindowStartupLocation$ CenterScreen=�6v   $��Century Gothic)�6�   ��63   Z� ��5      �� 5	   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5
      �  � Color$ White��6    � Offset$ 0Q�6)   � 5      $ 	#FF0095B6��6   $ 1Q�6-   5      .��5      � .+�5   
   �� -   5         ��Name$ labelCountTranslate��5      $-��'Количество переводов��6-   $��Center=�6L   $��Center=�6p   $��0q�6�   $��52��6�   $��	0,0,0,251q�6�   $��Bottom=�6�   
�������$��16(�6  ��6�   Z� 6  �� 5   
   -   5        $ labelWrd��5      $��Center=�6"   $��Center=�6F   $��
Слово��6h   $��0q�6x   $��52��6�   $��	0,0,0,198q�6�   $��Bottom=�6�   
�������$��16(�6�   ��6�   Z� 6�   �� 5   
   -   5        $ labelCategory��5      $��Center=�6'   $��Center=�6K   $��Категория��6m   $��0q�6�   $��52��6�   $��	0,0,0,308q�6�   $��Bottom=�6�   
�������$��16(�6�   ��6�   Z� 6�   �� 5   
   -   5         ��Name$ btnQuestion��5      $�� ��6&   $��
0,0,89,145q�61   $��0q�6\   	 � ToolTip$h	 bНажмите, чтобы увидеть подсказку. Будет снята 1 монета��6h   $��27��6�   $��34��6�   $��Bottom=�6�   $��Right=�6�   |�.  ��6E   Z� ��5      �� 5      
 j� Stretch$
 Uniform=�6    �� ImageSource$ Resources/question.png��6/   5      �� 5   
   -   5         ��Name$ textBlockQuestion��5      $
��Wrap=�6/   
�������$��14(�6V   $��0,0,0,85q�6d   $��Right=�6v   $��84��6�   $	��104��6�   $��Bottom=�6�   �� 5   
   -   5         ��Name$ 
textBoxWrd��5      $��Center=�6&   $��Center=�6H   $��122,0,121,145q�6�   $��34��6�   $��Bottom=�6�   �� 5   
   -   5        $ 
btnNextWrd��5      $��	0,0,10,42q�6%   $��Right=�68   $��27��6T   $��27��6_   $��Bottom=�6k   |�.  ��6�   Z� ��5      �� 5      $
 Uniform=�6   $ Resources/next.png��60   5      �� 5   
   -	   5        $ 	btnCancel��5      $��27��6S   $��Bottom=�6_   $��Right=�6z   $��27��6�   $��0q�6�   $��	0,0,10,10q�6�   |�.  ��6<   Z� ��5      �� 5       $ Resources/exit.png��6   $
 Uniform=�6>   5"      �� 5#   
   -
   5        $ 
labelScore��5#      $��	50,0,0,10q�6$   $��35��67   $��Bottom=�6C   $
��Left=�6^   $��70��6y   $��0��6�   $��0q�6�   $��Center=�6�   
�������$��14(�6�   �� 5$   
   -   5         ��Name$ 
imageScore��5$      $
��Left=�6$   $��35��6?   $��	10,0,0,10q�6K   $��Bottom=�6^   $��Resources/coin.png��6y   $��35��6�   5%      5&      