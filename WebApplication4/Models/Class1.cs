using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Register //so this Register class is an object that can be used. Its a thing in the real world that we can store data in and do stuff with

    {

        [Required]

        [Key]

        public string FirstName { get; set; }

        [Required]

        public string Email { get; set; }

        [Required]

        public int Phone { get; set; }

        public string Gender { get; set; }

        public string userName { get; set;  } 

    public string WellBeing { get; set; }

        [Required]
        public string thePass { get; set; }

}

}