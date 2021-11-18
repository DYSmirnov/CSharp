using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{/// <summary>
/// Info about book
/// </summary>
    class Book : IComparable
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public int Edition { get; private set; } = 1;
        public int IncreaseEditionNumber()
        {
            return ++Edition;
        }
        public override string ToString()
        {
            return $"{Title} {Autor}, edition{Edition}";

        }

        public int CompareTo(object o)
        {
            Book compareBook = o as Book;
                return this.Autor.CompareTo(compareBook.Autor);

        }

        interface IComparable
        {
            int CompareTo(object o);
        }
    }
}
