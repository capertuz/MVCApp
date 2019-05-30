using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Vidly.Models
{

    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
        [Display(Name = "Date of Birth")]//This attribute is used to display "Date of Birth" as the label for an input linked to this field.
        public DateTime? Birthdate { get; set; }
        
    }



}