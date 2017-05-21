using System.Collections.Generic;
using System.Linq;
using моделирование.DataAccess;
using моделирование.Models;

namespace моделирование.Fill
{
    class DataAdd
    {
        public static void FillDB(out int nCategory, out int nEducation, out int nLimitation, out int nProduct, out int nScore, out int nShop, out int nStatistic, out int nVocabulary, out int nWord)
        {
            var categories = new List<Category>
            {
                new Category
                {
                    Title = @"Программирование"
                },
                new Category
                {
                    Title = @"Путешествие"
                },
                new Category
                {
                    Title = @"Еда"
                }
            };
            using (var context = new VocabularyContext())
            {
                categories.ForEach(p => context.Categories.Add(p));
                context.SaveChanges();
                nCategory = context.Categories.Count();
            }

            var education = new List<Education>
            {
                new Education
                {
                    CountOfEducation = 0,
                    CountOfRightAnswer = 0,
                    CountOfWrongAnswer = 0
                }
            };
            using (var context = new VocabularyContext())
            {
                education.ForEach(p => context.Education.Add(p));
                context.SaveChanges();
                nEducation = context.Education.Count();
            }

            var limitation = new List<Limitation>
            {
                new Limitation
                {
                    MaxCountOfCategory = 3,
                    MaxCountOfVocabulary = 5,
                    MaxCountOfWordInVocabulary = 50
                }
            };
            using (var context = new VocabularyContext())
            {
                limitation.ForEach(p => context.Limitation.Add(p));
                context.SaveChanges();
                nLimitation = context.Limitation.Count();
            }

            var products = new List<Product>
            {
                new Product
                {
                   Title = @"Словарь",
                   Description = @"Вы можете увеличить максимальное количество словарей",
                   Price = 50M
                },
                new Product
                {
                   Title = @"Категория",
                   Description = @"Вы можете увеличить максимальное количество категорий",
                   Price = 25M
                },
                new Product
                {
                   Title = @"Расширить словарь",
                   Description = @"Вы можете увеличить максимальное количество слов в словаре",
                   Price = 10M
                }
            };
            using (var context = new VocabularyContext())
            {
                products.ForEach(p => context.Products.Add(p));
                context.SaveChanges();
                nProduct = context.Products.Count();
            }

            var score = new List<Score>
            {
                new Score
                {
                    Count = 0
                }
            };
            using (var context = new VocabularyContext())
            {
                score.ForEach(p => context.Score.Add(p));
                context.SaveChanges();
                nScore = context.Score.Count();
            }

            var shop = new List<Shop>
            {
                new Shop
                {

                }
            };
            using (var context = new VocabularyContext())
            {
                shop.ForEach(p => context.Shop.Add(p));
                context.SaveChanges();
                nShop = context.Shop.Count();
            }

            var statistic = new List<Statistic>
            {
                new Statistic
                {

                }
            };
            using (var context = new VocabularyContext())
            {
                statistic.ForEach(p => context.Statistic.Add(p));
                context.SaveChanges();
                nStatistic = context.Statistic.Count();
            }

            var vocabularies = new List<Vocabulary>
            {
                new Vocabulary
                {
                    Title = @"Словарь 1",
                    CountOfWord = 3,
                    CategoryID = 1
                },
                new Vocabulary
                {
                    Title = @"Словарь 2",
                    CountOfWord = 3,
                    CategoryID = 2
                },
                new Vocabulary
                {
                    Title = @"Словарь 3",
                    CountOfWord = 3,
                    CategoryID = 3
                }
            };
            using (var context = new VocabularyContext())
            {
                vocabularies.ForEach(p => context.Vocabularies.Add(p));
                context.SaveChanges();
                nVocabulary = context.Vocabularies.Count();
            }

            var words = new List<Word>
            {
                new Word
                {
                    RussianTranslation = @"Интерфейс",
                    EnglishTranslation = @"Interface",
                    VocabularyID = 1
                },
                new Word
                {
                    RussianTranslation = @"Полиморфизм",
                    EnglishTranslation = @"Polymorphism",
                    VocabularyID = 1
                },
                new Word
                {
                    RussianTranslation = @"Наследование",
                    EnglishTranslation = @"Inheritance",
                    VocabularyID = 1
                },
                new Word
                {
                    RussianTranslation = @"Страна",
                    EnglishTranslation = @"Country",
                    VocabularyID = 2
                },
                new Word
                {
                    RussianTranslation = @"Иностранец",
                    EnglishTranslation = @"Foreigner",
                    VocabularyID = 2
                },
                new Word
                {
                    RussianTranslation = @"Аеропорт",
                    EnglishTranslation = @"Airport",
                    VocabularyID = 2
                },
                new Word
                {
                    RussianTranslation = @"Салат",
                    EnglishTranslation = @"Salad",
                    VocabularyID = 3
                },
                new Word
                {
                    RussianTranslation = @"Курица",
                    EnglishTranslation = @"Chicken",
                    VocabularyID = 3
                },
                new Word
                {
                    RussianTranslation = @"Спагетти",
                    EnglishTranslation = @"Spaghetti",
                    VocabularyID = 3
                }
            };
            using (var context = new VocabularyContext())
            {
                words.ForEach(p => context.Words.Add(p));
                context.SaveChanges();
                nWord = context.Words.Count();
            }
        }
    }
}
