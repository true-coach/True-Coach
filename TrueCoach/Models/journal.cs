using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueCoach.Models
{
    public class Journal
    {
        public int ID { get; set; }
        public int ProfileID { get; set; }
        public string Entry { get; set; }
        public DateTime Date { get; set; }
        
    }
}
