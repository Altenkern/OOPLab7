using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOPLab7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<Student> StudentsList = new List<Student>();

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            StudentsList.Add(new Student() {
                StudenFirstName = textBoxStudentFirstName.Text,
                StudentSecondName = textBoxStudentSecondName.Text,
                StusenFatherName =textBoxStudentFatherName.Text});

            listBoxStudents.DataSource = StudentsList;

        }

        private void MainForm_Load(object sender, EventArgs e)
        { 
            listBoxStudents.DataSource = StudentsList;
        }
    }
}
