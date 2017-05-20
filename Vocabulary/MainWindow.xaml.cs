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
        public MainWindow()
        {
            InitializeComponent();
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
    }
}
