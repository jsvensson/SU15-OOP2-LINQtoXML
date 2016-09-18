using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;

namespace BookReader
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement xmlFile = XElement.Load(File.OpenText("authors.xml"));

            IEnumerable<XElement> authors = xmlFile.XPathSelectElements("author");

            foreach (XElement author in authors)
            {
                Console.WriteLine(author.Attribute("name")?.Value);

                IEnumerable<XElement> books = author.XPathSelectElements("books/book");
                foreach (XElement book in books)
                {
                    Console.WriteLine($"  * {book.Attribute("name")?.Value} ({book.Attribute("pagecount")?.Value} pages)");
                }
            }
        }
    }
}
