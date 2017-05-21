using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using моделирование.DataAccess;
using моделирование.Models;

namespace Vocabulary
{
    /// <summary>
    /// Логика взаимодействия для WordEditWindow.xaml
    /// </summary>
    public partial class WordEditWindow : Window
    {
        private Word currentWord = null;
        private DataGrid dataGrid = null;
        VocabularyContext db;

        public WordEditWindow(DataGrid dataGrid)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
            currentWord = (Word)dataGrid.SelectedItem;
            textEng.Text = currentWord.EnglishTranslation;
            textRus.Text = currentWord.RussianTranslation;
            textEng.Focus();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            currentWord.EnglishTranslation = firstSymbolUp(textEng.Text);
            currentWord.RussianTranslation = firstSymbolUp(textRus.Text);
            db = new VocabularyContext();
            db.Words.Load();
            var dbWord = db.Words.Find(currentWord.WordID);
            dbWord.EnglishTranslation = currentWord.EnglishTranslation;
            dbWord.RussianTranslation = currentWord.RussianTranslation;
            db.SaveChanges();
            dataGrid.Items.Refresh();
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.Equals(Key.Enter))
            {
                btnOK_Click(sender, e);
            }
            else if (e.Key.Equals(Key.Escape))
            {
                btnCancel_Click(sender, e);
            }
        }

        /// <summary>
        /// Возведение первого символа в верхний регистр
        /// </summary>
        private string firstSymbolUp(string text)
        {
            string oldfirstSymbol = text.Remove(1, text.Length - 1); // выделяем первый символ
            string newfirstSymbol = oldfirstSymbol.ToUpper(); // переводим его в верхний регистр
            text = text.Remove(0, 1).Insert(0, newfirstSymbol); // удаляем первый символ и вставляем на его место измененный
            return text;
        }
    }
}
