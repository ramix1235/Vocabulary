using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using моделирование.DataAccess;

namespace Vocabulary
{

    /// <summary>
    /// Логика взаимодействия для ShopWindow.xaml
    /// </summary>
    public partial class ShopWindow : Window
    {
        public Window MainWin { get; set; }
        VocabularyContext db;

        public ShopWindow()
        {
            InitializeComponent();
            db = new VocabularyContext();
            db.Products.Load();
            db.Score.Load();
            db.Categories.Load();
            db.Vocabularies.Load();
            db.Limitation.Load();
            dataGrid.ItemsSource = db.Products.Local.ToList();
            labelScore.Content = db.Score.Local.ToList()[0].Count;
            labelCategoriesScore.Content = db.Categories.Local.ToList().Count + "/" + db.Limitation.Local.ToList()[0].MaxCountOfCategory;
            labelVocabulariesScore.Content = db.Vocabularies.Local.ToList().Count + "/" + db.Limitation.Local.ToList()[0].MaxCountOfVocabulary;
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
        /// При двойном нажатии мышки, покупаем товар
        /// </summary>
        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dataGrid.SelectedIndex == -1) return;
        }
    }
}
