using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designs.Behavioural.Template
{
    public abstract class AbstractBookletPrinter
    {
        protected internal abstract int PageCount { get; }
        protected internal abstract void PrintCover();

        protected internal abstract void TableOfContents();

        protected internal abstract void PrintPage(int pageNumber);

        protected internal abstract void PrintTableOfContents();

        protected internal abstract void PrintIndex();

        public void Print()
        {
            PrintCover();
            TableOfContents();
            PrintTableOfContents();
            for (int i = 1; i <= PageCount; i++)
            {
                PrintPage(i);
            }
            PrintIndex();
        }
    }
}
