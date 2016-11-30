using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPoral.Models
{
    public class Compartment
    {

        public string CompartmentName { get; set; }
        public List<Service> lstService { get; set; }


    }
}