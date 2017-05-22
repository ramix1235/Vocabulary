using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using моделирование.DataAccess;
using моделирование.Models;

namespace Vocabulary
{

    /// <summary>
    /// Логика взаимодействия для Vocabularies.xaml
    /// </summary>
    public partial class VocabulariesWindow : Window
    {
        private VocabularyWindow VocWin;
        private VocabularyAddWindow vocAddWin;
        private VocabularyEditWindow VocEditWin;
        public Window MainWin { get; set; }
        VocabularyContext db;

        public VocabulariesWindow()
        {
            InitializeComponent();
            db = new VocabularyContext();
            db.Vocabularies.Load();
            db.Score.Load();
            dataGrid.ItemsSource = db.Vocabularies.Local.ToList();
            labelScore.Content = db.Score.Local.ToList()[0].Count;
        }

        /// <summary>
        /// Нажатие кнопки "Отмена"
        /// </summary>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MainWin.WindowState = WindowState.Normal;
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

        /// <summary>
        /// При двойном нажатии мышки, заходим в выбранный словарь
        /// </summary>
        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dataGrid.SelectedIndex == -1) return;
            VocWin = new VocabularyWindow(dataGrid);
            VocWin.Show();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            db = new VocabularyContext();
            db.Limitation.Load();
            var currentLimitation = db.Limitation.Local.ToList()[0].MaxCountOfVocabulary;
            if (currentLimitation == dataGrid.Items.Count)
            {
                MessageWindow MessWin = new MessageWindow("Ошибка", "Достигнуто максимальное количество словарей");
                MessWin.ShowDialog();
                return;
            }
            vocAddWin = new VocabularyAddWindow(dataGrid);
            vocAddWin.Show();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedIndex == -1) return;
            db = new VocabularyContext();
            db.Words.Load();
            db.Vocabularies.Load();
            db.Categories.Load();
            db.LimitationForVocabulary.Load();

            var currentVocabulary = (моделирование.Models.Vocabulary)dataGrid.SelectedItem;
            var dbVocabulary = db.Vocabularies.Find(currentVocabulary.VocabularyID);
            var dbLimitationForVocabulary = db.LimitationForVocabulary.Find(currentVocabulary.LimitationForVocabularyID);
            db.LimitationForVocabulary.Remove(dbLimitationForVocabulary);

            foreach (Word word in db.Words)
            {
                if (word.VocabularyID == currentVocabulary.VocabularyID)
                {
                    db.Words.Remove(word);
                }
            }
            int entries = 0;
            foreach (Category category in db.Categories)
            {
                if (category.CategoryID == currentVocabulary.CategoryID)
                {
                    entries++;
                }
            }
            if (entries == 1)
            {
                var dbCategory = db.Categories.Find(currentVocabulary.CategoryID);
                db.Categories.Remove(dbCategory);
            }
            db.Vocabularies.Remove(dbVocabulary);
            db.SaveChanges();
            //dataGrid.Items.Remove(currentVocabulary);
            dataGrid.Items.Refresh();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedIndex == -1) return;
            VocEditWin = new VocabularyEditWindow(dataGrid);
            VocEditWin.Show();
        }
    }
}
