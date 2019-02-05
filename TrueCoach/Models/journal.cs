using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueCoach.Models
{
    public class journal
    {
        public int ID { get; set; }
        public profileID ProfileID { get; set; }
        public string Entry { get; set; }
        public DateTime Date { get; set; }
        
    }
}
