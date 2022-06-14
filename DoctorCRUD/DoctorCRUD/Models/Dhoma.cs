using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorCRUD.Models
{
    public class Dhoma
    {
        public int DhomaId { get; set; }

        public string DhomaName { get; set; }
        public string Department { get; set; }
        public string EmployeeName { get; set; }
        public string NurseName { get; set; }
        public string Slots { get; set; }
    }
}
