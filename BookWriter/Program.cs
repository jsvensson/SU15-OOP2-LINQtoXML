using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Books;

namespace BookWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            var authors = new List<Author>
            {
                new Author
                {
                    Name = "Richard Morgan",
                    Books = new List<Book>
                    {
                        new Book { Title = "Altered Carbon", PageCount = 416 },
                        new Book { Title = "Broken Angels", PageCount = 400 },
                        new Book { Title = "Woken Furies", PageCount = 436 }
                    }
                },
                new Author
                {
                    Name = "Patrick Rothfuss",
                    Books = new List<Book>
                    {
                        new Book { Title = "The Name of the Wind", PageCount = 662 },
                        new Book { Title = "The Wise Man's Fear", PageCount = 994 }
                    }
                }
            };

            var xml = new XDocument(
                new XElement("authors", authors.Select(a => new XElement("author",
                    new XAttribute("name", a.Name),
                    new XElement("books", a.Books.Select(b => new XElement("book",
                        new XAttribute("name", b.Title),
                        new XAttribute("pagecount", b.PageCount)
                    )))
                )))
            ); 

            xml.Save("authors.xml");

        }
    }
}
