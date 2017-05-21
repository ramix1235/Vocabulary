﻿using System;
using System.Windows;
using System.Windows.Input;

namespace Vocabulary
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private VocabulariesWindow vocWin; // окно словаря

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
            vocWin.MainWin = this; // передаем главное окно в окно словаря для возврата к нему при закрытии окна словаря
            WindowState = WindowState.Minimized; // сворачиваем главное окно
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
