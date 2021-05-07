using System;
using System.Collections.Generic;

namespace HadithApi
{
    public class Hadith
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Speaker { get; set; }
        public string Reference { get; set; }
        public string Book { get; set; }
        public string Condition { get; set; }
        public string Body { get; set; }
    }

    public class ReadHadith
    {
        private List<Hadith> hadiths;
        public bool doUpdate { get; set; }

        public List<Hadith> Hadiths
        {
            get => hadiths ??= new List<Hadith>();
            set => hadiths = value;
        }
    }
}
