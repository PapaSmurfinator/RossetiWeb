using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RossetiWeb.Models
{
    public class AscillogramCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Ascillogram> Ascillograms { get; set; }
        public AscillogramCategory()
        {
            Ascillograms = new List<Ascillogram>();
        }
    }
}
