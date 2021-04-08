using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BYUEgyptExcavation.Models
{
    public partial class Mummy
    {
        [Key]
        public int MummyId { get; set; }
        public string GenderGe { get; set; }
        public string GenderMethod { get; set; }
        public decimal? GeFunctionTotal { get; set; }
        public string GenderBodyCol { get; set; }
        public string HairColor { get; set; }
        public decimal? EstimateAge { get; set; }
        public string AgeMethod { get; set; }
        public decimal? EstimateLivingStature { get; set; }
        public string ToothAttrition { get; set; }
        public string ToothEruption { get; set; }
        public string PathologyAnomalies { get; set; }
    }
}
