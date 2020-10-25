using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RossetiWeb.Models
{
    public class Ascillogram
    {
        public int Id { get; set; }
        public double Time { get; set; }
        public double Value { get; set; }

        public int? AscillogramCategoryId { get; set; }
        public AscillogramCategory AscillogramCategory { get; set; }
        public List<AscillogramCategory> AscillogramCategories { get; set; }
        public Ascillogram()
        {
            AscillogramCategories = new List<AscillogramCategory>();
        }
    }
}
