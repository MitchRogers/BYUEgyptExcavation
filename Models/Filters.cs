using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//this file allows for the Mummy List page to be filtered.
namespace BYUEgyptExcavation.Models
{
    public class Filters
    {
        public Filters(string filterstring)
        {
            //declaring the FilterString which is passed in by the Burial Controller, if it is null, then it is automatically sent to "all-"
            FilterString = filterstring ?? "all-all-all-all-all-all";

            //spliting the FilterString into an array, split by the "-" character
            string[] filters = FilterString.Split('-');


            //sets a specific attribute equal to each position of the array
            PreservationIndex = filters[0];
            HeadDirection = filters[1];
            Gender = filters[2];
            HairColor = filters[3];
            YearFound = filters[4];
            BurialId = filters[5];


        }

        //declaring the attributes of the filter, these are the columns in our database that we want to be able to filter by.
        public string BurialId { get; }
        public string FilterString { get; }
        public string PreservationIndex { get; }
        public string HeadDirection { get; }
        public string YearFound { get; }
        public string Gender { get; }
        public string HairColor { get; }


        //sets the boolean to true if there is a value in the reference after the lamda is not all.
        public bool HasPreservationIndex => PreservationIndex.ToLower() != "all";

        public bool HasBurialId => BurialId.ToLower() != "all";
        public bool HasHeadDirection => HeadDirection.ToLower() != "all";
        public bool HasYearFound => YearFound.ToLower() != "all";
        public bool HasGender => Gender.ToLower() != "all";
        public bool HasHairColor => HairColor.ToLower() != "all";
    }
}

