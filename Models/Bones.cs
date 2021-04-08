using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BYUEgyptExcavation.Models
{
    public partial class Bones
    {
        [Key]
        public int MummyId { get; set; }
        public int? SampleNumber { get; set; }
        public string BasilarSuture { get; set; }
        public int? VentralArc { get; set; }
        public int? SubpubicAngle { get; set; }
        public int? SciaticNotch { get; set; }
        public int? PubicBone { get; set; }
        public int? PreaurSulcus { get; set; }
        public int? MedialIpRamus { get; set; }
        public int? DorsalPitting { get; set; }
        public decimal? ForemanMagnum { get; set; }
        public decimal? FemurHead { get; set; }
        public decimal? HumerusHead { get; set; }
        public string Osteophytosis { get; set; }
        public string PubicSymphysis { get; set; }
        public decimal? FemurLength { get; set; }
        public decimal? HumerusLength { get; set; }
        public decimal? TibiaLength { get; set; }
        public int? Robust { get; set; }
        public int? SupraorbitalRidges { get; set; }
        public int? OrbitEdge { get; set; }
        public int? ParietalBossing { get; set; }
        public int? Gonian { get; set; }
        public int? NuchalCrest { get; set; }
        public int? ZygomaticCrest { get; set; }
        public string CranialSuture { get; set; }
        public decimal? MaximumCranialLength { get; set; }
        public decimal? MaximumCranialBreadth { get; set; }
        public decimal? BasionBregmaHeight { get; set; }
        public decimal? BasionNasion { get; set; }
        public decimal? BasionProsthionLength { get; set; }
        public decimal? BizygomaticDiameter { get; set; }
        public decimal? NasionProsthion { get; set; }
        public decimal? MaximumNasalBreadth { get; set; }
        public decimal? InterorbitalBreadth { get; set; }
        public string EpiphysealUnion { get; set; }
    }
}
