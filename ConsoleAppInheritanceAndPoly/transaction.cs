using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInheritanceAndPoly
{
    class transaction
    {
        public string AccountNumbert { get; set; }
        public decimal Amount { get; set; }

        public bool isSuccessful { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
