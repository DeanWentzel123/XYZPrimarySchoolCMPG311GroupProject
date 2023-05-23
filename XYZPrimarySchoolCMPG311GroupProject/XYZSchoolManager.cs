using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZPrimarySchoolCMPG311GroupProject
{
    public partial class frmXYZSchoolManager : Form
    {
        //Binding Lists for test
        BindingList<studentsTest> studentListTest = new BindingList<studentsTest>();
        BindingList<addStudentClasses> addStudentClassTest = new BindingList<addStudentClasses>();

        public frmXYZSchoolManager()
        {
            InitializeComponent();

            addToTestLists();
        }

        private void btnMainmenuStudents_Click(object sender, EventArgs e)
        {
            cbxStudentsGrade.SelectedIndex = 0;
            cbxStudentsSubject.SelectedIndex = 0;
            cbStudentsAbsentee.Checked = false;
            cbStudentsTextbooks.Checked = false;
            cbxStudentsOrderBy.SelectedIndex = 0;
            cbxStudentsOrderOrder.SelectedIndex = 0;

            fillCBXStudentSubjects(cbxStudentsGrade, cbxStudentsSubject);

            pnlfrmStudents.Visible = true;
            pnlfrmMainmenu.Visible = false;

            txtStudentsSearch.Select();
        }

        private void addToTestLists()
        {
            studentListTest.Add(new studentsTest { personID = 1, firstname = "john", lastname = "longwood", grade = 2, gender = "Male", parentFullname = "dan longwood", parentNumber  = "082 445 8748"});
            studentListTest.Add(new studentsTest { personID = 2, firstname = "shane", lastname = "langehoofen", grade = 4, gender = "Male", parentFullname = "raymond langehoofen", parentNumber = "076 587 9854" });
            studentListTest.Add(new studentsTest { personID = 3, firstname = "mary", lastname = "van heerden", grade = 6, gender = "Female", parentFullname = "susan heerden", parentNumber = "074 526 9875" });
            studentListTest.Add(new studentsTest { personID = 4, firstname = "dean", lastname = "wentzel",grade = 5, gender = "Male", parentFullname = "elria wentzel", parentNumber = "062 548 7896" });
            studentListTest.Add(new studentsTest { personID = 1, firstname = "john", lastname = "longwood", grade = 2, gender = "Male", parentFullname = "dan longwood", parentNumber = "082 445 8748" });
            studentListTest.Add(new studentsTest { personID = 2, firstname = "shane", lastname = "langehoofen", grade = 4, gender = "Male", parentFullname = "raymond langehoofen", parentNumber = "076 5879 854" });
            studentListTest.Add(new studentsTest { personID = 3, firstname = "mary", lastname = "van heerden", grade = 6, gender = "Female", parentFullname = "susan heerden", parentNumber = "074 526 9875" });
            studentListTest.Add(new studentsTest { personID = 4, firstname = "dean", lastname = "wentzel", grade = 5, gender = "Male", parentFullname = "elria wentzel", parentNumber = "062 548 7896" });
            studentListTest.Add(new studentsTest { personID = 1, firstname = "john", lastname = "longwood", grade = 2, gender = "Male", parentFullname = "dan longwood", parentNumber = "082 445 8748" });
            studentListTest.Add(new studentsTest { personID = 2, firstname = "shane", lastname = "langehoofen", grade = 4, gender = "Male", parentFullname = "raymond langehoofen", parentNumber = "076 587 9854" });
            studentListTest.Add(new studentsTest { personID = 3, firstname = "mary", lastname = "van heerden", grade = 6, gender = "Female", parentFullname = "susan heerden", parentNumber = "074 526 9875" });
            studentListTest.Add(new studentsTest { personID = 4, firstname = "dean", lastname = "wentzel", grade = 5, gender = "Male", parentFullname = "elria wentzel", parentNumber = "062 548 7896" });

            addStudentClassTest.Add(new addStudentClasses { classDay = 1, classPeriod = 1,  classSubject = "HLAFR", classTeacher = "Mev Van Rensburg"});
            addStudentClassTest.Add(new addStudentClasses { classDay = 1, classPeriod = 1, classSubject = "HLAFR", classTeacher = "Mev Van Rensburg" });
            addStudentClassTest.Add(new addStudentClasses { classDay = 1, classPeriod = 1, classSubject = "HLAFR", classTeacher = "Mev Van Rensburg" });
            addStudentClassTest.Add(new addStudentClasses { classDay = 1, classPeriod = 1, classSubject = "HLAFR", classTeacher = "Mev Van Rensburg" });
            addStudentClassTest.Add(new addStudentClasses { classDay = 1, classPeriod = 1, classSubject = "HLAFR", classTeacher = "Mev Van Rensburg" });
            addStudentClassTest.Add(new addStudentClasses { classDay = 1, classPeriod = 1, classSubject = "HLAFR", classTeacher = "Mev Van Rensburg" });
        }

        private void fillCBXStudentSubjects(ComboBox cbxGrade, ComboBox cbxSubjects)
        {
            try
            {
                cbxSubjects.Enabled = true;
                cbxSubjects.Items.Clear();
                cbxSubjects.Items.Add("All");
                cbxSubjects.SelectedIndex = 0;
                fillDGVStudents();

                switch (cbxGrade.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        cbxSubjects.Items.Add("HLAFR1");
                        cbxSubjects.Items.Add("HLENG1");
                        cbxSubjects.Items.Add("FALAFR1");
                        cbxSubjects.Items.Add("FALENG1");
                        cbxSubjects.Items.Add("MTHS1");
                        break;
                    case 2:
                        cbxSubjects.Items.Add("HLAFR2");
                        cbxSubjects.Items.Add("HLENG2");
                        cbxSubjects.Items.Add("FALAFR2");
                        cbxSubjects.Items.Add("FALENG2");
                        cbxSubjects.Items.Add("MTHS2");
                        break;
                    case 3:
                        cbxSubjects.Items.Add("HLAFR3");
                        cbxSubjects.Items.Add("HLENG3");
                        cbxSubjects.Items.Add("FALAFR3");
                        cbxSubjects.Items.Add("FALENG3");
                        cbxSubjects.Items.Add("MTHS3");
                        break;
                    case 4:
                        cbxSubjects.Items.Add("HLAFR4");
                        cbxSubjects.Items.Add("HLENG4");
                        cbxSubjects.Items.Add("FALAFR4");
                        cbxSubjects.Items.Add("FALENG4");
                        cbxSubjects.Items.Add("MTHS4");
                        cbxSubjects.Items.Add("NST4");
                        cbxSubjects.Items.Add("SS4");
                        cbxSubjects.Items.Add("LO4");
                        cbxSubjects.Items.Add("AC4");
                        break;
                    case 5:
                        cbxSubjects.Items.Add("HLAFR5");
                        cbxSubjects.Items.Add("HLENG5");
                        cbxSubjects.Items.Add("FALAFR5");
                        cbxSubjects.Items.Add("FALENG5");
                        cbxSubjects.Items.Add("MTHS5");
                        cbxSubjects.Items.Add("NST5");
                        cbxSubjects.Items.Add("SS5");
                        cbxSubjects.Items.Add("LO5");
                        cbxSubjects.Items.Add("AC5");
                        break;
                    case 6:
                        cbxSubjects.Items.Add("HLAFR6");
                        cbxSubjects.Items.Add("HLENG6");
                        cbxSubjects.Items.Add("FALAFR6");
                        cbxSubjects.Items.Add("FALENG6");
                        cbxSubjects.Items.Add("MTHS6");
                        cbxSubjects.Items.Add("NST6");
                        cbxSubjects.Items.Add("SS6");
                        cbxSubjects.Items.Add("LO6");
                        cbxSubjects.Items.Add("AC6");
                        break;
                    case 7:
                        cbxSubjects.Items.Add("HLAFR7");
                        cbxSubjects.Items.Add("HLENG7");
                        cbxSubjects.Items.Add("FALAFR7");
                        cbxSubjects.Items.Add("FALENG7");
                        cbxSubjects.Items.Add("MTHS7");
                        cbxSubjects.Items.Add("NS7");
                        cbxSubjects.Items.Add("TEC7");
                        cbxSubjects.Items.Add("SS7");
                        cbxSubjects.Items.Add("EMS7");
                        cbxSubjects.Items.Add("LO7");
                        cbxSubjects.Items.Add("AC7");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("An error has occured while trying to fill in subjects.", "Error");
            }
        }

        private void fillDGVStudents()
        {
            try
            {
                dgvStudentsList.DataSource = studentListTest;

                dgvStudentsList.Columns[0].HeaderText = "ID";
                dgvStudentsList.Columns[1].HeaderText = "First Name";
                dgvStudentsList.Columns[2].HeaderText = "Last Name";
                dgvStudentsList.Columns[3].HeaderText = "Grade";
                dgvStudentsList.Columns[4].HeaderText = "Gender";
                dgvStudentsList.Columns[5].HeaderText = "Parent Name";
                dgvStudentsList.Columns[6].HeaderText = "Cell Number";

                if (dgvStudentsList.Rows.Count > 16)
                {
                    dgvStudentsList.Columns[0].Width = 40;
                    dgvStudentsList.Columns[1].Width = 95;
                    dgvStudentsList.Columns[2].Width = 119;
                    dgvStudentsList.Columns[3].Width = 55;
                    dgvStudentsList.Columns[4].Width = 70;
                    dgvStudentsList.Columns[5].Width = 203;
                    dgvStudentsList.Columns[6].Width = 110;
                }
                else
                {
                    dgvStudentsList.Columns[0].Width = 40;
                    dgvStudentsList.Columns[1].Width = 100;
                    dgvStudentsList.Columns[2].Width = 124;
                    dgvStudentsList.Columns[3].Width = 55;
                    dgvStudentsList.Columns[4].Width = 70;
                    dgvStudentsList.Columns[5].Width = 210;
                    dgvStudentsList.Columns[6].Width = 110;
                }
            }
            catch
            {
                MessageBox.Show("An error has occured while trying to fill student datagridview.", "Error");
            }
        }

        private void cbxStudentsGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCBXStudentSubjects(cbxStudentsGrade, cbxStudentsSubject);
        }

        private void cbxStudentsSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDGVStudents();
        }

        private void cbStudentsAbsentee_CheckedChanged(object sender, EventArgs e)
        {
            fillDGVStudents();
        }

        private void cbStudentsTextbooks_CheckedChanged(object sender, EventArgs e)
        {
            fillDGVStudents();
        }

        private void cbxStudentsOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDGVStudents();
        }

        private void cbxStudentsOrderOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDGVStudents();
        }

        private void dgvStudentsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvStudentsList.Rows[e.RowIndex];

                //Selec
            }
        }

        private void btnStudentsBack_Click(object sender, EventArgs e)
        {
            pnlfrmMainmenu.Visible = true;
            pnlfrmStudents.Visible = false;
        }

        private void btnStudentsAdd_Click(object sender, EventArgs e)
        {
            pnlfrmAddstudent.Visible = true;
            pnlfrmStudents.Visible = false;
        }

        private void btnAddstudentClasses_Click(object sender, EventArgs e)
        {
            pnlfrmAddstudentclass.Visible = true;
            pnlfrmAddstudent.Visible = false;
        }

        private void btnAddstudentBack_Click(object sender, EventArgs e)
        {
            pnlfrmStudents.Visible = true;
            pnlfrmAddstudent.Visible = false;
        }

        private void btnAddstudentclass_Click(object sender, EventArgs e)
        {
            pnlfrmAddstudent.Visible = true;
            pnlfrmAddstudentclass.Visible = false;
        }

        private void btnStudentsMore_Click(object sender, EventArgs e)
        {
            pnlfrmEditstudent.Visible = true;
            pnlfrmStudents.Visible = false;
        }

        private void btnEditstudentClasses_Click(object sender, EventArgs e)
        {
            pnlfrmEditstudentclass.Visible = true;
            pnlfrmEditstudent.Visible = false;
        }

        private void btnEditstudentBack_Click(object sender, EventArgs e)
        {
            pnlfrmStudents.Visible = true;
            pnlfrmEditstudent.Visible = false;
        }

        private void btnEditstudentclassBack_Click(object sender, EventArgs e)
        {
            pnlfrmEditstudent.Visible = true;
            pnlfrmEditstudentclass.Visible = false;
        }

        private void btnStudentsRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this student?", "Warning");
        }
    }

    public class studentsTest
    {
        public int personID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int grade { get; set; }
        public string gender { get; set; }
        public string parentFullname { get; set; }
        public string parentNumber { get; set; }
    }

    public class addStudentClasses
    {
        public int classDay { get; set; }
        public int classPeriod { get; set; }
        public string classSubject { get; set; }
        public string classTeacher { get; set; }
    }
}
