using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Author
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
