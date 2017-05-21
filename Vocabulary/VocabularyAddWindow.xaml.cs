using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using моделирование.DataAccess;
using моделирование.Models;

namespace Vocabulary
{
    /// <summary>
    /// Логика взаимодействия для VocabularyAddWindow.xaml
    /// </summary>
    public partial class VocabularyAddWindow : Window
    {
        private DataGrid dataGrid = null;
        private моделирование.Models.Vocabulary currentVocabulary;
        VocabularyContext db;

        public VocabularyAddWindow(DataGrid dataGrid)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
            currentVocabulary = (моделирование.Models.Vocabulary)dataGrid.SelectedItem;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            var newCategory = new Category();
            newCategory.Title = firstSymbolUp(textCategory.Text);

            db = new VocabularyContext();
            db.Categories.Load();
            db.Vocabularies.Load();

            db.Categories.Add(newCategory);

            var newVocabulary = new моделирование.Models.Vocabulary();
            newVocabulary.Title = firstSymbolUp(textTitle.Text);
            newVocabulary.CategoryID = newCategory.CategoryID;
            newVocabulary.CountOfWord = 0;

            db.Vocabularies.Add(newVocabulary);

            db.SaveChanges();
            //dataGrid.Items.Add(newVocabulary);
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
