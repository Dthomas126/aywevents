using System;
using System.ComponentModel.DataAnnotations;

namespace aywevents.Models
{
    public class EventRequest
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public string Service { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
    }
}