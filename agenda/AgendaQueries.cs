using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agenda.Models;
using Microsoft.EntityFrameworkCore;

namespace agenda
{
    public interface iAgendaQueries
    {
        Task<Agenda> Authenticate(string email, string password);
    }
    public class AgendaQueries: iAgendaQueries
    {
        private readonly ApplicationDBContext db;

        public AgendaQueries(ApplicationDBContext db)
        {
            this.db = db;
        }

        public async Task<Agenda> Authenticate(string email, string password)
        {
            var user = await db.Agenda
                .Where(user => user.Email == email && user.Password == password)
                .FirstOrDefaultAsync();

            return user;

        }
    }
}
