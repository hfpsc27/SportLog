using Microsoft.EntityFrameworkCore;
using SportLog.Entities.Models;
using SportLog.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportLog.API.Interfaces;

namespace SportLog.API.Services
{
    public class SportRepository : ISportRepository
    {
        private readonly SportLogAppDbContext context;

        public SportRepository(SportLogAppDbContext context)
        {
            this.context = context;
        }

        public async Task AddSportAsync(Sport sport)
        {

            throw new NotImplementedException();
        }

        public async Task DeleteSportAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Sport>> GetAllAsync()
        {
            return await context.Sports.ToListAsync();
        }

        public async Task<Sport?> GetByIdAsync(int id)
        {
            return await context.Sports.FindAsync(id);
        }

        public async Task UpdateSportAsync(Sport sport)
        {
            throw new NotImplementedException();
        }

    }
}
