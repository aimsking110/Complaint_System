using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complaint_System.DTO
{
    class CustomerDTO
    {
        private string ComplainID;
        private string ComplainDescription;
        private string ComplainStatus;
        private string DeptName;

        public string ComplainID1 { get => ComplainID; set => ComplainID = value; }
        public string ComplainDescription1 { get => ComplainDescription; set => ComplainDescription = value; }
        public string ComplainStatus1 { get => ComplainStatus; set => ComplainStatus = value; }
        public string DeptName1 { get => DeptName; set => DeptName = value; }
    }
}
