using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueCoach.Models.Interfaces
{
    public interface IRegeneration
    {
        //creating Regeneration
        Task CreateRegeneration(Regeneration Regeneration);

        Task<Regeneration> GetRegeneration(int id);

        Task<IEnumerable<Regeneration>> GetRegenerations();

        //updating Regeneration
        Task UpdateRegeneration(Regeneration Regeneration);

        //Deleting Journal
        Task DeleteRegeneration(int id);
    }
}
