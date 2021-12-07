using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdvisor.Models
{
    public class Report
    {
        public int Id { get; set; }

        public int ReportListId { get; set; }

        public int CommentId { get; set; }
        public ReportList ReportList { get; set; }

        public Comment Comment { get; set; }

    }
}
