﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SportLog.Entities.Models;

[Index("Name", IsUnique = true)]
[Table("Sport")]
public partial class Sport
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "TEXT (200)")]
    public string Name { get; set; }

    public int NumberOfTeams { get; set; }

    public int MaxNumberOfPlayersByTeam { get; set; }

    public int NumberOfSubstitutionsByTeam { get; set; }

    public int NumberOfPeriods { get; set; }

    public int PeriodDuration { get; set; }

    public int BreakDuration { get; set; }

    [InverseProperty("Sport")]
    public virtual ICollection<Game> Game { get; set; } = new List<Game>();
}