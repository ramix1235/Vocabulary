using System;
using System.Windows;
using System.Windows.Input;

namespace Vocabulary
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private VocabulariesWindow vocWin;
        private EducationWindow edWin;
        private ShopWindow shopWin;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Нажатие кнопки "Словарь"
        /// </summary>
        private void btnVocabularies_Click(object sender, RoutedEventArgs e)
        {
            vocWin = new VocabulariesWindow();
            vocWin.Show();
            vocWin.MainWin = this;
            WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// Главное окно активно
        /// </summary>
        private void Window_Activated(object sender, EventArgs e)
        {
            BlrEffect.Radius = 0;
        }

        /// <summary>
        /// Главное окно не активно
        /// </summary>
        private void Window_Deactivated(object sender, EventArgs e)
        {
            BlrEffect.Radius = 7;
        }

        /// <summary>
        /// При нажатии Esc выходим из приложения
        /// </summary>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.Equals(Key.Escape))
            {
                Close();
            }
        }

        private void btnTraining_Click(object sender, RoutedEventArgs e)
        {
            edWin = new EducationWindow();
            edWin.Show();
            edWin.MainWin = this;
            WindowState = WindowState.Minimized;
        }

        private void btnShop_Click(object sender, RoutedEventArgs e)
        {
            shopWin = new ShopWindow();
            shopWin.Show();
            shopWin.MainWin = this;
            WindowState = WindowState.Minimized;
        }
    }
}
