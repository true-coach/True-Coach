using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueCoach.Models.Interfaces
{
    public interface IJournal
    {
        //creating Journal
        Task CreateJournal(Journal journal);

        Task<Journal> GetJournal(int id);
        Task<IEnumerable<Journal>> GetJournal();
        //updating Journal
        Task updateJournal(Journal journal);

        //Deleting Journal
        Task DeleteJournal(int id);
    }
}
