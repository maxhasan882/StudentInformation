using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentEntryUI.Classes;

namespace StudentEntryUI
{
    public partial class StudentRegisterUI : Form
    {
        public StudentRegisterUI()
        {
            InitializeComponent();
        }

        private Depertment aDepertment;
        private void saveButton_Click(object sender, EventArgs e)
        {
            aDepertment = new Depertment(departmentCodeTextBox.Text,DepartmentNameTextBox.Text);
            MessageBox.Show("Department Created");
        }

        private void studentRegisterdButton_Click(object sender, EventArgs e)
        {
            string msg;
            StudentInformation aStudentInformation = new StudentInformation(studentRegisteredNoTextBos.Text, studentNameTextBox.Text, studentEmailTextBox.Text);
            msg = aDepertment.RegisterStudent(aStudentInformation);
            MessageBox.Show(msg);
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            string information = "Department Code :" + aDepertment.DepertmentCode + "\tDepart Name :" +
                                 aDepertment.DepertmenrtName+ "\n";
            information += "Student Code :\t" + "StudentName :\t" + "Student Email:\n";
            foreach (StudentInformation aStudentInformation in aDepertment.AStudentInformations)
            {
                information += aStudentInformation.RegisterNo + "\t" + aStudentInformation.StudentName+ "\t" +
                               aStudentInformation.StudentEmail + "\n";
            }
            MessageBox.Show(information);
        }
    }
}
