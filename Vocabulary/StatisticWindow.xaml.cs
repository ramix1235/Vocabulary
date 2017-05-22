using System;
using System.Windows;
using System.Windows.Input;

namespace Vocabulary
{
    /// <summary>
    /// Логика взаимодействия для StatisticWindow.xaml
    /// </summary>
    public partial class StatisticWindow : Window
    {
        public Window MainWin { get; set; }
        private bool _isReportViewerLoaded;

        public StatisticWindow()
        {
            InitializeComponent();
            _reportViewer.Load += ReportViewer_Load;
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            if (!_isReportViewerLoaded)
            {
                Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
                VocabularyDataSet dataset = new VocabularyDataSet();
                dataset.BeginInit();
                reportDataSource.Name = "DataSet";
                //Name of the report dataset in our .RDLC file
                reportDataSource.Value = dataset.Words;
                _reportViewer.LocalReport.DataSources.Add(reportDataSource);
                _reportViewer.LocalReport.ReportPath = "../../ReportAllWords.rdlc";
                dataset.EndInit();
                //fill data into WpfApplication4DataSet
                VocabularyDataSetTableAdapters.WordsTableAdapter wordsTableAdapter = new VocabularyDataSetTableAdapters.WordsTableAdapter();

                wordsTableAdapter.ClearBeforeFill = true;
                wordsTableAdapter.Fill(dataset.Words);
                _reportViewer.RefreshReport();
                _isReportViewerLoaded = true;
            }
        }

        /// <summary>
        /// Нажатие кнопки "Отмена"
        /// </summary>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWin.WindowState = WindowState.Normal;
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
    }
}
