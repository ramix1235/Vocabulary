using System.Windows;
using System.Windows.Input;

namespace Vocabulary
{
    /// <summary>
    /// Логика взаимодействия для MessageWindow.xaml
    /// </summary>
    public partial class MessageWindow : Window
    {
        public MessageWindow()
        {
            InitializeComponent();
        }

        public MessageWindow(string title, string errorText)
        {
            InitializeComponent();
            lblTitle.Content = title;
            textBoxMessage.Text = errorText;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.Equals(Key.Enter))
            {
                Close();
            }
        }
    }
}
