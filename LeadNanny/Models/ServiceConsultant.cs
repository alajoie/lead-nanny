using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeadNanny.Models
{
    public class ServiceConsultant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Quota { get; set; }
        public int LeadsUsed { get; set; }
    }
}