using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using моделирование.DataAccess;

namespace Vocabulary
{

    /// <summary>
    /// Логика взаимодействия для Vocabularies.xaml
    /// </summary>
    public partial class VocabulariesWindow : Window
    {
        public Window MainWin { get; set; } // окно родитель к которому следует вернутся при закрытии
        VocabularyContext db;

        public VocabulariesWindow()
        {
            InitializeComponent();
            db = new VocabularyContext();
            db.Vocabularies.Load();
            var vocabularies = db.Vocabularies;
            dataGrid.ItemsSource = db.Vocabularies.Local.ToList();
            //foreach (моделирование.Models.Vocabulary vocabulary in vocabularies)
            //{
            //dataGrid.Items.Add(new Vocabulary { Title = vocabulary.Title, Category = vocabulary.Category.Title, CountOfWord = vocabulary.CountOfWord });
            //Title = vocabulary.Title, Category = vocabulary.Category, CountOfWord = vocabulary.CountOfWord;
            //}
        }

        /// <summary>
        /// Нажатие кнопки "Отмена"
        /// </summary>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MainWin.WindowState = WindowState.Normal; // разворачиваем главное окно
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
    }
}
