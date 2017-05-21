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
        private VocabularyWindow VocWin;
        public Window MainWin { get; set; }
        VocabularyContext db;

        public VocabulariesWindow()
        {
            InitializeComponent();
            db = new VocabularyContext();
            db.Vocabularies.Load();
            dataGrid.ItemsSource = db.Vocabularies.Local.ToList();
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
    }
}
