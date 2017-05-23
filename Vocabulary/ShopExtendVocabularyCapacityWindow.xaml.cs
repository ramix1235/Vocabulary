using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using моделирование.DataAccess;
using моделирование.Models;

namespace Vocabulary
{

    /// <summary>
    /// Логика взаимодействия для ShopExtendVocabularyCapacityWindow.xaml
    /// </summary>
    public partial class ShopExtendVocabularyCapacityWindow : Window
    {
        public Window MainWin { get; set; }
        VocabularyContext db;
        public Label labelScore;
        public Score dbScore;
        public Product product;

        public ShopExtendVocabularyCapacityWindow(Label labelScore, Product product)
        {
            InitializeComponent();
            this.labelScore = labelScore;
            this.product = product;
            db = new VocabularyContext();
            db.Vocabularies.Load();
            db.Score.Load();
            dbScore = db.Score.Local.ToList()[0];
            comboBox.ItemsSource = db.Vocabularies.Local.ToBindingList();
            comboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Нажатие кнопки "Отмена"
        /// </summary>
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            db = new VocabularyContext();
            db.Vocabularies.Load();
            моделирование.Models.Vocabulary currentVocabulary = (моделирование.Models.Vocabulary)comboBox.SelectedItem;
            var dbVocabulary = db.Vocabularies.Find(currentVocabulary.VocabularyID);
            dbVocabulary.LimitationForVocabulary.MaxCountOfWord += 10;
            labelScore.Content = dbScore.Count - (int)product.Price;
            dbScore.Count -= (int)product.Price;
            db.SaveChanges();
            Close();
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

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
