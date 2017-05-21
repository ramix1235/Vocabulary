using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using моделирование.DataAccess;

namespace Vocabulary
{
    /// <summary>
    /// Логика взаимодействия для VocabularyEditWindow.xaml
    /// </summary>
    public partial class VocabularyEditWindow : Window
    {
        private DataGrid dataGrid = null;
        private моделирование.Models.Vocabulary currentVocabulary;
        VocabularyContext db;

        public VocabularyEditWindow(DataGrid dataGrid)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
            currentVocabulary = (моделирование.Models.Vocabulary)dataGrid.SelectedItem;
            textTitle.Text = currentVocabulary.Title;
            textCategory.Text = currentVocabulary.Category.Title;
            textTitle.Focus();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            currentVocabulary = (моделирование.Models.Vocabulary)dataGrid.SelectedItem;
            currentVocabulary.Title = firstSymbolUp(textTitle.Text);
            currentVocabulary.Category.Title = firstSymbolUp(textCategory.Text);
            db = new VocabularyContext();
            db.Vocabularies.Load();
            db.Categories.Load();

            var dbCategory = db.Categories.Find(currentVocabulary.CategoryID);
            dbCategory.Title = currentVocabulary.Category.Title;
            var dbVocabulary = db.Vocabularies.Find(currentVocabulary.VocabularyID);
            dbVocabulary.Title = currentVocabulary.Title;

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
