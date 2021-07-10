using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return (DateTime)value > DateTime.Now;

        }
        [Required]
        [FutureDate]
        public string Date { get; set; }
    }
}