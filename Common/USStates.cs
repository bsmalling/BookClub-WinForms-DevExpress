using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClub.Common
{

    public static class USStates
    {

         private static List<USState> los = new List<USState>
         {
            // USA
            new USState("AL", "Alabama"),
            new USState("AK", "Alaska"),
            new USState("AZ", "Arizona"),
            new USState("AR", "Arkansas"),
            new USState("CA", "California"),
            new USState("CO", "Colorado"),
            new USState("CT", "Connecticut"),
            new USState("DE", "Delaware"),
            new USState("DC", "District Of Columbia"),
            new USState("FL", "Florida"),
            new USState("GA", "Georgia"),
            new USState("HI", "Hawaii"),
            new USState("ID", "Idaho"),
            new USState("IL", "Illinois"),
            new USState("IN", "Indiana"),
            new USState("IA", "Iowa"),
            new USState("KS", "Kansas"),
            new USState("KY", "Kentucky"),
            new USState("LA", "Louisiana"),
            new USState("ME", "Maine"),
            new USState("MD", "Maryland"),
            new USState("MA", "Massachusetts"),
            new USState("MI", "Michigan"),
            new USState("MN", "Minnesota"),
            new USState("MS", "Mississippi"),
            new USState("MO", "Missouri"),
            new USState("MT", "Montana"),
            new USState("NE", "Nebraska"),
            new USState("NV", "Nevada"),
            new USState("NH", "New Hampshire"),
            new USState("NJ", "New Jersey"),
            new USState("NM", "New Mexico"),
            new USState("NY", "New York"),
            new USState("NC", "North Carolina"),
            new USState("ND", "North Dakota"),
            new USState("OH", "Ohio"),
            new USState("OK", "Oklahoma"),
            new USState("OR", "Oregon"),
            new USState("PA", "Pennsylvania"),
            new USState("RI", "Rhode Island"),
            new USState("SC", "South Carolina"),
            new USState("SD", "South Dakota"),
            new USState("TN", "Tennessee"),
            new USState("TX", "Texas"),
            new USState("UT", "Utah"),
            new USState("VT", "Vermont"),
            new USState("VA", "Virginia"),
            new USState("WA", "Washington"),
            new USState("WV", "West Virginia"),
            new USState("WI", "Wisconsin"),
            new USState("WY", "Wyoming"),

            // Canada
            //new State("AB", "Alberta"),
            //new State("BC", "British Columbia"),
            //new State("MB", "Manitoba"),
            //new State("NB", "New Brunswick"),
            //new State("NL", "Newfoundland and Labrador"),
            //new State("NS", "Nova Scotia"),
            //new State("NT", "Northwest Territories"),
            //new State("NU", "Nunavut"),
            //new State("ON", "Ontario"),
            //new State("PE", "Prince Edward Island"),
            //new State("QC", "Quebec"),
            //new State("SK", "Saskatchewan"),
            //new State("YT", "Yukon"),
        };

        public static List<string> Abbreviations()
        {
            return los.Select(s => s.Abbreviation).ToList();
        }

        public static List<string> Names()
        {
            return los.Select(s => s.Name).ToList();
        }

        public static string GetName(string abbreviation)
        {
            return los.Where(s => s.Abbreviation.Equals(abbreviation, StringComparison.CurrentCultureIgnoreCase)).Select(s => s.Name).FirstOrDefault();
        }

        public static string GetAbbreviation(string name)
        {
            return los.Where(s => s.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)).Select(s => s.Abbreviation).FirstOrDefault();
        }

        public static List<USState> ToList()
        {
            return los;
        }

    }

    public class USState
    {

        public USState(string ab, string name)
        {
            Name = name;
            Abbreviation = ab;
        }

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Abbreviation, Name);
        }

    }

}
