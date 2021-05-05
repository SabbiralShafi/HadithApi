using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HadithApi
{
    public class Hadith
    {
        public int ID { get; set; }
        public string Speaker { get; set; }
        public string Reference { get; set; }
        public string Book { get; set; }
        public string Condition { get; set; }
        public string Body { get; set; }
    }
}
