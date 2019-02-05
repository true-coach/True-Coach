using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueCoach.Controllers
{
    public class JournalController
    {
        private readonly IJournal _context;

            public JournalController(IJournal context)
        {
            _context = context;
        }
        public async Task<IAsyncResult> Index(string Entry)
        {
            var Entry = await _context.GetEntry();

            if (!string.IsNullOrEmpty(Entry))
            {
                Entry=Entry.where()
            }
        }

    }
}
