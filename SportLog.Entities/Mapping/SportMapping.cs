using SportLog.Entities.DTOs;
using SportLog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLog.Entities.Mapping;

public static class SportMapping
{
    public static Sport Map(SportDTO dto)
    {
        var sport = new Sport
        {
            BreakDuration = dto.BreakDuration,
            MaxNumberOfPlayersByTeam = dto.MaxNumberOfPlayersByTeam,
            Name = dto.Name,
            NumberOfPeriods = dto.NumberOfPeriods,
            NumberOfSubstitutionsByTeam = dto.NumberOfSubstitutionsByTeam,
            NumberOfTeams = dto.NumberOfTeams,
            PeriodDuration = dto.PeriodDuration
        };

        return sport;
    }
}
