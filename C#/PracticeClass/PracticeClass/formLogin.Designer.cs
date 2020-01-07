namespace PracticeClass {
    partial class formLogin {
        /// <summary>
        /// 
        /// 
        public void itemColor() {
            classThem them = new classThem();
            lblId.ForeColor = lblPassword.ForeColor = textBoxId.ForeColor = textBoxPassword.ForeColor = them.mainText;
            buttonLogin.ForeColor = them.row;
            buttonLogin.BackColor = them.buttonOut;
            radioButtonProfessor.ForeColor = radioButtonStudent.ForeColor = them.mainText;

        }
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {

            this.components = new System.ComponentModel.Container();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonProfessor = new System.Windows.Forms.RadioButton();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblId.Location = new System.Drawing.Point(362, 255);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 19);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.Location = new System.Drawing.Point(362, 318);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 19);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonStudent.Location = new System.Drawing.Point(365, 378);
            this.radioButtonStudent.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(62, 17);
            this.radioButtonStudent.TabIndex = 4;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UseVisualStyleBackColor = false;
            // 
            // radioButtonProfessor
            // 
            this.radioButtonProfessor.AutoSize = true;
            this.radioButtonProfessor.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonProfessor.Location = new System.Drawing.Point(365, 400);
            this.radioButtonProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonProfessor.Name = "radioButtonProfessor";
            this.radioButtonProfessor.Size = new System.Drawing.Size(69, 17);
            this.radioButtonProfessor.TabIndex = 5;
            this.radioButtonProfessor.TabStop = true;
            this.radioButtonProfessor.Text = "Professor";
            this.radioButtonProfessor.UseVisualStyleBackColor = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(441, 437);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(74, 26);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Sign in";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            this.buttonLogin.MouseEnter += new System.EventHandler(this.buttonLogin_MouseEnter);
            this.buttonLogin.MouseLeave += new System.EventHandler(this.buttonLogin_MouseLeave);
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.textBoxId.Location = new System.Drawing.Point(365, 276);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(229, 25);
            this.textBoxId.TabIndex = 7;
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
            this.textBoxId.MouseHover += new System.EventHandler(this.textBoxId_MouseHover);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.textBoxPassword.Location = new System.Drawing.Point(365, 340);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.MaxLength = 60;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(229, 25);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            this.textBoxPassword.MouseHover += new System.EventHandler(this.textBoxPassword_MouseHover);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PracticeClass.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 612);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.radioButtonProfessor);
            this.Controls.Add(this.radioButtonStudent);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblId);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;

            this.Margin = new System.Windows.Forms.Padding(2);

            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.RadioButton radioButtonProfessor;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}