using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueCoach.Models.Interfaces
{
    public interface IJournal
    {
        //creating Journal
        Task CreateJournal(journal Journal);

        Task<journal> GetJournal(int id);
        Task<IEnumerable<journal>> GetJournals();
        //updating Journal
        Task updateJournal(journal journal);

        //Deleting Journal
        Task DeleteJournal(int id);
    }
}
