using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using моделирование.DataAccess;

namespace Vocabulary
{

    /// <summary>
    /// Логика взаимодействия для Education.xaml
    /// </summary>
    public partial class EducationWindow : Window
    {
        public Window MainWin { get; set; }
        public EducationTestWindow edTestWin;
        public string mode;
        VocabularyContext db;

        public EducationWindow()
        {
            InitializeComponent();
            db = new VocabularyContext();
            db.Score.Load();
            db.Vocabularies.Load();
            comboBox.ItemsSource = db.Vocabularies.Local.ToBindingList();
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

        private void btnRusEng_Click(object sender, RoutedEventArgs e)
        {
            mode = "rusEng";
            edTestWin = new EducationTestWindow(mode, (моделирование.Models.Vocabulary)comboBox.SelectedItem);
            edTestWin.Show();
            edTestWin.MainWin = MainWin;
            Close();
        }

        private void btnEngRus_Click(object sender, RoutedEventArgs e)
        {
            mode = "engRus";
            edTestWin = new EducationTestWindow(mode, (моделирование.Models.Vocabulary)comboBox.SelectedItem);
            edTestWin.Show();
            edTestWin.MainWin = MainWin;
            Close();
        }
    }
}
