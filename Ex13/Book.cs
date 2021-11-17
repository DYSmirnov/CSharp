using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{/// <summary>
/// Info about book
/// </summary>
    class Book
    {
        public string Title { get; set; }
        public int Edition { get; private set; } = 1;
        public int IncreaseEditionNumber()
        {
            return ++Edition;
        }
        public override string ToString()
        {
            return $"{Title}, edition{Edition}";
            //return base.ToString();
        }
    }
}
