using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLog.Entities.DTOs
{
    public class SportDTO
    {
        public string Name { get; set; } = string.Empty;

        public int NumberOfTeams { get; set; }

        public int MaxNumberOfPlayersByTeam { get; set; }

        public int NumberOfSubstitutionsByTeam { get; set; }

        public int NumberOfPeriods { get; set; }

        public int PeriodDuration { get; set; }

        public int BreakDuration { get; set; }
    }
}
