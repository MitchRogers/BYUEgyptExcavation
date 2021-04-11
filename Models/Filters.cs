using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYUEgyptExcavation.Models
{
    public class Filters
    {
        public Filters(string filterstring)
        {
            FilterString = filterstring ?? "all-all-all-all";
            string[] filters = FilterString.Split('-');
            //Depth = filters[0];
            //RemainsLength = filters[1];
            PreservationIndex = filters[0];
            HeadDirection = filters[1];
            //YearFound = filters[4];
            Gender = filters[2];
            HairColor = filters[3];
            //AgeAtDeath = filters[7];
        }

        public string FilterString { get; }
        //public string Depth { get; }
        //public string RemainsLength { get; }
        public string PreservationIndex { get; }
        public string HeadDirection { get; }
        //public string YearFound { get; }
        public string Gender { get; }
        public string HairColor { get; }
        //public string AgeAtDeath { get; }

        //public bool HasDepth => Depth.ToLower() != "all";
        //public bool HasRemainsLength => RemainsLength.ToLower() != "all";
        public bool HasPreservationIndex => PreservationIndex.ToLower() != "all";
        public bool HasHeadDirection => HeadDirection.ToLower() != "all";
        //public bool HasYearFound => YearFound.ToLower() != "all";
        public bool HasGender => Gender.ToLower() != "all";
        public bool HasHairColor => HairColor.ToLower() != "all";
        //public bool HasAgeAtDeath => AgeAtDeath.ToLower() != "all";

        //public static Dictionary<string, string> DueFilterValues =>
        //    new Dictionary<string, string>
        //    {
        //        {"future", "Future" },
        //        {"past", "Past" },
        //        {"today", "Today" }
        //    };

        //public bool IsPast => Due.ToLower() == "past";
        //public bool IsFuture => Due.ToLower() == "future";
        //public bool IsToday => Due.ToLower() == "today";
    }
}

