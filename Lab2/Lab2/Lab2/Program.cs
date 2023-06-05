using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string path = "articles.xml";
            List<Article> article_data = new List<Article>()
            {
                new Article(1, "The power of positive thinking", 1, "2020-07-14"),
                new Article(2, "How to stay motivated", 1, "2020-06-06"),
                new Article(3, "The importance of staying organized", 2, "2020-05-13"),
                new Article(4, "Leadership and its impact on success", 2, "2020-04-20"),
                new Article(5, "The power of networking", 2, "2020-03-29"),
                new Article(6, "The importance of time management", 3, "2020-02-17"),
                new Article(7, "The power of goal setting", 4, "2020-01-13"),
                new Article(8, "The importance of resilience", 5, "2019-12-20"),
                new Article(9, "Problem-solving for success", 5, "2019-11-29"),
                new Article(10, "Creativity and its importance", 6, "2019-10-17"),
                new Article(11, "History of Data Science", 6, "2020-07-15"),
                new Article(12, "The Benefits of Data Science", 7, "2020-08-20"),
                new Article(13,  "Data Science for Business", 7, "2020-09-10"),
                new Article(14, "Data Science and Machine Learning", 8, "2020-10-12"),
                new Article(15, "Data Science and Artificial Intelligence", 8, "2020-11-05")
            };

            List<Author> authors_data = new List<Author>()
            {
                new Author(1,"John","Smit","Thompson","Microsoft"),
                new Author(2,"Fiona","Harris","Christian","Apple"),
                new Author(3,"Liam","Wilson","Thomas","Apple"),
                new Author(4,"Olivia","Hall","Oliver","McDonald's"),
                new Author(5,"Noah","Taylor","William","Google"),
                new Author(6,"Emma","White","David","Google"),
                new Author(7,"Mason","Martin","Matthew","IBM"),
                new Author(8,"Ava","Thompson","Michael","Microsoft"),
                new Author(9,"Jacob","Warcia","Joseph","Google"),
                new Author(10,"Sophia","Robinson","George","Google")
            };

            List<Magazine> magazine_data = new List<Magazine>()
            {
                new Magazine(1, "The New York Times", "Daily", "2018-01-01", 1000000),
                new Magazine(2, "The Wall Street Journal", "Daily", "2016-02-01", 500000),
                new Magazine(3, "The Washington Post", "Daily", "2018-03-01", 700000),
                new Magazine(4, "USA Today", "Daily", "2019-04-01", 800000),
                new Magazine(5, "The Times", "Weekly", "2015-05-01", 100000),
                new Magazine(6, "The Economist", "Weekly", "2011-06-01", 200000),
                new Magazine(7, "National Geographic", "Monthly", "2017-07-01", 250000),
                new Magazine(8, "Time", "Monthly", "2015-08-01", 300000)
            };

            List<DataLink> author_article = new List<DataLink>()
            {
                new DataLink(1,1),
                new DataLink(1,2),
                new DataLink(3,2),
                new DataLink(1,3),
                new DataLink(3,3),
                new DataLink(2,4),
                new DataLink(3,3),
                new DataLink(2,5),
                new DataLink(2,6),
                new DataLink(2,7),
                new DataLink(3,8),
                new DataLink(3,9),
                new DataLink(4,10),
                new DataLink(9,10),
                new DataLink(5,11),
                new DataLink(10,12),
                new DataLink(6,12),
                new DataLink(7,13),
                new DataLink(8,14),
                new DataLink(8,15),
                new DataLink(7,15),
            };

            List<Publisher> publisher_data = new List<Publisher>()
            {
                new Publisher(1, "John Doe", "New York", "123 Main Street", new List<Magazine>()
                {
                    magazine_data[0],
                    magazine_data[1]
                }),
                new Publisher(2, "Jane Doe", "Los Angeles", "456 Broadway Avenue", new List<Magazine>()
                {
                    magazine_data[2],
                    magazine_data[3],
                    magazine_data[4]
                }),
                new Publisher(3, "Luke Smith", "New York", "789 Houston Street", new List<Magazine>()
                {
                    magazine_data[5]
                }),
                new Publisher(4, "Sarah Williams", "Chicago", "111 W Chicago Avenue", new List<Magazine>()
                {
                    magazine_data[6]
                }),
                new Publisher(5, "Joshua Miller", "Philadelphia", "222 S Broad Street", new List<Magazine>()
                {
                    magazine_data[7]
                })
            };

            XML_manager.dataToXML(article_data, authors_data, magazine_data, author_article, publisher_data, path);

            Container cont = XML_manager.XMLToData(path);
            
            cont.print();
            
            Console.WriteLine("Запит 1. Вивести всіх авторів");
            var q1 = from x in cont.Author
                     select x;
            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nЗапит 2. Вивести журнали у порядку спадання тиражу");
            var q2 = from x in cont.Magazine
                     orderby x.Circulation descending
                     select x;
            foreach (var item in q2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nЗапит 3. Вивести кількість статей у кожного автора");
            var q3 = from x in cont.Author
                     select new
                     {
                         name = x.name,
                         surname = x.surname,
                         patronymic = x.patronymic,
                         count = (from l in cont.DataLink
                                  where x.ID == l.ID1
                                  select l).Count()
                     };
            foreach (var item in q3)
            {
                Console.WriteLine($"({item.name}, {item.surname}, {item.patronymic}, {item.count})");
            }

            Console.WriteLine("\nЗапит 4. Вивести видавців у яких більше 1 журнала");
            var q4 = from x in cont.Publisher
                     where x.Magazine.Count > 1
                     select new
                     {
                         name = x.name,
                         count = x.Magazine.Count
                     };
            foreach (var item in q4)
            {
                Console.WriteLine($"({item.name}, {item.count})");
            }

            Console.WriteLine("\nЗапит 5. Вивести журнали тираж, яких більше 300000");
            var q5 = from x in cont.Magazine
                     where x.Circulation > 300000
                     select x;
            foreach (var item in q5)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nЗапит 6. Вивести журнали з недільною периодичністю");
            var q6 = from x in cont.Magazine
                     where x.periodicity == "Weekly"
                     select x;
            foreach (var item in q6)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nЗапит 7. Вивести всі журнали, що випускалися в певному місті");
            var q7 = cont.Publisher.SelectMany(p => p.Magazine.Where(m => p.city == "New York"));
            foreach (var item in q7)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nЗапит 8. Вивести всіх авторів, які писали статті для журналу з щоденною періодичності.");
            var q8 = (from aut in cont.Author
                      join link in cont.DataLink on aut.ID equals link.ID1
                      join art in cont.Article on link.ID2 equals art.ID
                      join magazine in cont.Magazine on art.ID_magazine equals magazine.ID
                      where magazine.periodicity == "Daily" && link.ID1 == aut.ID && link.ID2 == art.ID
                      select aut).Distinct();
            foreach (var item in q8)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nЗапит 9. Вивести всіх авторів, які писали для 2 журналу.");
            var q9 = (from aut in cont.Author
                      join link in cont.DataLink on aut.ID equals link.ID1
                      join art in cont.Article on link.ID2 equals art.ID
                      where art.ID_magazine == 2
                      select aut).Distinct();
            foreach (var item in q9)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nЗапит 10. Вивести авторів які співпрацють з організацією Google");
            var q10 = cont.Author.Where(a => a.organization == "Google");
            foreach (var item in q10)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nЗапит 11. Вивести журнали, які вийшли після 2017 року");
            var q11 = from m in cont.Magazine
                      where m.release_date.Year > 2017
                      select m;
            foreach (var item in q11)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nЗапит 12. Вивести статті, які поступили до редакції після 2020.06.06");
            var q12 = from a in cont.Article
                      where a.input_data >= new DateTime(2020, 6, 6)
                      select a;
            foreach (var item in q12)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nЗапит 13. Вивести статті, які мають слово Science у назві");
            var q13 = from a in cont.Article
                      where a.name.Contains("Science")
                      select a;
            foreach (var item in q13)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nЗапит 14. Вивести статті, які знаходяться у журналі номер 1");
            var q14 = from a in cont.Article
                      where a.ID_magazine == 1
                      select a;
            foreach (var item in q14)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nЗапит 15. Вивести кількість авторів у кожній організації");
            var q15 = from a in cont.Author
                      group a by a.organization into g
                      select new
                      {
                          name = g.Key,
                          cout = g.Count()
                      };
            foreach (var item in q15)
            {
                Console.WriteLine($"({item.name}, {item.cout})");
            }
            

        }
        
    }
}
