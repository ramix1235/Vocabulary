   M S B A M L   `   `   `  ����E  AVocabulary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Vocabulary
Vocabulary  5   	       Vocabulary.ShopWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Vocabulary     5   	   -   5        $	��500��5      $	��850��6'     � WindowStyle$
  None=�6I    � Icon$ Resources/icon.ico��6\    � WindowStartupLocation$ CenterScreen=�6v   $��Century Gothic)�6�   ��63   Z� ��5      �� 5	   
    �� ImageSource$* $Resources/backgroundVocabularies.jpg��6   .��5      � .+�5   
   � $��	0,0,10,10q�6    � Orientation$ Vertical=�6'   $��38��6>   $��Bottom=�6J   $��Right=�6e   $��30��6�   .+�5      �� -   5         ��Name$ 	btnCancel��5      $��27��6W   $��Bottom=�6c   $��Right=�6~   $��27��6�   $��0q�6�   $��0,10,0,0q�6�   |�.  ��6@   Z� ��5      �� 5      $ Resources/exit.png��6!    j� Stretch$ Uniform=�6B   5      5      �� 5   
   -   5         ��Name$ 
labelScore��5      $��	50,0,0,10q�6$   $��35��67   $��Bottom=�6C   $
��Left=�6^   $��70��6y   $��0��6�   $��0q�6�   $��Center=�6�   
�������$��14(�6�   �� 5   
   $��Словарей:��6   $��
125,0,0,10q�6$   $��35��68   $��Bottom=�6D   $
��Left=�6_   $��78��6z   $��0q�6�   $��Center=�6�   
�������$��14(�6�   �� 5   
   -   5        $ labelVocabulariesScore��5      $	��3/3��60   $��
208,0,0,10q�6>   $��35��6R   $��Bottom=�6^   $
��Left=�6y   $��70��6�   $��0q�6�   $��Center=�6�   
�������$��14(�6�   �� 5   
   $��Категорий:��6   $��
283,0,0,10q�6%   $��35��69   $��Bottom=�6E   $
��Left=�6`   $��79��6{   $��0q�6�   $��Center=�6�   
�������$��14(�6�   �� 5   
   -   5        $ labelCategoriesScore��5      $	��3/3��6.   $��
367,0,0,10q�6<   $��35��6P   $��Bottom=�6\   $
��Left=�6w   $��70��6�   $��0q�6�   $��Center=�6�   
�������$��14(�6�   �� 5   
   -   5         ��Name$ 
imageScore��5      $
��Left=�6$   $��35��6?   $��	10,0,0,10q�6K   $��Bottom=�6^   $��Resources/coin.png��6y   $��35��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dataGrid��5      $��10,10,10,53q�6%   
   
IsReadOnly
 . 
�������   AutoGenerateColumns .     GridLinesVisibility$
 None=�6�      HeadersVisibility$ Column=�6�      SelectionMode$ Single=�6�   $��16(�6�   ��6L   Z� ��5      �� 5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Title+  5      $ Описание��6%    67   �� *Description+  5       $ Цена��6%    63   �� *Price+5"      5#      5$      