using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEntryUI.Classes
{
    public class StudentInformation
    {
        private string registerNo;
        private string studentName;
        private string studentEmail;

       public StudentInformation(string registerNO, string studentName, string studentEmail)
        {
            this.registerNo = registerNO;
            this.studentName = studentName;
            this.studentEmail = studentEmail;
        }
        public string StudentEmail
        {
            get { return studentEmail; }
        }

        public string StudentName
        {
            get { return studentName; }
        }

        public string RegisterNo
        {
            get { return registerNo; }
        }
    }
}
