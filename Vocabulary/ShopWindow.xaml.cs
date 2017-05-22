using System;
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
            try
            {
                DragMove();
            }
            catch (Exception)
            {
                return;
            }
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
            db = new VocabularyContext();
            db.Products.Load();
            db.Score.Load();
            db.Limitation.Load();
            db.LimitationForVocabulary.Load();
            var product = db.Products.Local.ToList()[dataGrid.SelectedIndex];
            var products = db.Products.Local.ToArray();
            if (db.Score.Local.ToList()[0].Count < product.Price)
            {
                MessageWindow MessWin = new MessageWindow("Ошибка", "У вас недостаточно монет");
                MessWin.ShowDialog();
                return;
            }
            labelScore.Content = db.Score.Local.ToList()[0].Count - (int)product.Price;
            db.Score.Local.ToList()[0].Count -= (int)product.Price;
            if (product.Title == products[0].Title)
            {
                db.Limitation.ToList()[0].MaxCountOfVocabulary++;
                labelVocabulariesScore.Content = db.Vocabularies.ToList().Count + "/" + db.Limitation.ToList()[0].MaxCountOfVocabulary;
            }
            else if (product.Title == products[1].Title)
            {
                db.Limitation.ToList()[0].MaxCountOfCategory++;
                labelCategoriesScore.Content = db.Categories.ToList().Count + "/" + db.Limitation.ToList()[0].MaxCountOfCategory;
            }
            else
            {
                // слова
            }
            db.SaveChanges();
            // понять какую услугу выбрал
            // отнять монеты (если это возможно)
            // увеличить запас
        }
    }
}
