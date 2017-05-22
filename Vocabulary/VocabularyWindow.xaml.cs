using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using моделирование.DataAccess;
using моделирование.Models;

namespace Vocabulary
{
    /// <summary>
    /// Логика взаимодействия для VocabularyWindow.xaml
    /// </summary>
    public partial class VocabularyWindow : Window
    {
        private WordEditWindow wordEditWin;
        private WordAddWindow wordAddWin;
        private моделирование.Models.Vocabulary currentVocabulary;
        private DataGrid dataGridVocabularies = null;
        VocabularyContext db;

        public VocabularyWindow(DataGrid dataGridVocabularies)
        {
            InitializeComponent();
            this.dataGridVocabularies = dataGridVocabularies;
            db = new VocabularyContext();
            db.Words.Load();
            db.Vocabularies.Load();
            currentVocabulary = (моделирование.Models.Vocabulary)dataGridVocabularies.SelectedItem; //db.Vocabularies.Find(vocabularyIndex);
            foreach (Word word in db.Words)
            {
                if (word.VocabularyID == currentVocabulary.VocabularyID)
                {
                    dataGrid.Items.Add(new Word { WordID = word.WordID, EnglishTranslation = word.EnglishTranslation, RussianTranslation = word.RussianTranslation, VocabularyID = word.VocabularyID });
                }
            }
        }

        /// <summary>
        /// Нажатие кнопки "Отмена"
        /// </summary>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Возможность перетаскивать окно за любую взятую область
        /// </summary>
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        /// <summary>
        /// При нажатии Esc выходим из этого окна
        /// </summary>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.Equals(Key.Escape))
            {
                btnCancel_Click(sender, e);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedIndex == -1) return;
            wordEditWin = new WordEditWindow(dataGrid);
            wordEditWin.Show();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedIndex == -1) return;
            db = new VocabularyContext();
            db.Words.Load();
            db.Vocabularies.Load();

            var currentWord = (Word)dataGrid.SelectedItem;
            var dbWord = db.Words.Find(currentWord.WordID);
            db.Words.Remove(dbWord);

            currentVocabulary = (моделирование.Models.Vocabulary)dataGridVocabularies.SelectedItem;
            var dbVocabulary = db.Vocabularies.Find(currentVocabulary.VocabularyID);
            dbVocabulary.CountOfWord--;
            currentVocabulary.CountOfWord--;

            db.SaveChanges();
            dataGrid.Items.Remove(currentWord);
            dataGrid.Items.Refresh();
            dataGridVocabularies.Items.Refresh();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            wordAddWin = new WordAddWindow(dataGridVocabularies, dataGrid);
            //wordAddWin.Show();
        }
    }
}
