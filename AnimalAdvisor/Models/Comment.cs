using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdvisor.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string CommentText { get; set; }

        public DateTime CommentDate { get; set; }

        public Animal Animal { get; set; }

        public int AnimalId { get; set; }


    }
}
