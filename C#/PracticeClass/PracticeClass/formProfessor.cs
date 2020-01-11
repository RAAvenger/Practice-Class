using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeClass
{
    public partial class formProfessor : Form
    {
        List<ShowClass> onGoingClassesList = null;
        classProfessor thisProfessor = null;
        classPracticeClass thisPractisClass = null;
         classBase temp = new classBase();
        //false=Practice and quiz , true=Home
        bool isInHome = true;

        //0=Student view , 1=TA view
        public bool mode = false;
        List<ShowPractice> selectedClassPractice = null;
        List<ShowQuiz> selectedClassQuiz = null;
        List<ShowStudent> selectedClassStudents = null;
        int rowIndexTab1;
        int rowIndexTab2Practice;
        public formProfessor(string id, string pass)
        {
            InitializeComponent();



            //login the Professor
            thisProfessor = temp.LoginProfessor(id, pass);

            //disShow TA icon
            if (thisProfessor.GetAccessLevel() == 1)
                iconStudentToTa.Visible = false;
            else
                iconStudentToTa.Visible = true;

            onGoingClassesList = thisProfessor.GetProfessorOnGoingClassesList();

            if (onGoingClassesList.Count != 0)
            {
                dataGridViewTab1.Rows.Clear();
                dataGridViewTab1.RowCount = onGoingClassesList.Count;
                for (int i = 0; i < onGoingClassesList.Count; i++)
                {
                    dataGridViewTab1.Rows[i].Cells["Course"].Value = onGoingClassesList[i].nameCourse;
                    dataGridViewTab1.Rows[i].Cells["TA"].Value = onGoingClassesList[i].fullNameTA;
                    dataGridViewTab1.Rows[i].Cells["Professor"].Value = onGoingClassesList[i].fullNameProfessor;
                    dataGridViewTab1.Rows[i].Cells["Grade"].Value = onGoingClassesList[i].grade;
                }
            }
        }
        private void iconHome_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Home", iconHome);
        }

        private void iconSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Search", iconSearch);

        }


        private void iconProfile_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(thisProfessor.GetFullName() + "\n@" + thisProfessor.GetID(), iconProfile);
        }



        private void buttonTab1Archve_MouseEnter(object sender, EventArgs e)
        {
            classThem theme = new classThem();
            buttonTab1Archve.BackColor = theme.buttonIn;
        }

        private void buttonTab1Archve_MouseLeave(object sender, EventArgs e)
        {
            classThem theme = new classThem();
            buttonTab1Archve.BackColor = theme.buttonOut;
        }

        private void buttonTab1Archve_Click(object sender, EventArgs e)
        {
            dataGridViewTab1.Rows.Clear();
            if (buttonTab1Archve.Text == "Archive")
            {
                List<ShowClass> archiveClassesList = new List<ShowClass>();
                archiveClassesList = thisProfessor.GetProfessorArchivedClassesList();
                if (archiveClassesList.Count != 0)
                {
                    dataGridViewTab1.RowCount = archiveClassesList.Count;
                    for (int i = 0; i < archiveClassesList.Count; i++)
                    {
                        dataGridViewTab1.Rows[i].Cells["Course"].Value = archiveClassesList[i].nameCourse;
                        dataGridViewTab1.Rows[i].Cells["TA"].Value = archiveClassesList[i].fullNameTA;
                        dataGridViewTab1.Rows[i].Cells["Professor"].Value = archiveClassesList[i].fullNameProfessor;
                        dataGridViewTab1.Rows[i].Cells["Grade"].Value = archiveClassesList[i].grade;
                    }
                }

                buttonTab1Archve.Text = "Close Archive";
                labelTab1Title.Text = "Archive of classes";
            }
            else
            {
                List<ShowClass> onGoingClassesList = new List<ShowClass>();
                onGoingClassesList = thisProfessor.GetProfessorOnGoingClassesList();
                if (onGoingClassesList.Count != 0)
                {

                    dataGridViewTab1.RowCount = onGoingClassesList.Count;
                    for (int i = 0; i < onGoingClassesList.Count; i++)
                    {
                        dataGridViewTab1.Rows[i].Cells["Course"].Value = onGoingClassesList[i].nameCourse;
                        dataGridViewTab1.Rows[i].Cells["TA"].Value = onGoingClassesList[i].fullNameTA;
                        dataGridViewTab1.Rows[i].Cells["Professor"].Value = onGoingClassesList[i].fullNameProfessor;
                        dataGridViewTab1.Rows[i].Cells["Grade"].Value = onGoingClassesList[i].grade;
                    }
                }
                buttonTab1Archve.Text = "Archive";
                labelTab1Title.Text = "List of classes";
            }
        }




        private void dataGridViewTab1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (labelTab1Title.Text != "Archive")
            {


                rowIndexTab1 = dataGridViewTab1.CurrentRow.Index;
                labelTab1Title.Text = rowIndexTab1.ToString();
                {
                    //rename the title's of practice class page
                    labelTab2NameCourse.Text = onGoingClassesList[rowIndexTab1].nameCourse;
                    labelTab2NameProfessor.Text = onGoingClassesList[rowIndexTab1].fullNameProfessor;
                    labelTab2NameTa.Text = onGoingClassesList[rowIndexTab1].fullNameTA;

                    //make a list from practice that TA or professor uploaded
                    database_practiceclass db = new database_practiceclass();
                    thisPractisClass = new classPracticeClass(onGoingClassesList[rowIndexTab1].term,
                        onGoingClassesList[rowIndexTab1].year, onGoingClassesList[rowIndexTab1].groupNumber);
                    selectedClassPractice = new List<ShowPractice>();
                    selectedClassPractice = thisPractisClass.GetClassPracticeList();

                    //show the practice in it's GridView
                    dataGridViewTab2Practice.Rows.Clear();
                    if (selectedClassPractice.Count != 0)
                    {
                        dataGridViewTab2Practice.RowCount = selectedClassPractice.Count;
                        for (int i = 0; i < selectedClassPractice.Count; i++)
                        {
                            dataGridViewTab2Practice.Rows[i].Cells["Tab2NumberPractice"].Value = selectedClassPractice[i].number;
                            dataGridViewTab2Practice.Rows[i].Cells["Tab2PartPractice"].Value = selectedClassPractice[i].part;
                            //dataGridViewTab2Practice.Rows[i].Cells["tab2GradePractice"].Value = selectedClassPractice[i].;
                            dataGridViewTab2Practice.Rows[i].Cells["tab2UploadPractice"].Value =
                                global::PracticeClass.Properties.Resources.Icon_feather_upload_2x;
                            dataGridViewTab2Practice.Rows[i].Cells["tab2DownloadPractice"].Value =
                                global::PracticeClass.Properties.Resources.Icon_feather_download_2x;
                        }
                    }

                    //make data grid view for quiz
                    //selectedClassQuiz = thisPractisClass.GetClassQuizList();
                    //dataGridViewTab2Quiz.Rows.Clear();
                    //if (selectedClassPractice.Count != 0)
                    //{
                    //    dataGridViewTab2Quiz.RowCount = selectedClassQuiz.Count;
                    //    for (int i = 0; i < selectedClassPractice.Count; i++)
                    //    {
                    //        dataGridViewTab2Quiz.Rows[i].Cells["Tab2NumberPractice"].Value = selectedClassQuiz[i].number;
                    //        dataGridViewTab2Quiz.Rows[i].Cells["Tab2PartPractice"].Value = selectedClassQuiz[i].date;
                    //        // dataGridViewTab2Quiz.Rows[i].Cells["tab2UploadPractice"].Value = selectedClassQuiz[i].;
                    //    }
                    //}

                    //go to practice class page
                    tabControl1.SelectTab(tabPage2);
                    iconHome.Visible = true;

                }
            }
        }



        private void buttonTab3SaveNewPassword_MouseEnter(object sender, EventArgs e)
        {
            classThem theme = new classThem();
            buttonTab3SaveNewPassword.BackColor = theme.buttonIn;
        }



        private void buttonTab3SaveNewPassword_MouseLeave(object sender, EventArgs e)
        {
            classThem theme = new classThem();
            buttonTab4SaveNewPassword.BackColor = theme.buttonOut;
        }

        private void buttonTab3SaveNewPassword_Click(object sender, EventArgs e)
        {
            //Change the password for Professor
            classBase baseItem = new classBase();
            if (labelTab3TitleCurrentPassword.Text == labelTab3RepeatNewPassword.Text)
            {
                if (baseItem.EditUser("", "", labelTab3NewPass.Text) == 1)
                    MessageBox.Show("You changed the password successfuly.");
                else
                    MessageBox.Show("Somthing is false. try agin later.");

            }
        }

        private void labelTab2NameProfessor_Click(object sender, EventArgs e)
        {

        }

        private void buttonTab3SaveNewPassword_MouseEnter_1(object sender, EventArgs e)
        {
            classThem theme = new classThem();
            buttonTab3SaveNewPassword.BackColor = theme.buttonIn;
        }

        private void buttonTab3SaveNewPassword_MouseLeave_1(object sender, EventArgs e)
        {

            classThem theme = new classThem();
            buttonTab3SaveNewPassword.BackColor = theme.buttonOut;
        }

        private void dataGridViewTab2Practice_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if user pressed the download icon
            if (dataGridViewTab2Practice.CurrentCell.ColumnIndex == 2)
            {
                rowIndexTab2Practice = dataGridViewTab2Practice.CurrentCell.RowIndex;
                System.Diagnostics.Process.Start(selectedClassPractice[rowIndexTab2Practice].link);

            }
            else if (dataGridViewTab2Practice.CurrentCell.ColumnIndex == 3)
            {
                rowIndexTab2Practice = dataGridViewTab2Practice.CurrentCell.RowIndex;
                int temp = thisPractisClass.AddSolvedPractice(selectedClassPractice[rowIndexTab2Practice].number, (short)selectedClassPractice[rowIndexTab2Practice].part,
                    thisProfessor.GetID(), "");
                if (temp == 1)
                {

                }

                tabControl1.SelectTab(tabPage5);

            }
        }

        private void dataGridViewTab2Practice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconSetting_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
            labelTab3FullNameProfessor.Text = thisProfessor.GetFullName();
            labelTab3Id.Text = thisProfessor.GetID();
            bunifuMaterialTextboxTab3NewPassword.Text = bunifuMaterialTextboxTab3RepeatNewPassword.Text =
                buttonTab3SaveNewPassword.Text = "";
            iconHome.Visible = true;
        }

        private void iconHome_Click(object sender, EventArgs e)
        {
            iconHome.Visible = false;
            tabControl1.SelectTab(tabPage1);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to sign out?", "Sign out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                formLogin login = new formLogin();
                login.Show();
                this.Close();
            }

        }

        private void iconTab4BackArrow_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void labelTab2NameCourse_Click(object sender, EventArgs e)
        {
            //disply resourses of course
            classBase baseItem = new classBase();
            List<ShowResource> thisCourseResource = new List<ShowResource>();
            thisCourseResource = baseItem.GetCourseResourcesList(thisPractisClass.getIDCourse());
            dataGridViewTab4.Rows.Clear();
            if (thisCourseResource.Count != 0)
            {
                dataGridViewTab4.RowCount = thisCourseResource.Count;
                for (int i = 0; i < thisCourseResource.Count; i++)
                {
                    dataGridViewTab4.Rows[i].Cells[0].Value = thisCourseResource[i].numberResource;
                    dataGridViewTab4.Rows[i].Cells[1].Value = thisCourseResource[i].nameResource;
                    dataGridViewTab4.Rows[i].Cells[2].Value = thisCourseResource[i].linkResource;
                }

            }
            labelTab4nameCourse.Text = labelTab2NameCourse.Text;

            tabControl1.SelectTab(tabPage4);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
            bunifuMetroTextboxTab5LinkPractice.Text = "";
        }

        private void iconTab6BackArrow_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void iconTab5Send_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextboxTab5LinkPractice.Text == "")
                MessageBox.Show("Please first fill the field.");
            else
            {
                thisPractisClass.AddSolvedPractice(selectedClassPractice[rowIndexTab2Practice].number,
                     (short)selectedClassPractice[rowIndexTab2Practice].part,
                      thisProfessor.GetID(), bunifuMetroTextboxTab5LinkPractice.Text);
                MessageBox.Show("Upload done successfully.");
                labelTab6NumberPartPractice.Text = ("Practice " + selectedClassPractice[rowIndexTab2Practice].number.ToString()
                    + " Part " + selectedClassPractice[rowIndexTab2Practice].part.ToString());
                labelTab6Grade.Visible = false;
                labelTab6Date.Visible = false;
                iconTab6EditPractice.Visible = false;


            }
        }

        private void iconTab5Brows_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select A File";
            openDialog.Filter = "Text Files (*.txt)|*.txt" + "|" +
                                "Image Files (*.png;*.jpg)|*.png;*.jpg" + "|" +
                                "All Files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                bunifuMetroTextboxTab5LinkPractice.Text = openDialog.FileName;
            }
        }

        private void bunifuMaterialTextboxCurrentPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 9 || e.KeyChar == 13)
            {
                if (bunifuMaterialTextboxCurrentPassword.Text != "")
                {
                    bunifuMaterialTextboxTab3NewPassword.Focus();
                    e.Handled = true;
                }
            }
        }

        private void bunifuMaterialTextboxTab3NewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 9 || e.KeyChar == 13)
            {
                if (bunifuMaterialTextboxTab3NewPassword.Text != "")
                {
                    bunifuMaterialTextboxTab3RepeatNewPassword.Focus();
                    e.Handled = true;
                }
            }
        }

        private void bunifuMaterialTextboxTab3RepeatNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 9 || e.KeyChar == 13)
            {
                if (bunifuMaterialTextboxTab3RepeatNewPassword.Text != "")
                {
                    buttonTab4SaveNewPassword.Focus();
                    e.Handled = true;
                }
            }
        }


        private void AddClass_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AddClass_courseLable.Visible =
            AddClass_courseTextbox.Visible =
            AddClass_professorLable.Visible =
            AddClass_ProfessorName.Visible =
            AddClass_submitButt.Visible =
            AddClass_TALable.Visible =
            AddClass_TATextbox.Visible =
            addClass_warningLbl.Visible = AddClass_CheckBox.Checked;
        }

        private void AddClass_submitButt_Click(object sender, EventArgs e)
        {
            addClass_warningLbl.Visible = false;
            if (AddClass_TATextbox.Text != "" && AddClass_courseTextbox.Text != "")
            {
                classBase tempbase = new classBase();
                int result = tempbase.AddNewPracticeClass(AddClass_courseTextbox.Text, AddClass_courseTextbox.Text, tempbase.get_numberyear(), tempbase.get_term());

                switch (result)
                {
                    case 1:

                        if (buttonTab1Archve.Text != "Archive")
                        {
                            dataGridViewTab1.Rows.Clear();
                            List<ShowClass> onGoingClassesList = new List<ShowClass>();
                            onGoingClassesList = thisProfessor.GetProfessorOnGoingClassesList();
                            if (onGoingClassesList.Count != 0)
                            {

                                dataGridViewTab1.RowCount = onGoingClassesList.Count;
                                for (int i = 0; i < onGoingClassesList.Count; i++)
                                {
                                    dataGridViewTab1.Rows[i].Cells["Course"].Value = onGoingClassesList[i].nameCourse;
                                    dataGridViewTab1.Rows[i].Cells["TA"].Value = onGoingClassesList[i].fullNameTA;
                                    dataGridViewTab1.Rows[i].Cells["Professor"].Value = onGoingClassesList[i].fullNameProfessor;
                                    dataGridViewTab1.Rows[i].Cells["Grade"].Value = onGoingClassesList[i].grade;
                                }
                            }
                        }

                        break;
                    case -2:
                        AddStudent_warningLbl.Text = "access violation";
                        AddStudent_warningLbl.Visible = true;
                        break;
                    case -3:
                        AddStudent_warningLbl.Text = "wrong course";
                        AddStudent_warningLbl.Visible = true;
                        break;
                    case -4:
                        AddStudent_warningLbl.Text = "wrong idTA";
                        AddStudent_warningLbl.Visible = true;
                        break;
                    case -1:
                        AddStudent_warningLbl.Text = "general error";
                        AddStudent_warningLbl.Visible = true;
                        break;
                }
            }
            else
            {
                AddStudent_warningLbl.Text = "Required Input";
                AddStudent_warningLbl.Visible = true;
            }
        }

        private void goto_Student_Btn_Click(object sender, EventArgs e)
        {


            {
                //rename the title's of practice class page
                Tab7_nameCourseLable.Text = onGoingClassesList[rowIndexTab1].nameCourse;
                Tab7_ProfessorLable.Text = onGoingClassesList[rowIndexTab1].fullNameProfessor;
                Tab7_TALable.Text = onGoingClassesList[rowIndexTab1].fullNameTA;

                //make a list from practice that TA or professor uploaded
                database_practiceclass db = new database_practiceclass();
                thisPractisClass = new classPracticeClass(onGoingClassesList[rowIndexTab1].term,
                    onGoingClassesList[rowIndexTab1].year, onGoingClassesList[rowIndexTab1].groupNumber);

                selectedClassStudents = new List<ShowStudent>();
                selectedClassStudents = thisPractisClass.GetClassStudentList();


                //------------------------------------------------------------------------------------------------------------------------

                //show the students in it's GridView
                dataGridView_StudentList.Rows.Clear();
                if (selectedClassStudents.Count != 0)
                {
                    dataGridView_StudentList.RowCount = selectedClassStudents.Count;
                    for (int i = 0; i < selectedClassStudents.Count; i++)
                    {
                        dataGridView_StudentList.Rows[i].Cells["StudentID"].Value = selectedClassStudents[i].id;
                        dataGridView_StudentList.Rows[i].Cells["StudentName"].Value = selectedClassStudents[i].fullName;
                    }
                }

                //go to practice class page
                tabControl1.SelectTab(tabPage7);
                iconHome.Visible = true;

            }
        }

        private void AddStudent_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            AddStudent_stdID_TextBox.Visible =
               AddStudent_studentIdLbl.Visible =
               AddStudent_submitBtn.Visible =
               AddStudent_warningLbl.Visible = AddStudent_checkBox.Checked;
        }

        private void AddStudent_submitBtn_Click(object sender, EventArgs e)
        {

            AddStudent_warningLbl.Visible = false;
            if (AddStudent_stdID_TextBox.Text != "")
            {
                //"-2" means "wrong idStudent", "-3" means "idStudent = idTA", "-4" means "student_class relation already exists and not deleted", "-1" means "general error" and "1" means "done"

                classBase tempbase = new classBase();
                int result = thisPractisClass.AddStudentToClass(AddStudent_stdID_TextBox.Text);
                switch (result)
                {
                    case 1:

                        selectedClassStudents = thisPractisClass.GetClassStudentList();

                        //show the students in it's GridView
                        dataGridView_StudentList.Rows.Clear();
                        if (selectedClassStudents.Count != 0)
                        {
                            dataGridView_StudentList.RowCount = selectedClassStudents.Count;
                            for (int i = 0; i < selectedClassStudents.Count; i++)
                            {
                                dataGridView_StudentList.Rows[i].Cells["StudentID"].Value = selectedClassStudents[i].id;
                                dataGridView_StudentList.Rows[i].Cells["StudentName"].Value = selectedClassStudents[i].fullName;
                            }
                        }
                        AddStudent_stdID_TextBox.Text = "";

                        break;
                    case -2:
                        AddStudent_warningLbl.Text = "wrong idStudent";
                        AddStudent_warningLbl.Visible = true;
                        break;
                    case -3:
                        AddStudent_warningLbl.Text = "idStudent = idTA";
                        AddStudent_warningLbl.Visible = true;
                        break;
                    case -4:
                        AddStudent_warningLbl.Text = "student_class relation already exists and not deleted";
                        AddStudent_warningLbl.Visible = true;
                        break;
                    case -1:
                        AddStudent_warningLbl.Text = "general error";
                        AddStudent_warningLbl.Visible = true;
                        break;
                }
            }
            else
            {
                AddStudent_warningLbl.Text = "Required Input";
                AddStudent_warningLbl.Visible = true;
            }
        }
    }
}
