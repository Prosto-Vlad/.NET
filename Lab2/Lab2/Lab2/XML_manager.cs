using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace Lab2
{
    public static class XML_manager
    {
        public static void dataToXML(List<Article> art_data, List<Author> aut_data, List<Magazine> mag_data, List<DataLink> link_data, List<Publisher> pub_data, string path)
        {
            
            var arrayArt = from art in art_data
                           select
                           new XElement("Article",
                           new XElement("ID", art.ID),
                           new XElement("name", art.name),
                           new XElement("ID_magazine", art.ID_magazine),
                           new XElement("input_data", art.input_data));

            XElement articles = new XElement("Article", arrayArt);
            var arrayAut = from aut in aut_data
                           select
                           new XElement("Author",
                           new XElement("ID", aut.ID),
                           new XElement("name", aut.name),
                           new XElement("surname", aut.surname),
                           new XElement("patronymic", aut.patronymic),
                           new XElement("organization", aut.organization));

            XElement authors = new XElement("Author", arrayAut);
            var arrayMag = from mag in mag_data
                           select
                           new XElement("Magazine",
                           new XElement("ID", mag.ID),
                           new XElement("name", mag.name),
                           new XElement("periodicity", mag.periodicity.ToString()),
                           new XElement("release_date", mag.release_date.ToUniversalTime()),
                           new XElement("Circulation", mag.Circulation.ToString()));

            XElement magazines = new XElement("Magazine", arrayMag);
            var arrayLink = from link in link_data
                            select
                            new XElement("DataLink",
                            new XElement("ID1", link.ID1),
                            new XElement("ID2", link.ID2));

            XElement links = new XElement("DataLink", arrayLink);
            var arrayPub = from pub in pub_data
                           select
                            new XElement("Publisher",
                            new XElement("ID", pub.ID),
                            new XElement("name", pub.name),
                            new XElement("city", pub.city),
                            new XElement("address", pub.address),
                            new XElement("Magazine", from mag in pub.Magazine
                                                     select
                                                     new XElement("Magazine",
                                                       new XElement("ID", mag.ID),
                                                       new XElement("name", mag.name),
                                                       new XElement("periodicity", mag.periodicity.ToString()),
                                                       new XElement("release_date", mag.release_date.ToUniversalTime()),
                                                       new XElement("Circulation", mag.Circulation.ToString()))));

            XElement publishers = new XElement("Publisher", arrayPub);

            XElement res = new XElement("Container");
            res.Add(articles);
            res.Add(authors);
            res.Add(magazines);
            res.Add(links);
            res.Add(publishers);
            res.Save(path);

        }
        public static Container XMLToData(string path)
        {
            Container container;
            XmlSerializer serializer = new XmlSerializer(typeof(Container));
            using (StreamReader sr = new StreamReader(path))
            {
                container = (Container)serializer.Deserialize(sr);
            }
            return container;
        }


    }
}
