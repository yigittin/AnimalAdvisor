using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdvisor.Models
{
    public class Species
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string SpeciesName { get; set; }

        public string SpeciesPhoto { get; set; }

    }
}
