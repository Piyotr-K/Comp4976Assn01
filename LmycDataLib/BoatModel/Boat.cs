using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmycDataLib.BoatModel
{
    public class Boat
    {
        // Primary Key
        public string BoatId { get; set; }

        public string BoatName { get; set; }
        public string Picture { get; set; }
        public double LengthInFeet { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string RecordCreationDate { get; set; }
        
        // Foreign Keys
        public int Id { get; set; }
        public ApplicationUser CreatedBy { get; set; }
    }
}
