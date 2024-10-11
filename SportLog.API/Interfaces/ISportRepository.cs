using SportLog.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLog.API.Interfaces
{
    public interface ISportRepository
    {
        Task<List<Sport>> GetAllAsync();
        Task<Sport?> GetByIdAsync(int id);

        Task AddSportAsync(Sport sport);

        Task UpdateSportAsync(Sport sport);

        Task DeleteSportAsync(int id);
    }
}
