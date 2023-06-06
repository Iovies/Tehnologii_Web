using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Models.Models
{
    public class ContentTrackerDbModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Href { get; set; }
        public string LacalPath { get; set; }
        public DateTime Uploaded { get; set; }
    }
}
