using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeaturedDeveloper.Models
{
    [Serializable]
    [Table("Developers")]
    public class DeveloperFields
    {
        [Key]
        public int DeveloperId { get; set; }
        
        public String Name { get; set; }

        public String Email { get; set; }

        public String Goals { get; set; }

        public String skills { get; set; }

        public String LinkedInURL { get; set; }

        public String GitURL { get; set; }

        public String ImageURL { get; set; }

        public DateTime LastShowed { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
