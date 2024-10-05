using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLog.Entities.PseudoModels;

public class pseudoSport
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public sbyte NumberOfTeams { get; set; }
    public sbyte MaxNumberOfPlayersByTeam { get; set; }
    public sbyte NumberOfSubstitutionsByTeam { get; set; }
    public sbyte NumberOfPeriods { get; set; }
    public sbyte PeriodDuration { get; set; }
    public sbyte BreakDuration { get; set; }

    //navigation
    public ICollection<pseudoGame> Games { get; set; } = new List<pseudoGame>();
}
