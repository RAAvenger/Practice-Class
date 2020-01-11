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
    public partial class formStudent : Form
    {
        classStudent thisStudent = null;
        classPracticeClass thisPractisClass = null;
        classBase temp = new classBase();
        //false=Practice and quiz , true=Home
        bool isInHome = true;

        //0=Student view , 1=TA view
        public bool mode = false;
        List<ShowClass> onGoingClassesList = null;
        List<ShowPractice> selectedClassPractice = null;
        List<ShowQuiz> selectedClassQuiz = null;
        int rowIndexTab1;
        int rowIndexTab2Practice;

        public formStudent(string id, string pass)
        {
            InitializeComponent();
            itemColor();
            //login the student
            thisStudent = temp.LoginStudent(id, pass);

            //disShow TA icon
            if (thisStudent.GetAccessLevel() == 1)
                iconStudentToTa.Visible = false;
            else
                iconStudentToTa.Visible = true;

            if (mode == false)
            {
                //in a simple student mode

                //sorted by professor name
                onGoingClassesList =
                    thisStudent.GetStudentOnGoingClassesList();

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

        }

        private void iconHome_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Home", iconHome);
        }

        private void iconSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Search", iconSearch);

        }

        private void iconStudentToTa_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Go to TA mode!", iconStudentToTa);

        }

        private void iconProfile_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(thisStudent.GetFullName() + "\n@" + thisStudent.GetID(), iconProfile);
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
                archiveClassesList = thisStudent.GetStudentArchivedClassesList();
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




        private void buttonTab4SaveNewPassword_Click(object sender, EventArgs e)
        {

        }



        private void dataGridViewTab1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTab1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (labelTab1Title.Text != "Archive")
            {


                rowIndexTab1 = dataGridViewTab1.CurrentRow.Index;
                {
                    //rename the title's of practice class page
                    labelTab2NameCourse.Text = onGoingClassesList[rowIndexTab1].nameCourse;
                    labelTab2NameProfessor.Text = onGoingClassesList[rowIndexTab1].fullNameProfessor;
                    labelTab2NameTa.Text = onGoingClassesList[rowIndexTab1].fullNameTA;

                    //make a list from practice that TA or professor uploaded
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
                    selectedClassQuiz = thisPractisClass.GetClassQuizList();
                    dataGridViewTab2Quiz.Rows.Clear();
                    if (selectedClassPractice.Count != 0)
                    {
                        dataGridViewTab2Quiz.RowCount = selectedClassQuiz.Count;
                        for (int i = 0; i < selectedClassPractice.Count; i++)
                        {
                            dataGridViewTab2Quiz.Rows[i].Cells["tab2NumberQuiz"].Value = selectedClassQuiz[i].number;
                            dataGridViewTab2Quiz.Rows[i].Cells["tab2DateQuiz"].Value = selectedClassQuiz[i].date;
                            // dataGridViewTab2Quiz.Rows[i].Cells["tab2UploadPractice"].Value = selectedClassQuiz[i].;
                        }
                    }

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
            //Change the password for student
            classBase baseItem = new classBase();
            if (bunifuMaterialTextboxTab3NewPassword.Text == bunifuMaterialTextboxTab3RepeatNewPassword.Text)
            {
                if (baseItem.EditUser("", "", bunifuMaterialTextboxTab3NewPassword.Text) == 1)
                    MessageBox.Show("You changed the password successfuly.");
                else
                    MessageBox.Show("Somthing is false. try agin later.");

            }
            else
                MessageBox.Show("Please enter correct information.");

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
                if (selectedClassPractice[rowIndexTab2Practice].link != null)
                    System.Diagnostics.Process.Start(selectedClassPractice[rowIndexTab2Practice].link);

            }
            else if (dataGridViewTab2Practice.CurrentCell.ColumnIndex == 3)
            {
                rowIndexTab2Practice = dataGridViewTab2Practice.CurrentCell.RowIndex;
                int temp = thisPractisClass.AddSolvedPractice(selectedClassPractice[rowIndexTab2Practice].number, (short)selectedClassPractice[rowIndexTab2Practice].part,
                    thisStudent.GetID(), "");
                labelTab5NumberPractice.Text = "Pactice Number " +
                    selectedClassPractice[rowIndexTab2Practice].number.ToString() +
                    " Part " + selectedClassPractice[rowIndexTab2Practice].part.ToString();
                tabControl1.SelectTab(tabPage5);

            }
        }

        private void dataGridViewTab2Practice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconSetting_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
            labelTab3FullNameStudent.Text = thisStudent.GetFullName();
            labelTab3Id.Text = thisStudent.GetID();
            bunifuMaterialTextboxTab3NewPassword.Text = bunifuMaterialTextboxTab3RepeatNewPassword.Text = "";
                
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
                int temp = thisPractisClass.AddSolvedPractice(selectedClassPractice[rowIndexTab2Practice].number,
                      (short)selectedClassPractice[rowIndexTab2Practice].part,
                      thisStudent.GetID(), bunifuMetroTextboxTab5LinkPractice.Text);
                if (temp == -4)
                {
                    MessageBox.Show("You had a practice for time ago.");
                }
                else if (temp == -3 || temp == -2)
                    MessageBox.Show("There is a mistake. please try again.");
                else
                    MessageBox.Show("Upload done successfully.");
                bunifuMetroTextboxTab5LinkPractice.Text = "";
                tabControl1.SelectTab(tabPage2);
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

        private void labelTab4nameCourse_Click(object sender, EventArgs e)
        {

        }
    }
}
