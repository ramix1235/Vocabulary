using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using моделирование.DataAccess;
using моделирование.Models;

namespace Vocabulary
{
    /// <summary>
    /// Логика взаимодействия для WordAddWindow.xaml
    /// </summary>
    public partial class WordAddWindow : Window
    {
        private DataGrid dataGrid = null;
        private DataGrid dataGridVocabularies = null;
        private моделирование.Models.Vocabulary currentVocabulary;
        VocabularyContext db;

        public WordAddWindow(DataGrid dataGridVocabularies, DataGrid dataGrid)
        {
            InitializeComponent();
            this.dataGridVocabularies = dataGridVocabularies;
            this.dataGrid = dataGrid;
            currentVocabulary = (моделирование.Models.Vocabulary)dataGridVocabularies.SelectedItem;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            var newWorld = new Word();
            newWorld.EnglishTranslation = firstSymbolUp(textEng.Text);
            newWorld.RussianTranslation = firstSymbolUp(textRus.Text);
            newWorld.VocabularyID = currentVocabulary.VocabularyID;
            db = new VocabularyContext();
            db.Words.Load();
            db.Words.Add(newWorld);
            currentVocabulary.CountOfWord++;
            db.SaveChanges();
            dataGrid.Items.Refresh();
            dataGridVocabularies.Items.Refresh();
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
