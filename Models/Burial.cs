using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line: 
// #nullable disable


//created through scafofolding, has some required features, but allows us to reference our data in the program.
namespace BYUEgyptExcavation.Models
{
    public partial class Burial
    {
        public int MummyId { get; set; }
        public string BurialId { get; set; }
        public double BurialNumber { get; set; }
        [Required]
        public string BurialLocationNs { get; set; }
        public double LowPairNs { get; set; }
        public double HighPairNs { get; set; }
        [Required]
        public string BurialLocationEw { get; set; }
        public double LowPairEw { get; set; }
        public double HighPairEw { get; set; }
        [Required]
        public string BurialSubplot { get; set; }
        public double BurialDepth { get; set; }
        public double SouthToHead { get; set; }
        public double SouthToFeet { get; set; }
        public double EastToHead { get; set; }
        public double EastToFeet { get; set; }
        public double LengthOfRemains { get; set; }
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
        [Required]
        public string HeadDirection { get; set; }
        [Required]
        public string YearFound { get; set; }
        [Required]
        public string MonthFound { get; set; }
        [Required]
        public string DayFound { get; set; }
        [Required]
        public string UserInitials { get; set; }
        public string GenderGe { get; set; }
        public string GenderMethod { get; set; }
        public double? GeFunctionTotal { get; set; }
        public string GenderBodyCol { get; set; }
        public string HairColor { get; set; }
        public double? EstimateAge { get; set; }
        public string AgeMethod { get; set; }
        public double? EstimateLivingStature { get; set; }
        public string ToothAttrition { get; set; }
        public string ToothEruption { get; set; }
        public string PathologyAnomalies { get; set; }
        public double? SampleNumber { get; set; }
        public string BasilarSuture { get; set; }
        public double? VentralArc { get; set; }
        public double? SubpubicAngle { get; set; }
        public double? SciaticNotch { get; set; }
        public double? PubicBone { get; set; }
        public double? PreaurSulcus { get; set; }
        public double? MedialIpRamus { get; set; }
        public double? DorsalPitting { get; set; }
        public double? ForemanMagnum { get; set; }
        public double? FemurHead { get; set; }
        public double? HumerusHead { get; set; }
        public string Osteophytosis { get; set; }
        public string PubicSymphysis { get; set; }
        public double? FemurLength { get; set; }
        public double? HumerusLength { get; set; }
        public double? TibiaLength { get; set; }
        public double? Robust { get; set; }
        public double? SupraorbitalRidges { get; set; }
        public double? OrbitEdge { get; set; }
        public double? ParietalBossing { get; set; }
        public double? Gonian { get; set; }
        public double? NuchalCrest { get; set; }
        public double? ZygomaticCrest { get; set; }
        public string CranialSuture { get; set; }
        public double? MaximumCranialLength { get; set; }
        public double? MaximumCranialBreadth { get; set; }
        public double? BasionBregmaHeight { get; set; }
        public double? BasionNasion { get; set; }
        public double? BasionProsthionLength { get; set; }
        public double? BizygomaticDiameter { get; set; }
        public double? NasionProsthion { get; set; }
        public double? MaximumNasalBreadth { get; set; }
        public double? InterorbitalBreadth { get; set; }
        public string EpiphysealUnion { get; set; }
    }
}
