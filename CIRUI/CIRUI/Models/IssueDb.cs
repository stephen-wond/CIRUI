using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CIRUI.Models
{
    public class IssueDb:DbContext
    {
        public DbSet<Issue> Issues { get; set; }
    }
}