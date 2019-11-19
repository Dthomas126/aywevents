using System;
using System.ComponentModel.DataAnnotations;

namespace aywevents.Models
{
    public class Service
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required]
        public string Details { get; set; }

    }
}