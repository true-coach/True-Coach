using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueCoach.Models.Interfaces
{
    public interface IJournal
    {
        Task CreateJournal(journal Journal);

        Task<journal> GetJournal(int id);
        Task<IEnumerable<journal>> GetJournals();
        Task DeleteJournal(int id);
    }
}
