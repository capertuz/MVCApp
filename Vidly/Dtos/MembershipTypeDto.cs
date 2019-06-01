using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MembershipTypeDto
    {
        //In the Dto we only add what is needed to keep it lightweight
        //Since we are using it to get data on the Customers table 
        public byte Id { get; set; }
        
        public string Name { get; set; }
    }
}