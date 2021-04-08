using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BYUEgyptExcavation.Models
{
    public partial class Burial
    {
        [Key]
        public int MummyId { get; set; }
        public string BurialId { get; set; }
        public string BurialLocationNs { get; set; }
        public int? LowPairNs { get; set; }
        public int? HighPairNs { get; set; }
        public string BurialLocationEw { get; set; }
        public int? LowPairEw { get; set; }
        public int? HighPairEw { get; set; }
        public string BurialSubplot { get; set; }
        public decimal? BurialDepth { get; set; }
        public decimal? SouthToHead { get; set; }
        public decimal? SouthToFeet { get; set; }
        public decimal? EastToHead { get; set; }
        public decimal? EastToFeet { get; set; }
        public decimal? LengthOfRemains { get; set; }
        public int? BurialNumber { get; set; }
        public string PreservationIndex { get; set; }
        public string BurialSituationNotes { get; set; }
        public string ArtifactsTakenNotes { get; set; }
        public string SampleTakenNotes { get; set; }
        public bool HairTaken { get; set; }
        public bool SoftTissueTaken { get; set; }
        public bool BoneTaken { get; set; }
        public bool ToothTaken { get; set; }
        public bool TextileTaken { get; set; }
        public bool ArtifactFound { get; set; }
        public bool Wrapped { get; set; }
        public string HeadDirection { get; set; }
        public string YearFound { get; set; }
        public string MonthFound { get; set; }
        public string DayFound { get; set; }
        public string UserInitials { get; set; }
    }
}
