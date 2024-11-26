using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Template
{
    public class ServiceHistoryBooklet : AbstractBookletPrinter
    {
        protected internal override int PageCount => 20;
        protected internal override void PrintCover()
        {
            Console.WriteLine("Printing Service History Booklet Cover");
        }
        protected internal override void PrintIndex()
        {
            Console.WriteLine("Printing Service History Booklet Index");
        }
        protected internal override void PrintPage(int pageNumber)
        {
            Console.WriteLine($"Printing Service History Booklet Page {pageNumber}");
        }
        protected internal override void PrintTableOfContents()
        {
            Console.WriteLine("Printing Service History Booklet Table of Contents");
        }
        protected internal override void TableOfContents()
        {
            Console.WriteLine("Printing Service History Booklet Table of Contents");
        }
    }
}
