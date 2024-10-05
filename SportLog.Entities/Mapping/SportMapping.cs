using SportLog.Entities.DTOs;
using SportLog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SportLog.Entities.Mapping;

public static class SportMapping
{
    public static Sport Map(SportDTO dto, Sport? sport = null)
    {
        if (sport != null)
        {
            sport.BreakDuration = dto.BreakDuration;
            sport.MaxNumberOfPlayersByTeam = dto.MaxNumberOfPlayersByTeam;
            sport.Name = dto.Name;
            sport.NumberOfPeriods = dto.NumberOfPeriods;
            sport.NumberOfSubstitutionsByTeam = dto.NumberOfSubstitutionsByTeam;
            sport.NumberOfTeams = dto.NumberOfTeams;
            sport.PeriodDuration = dto.PeriodDuration;
        }
        else
        {
            var newSport = new Sport
            {
                BreakDuration = dto.BreakDuration,
                MaxNumberOfPlayersByTeam = dto.MaxNumberOfPlayersByTeam,
                Name = dto.Name,
                NumberOfPeriods = dto.NumberOfPeriods,
                NumberOfSubstitutionsByTeam = dto.NumberOfSubstitutionsByTeam,
                NumberOfTeams = dto.NumberOfTeams,
                PeriodDuration = dto.PeriodDuration
            };

            return newSport;
        }

        return sport;
    }
}
