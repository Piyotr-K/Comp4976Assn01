using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LmycDataLib.BoatModel;

namespace LmycWebSite.Data
{
    public class DummyData
    {
        public static System.Collections.Generic.List<Boat> getBoats()
        {
            List<Boat> boats = new List<Boat>()
            {
                new Boat()
                {
                    BoatName = "S.S. Wave",
                    LengthInFeet = 35.21,
                    Make = "Cruiser Yachts",
                    Year = 2005,
                    RecordCreationDate = "2010-03-24"
                },
                new Boat()
                {
                    BoatName = "Lady Luck",
                    LengthInFeet = 37.19,
                    Make = "Hunton Yachts",
                    Year = 2011,
                    RecordCreationDate = "2013-09-12"
                },
                new Boat()
                {
                    BoatName = "Captain Sea",
                    LengthInFeet = 40.12,
                    Make = "MasterCraft",
                    Year = 2008,
                    RecordCreationDate = "2011-10-02"
                },
                new Boat()
                {
                    BoatName = "Anchorage Scourge",
                    LengthInFeet = 42.18,
                    Make = "Sunseeker",
                    Year = 2009,
                    RecordCreationDate = "2011-11-09"
                },
            };

            return boats;
        }
    }
}