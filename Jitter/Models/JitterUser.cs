using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jitter.Models
{
    public class JitterUser
    {
        [Key] // This has Database autogenerate the following properties value
        public int JitterUserId { get; set; }

        [MaxLength(161)] 
        public string Description { get; set; }
        public string FirstName { get; set; }

        [Required] // makes the property immediately following this declaration a required property (in this case, Handle)
        [MaxLength(20)] // Sets a max langth for Handle
        [MinLength(3)] // Sets min length for Handle 
        [RegularExpression(@"^[a-zA-Z\d]+[-_a-zA-Z\d]{0,2}[a-zA-Z\d]+")]
        public string Handle { get; set; }

        public string LastName { get; set; }
        public string Picture { get; set; }
    }
}