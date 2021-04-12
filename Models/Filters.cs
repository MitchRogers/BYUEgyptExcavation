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
            FilterString = filterstring ?? "all-all-all-all-all-all";
            string[] filters = FilterString.Split('-');
            
            
            //RemainsLength = filters[1];
            PreservationIndex = filters[0];
            HeadDirection = filters[1];
            Gender = filters[2];
            HairColor = filters[3];
            MummyId = filters[4];
            //YearFound = filters[4];

            //HairTaken = filters[5];
            //SoftTissueTaken = filters[6];
            //BoneTaken = filters[7];
            //ToothTaken = filters[8];
            //TextileTaken = filters[9];
            //ArtifactFound = filters[10];
            //Wrapped = filters[11];

            //AgeAtDeath = filters[7];
        }

        public string MummyId { get; }
        public string FilterString { get; }
        public string Depth { get; }
        //public string RemainsLength { get; }
        public string PreservationIndex { get; }
        public string HeadDirection { get; }
        public string YearFound { get; }
        public string Gender { get; }
        public string HairColor { get; }

        public string HairTaken { get; }
        public string SoftTissueTaken { get; }
        public string BoneTaken { get; }
        public string ToothTaken { get; }
        public string TextileTaken { get; }

        public string ArtifactFound { get; }
        public string Wrapped { get; }
        //public string AgeAtDeath { get; }

        //public bool HasDepth => Depth.ToLower() != "all";
        //public bool HasRemainsLength => RemainsLength.ToLower() != "all";
        public bool HasPreservationIndex => PreservationIndex.ToLower() != "all";
        public bool HasHeadDirection => HeadDirection.ToLower() != "all";
        public bool HasYearFound => YearFound.ToLower() != "all";
        public bool HasGender => Gender.ToLower() != "all";
        public bool HasHairColor => HairColor.ToLower() != "all";

        public bool HasMummyId => MummyId.ToString() != "all";

        public bool HasHairTaken => HairTaken.ToLower() != "all";
        public bool HasSoftTissueTaken => SoftTissueTaken.ToLower() != "all";
        public bool HasBoneTaken => BoneTaken.ToLower() != "all";
        public bool HasToothTaken => ToothTaken.ToLower() != "all";
        public bool HasTextileTaken => TextileTaken.ToLower() != "all";
        public bool HasArtifactFound => ArtifactFound.ToLower() != "all";
        public bool HasWrapped => Wrapped.ToLower() != "all";

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

