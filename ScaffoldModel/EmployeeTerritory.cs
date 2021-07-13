using System;
using System.Collections.Generic;

#nullable disable

namespace s4lab4v6.ScaffoldModel
{
    public partial class EmployeeTerritory
    {
        public int EmployeeId { get; set; }
        public string TerritoryId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Territory Territory { get; set; }
    }
}
