using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIRUI.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Resolution { get; set; }
        public int Complexity { get; set; }
        public int Occurrences { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate{ get; set; }
        public bool Edited { get; set; }
        public string EditedBy { get; set; }
        public DateTime EditedDate { get; set; }
    }
}