using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdvisor.Models
{
    public class Animal
    {
        public int Id { get; set; }

        public string AnimalName { get; set; }        

        public double? AnimalLenght { get; set; }

        public double? AnimalWeight { get; set; }

        public string AnimalPhoto { get; set; }

        public Species Species { get; set; }
        public int SpeciesId { get; set; }


    }
}
