using System;
using System.Collections.Generic;

namespace DatabaseFirstApproachWithOneTable.Models;

public partial class TblCountry
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public string? CountryCapital { get; set; }

    public string? CountryCurrency { get; set; }

    public string? CountryContinent { get; set; }
}
