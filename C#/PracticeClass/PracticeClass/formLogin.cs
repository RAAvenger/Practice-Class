using System;
using System.Windows.Forms;

namespace PracticeClass {
    public partial class formLogin : Form {
        public string id = "";
        public string pass = "";
        public MainWindow mainWindow;

        classBase temp = new classBase();


        public formLogin() {
            InitializeComponent();
            itemColor();


            textBoxPassword.Text = "";
            textBoxId.Text = "";
        }

        private void formLogin_Load(object sender, EventArgs e)
        {


            textBoxPassword.Text = "";
            textBoxId.Text = "";
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            id = textBoxId.Text;
            pass = textBoxPassword.Text;
            if (radioButtonStudent.Checked == true) {
                classStudent accountStudent = null;
                accountStudent = temp.LoginStudent(id, pass);
                if (accountStudent != null)
                {
                    formStudent formForStudent = new formStudent(id, pass);
                    formForStudent.Show();
                    this.Close();

                }
                else {
                    MessageBox.Show("Username or password is wrong!");
                    textBoxId.Text = "";
                    textBoxPassword.Text = "";
                }
            }
        }


        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {

            classThem theme = new classThem();
            buttonLogin.BackColor = theme.buttonIn;
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {

            classThem theme = new classThem();
            buttonLogin.BackColor = theme.buttonOut;
        }


        private void textBoxId_MouseHover(object sender, EventArgs e)
        {

            if (textBoxId.Text == "")
                toolTip1.Show("Enter your id here.", textBoxId);
        }

        private void textBoxPassword_MouseHover(object sender, EventArgs e)
        {

            if (textBoxPassword.Text == "")
                toolTip1.Show("Enter your password here.", textBoxPassword);
        }


        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 9 || e.KeyChar == 13) {
                if (textBoxId.Text != "") {

                    textBoxPassword.Focus();
                    e.Handled = true;
                }
            }
        }


        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 9 || e.KeyChar == 13) {
                if (textBoxPassword.Text != "") {

                    buttonLogin.Focus();
                    e.Handled = true;
                }
            }
        }

        private void formLogin_FormClosed(object sender, FormClosedEventArgs e) {
            mainWindow.Close();
        }

    }
}
