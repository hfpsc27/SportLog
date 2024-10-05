using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLog.Entities.PseudoModels;

public class pseudoGame
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public int SportId { get; set; }

    //navigation
    public pseudoSport Sport { get; set; } = new();
}
