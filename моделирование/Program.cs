using System;
using System.Data.Entity;
using моделирование.DataAccess;
using моделирование.Fill;

namespace моделирование
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Стратегия работы с базой данных
                Database.SetInitializer(new DropCreateDatabaseAlways<VocabularyContext>());
                int nCategory;
                int nEducation;
                int nLimitation;
                int nProduct;
                int nScore;
                int nShop;
                int nStatistic;
                int nVocabulary;
                int nWord;
                DataAdd.FillDB(out nCategory, out nEducation, out nLimitation, out nProduct, out nScore, out nShop, out nStatistic, out nVocabulary, out nWord);
                Console.WriteLine("База данных на SQL Server создана"
                + " и заполнена." + "\n В таблицы записано следующее количество строк:\n"
                + "Categories– " + nCategory
                + ", Education– " + nEducation
                + ", Limitation– " + nLimitation
                + ", Products– " + nProduct
                + ", Score– " + nScore
                + ", Shop– " + nShop
                + ", Statistic– " + nStatistic
                + ", Vocabularies– " + nVocabulary
                + ", Words– " + nWord
                + ".\n Проверьте!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("База данных не создана. \n Ошибка:\n " + ex.ToString());
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
            Console.ReadKey();
        }
    }
}
