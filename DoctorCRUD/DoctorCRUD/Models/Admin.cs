using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorCRUD.Models
{

    public class Admin
    {
        public int AdminId { get; set; }

        public string AdminName { get; set; }
        public string Birthday { get; set; }
        public string Vendbanimi { get; set; }
        public string PhotoFileName { get; set; }
        public string Email { get; set; }
        public string AdminPassword { get; set; }
        public string AdminRole { get; set; }
    }
}
