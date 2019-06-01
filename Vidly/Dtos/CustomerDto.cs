using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The customer's name is a required field")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipTypeDto MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }

        //[Min18YearsIfAMember]
        ////This attribute is deleted because the logic of the validation was made for Customer and not CustomerDto
        public DateTime? Birthdate { get; set; }
    }
}