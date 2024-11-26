using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Template
{
    public class SaloonBookletPrinter : AbstractBookletPrinter
    {
        protected internal override int PageCount => 10;
        protected internal override void PrintCover()
        {
            Console.WriteLine("Printing Saloon Booklet Cover");
        }
        protected internal override void PrintIndex()
        {
            Console.WriteLine("Printing Saloon Booklet Index");
        }
        protected internal override void PrintPage(int pageNumber)
        {
            Console.WriteLine($"Printing Saloon Booklet Page {pageNumber}");
        }
        protected internal override void PrintTableOfContents()
        {
            Console.WriteLine("Printing Saloon Booklet Table of Contents");
        }
        protected internal override void TableOfContents()
        {
            Console.WriteLine("Printing Saloon Booklet Table of Contents");
        }
    }
}
