using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_SubstractionApplication.Models
{
    public class MinusModel
    {
        [Required(ErrorMessage="Enter Number1 to substract!!!")]
        public int Number1 { get; set; }

        [Required(ErrorMessage = "Enter Number2 to substract!!!")]
        public int Number2 { get; set; }

        public int? Answer { get; set; }
    }
}