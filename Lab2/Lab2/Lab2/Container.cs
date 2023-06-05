using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Container
    {
        public List<Article> Article { get; set; }
        public List<Author> Author { get; set; }
        public List<Magazine> Magazine { get; set; }
        public List<DataLink> DataLink { get; set; }
        public List<Publisher> Publisher { get; set; }
        public Container()
        {

        }

        public void print()
        {
            Console.WriteLine("Article");
            foreach (var art in Article)
            {
                Console.WriteLine(art.ToString());
            }
            Console.WriteLine("Author");
            foreach (var aut in Author)
            {
                Console.WriteLine(aut.ToString());
            }
            Console.WriteLine("Magazine");
            foreach (var mag in Magazine)
            {
                Console.WriteLine(mag.ToString());
            }
            Console.WriteLine("DataLink");
            foreach (var link in DataLink)
            {
                Console.WriteLine(link.ToString());
            }
            Console.WriteLine("Publisher");
            foreach (var pub in Publisher)
            {
                Console.WriteLine(pub.ToString());
                foreach (var mag in pub.Magazine)
                {
                    Console.WriteLine("\t" + mag.ToString());
                }
            }
        }
    }
}
