using Fact.Faker.Utils;
using System.Linq;

namespace Fact.Faker.US
{
    public class AddressUS
    {
        public static string State => STATES.Rand();
        public static string StateAbbr => STATES_ABBR.Rand();
        public static string ZipCode => "#####-####".Numerify();

        public static string StreetName
        {
            get
            {
                switch (2.Randomize())
                {
                    case 0: return string.Format("{0} {1}", Name.LasttName, STREET_SUFIX.Rand());
                    case 1: return string.Format("{0} {1}", Name.FirstName, STREET_SUFIX.Rand());
                    default: return string.Empty;
                }
            }
        }

        public static string City
        {
            get
            {
                var prefix = COMPASS_DIRECTIONS.Union(CITY_PREFIXES);

                switch (4.Randomize())
                {
                    case 0: return string.Format("{0} {1}", prefix, Name.FirstName);
                    case 1: return string.Format("{0} {1}{2}", prefix, Name.FirstName, CITY_SUFIX.Rand());
                    case 2: return string.Format("{0}{1}", Name.FirstName, CITY_SUFIX.Rand());
                    case 3: return string.Format("{0}{1}", Name.LasttName, CITY_SUFIX.Rand());
                    default: return string.Empty;
                }
            }
        }


        public static string Address
        {
            get
            {
                return string.Format("{0} {1}", "###".Numerify(), StreetName);
            }
        }


        private static string[] STATES_ABBR = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI",
            "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH",
            "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA",
            "WV", "WI", "WY" };


        private static string[] STATES = { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut",
            "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana",
            "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada",
            "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon",
            "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia",
            "Washington", "West Virginia", "Wisconsin", "Wyoming" };


        private static string[] COMPASS_DIRECTIONS = { "North", "East", "West", "South" };


        private static string[] CITY_PREFIXES = {"New", "Lake", "Port" };


        private static string[] CITY_SUFIX = { "town", "ton", "land", "ville", "berg", "burgh", "borough", "bury", "view", "port",
            "mouth", "stad", "furt", "chester", "mouth", "fort", "haven", "side", "shire" };


        private static string[] STREET_SUFIX = { "Alley", "Avenue", "Branch", "Bridge", "Brook", "Brooks", "Burg", "Burgs", "Bypass", "Camp",
            "Canyon", "Cape", "Causeway", "Center", "Centers", "Circle", "Circles", "Cliff", "Cliffs", "Club", "Common", "Corner",
            "Corners", "Course", "Court", "Courts", "Cove", "Coves", "Creek", "Crescent", "Crest", "Crossing", "Crossroad", "Curve",
            "Dale", "Dam", "Divide", "Drive", "Drives", "Estate", "Estates", "Expressway", "Extension", "Extensions", "Fall", "Falls",
            "Ferry", "Field", "Fields", "Flat", "Flats", "Ford", "Fords", "Forest", "Forge", "Forges", "Fork", "Forks", "Fort",
            "Freeway", "Garden", "Gardens", "Gateway", "Glen", "Glens", "Green", "Greens", "Grove", "Groves", "Harbor", "Harbors",
            "Haven", "Heights", "Highway", "Hill", "Hills", "Hollow", "Inlet", "Island", "Islands", "Isle", "Junction", "Junctions",
            "Key", "Keys", "Knoll", "Knolls", "Lake", "Lakes", "Land", "Landing", "Lane", "Light", "Lights", "Loaf", "Lock", "Locks",
            "Lodge", "Loop", "Mall", "Manor", "Manors", "Meadow", "Meadows", "Mews", "Mill", "Mills", "Mission", "Motorway", "Mount",
            "Mountain", "Mountains", "Neck", "Orchard", "Oval", "Overpass", "Park", "Parks", "Parkway", "Parkways", "Pass", "Passage",
            "Path", "Pike", "Pine", "Pines", "Place", "Plain", "Plains", "Plaza", "Point", "Points", "Port", "Ports", "Prairie",
            "Radial", "Ramp", "Ranch", "Rapid", "Rapids", "Rest", "Ridge", "Ridges", "River", "Road", "Roads", "Route", "Row",
            "Rue", "Run", "Shoal", "Shoals", "Shore", "Shores", "Skyway", "Spring", "Springs", "Spur", "Spurs", "Square", "Squares",
            "Station", "Stravenue", "Stream", "Street", "Streets", "Summit", "Terrace", "Throughway", "Trace", "Track", "Trafficway",
            "Trail", "Tunnel", "Turnpike", "Underpass", "Union", "Unions", "Valley", "Valleys", "Via", "Viaduct", "View", "Views",
            "Village", "Villages", "Ville", "Vista", "Walk", "Walks", "Wall", "Way", "Ways", "Well", "Wells" };

    }
}
