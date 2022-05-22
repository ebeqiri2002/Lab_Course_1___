using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorCRUD.Models
{
    public class Nurse
    {
        public int NurseId { get; set; }

        public string NurseName { get; set; }
        public string Department { get; set; }
        public string DateOfJoining { get; set; }
        public string PhotoFileName { get; set; }

        public int NrDhomes { get; set; }
    }
}
