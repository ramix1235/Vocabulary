using System;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using моделирование.DataAccess;
using моделирование.Models;

namespace Vocabulary
{

    /// <summary>
    /// Логика взаимодействия для EducationTestWindow.xaml
    /// </summary>
    public partial class EducationTestWindow : Window
    {
        public Window MainWin { get; set; }
        public string mode;
        public Word currentWord;
        public bool isBtnQuestionClick = false;
        public bool isRightAnswer = false;
        private EducationWindow edWin;
        VocabularyContext db;

        public EducationTestWindow(string mode)
        {
            InitializeComponent();
            this.mode = mode;
            if (mode == "engRus")
            {
                InputLanguageManager.SetInputLanguage(textBoxWrd, CultureInfo.CreateSpecificCulture("ru"));
            }
            else
            {
                InputLanguageManager.SetInputLanguage(textBoxWrd, CultureInfo.CreateSpecificCulture("en"));
            }
            db = new VocabularyContext();
            db.Score.Load();
            labeScore.Content = db.Score.Local.ToList()[0].Count;
            randomWord(mode);
            btnNextWrd.Visibility = Visibility.Collapsed;
            textBlockQuestion.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Нажатие кнопки "Отмена"
        /// </summary>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
            edWin = new EducationWindow();
            edWin.Show();
            edWin.MainWin = MainWin;
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

        private void btnQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (isBtnQuestionClick == true) return;
            isBtnQuestionClick = true;
            db = new VocabularyContext();
            db.Score.Load();
            labeScore.Content = --db.Score.Local.ToList()[0].Count;
            db.SaveChanges();
            textBlockQuestion.Visibility = Visibility.Visible;
            if (mode == "rusEng")
            {
                textBlockQuestion.Text = currentWord.EnglishTranslation;
            }
            else
            {
                textBlockQuestion.Text = currentWord.RussianTranslation;
            }
        }

        private void btnNextWrd_Click(object sender, RoutedEventArgs e)
        {
            isRightAnswer = false;
            isBtnQuestionClick = false;
            btnNextWrd.Visibility = Visibility.Collapsed;
            textBlockQuestion.Visibility = Visibility.Collapsed;
            textBoxWrd.Text = "";
            textBlockQuestion.Text = "";
            Background = new LinearGradientBrush(Colors.White, Color.FromRgb(0, 149, 182), 90);
            randomWord(mode);
        }

        private void textBoxWrd_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (textBoxWrd.Text.Equals(""))
            {
                validationWord();
            }
            else
            {
                validationWord();
            }
        }

        private void validationWord()
        {
            if (mode == "engRus")
            {
                var word = currentWord.RussianTranslation.Split(',');
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i].Trim().ToLower().Equals(textBoxWrd.Text.ToLower()))
                    {
                        if (isRightAnswer == false)
                        {
                            db = new VocabularyContext();
                            db.Score.Load();
                            labeScore.Content = ++db.Score.Local.ToList()[0].Count;
                            db.SaveChanges();
                            isRightAnswer = true;
                        }
                        btnNextWrd.Visibility = Visibility.Visible;
                        Background = new LinearGradientBrush(Colors.White, Color.FromRgb(79, 162, 40), 90);
                        break;
                    }
                    else
                    {
                        btnNextWrd.Visibility = Visibility.Collapsed;
                        Background = new LinearGradientBrush(Colors.White, Color.FromRgb(214, 38, 38), 90);
                    }
                }
            }
            else
            {
                var word = currentWord.EnglishTranslation.Split(',');
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i].Trim().ToLower().Equals(textBoxWrd.Text.ToLower()))
                    {
                        if (isRightAnswer == false)
                        {
                            db = new VocabularyContext();
                            db.Score.Load();
                            labeScore.Content = ++db.Score.Local.ToList()[0].Count;
                            db.SaveChanges();
                            isRightAnswer = true;
                        }
                        btnNextWrd.Visibility = Visibility.Visible;
                        Background = new LinearGradientBrush(Colors.White, Color.FromRgb(79, 162, 40), 90);
                        break;
                    }
                    else
                    {
                        btnNextWrd.Visibility = Visibility.Collapsed;
                        Background = new LinearGradientBrush(Colors.White, Color.FromRgb(214, 38, 38), 90);
                    }
                }
            }
        }

        /// <summary>
        /// Генерация слова в зависимости от режима тренировки
        /// </summary>
        /// <param name="mode">Язык тренировки</param>
        private void randomWord(string mode)
        {
            Random rnd = new Random();
            db = new VocabularyContext();
            db.Words.Load();
            var words = db.Words.Local.ToArray();
            int min = 1;
            int max = words.Length;
            int index = rnd.Next(min, max);
            if (mode == "engRus")
            {
                var word = words[index].RussianTranslation.Split(',');
                labelCountTranslate.Content = "количество переводов: " + word.Length;
                labelWrd.Content = words[index].EnglishTranslation;
                labelCategory.Content = "категория: " + words[index].Vocabulary.Category.Title;
            }
            else
            {
                var word = words[index].EnglishTranslation.Split(',');
                labelCountTranslate.Content = "количество переводов: " + word.Length;
                labelWrd.Content = words[index].RussianTranslation;
                labelCategory.Content = "категория: " + words[index].Vocabulary.Category.Title;
            }
            currentWord = words[index];
        }
    }
}
