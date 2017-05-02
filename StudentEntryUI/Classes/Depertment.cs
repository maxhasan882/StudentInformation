using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryUI.Classes
{
    public class Depertment
    {
        private string depertmentCode;
        private string depertmentName;
        private List<StudentInformation> aStudentInformations = new List<StudentInformation>();

        public Depertment(String depertmentCode, string depertmentName)
        {
            this.depertmentCode = depertmentCode;
            this.depertmentName = depertmentName;
        }

        public string DepertmentCode
        {
            get { return depertmentCode; }
        }

        public string DepertmenrtName
        {
            get { return depertmentName; }
        }

        public List<StudentInformation> AStudentInformations
        {
            get { return aStudentInformations; }
        }

        public string RegisterStudent(StudentInformation aStudentInformation)
        {
            AStudentInformations.Add(aStudentInformation);
            return "Registerd";
        }
    }
}
