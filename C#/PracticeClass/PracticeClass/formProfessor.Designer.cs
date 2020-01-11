namespace PracticeClass
{
    partial class formProfessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public void itemColor()
        {
            classThem them = new classThem();
            panelSideMenu.BackColor = them.sideMenuBack;
            BackColor = this.tabPage1.BackColor = this.tabPage2.BackColor = them.background;
            tabPage1.ForeColor = this.tabPage2.ForeColor = them.background;
            labelTab1Title.ForeColor = labelTab2Pracitce.ForeColor = labelTab2Quiz.ForeColor = them.mainText;
            labelTab2NameCourse.ForeColor = labelTab2NameProfessor.ForeColor
                 = labelTab2NameTa.ForeColor = them.mainText;

            //dataGridViewTab1;
            dataGridViewTab1.RowHeadersVisible = false;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 =
                new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = them.background;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = them.mainText;
            dataGridViewTab1.RowsDefaultCellStyle.ForeColor = them.mainText;
            dataGridViewTab1.BackgroundColor = them.row;
            dataGridViewTab1.ForeColor = System.Drawing.Color.Black;
            dataGridViewTab1.DefaultCellStyle.ForeColor = them.mainText;
            dataGridViewTab1.DefaultCellStyle.SelectionForeColor = them.row;
            dataGridViewTab1.DefaultCellStyle.SelectionBackColor = them.unmainText;
            dataGridViewTab1.GridColor = them.unmainText;
            dataGridViewTab1.ColumnHeadersDefaultCellStyle.ForeColor = them.row;
            dataGridViewTab1.ColumnHeadersDefaultCellStyle.BackColor = them.mainText;

            //dataGridView tab2 practice
            dataGridViewTab2Practice.RowsDefaultCellStyle.ForeColor = them.mainText;
            dataGridViewTab2Practice.BackgroundColor = them.row;
            dataGridViewTab2Practice.ForeColor = System.Drawing.Color.Black;
            dataGridViewTab2Practice.DefaultCellStyle.ForeColor = them.mainText;
            dataGridViewTab2Practice.DefaultCellStyle.SelectionForeColor = them.row;
            dataGridViewTab2Practice.DefaultCellStyle.SelectionBackColor = them.unmainText;
            dataGridViewTab2Practice.GridColor = them.unmainText;
            dataGridViewTab2Practice.ColumnHeadersDefaultCellStyle.ForeColor = them.row;
            dataGridViewTab2Practice.ColumnHeadersDefaultCellStyle.BackColor = them.mainText;

            //dataGridView tab2 quiz
            dataGridViewTab2Quiz.RowsDefaultCellStyle.ForeColor = them.mainText;
            dataGridViewTab2Quiz.BackgroundColor = them.row;
            dataGridViewTab2Quiz.ForeColor = System.Drawing.Color.Black;
            dataGridViewTab2Quiz.DefaultCellStyle.ForeColor = them.mainText;
            dataGridViewTab2Quiz.DefaultCellStyle.SelectionForeColor = them.row;
            dataGridViewTab2Quiz.DefaultCellStyle.SelectionBackColor = them.unmainText;
            dataGridViewTab2Quiz.GridColor = them.unmainText;
            dataGridViewTab2Quiz.ColumnHeadersDefaultCellStyle.ForeColor = them.row;
            dataGridViewTab2Quiz.ColumnHeadersDefaultCellStyle.BackColor = them.mainText;

            //dataGridView Tab 4
            dataGridViewTab4.RowsDefaultCellStyle.ForeColor = them.mainText;
            dataGridViewTab4.BackgroundColor = them.row;
            dataGridViewTab4.ForeColor = System.Drawing.Color.Black;
            dataGridViewTab4.DefaultCellStyle.ForeColor = them.mainText;
            dataGridViewTab4.DefaultCellStyle.SelectionForeColor = them.row;
            dataGridViewTab4.DefaultCellStyle.SelectionBackColor = them.unmainText;
            dataGridViewTab4.GridColor = them.unmainText;
            dataGridViewTab4.ColumnHeadersDefaultCellStyle.ForeColor = them.row;
            dataGridViewTab4.ColumnHeadersDefaultCellStyle.BackColor = them.mainText;

            //page 4
            labelTab4nameCourse.ForeColor = them.mainText;
            panel4.BackColor = them.sideMenuBack;


            tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            panelTab2InfoClass.BackColor = them.row;
            buttonTab4SaveNewPassword.BackColor =
            buttonTab1Archve.BackColor = them.buttonOut;
            buttonTab4SaveNewPassword.ForeColor =
            buttonTab1Archve.ForeColor = them.row;

            tabPage1.BackColor = them.background;
            tabPage2.BackColor = them.background;
            tabPage3.BackColor = them.background;
            tabPage4.BackColor = them.background;
            tabPage5.BackColor = them.background;
            tabPage6.BackColor = them.background;
            //page 3
            bunifuMaterialTextboxTab3NewPassword.ForeColor = bunifuMaterialTextboxTab3RepeatNewPassword.ForeColor =
                labelTab3FullNameProfessor.ForeColor = labelTab3Id.ForeColor = labelTab3Title.ForeColor =
                labelTab3TitleCurrentPassword.ForeColor = labelTab3NewPass.ForeColor = label2.ForeColor =
                label3.ForeColor = bunifuMaterialTextboxCurrentPassword.ForeColor = them.mainText;

            buttonTab3SaveNewPassword.ForeColor = panel2.BackColor = panel1.BackColor = them.row;
            buttonTab3SaveNewPassword.BackColor = them.mainText;
            panel3.BackColor = them.sideMenuBack;
            tabPage3.BackColor = them.background;



            //page 5
            labelTab5NumberPractice.ForeColor = them.mainText;
            bunifuMetroTextboxTab5LinkPractice.ForeColor = them.mainText;

            //page 6
            labelTab6Date.ForeColor = labelTab6Grade.ForeColor = labelTab6NumberPartPractice.ForeColor = them.mainText;

        }

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.iconSetting = new System.Windows.Forms.PictureBox();
            this.iconProfile = new System.Windows.Forms.PictureBox();
            this.iconSearch = new System.Windows.Forms.PictureBox();
            this.iconStudentToTa = new System.Windows.Forms.PictureBox();
            this.iconHome = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addClass_warningLbl = new System.Windows.Forms.Label();
            this.AddClass_CheckBox = new System.Windows.Forms.CheckBox();
            this.AddClassLable = new System.Windows.Forms.Label();
            this.AddClass_submitButt = new System.Windows.Forms.Button();
            this.AddClass_ProfessorName = new System.Windows.Forms.Label();
            this.AddClass_TALable = new System.Windows.Forms.Label();
            this.AddClass_TATextbox = new System.Windows.Forms.TextBox();
            this.AddClass_professorLable = new System.Windows.Forms.Label();
            this.AddClass_courseLable = new System.Windows.Forms.Label();
            this.AddClass_courseTextbox = new System.Windows.Forms.TextBox();
            this.dataGridViewTab1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTab1Archve = new System.Windows.Forms.Button();
            this.labelTab1Title = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.goto_Student_Btn = new System.Windows.Forms.Button();
            this.dataGridViewTab2Quiz = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.tab2NumberQuiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab2DateQuiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTab2Practice = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Tab2PartPractice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tab2NumberPractice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab2DownloadPractice = new System.Windows.Forms.DataGridViewImageColumn();
            this.tab2UploadPractice = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelTab2InfoClass = new System.Windows.Forms.Panel();
            this.labelTab2NameTa = new System.Windows.Forms.Label();
            this.labelTab2NameProfessor = new System.Windows.Forms.Label();
            this.labelTab2NameCourse = new System.Windows.Forms.Label();
            this.labelTab2Quiz = new System.Windows.Forms.Label();
            this.labelTab2Pracitce = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonTab3SaveNewPassword = new System.Windows.Forms.Button();
            this.labelTab3Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuMaterialTextboxTab3RepeatNewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelTab3RepeatNewPassword = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxTab3NewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelTab3NewPass = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxCurrentPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelTab3TitleCurrentPassword = new System.Windows.Forms.Label();
            this.labelTab3Id = new System.Windows.Forms.Label();
            this.labelTab3FullNameProfessor = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconTab4BackArrow = new System.Windows.Forms.PictureBox();
            this.labelTab4nameCourse = new System.Windows.Forms.Label();
            this.dataGridViewTab4 = new System.Windows.Forms.DataGridView();
            this.numberResource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameResource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkResourse = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panelTab5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTab5NumberPractice = new System.Windows.Forms.Label();
            this.bunifuMetroTextboxTab5LinkPractice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.iconTab5Send = new System.Windows.Forms.PictureBox();
            this.iconTab5Brows = new System.Windows.Forms.PictureBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconTab6EditPractice = new System.Windows.Forms.PictureBox();
            this.iconTab6BackArrow = new System.Windows.Forms.PictureBox();
            this.labelTab6Grade = new System.Windows.Forms.Label();
            this.labelTab6NumberPartPractice = new System.Windows.Forms.Label();
            this.labelTab6Date = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.AddStudent_warningLbl = new System.Windows.Forms.Label();
            this.AddStudent_checkBox = new System.Windows.Forms.CheckBox();
            this.AddStudent_lable = new System.Windows.Forms.Label();
            this.AddStudent_submitBtn = new System.Windows.Forms.Button();
            this.AddStudent_studentIdLbl = new System.Windows.Forms.Label();
            this.AddStudent_stdID_TextBox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Tab7_TALable = new System.Windows.Forms.Label();
            this.Tab7_ProfessorLable = new System.Windows.Forms.Label();
            this.Tab7_nameCourseLable = new System.Windows.Forms.Label();
            this.dataGridView_StudentList = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxTab4PreviewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxTab4NewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxTab4ReapeatNewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonTab4SaveNewPassword = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStudentToTa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTab1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTab2Quiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTab2Practice)).BeginInit();
            this.panelTab2InfoClass.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTab4BackArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTab4)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panelTab5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTab5Send)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTab5Brows)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTab6EditPractice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTab6BackArrow)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSideMenu.Controls.Add(this.iconSetting);
            this.panelSideMenu.Controls.Add(this.iconProfile);
            this.panelSideMenu.Controls.Add(this.iconSearch);
            this.panelSideMenu.Controls.Add(this.iconStudentToTa);
            this.panelSideMenu.Controls.Add(this.iconHome);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(64, 753);
            this.panelSideMenu.TabIndex = 0;
            // 
            // iconSetting
            // 
            this.iconSetting.Image = global::PracticeClass.Properties.Resources.Icon_ionic_ios_settings_2x;
            this.iconSetting.Location = new System.Drawing.Point(12, 673);
            this.iconSetting.Name = "iconSetting";
            this.iconSetting.Size = new System.Drawing.Size(40, 38);
            this.iconSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconSetting.TabIndex = 6;
            this.iconSetting.TabStop = false;
            this.iconSetting.Click += new System.EventHandler(this.iconSetting_Click);
            // 
            // iconProfile
            // 
            this.iconProfile.Image = global::PracticeClass.Properties.Resources.Icon_material_account_circle_2x;
            this.iconProfile.Location = new System.Drawing.Point(12, 629);
            this.iconProfile.Name = "iconProfile";
            this.iconProfile.Size = new System.Drawing.Size(40, 38);
            this.iconProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconProfile.TabIndex = 5;
            this.iconProfile.TabStop = false;
            this.iconProfile.MouseHover += new System.EventHandler(this.iconProfile_MouseHover);
            // 
            // iconSearch
            // 
            this.iconSearch.Image = global::PracticeClass.Properties.Resources.Search_2x;
            this.iconSearch.Location = new System.Drawing.Point(12, 88);
            this.iconSearch.Name = "iconSearch";
            this.iconSearch.Size = new System.Drawing.Size(40, 38);
            this.iconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconSearch.TabIndex = 4;
            this.iconSearch.TabStop = false;
            this.iconSearch.MouseHover += new System.EventHandler(this.iconSearch_MouseHover);
            // 
            // iconStudentToTa
            // 
            this.iconStudentToTa.Image = global::PracticeClass.Properties.Resources.education_2;
            this.iconStudentToTa.Location = new System.Drawing.Point(12, 585);
            this.iconStudentToTa.Name = "iconStudentToTa";
            this.iconStudentToTa.Size = new System.Drawing.Size(40, 38);
            this.iconStudentToTa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconStudentToTa.TabIndex = 3;
            this.iconStudentToTa.TabStop = false;
            this.iconStudentToTa.Visible = false;
            // 
            // iconHome
            // 
            this.iconHome.Image = global::PracticeClass.Properties.Resources.Icon_home_2x;
            this.iconHome.Location = new System.Drawing.Point(12, 44);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(40, 38);
            this.iconHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconHome.TabIndex = 2;
            this.iconHome.TabStop = false;
            this.iconHome.Visible = false;
            this.iconHome.Click += new System.EventHandler(this.iconHome_Click);
            this.iconHome.MouseHover += new System.EventHandler(this.iconHome_MouseHover);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(58, -8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1227, 761);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.addClass_warningLbl);
            this.tabPage1.Controls.Add(this.AddClass_CheckBox);
            this.tabPage1.Controls.Add(this.AddClassLable);
            this.tabPage1.Controls.Add(this.AddClass_submitButt);
            this.tabPage1.Controls.Add(this.AddClass_ProfessorName);
            this.tabPage1.Controls.Add(this.AddClass_TALable);
            this.tabPage1.Controls.Add(this.AddClass_TATextbox);
            this.tabPage1.Controls.Add(this.AddClass_professorLable);
            this.tabPage1.Controls.Add(this.AddClass_courseLable);
            this.tabPage1.Controls.Add(this.AddClass_courseTextbox);
            this.tabPage1.Controls.Add(this.dataGridViewTab1);
            this.tabPage1.Controls.Add(this.buttonTab1Archve);
            this.tabPage1.Controls.Add(this.labelTab1Title);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1219, 752);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // addClass_warningLbl
            // 
            this.addClass_warningLbl.AutoSize = true;
            this.addClass_warningLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClass_warningLbl.ForeColor = System.Drawing.Color.Red;
            this.addClass_warningLbl.Location = new System.Drawing.Point(863, 668);
            this.addClass_warningLbl.Name = "addClass_warningLbl";
            this.addClass_warningLbl.Size = new System.Drawing.Size(107, 32);
            this.addClass_warningLbl.TabIndex = 17;
            this.addClass_warningLbl.Text = "Warning";
            this.addClass_warningLbl.Visible = false;
            // 
            // AddClass_CheckBox
            // 
            this.AddClass_CheckBox.AutoSize = true;
            this.AddClass_CheckBox.Location = new System.Drawing.Point(990, 636);
            this.AddClass_CheckBox.Name = "AddClass_CheckBox";
            this.AddClass_CheckBox.Size = new System.Drawing.Size(18, 17);
            this.AddClass_CheckBox.TabIndex = 16;
            this.AddClass_CheckBox.UseVisualStyleBackColor = true;
            this.AddClass_CheckBox.CheckedChanged += new System.EventHandler(this.AddClass_CheckBox_CheckedChanged);
            // 
            // AddClassLable
            // 
            this.AddClassLable.AutoSize = true;
            this.AddClassLable.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClassLable.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.AddClassLable.Location = new System.Drawing.Point(863, 626);
            this.AddClassLable.Name = "AddClassLable";
            this.AddClassLable.Size = new System.Drawing.Size(120, 32);
            this.AddClassLable.TabIndex = 15;
            this.AddClassLable.Text = "Add Class";
            // 
            // AddClass_submitButt
            // 
            this.AddClass_submitButt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClass_submitButt.Location = new System.Drawing.Point(659, 648);
            this.AddClass_submitButt.Name = "AddClass_submitButt";
            this.AddClass_submitButt.Size = new System.Drawing.Size(133, 36);
            this.AddClass_submitButt.TabIndex = 14;
            this.AddClass_submitButt.Text = "Submit";
            this.AddClass_submitButt.UseVisualStyleBackColor = true;
            this.AddClass_submitButt.Visible = false;
            this.AddClass_submitButt.Click += new System.EventHandler(this.AddClass_submitButt_Click);
            // 
            // AddClass_ProfessorName
            // 
            this.AddClass_ProfessorName.AutoSize = true;
            this.AddClass_ProfessorName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClass_ProfessorName.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.AddClass_ProfessorName.Location = new System.Drawing.Point(263, 668);
            this.AddClass_ProfessorName.Name = "AddClass_ProfessorName";
            this.AddClass_ProfessorName.Size = new System.Drawing.Size(180, 32);
            this.AddClass_ProfessorName.TabIndex = 13;
            this.AddClass_ProfessorName.Text = "Professor name";
            this.AddClass_ProfessorName.Visible = false;
            // 
            // AddClass_TALable
            // 
            this.AddClass_TALable.AutoSize = true;
            this.AddClass_TALable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClass_TALable.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.AddClass_TALable.Location = new System.Drawing.Point(460, 626);
            this.AddClass_TALable.Name = "AddClass_TALable";
            this.AddClass_TALable.Size = new System.Drawing.Size(48, 32);
            this.AddClass_TALable.TabIndex = 10;
            this.AddClass_TALable.Text = "TA ";
            this.AddClass_TALable.Visible = false;
            // 
            // AddClass_TATextbox
            // 
            this.AddClass_TATextbox.Location = new System.Drawing.Point(466, 670);
            this.AddClass_TATextbox.Multiline = true;
            this.AddClass_TATextbox.Name = "AddClass_TATextbox";
            this.AddClass_TATextbox.Size = new System.Drawing.Size(133, 30);
            this.AddClass_TATextbox.TabIndex = 9;
            this.AddClass_TATextbox.Visible = false;
            // 
            // AddClass_professorLable
            // 
            this.AddClass_professorLable.AutoSize = true;
            this.AddClass_professorLable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClass_professorLable.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.AddClass_professorLable.Location = new System.Drawing.Point(263, 626);
            this.AddClass_professorLable.Name = "AddClass_professorLable";
            this.AddClass_professorLable.Size = new System.Drawing.Size(120, 32);
            this.AddClass_professorLable.TabIndex = 8;
            this.AddClass_professorLable.Text = "Professor ";
            this.AddClass_professorLable.Visible = false;
            // 
            // AddClass_courseLable
            // 
            this.AddClass_courseLable.AutoSize = true;
            this.AddClass_courseLable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClass_courseLable.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.AddClass_courseLable.Location = new System.Drawing.Point(57, 626);
            this.AddClass_courseLable.Name = "AddClass_courseLable";
            this.AddClass_courseLable.Size = new System.Drawing.Size(89, 32);
            this.AddClass_courseLable.TabIndex = 6;
            this.AddClass_courseLable.Text = "Course";
            this.AddClass_courseLable.Visible = false;
            // 
            // AddClass_courseTextbox
            // 
            this.AddClass_courseTextbox.Location = new System.Drawing.Point(63, 670);
            this.AddClass_courseTextbox.Multiline = true;
            this.AddClass_courseTextbox.Name = "AddClass_courseTextbox";
            this.AddClass_courseTextbox.Size = new System.Drawing.Size(133, 30);
            this.AddClass_courseTextbox.TabIndex = 4;
            this.AddClass_courseTextbox.Visible = false;
            // 
            // dataGridViewTab1
            // 
            this.dataGridViewTab1.AllowCustomTheming = false;
            this.dataGridViewTab1.AllowUserToAddRows = false;
            this.dataGridViewTab1.AllowUserToDeleteRows = false;
            this.dataGridViewTab1.AllowUserToOrderColumns = true;
            this.dataGridViewTab1.AllowUserToResizeRows = false;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTab1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTab1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTab1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewTab1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTab1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTab1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewTab1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTab1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTab1.ColumnHeadersHeight = 40;
            this.dataGridViewTab1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.Professor,
            this.TA,
            this.Grade});
            this.dataGridViewTab1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewTab1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTab1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTab1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewTab1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTab1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewTab1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewTab1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewTab1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTab1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewTab1.CurrentTheme.Name = null;
            this.dataGridViewTab1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTab1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTab1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTab1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewTab1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTab1.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTab1.EnableHeadersVisualStyles = false;
            this.dataGridViewTab1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewTab1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewTab1.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewTab1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewTab1.Location = new System.Drawing.Point(47, 101);
            this.dataGridViewTab1.Name = "dataGridViewTab1";
            this.dataGridViewTab1.ReadOnly = true;
            this.dataGridViewTab1.RowHeadersVisible = false;
            this.dataGridViewTab1.RowHeadersWidth = 40;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTab1.RowsDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTab1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTab1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTab1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal;
            this.dataGridViewTab1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewTab1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTab1.RowTemplate.Height = 40;
            this.dataGridViewTab1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTab1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTab1.Size = new System.Drawing.Size(1120, 505);
            this.dataGridViewTab1.TabIndex = 3;
            this.dataGridViewTab1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridViewTab1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTab1_CellDoubleClick_1);
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Professor
            // 
            this.Professor.HeaderText = "Professor";
            this.Professor.Name = "Professor";
            this.Professor.ReadOnly = true;
            // 
            // TA
            // 
            this.TA.HeaderText = "TA";
            this.TA.Name = "TA";
            this.TA.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.FillWeight = 50F;
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // buttonTab1Archve
            // 
            this.buttonTab1Archve.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTab1Archve.Location = new System.Drawing.Point(1034, 650);
            this.buttonTab1Archve.Name = "buttonTab1Archve";
            this.buttonTab1Archve.Size = new System.Drawing.Size(133, 36);
            this.buttonTab1Archve.TabIndex = 2;
            this.buttonTab1Archve.Text = "Archive";
            this.buttonTab1Archve.UseVisualStyleBackColor = true;
            this.buttonTab1Archve.Click += new System.EventHandler(this.buttonTab1Archve_Click);
            this.buttonTab1Archve.MouseEnter += new System.EventHandler(this.buttonTab1Archve_MouseEnter);
            this.buttonTab1Archve.MouseLeave += new System.EventHandler(this.buttonTab1Archve_MouseLeave);
            // 
            // labelTab1Title
            // 
            this.labelTab1Title.AutoSize = true;
            this.labelTab1Title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab1Title.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab1Title.Location = new System.Drawing.Point(39, 39);
            this.labelTab1Title.Name = "labelTab1Title";
            this.labelTab1Title.Size = new System.Drawing.Size(231, 45);
            this.labelTab1Title.TabIndex = 1;
            this.labelTab1Title.Text = "List of classes";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.goto_Student_Btn);
            this.tabPage2.Controls.Add(this.dataGridViewTab2Quiz);
            this.tabPage2.Controls.Add(this.dataGridViewTab2Practice);
            this.tabPage2.Controls.Add(this.panelTab2InfoClass);
            this.tabPage2.Controls.Add(this.labelTab2Quiz);
            this.tabPage2.Controls.Add(this.labelTab2Pracitce);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1219, 744);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // goto_Student_Btn
            // 
            this.goto_Student_Btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goto_Student_Btn.Location = new System.Drawing.Point(536, 680);
            this.goto_Student_Btn.Name = "goto_Student_Btn";
            this.goto_Student_Btn.Size = new System.Drawing.Size(133, 36);
            this.goto_Student_Btn.TabIndex = 9;
            this.goto_Student_Btn.Text = "Students";
            this.goto_Student_Btn.UseVisualStyleBackColor = true;
            this.goto_Student_Btn.Click += new System.EventHandler(this.goto_Student_Btn_Click);
            // 
            // dataGridViewTab2Quiz
            // 
            this.dataGridViewTab2Quiz.AllowCustomTheming = false;
            this.dataGridViewTab2Quiz.AllowUserToAddRows = false;
            this.dataGridViewTab2Quiz.AllowUserToDeleteRows = false;
            this.dataGridViewTab2Quiz.AllowUserToOrderColumns = true;
            this.dataGridViewTab2Quiz.AllowUserToResizeRows = false;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTab2Quiz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTab2Quiz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTab2Quiz.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewTab2Quiz.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTab2Quiz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTab2Quiz.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewTab2Quiz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTab2Quiz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTab2Quiz.ColumnHeadersHeight = 40;
            this.dataGridViewTab2Quiz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tab2NumberQuiz,
            this.tab2DateQuiz});
            this.dataGridViewTab2Quiz.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewTab2Quiz.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTab2Quiz.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTab2Quiz.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewTab2Quiz.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTab2Quiz.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewTab2Quiz.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewTab2Quiz.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewTab2Quiz.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTab2Quiz.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewTab2Quiz.CurrentTheme.Name = null;
            this.dataGridViewTab2Quiz.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTab2Quiz.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTab2Quiz.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTab2Quiz.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewTab2Quiz.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTab2Quiz.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewTab2Quiz.EnableHeadersVisualStyles = false;
            this.dataGridViewTab2Quiz.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewTab2Quiz.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewTab2Quiz.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewTab2Quiz.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewTab2Quiz.Location = new System.Drawing.Point(636, 216);
            this.dataGridViewTab2Quiz.Name = "dataGridViewTab2Quiz";
            this.dataGridViewTab2Quiz.ReadOnly = true;
            this.dataGridViewTab2Quiz.RowHeadersVisible = false;
            this.dataGridViewTab2Quiz.RowHeadersWidth = 40;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTab2Quiz.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewTab2Quiz.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTab2Quiz.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTab2Quiz.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal;
            this.dataGridViewTab2Quiz.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewTab2Quiz.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTab2Quiz.RowTemplate.Height = 40;
            this.dataGridViewTab2Quiz.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTab2Quiz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTab2Quiz.Size = new System.Drawing.Size(529, 439);
            this.dataGridViewTab2Quiz.TabIndex = 8;
            this.dataGridViewTab2Quiz.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // tab2NumberQuiz
            // 
            this.tab2NumberQuiz.HeaderText = "Number";
            this.tab2NumberQuiz.Name = "tab2NumberQuiz";
            this.tab2NumberQuiz.ReadOnly = true;
            // 
            // tab2DateQuiz
            // 
            this.tab2DateQuiz.HeaderText = "Date";
            this.tab2DateQuiz.Name = "tab2DateQuiz";
            this.tab2DateQuiz.ReadOnly = true;
            // 
            // dataGridViewTab2Practice
            // 
            this.dataGridViewTab2Practice.AllowCustomTheming = false;
            this.dataGridViewTab2Practice.AllowUserToAddRows = false;
            this.dataGridViewTab2Practice.AllowUserToDeleteRows = false;
            this.dataGridViewTab2Practice.AllowUserToOrderColumns = true;
            this.dataGridViewTab2Practice.AllowUserToResizeRows = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTab2Practice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewTab2Practice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTab2Practice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewTab2Practice.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTab2Practice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTab2Practice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewTab2Practice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTab2Practice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewTab2Practice.ColumnHeadersHeight = 40;
            this.dataGridViewTab2Practice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tab2PartPractice,
            this.Tab2NumberPractice,
            this.tab2DownloadPractice,
            this.tab2UploadPractice});
            this.dataGridViewTab2Practice.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewTab2Practice.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTab2Practice.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTab2Practice.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewTab2Practice.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTab2Practice.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewTab2Practice.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewTab2Practice.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewTab2Practice.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTab2Practice.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewTab2Practice.CurrentTheme.Name = null;
            this.dataGridViewTab2Practice.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTab2Practice.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTab2Practice.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTab2Practice.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewTab2Practice.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTab2Practice.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridViewTab2Practice.EnableHeadersVisualStyles = false;
            this.dataGridViewTab2Practice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewTab2Practice.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewTab2Practice.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewTab2Practice.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewTab2Practice.Location = new System.Drawing.Point(46, 216);
            this.dataGridViewTab2Practice.Name = "dataGridViewTab2Practice";
            this.dataGridViewTab2Practice.ReadOnly = true;
            this.dataGridViewTab2Practice.RowHeadersVisible = false;
            this.dataGridViewTab2Practice.RowHeadersWidth = 40;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTab2Practice.RowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridViewTab2Practice.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTab2Practice.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTab2Practice.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal;
            this.dataGridViewTab2Practice.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewTab2Practice.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTab2Practice.RowTemplate.Height = 40;
            this.dataGridViewTab2Practice.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTab2Practice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewTab2Practice.Size = new System.Drawing.Size(529, 439);
            this.dataGridViewTab2Practice.TabIndex = 7;
            this.dataGridViewTab2Practice.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridViewTab2Practice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTab2Practice_CellContentClick);
            this.dataGridViewTab2Practice.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTab2Practice_CellContentDoubleClick);
            // 
            // Tab2PartPractice
            // 
            this.Tab2PartPractice.HeaderText = "Part";
            this.Tab2PartPractice.Name = "Tab2PartPractice";
            this.Tab2PartPractice.ReadOnly = true;
            // 
            // Tab2NumberPractice
            // 
            this.Tab2NumberPractice.HeaderText = "Number";
            this.Tab2NumberPractice.Name = "Tab2NumberPractice";
            this.Tab2NumberPractice.ReadOnly = true;
            // 
            // tab2DownloadPractice
            // 
            this.tab2DownloadPractice.FillWeight = 40F;
            this.tab2DownloadPractice.HeaderText = "DL";
            this.tab2DownloadPractice.Name = "tab2DownloadPractice";
            this.tab2DownloadPractice.ReadOnly = true;
            // 
            // tab2UploadPractice
            // 
            this.tab2UploadPractice.FillWeight = 40F;
            this.tab2UploadPractice.HeaderText = "UP";
            this.tab2UploadPractice.Name = "tab2UploadPractice";
            this.tab2UploadPractice.ReadOnly = true;
            // 
            // panelTab2InfoClass
            // 
            this.panelTab2InfoClass.BackColor = System.Drawing.Color.LightGray;
            this.panelTab2InfoClass.Controls.Add(this.labelTab2NameTa);
            this.panelTab2InfoClass.Controls.Add(this.labelTab2NameProfessor);
            this.panelTab2InfoClass.Controls.Add(this.labelTab2NameCourse);
            this.panelTab2InfoClass.Location = new System.Drawing.Point(-3, 46);
            this.panelTab2InfoClass.Name = "panelTab2InfoClass";
            this.panelTab2InfoClass.Size = new System.Drawing.Size(1219, 46);
            this.panelTab2InfoClass.TabIndex = 5;
            // 
            // labelTab2NameTa
            // 
            this.labelTab2NameTa.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab2NameTa.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab2NameTa.Location = new System.Drawing.Point(933, 0);
            this.labelTab2NameTa.Name = "labelTab2NameTa";
            this.labelTab2NameTa.Size = new System.Drawing.Size(274, 45);
            this.labelTab2NameTa.TabIndex = 8;
            this.labelTab2NameTa.Text = "TA";
            this.labelTab2NameTa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTab2NameProfessor
            // 
            this.labelTab2NameProfessor.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab2NameProfessor.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab2NameProfessor.Location = new System.Drawing.Point(407, 1);
            this.labelTab2NameProfessor.Name = "labelTab2NameProfessor";
            this.labelTab2NameProfessor.Size = new System.Drawing.Size(392, 45);
            this.labelTab2NameProfessor.TabIndex = 7;
            this.labelTab2NameProfessor.Text = "professor";
            this.labelTab2NameProfessor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTab2NameProfessor.Click += new System.EventHandler(this.labelTab2NameProfessor_Click);
            // 
            // labelTab2NameCourse
            // 
            this.labelTab2NameCourse.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab2NameCourse.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab2NameCourse.Location = new System.Drawing.Point(9, 1);
            this.labelTab2NameCourse.Name = "labelTab2NameCourse";
            this.labelTab2NameCourse.Size = new System.Drawing.Size(260, 45);
            this.labelTab2NameCourse.TabIndex = 6;
            this.labelTab2NameCourse.Text = "nameCourse";
            this.labelTab2NameCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTab2NameCourse.Click += new System.EventHandler(this.labelTab2NameCourse_Click);
            // 
            // labelTab2Quiz
            // 
            this.labelTab2Quiz.AutoSize = true;
            this.labelTab2Quiz.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab2Quiz.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab2Quiz.Location = new System.Drawing.Point(628, 129);
            this.labelTab2Quiz.Name = "labelTab2Quiz";
            this.labelTab2Quiz.Size = new System.Drawing.Size(123, 45);
            this.labelTab2Quiz.TabIndex = 4;
            this.labelTab2Quiz.Text = "Quizes";
            // 
            // labelTab2Pracitce
            // 
            this.labelTab2Pracitce.AutoSize = true;
            this.labelTab2Pracitce.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab2Pracitce.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab2Pracitce.Location = new System.Drawing.Point(38, 129);
            this.labelTab2Pracitce.Name = "labelTab2Pracitce";
            this.labelTab2Pracitce.Size = new System.Drawing.Size(158, 45);
            this.labelTab2Pracitce.TabIndex = 3;
            this.labelTab2Pracitce.Text = "Practices";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.labelTab3Title);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1219, 744);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.buttonTab3SaveNewPassword);
            this.panel3.Location = new System.Drawing.Point(483, 552);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 73);
            this.panel3.TabIndex = 6;
            // 
            // buttonTab3SaveNewPassword
            // 
            this.buttonTab3SaveNewPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTab3SaveNewPassword.Location = new System.Drawing.Point(166, 19);
            this.buttonTab3SaveNewPassword.Name = "buttonTab3SaveNewPassword";
            this.buttonTab3SaveNewPassword.Size = new System.Drawing.Size(100, 36);
            this.buttonTab3SaveNewPassword.TabIndex = 11;
            this.buttonTab3SaveNewPassword.Text = "Save";
            this.buttonTab3SaveNewPassword.UseVisualStyleBackColor = true;
            this.buttonTab3SaveNewPassword.Click += new System.EventHandler(this.buttonTab3SaveNewPassword_Click);
            this.buttonTab3SaveNewPassword.MouseEnter += new System.EventHandler(this.buttonTab3SaveNewPassword_MouseEnter_1);
            this.buttonTab3SaveNewPassword.MouseLeave += new System.EventHandler(this.buttonTab3SaveNewPassword_MouseLeave_1);
            // 
            // labelTab3Title
            // 
            this.labelTab3Title.AutoSize = true;
            this.labelTab3Title.Font = new System.Drawing.Font("Segoe UI", 21.8F, System.Drawing.FontStyle.Bold);
            this.labelTab3Title.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab3Title.Location = new System.Drawing.Point(320, 148);
            this.labelTab3Title.Name = "labelTab3Title";
            this.labelTab3Title.Size = new System.Drawing.Size(147, 50);
            this.labelTab3Title.TabIndex = 5;
            this.labelTab3Title.Text = "Setting";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(303, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 148);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Location = new System.Drawing.Point(35, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sign out";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(47, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Profile";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuMaterialTextboxTab3RepeatNewPassword);
            this.panel1.Controls.Add(this.labelTab3RepeatNewPassword);
            this.panel1.Controls.Add(this.bunifuMaterialTextboxTab3NewPassword);
            this.panel1.Controls.Add(this.labelTab3NewPass);
            this.panel1.Controls.Add(this.bunifuMaterialTextboxCurrentPassword);
            this.panel1.Controls.Add(this.labelTab3TitleCurrentPassword);
            this.panel1.Controls.Add(this.labelTab3Id);
            this.panel1.Controls.Add(this.labelTab3FullNameProfessor);
            this.panel1.Location = new System.Drawing.Point(483, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 526);
            this.panel1.TabIndex = 3;
            // 
            // bunifuMaterialTextboxTab3RepeatNewPassword
            // 
            this.bunifuMaterialTextboxTab3RepeatNewPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.bunifuMaterialTextboxTab3RepeatNewPassword.ForeColor = System.Drawing.Color.Navy;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.HintText = "";
            this.bunifuMaterialTextboxTab3RepeatNewPassword.isPassword = false;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.LineIdleColor = System.Drawing.Color.Teal;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.LineThickness = 3;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.Location = new System.Drawing.Point(46, 344);
            this.bunifuMaterialTextboxTab3RepeatNewPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMaterialTextboxTab3RepeatNewPassword.MaxLength = 32767;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.Name = "bunifuMaterialTextboxTab3RepeatNewPassword";
            this.bunifuMaterialTextboxTab3RepeatNewPassword.Size = new System.Drawing.Size(336, 36);
            this.bunifuMaterialTextboxTab3RepeatNewPassword.TabIndex = 13;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxTab3RepeatNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextboxTab3RepeatNewPassword_KeyPress);
            // 
            // labelTab3RepeatNewPassword
            // 
            this.labelTab3RepeatNewPassword.AutoSize = true;
            this.labelTab3RepeatNewPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab3RepeatNewPassword.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab3RepeatNewPassword.Location = new System.Drawing.Point(40, 307);
            this.labelTab3RepeatNewPassword.Name = "labelTab3RepeatNewPassword";
            this.labelTab3RepeatNewPassword.Size = new System.Drawing.Size(127, 32);
            this.labelTab3RepeatNewPassword.TabIndex = 12;
            this.labelTab3RepeatNewPassword.Text = "Last Name";
            // 
            // bunifuMaterialTextboxTab3NewPassword
            // 
            this.bunifuMaterialTextboxTab3NewPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextboxTab3NewPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextboxTab3NewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuMaterialTextboxTab3NewPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextboxTab3NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxTab3NewPassword.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.bunifuMaterialTextboxTab3NewPassword.ForeColor = System.Drawing.Color.Navy;
            this.bunifuMaterialTextboxTab3NewPassword.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxTab3NewPassword.HintText = "";
            this.bunifuMaterialTextboxTab3NewPassword.isPassword = false;
            this.bunifuMaterialTextboxTab3NewPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab3NewPassword.LineIdleColor = System.Drawing.Color.Teal;
            this.bunifuMaterialTextboxTab3NewPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab3NewPassword.LineThickness = 3;
            this.bunifuMaterialTextboxTab3NewPassword.Location = new System.Drawing.Point(46, 252);
            this.bunifuMaterialTextboxTab3NewPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMaterialTextboxTab3NewPassword.MaxLength = 32767;
            this.bunifuMaterialTextboxTab3NewPassword.Name = "bunifuMaterialTextboxTab3NewPassword";
            this.bunifuMaterialTextboxTab3NewPassword.Size = new System.Drawing.Size(336, 36);
            this.bunifuMaterialTextboxTab3NewPassword.TabIndex = 8;
            this.bunifuMaterialTextboxTab3NewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxTab3NewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextboxTab3NewPassword_KeyPress);
            // 
            // labelTab3NewPass
            // 
            this.labelTab3NewPass.AutoSize = true;
            this.labelTab3NewPass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab3NewPass.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab3NewPass.Location = new System.Drawing.Point(40, 215);
            this.labelTab3NewPass.Name = "labelTab3NewPass";
            this.labelTab3NewPass.Size = new System.Drawing.Size(167, 32);
            this.labelTab3NewPass.TabIndex = 7;
            this.labelTab3NewPass.Text = "New Password";
            // 
            // bunifuMaterialTextboxCurrentPassword
            // 
            this.bunifuMaterialTextboxCurrentPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextboxCurrentPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextboxCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuMaterialTextboxCurrentPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextboxCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxCurrentPassword.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.bunifuMaterialTextboxCurrentPassword.ForeColor = System.Drawing.Color.Navy;
            this.bunifuMaterialTextboxCurrentPassword.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxCurrentPassword.HintText = "";
            this.bunifuMaterialTextboxCurrentPassword.isPassword = false;
            this.bunifuMaterialTextboxCurrentPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxCurrentPassword.LineIdleColor = System.Drawing.Color.Teal;
            this.bunifuMaterialTextboxCurrentPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxCurrentPassword.LineThickness = 3;
            this.bunifuMaterialTextboxCurrentPassword.Location = new System.Drawing.Point(46, 162);
            this.bunifuMaterialTextboxCurrentPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMaterialTextboxCurrentPassword.MaxLength = 32767;
            this.bunifuMaterialTextboxCurrentPassword.Name = "bunifuMaterialTextboxCurrentPassword";
            this.bunifuMaterialTextboxCurrentPassword.Size = new System.Drawing.Size(336, 36);
            this.bunifuMaterialTextboxCurrentPassword.TabIndex = 6;
            this.bunifuMaterialTextboxCurrentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxCurrentPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextboxCurrentPassword_KeyPress);
            // 
            // labelTab3TitleCurrentPassword
            // 
            this.labelTab3TitleCurrentPassword.AutoSize = true;
            this.labelTab3TitleCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab3TitleCurrentPassword.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab3TitleCurrentPassword.Location = new System.Drawing.Point(40, 125);
            this.labelTab3TitleCurrentPassword.Name = "labelTab3TitleCurrentPassword";
            this.labelTab3TitleCurrentPassword.Size = new System.Drawing.Size(199, 32);
            this.labelTab3TitleCurrentPassword.TabIndex = 5;
            this.labelTab3TitleCurrentPassword.Text = "Current Password";
            // 
            // labelTab3Id
            // 
            this.labelTab3Id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTab3Id.Font = new System.Drawing.Font("Segoe UI", 15.2F, System.Drawing.FontStyle.Italic);
            this.labelTab3Id.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab3Id.Location = new System.Drawing.Point(93, 62);
            this.labelTab3Id.Name = "labelTab3Id";
            this.labelTab3Id.Size = new System.Drawing.Size(239, 32);
            this.labelTab3Id.TabIndex = 4;
            this.labelTab3Id.Text = "ID : 961845125";
            this.labelTab3Id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTab3FullNameProfessor
            // 
            this.labelTab3FullNameProfessor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTab3FullNameProfessor.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab3FullNameProfessor.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab3FullNameProfessor.Location = new System.Drawing.Point(16, 15);
            this.labelTab3FullNameProfessor.Name = "labelTab3FullNameProfessor";
            this.labelTab3FullNameProfessor.Size = new System.Drawing.Size(393, 51);
            this.labelTab3FullNameProfessor.TabIndex = 3;
            this.labelTab3FullNameProfessor.Text = "Name LName";
            this.labelTab3FullNameProfessor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.dataGridViewTab4);
            this.tabPage4.Location = new System.Drawing.Point(4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1219, 744);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.iconTab4BackArrow);
            this.panel4.Controls.Add(this.labelTab4nameCourse);
            this.panel4.Location = new System.Drawing.Point(55, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1097, 53);
            this.panel4.TabIndex = 11;
            // 
            // iconTab4BackArrow
            // 
            this.iconTab4BackArrow.Image = global::PracticeClass.Properties.Resources.Icon_ionic_ios_arrow_back_2x;
            this.iconTab4BackArrow.Location = new System.Drawing.Point(3, 7);
            this.iconTab4BackArrow.Name = "iconTab4BackArrow";
            this.iconTab4BackArrow.Size = new System.Drawing.Size(40, 38);
            this.iconTab4BackArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconTab4BackArrow.TabIndex = 12;
            this.iconTab4BackArrow.TabStop = false;
            this.iconTab4BackArrow.Click += new System.EventHandler(this.iconTab4BackArrow_Click);
            // 
            // labelTab4nameCourse
            // 
            this.labelTab4nameCourse.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab4nameCourse.ForeColor = System.Drawing.Color.White;
            this.labelTab4nameCourse.Location = new System.Drawing.Point(96, 0);
            this.labelTab4nameCourse.Name = "labelTab4nameCourse";
            this.labelTab4nameCourse.Size = new System.Drawing.Size(889, 51);
            this.labelTab4nameCourse.TabIndex = 0;
            this.labelTab4nameCourse.Text = "label1";
            this.labelTab4nameCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTab4
            // 
            this.dataGridViewTab4.AllowUserToAddRows = false;
            this.dataGridViewTab4.AllowUserToDeleteRows = false;
            this.dataGridViewTab4.AllowUserToOrderColumns = true;
            this.dataGridViewTab4.AllowUserToResizeRows = false;
            this.dataGridViewTab4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTab4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewTab4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTab4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewTab4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTab4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridViewTab4.ColumnHeadersHeight = 50;
            this.dataGridViewTab4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTab4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberResource,
            this.nameResource,
            this.linkResourse});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTab4.DefaultCellStyle = dataGridViewCellStyle33;
            this.dataGridViewTab4.Location = new System.Drawing.Point(55, 130);
            this.dataGridViewTab4.Name = "dataGridViewTab4";
            this.dataGridViewTab4.ReadOnly = true;
            this.dataGridViewTab4.RowHeadersVisible = false;
            this.dataGridViewTab4.RowHeadersWidth = 40;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTab4.RowsDefaultCellStyle = dataGridViewCellStyle34;
            this.dataGridViewTab4.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTab4.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTab4.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal;
            this.dataGridViewTab4.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewTab4.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTab4.RowTemplate.Height = 35;
            this.dataGridViewTab4.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTab4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewTab4.Size = new System.Drawing.Size(1097, 1022);
            this.dataGridViewTab4.TabIndex = 10;
            // 
            // numberResource
            // 
            this.numberResource.FillWeight = 30F;
            this.numberResource.HeaderText = "Number";
            this.numberResource.Name = "numberResource";
            this.numberResource.ReadOnly = true;
            // 
            // nameResource
            // 
            this.nameResource.HeaderText = "Name";
            this.nameResource.Name = "nameResource";
            this.nameResource.ReadOnly = true;
            // 
            // linkResourse
            // 
            this.linkResourse.HeaderText = "Link";
            this.linkResourse.Name = "linkResourse";
            this.linkResourse.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage5.Controls.Add(this.panelTab5);
            this.tabPage5.Location = new System.Drawing.Point(4, 5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1219, 744);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            // 
            // panelTab5
            // 
            this.panelTab5.BackColor = System.Drawing.Color.White;
            this.panelTab5.Controls.Add(this.pictureBox1);
            this.panelTab5.Controls.Add(this.labelTab5NumberPractice);
            this.panelTab5.Controls.Add(this.bunifuMetroTextboxTab5LinkPractice);
            this.panelTab5.Controls.Add(this.iconTab5Send);
            this.panelTab5.Controls.Add(this.iconTab5Brows);
            this.panelTab5.Location = new System.Drawing.Point(126, 204);
            this.panelTab5.Name = "panelTab5";
            this.panelTab5.Size = new System.Drawing.Size(954, 158);
            this.panelTab5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PracticeClass.Properties.Resources.Icon_ionic_ios_arrow_back_2x;
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelTab5NumberPractice
            // 
            this.labelTab5NumberPractice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTab5NumberPractice.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab5NumberPractice.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab5NumberPractice.Location = new System.Drawing.Point(30, 20);
            this.labelTab5NumberPractice.Name = "labelTab5NumberPractice";
            this.labelTab5NumberPractice.Size = new System.Drawing.Size(803, 53);
            this.labelTab5NumberPractice.TabIndex = 7;
            this.labelTab5NumberPractice.Text = "Practice number";
            this.labelTab5NumberPractice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuMetroTextboxTab5LinkPractice
            // 
            this.bunifuMetroTextboxTab5LinkPractice.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextboxTab5LinkPractice.BorderColorIdle = System.Drawing.Color.Teal;
            this.bunifuMetroTextboxTab5LinkPractice.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextboxTab5LinkPractice.BorderThickness = 3;
            this.bunifuMetroTextboxTab5LinkPractice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMetroTextboxTab5LinkPractice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextboxTab5LinkPractice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextboxTab5LinkPractice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextboxTab5LinkPractice.isPassword = false;
            this.bunifuMetroTextboxTab5LinkPractice.Location = new System.Drawing.Point(25, 92);
            this.bunifuMetroTextboxTab5LinkPractice.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextboxTab5LinkPractice.MaxLength = 32767;
            this.bunifuMetroTextboxTab5LinkPractice.Name = "bunifuMetroTextboxTab5LinkPractice";
            this.bunifuMetroTextboxTab5LinkPractice.Size = new System.Drawing.Size(816, 44);
            this.bunifuMetroTextboxTab5LinkPractice.TabIndex = 6;
            this.bunifuMetroTextboxTab5LinkPractice.Text = "bunifuMetroTextbox1";
            this.bunifuMetroTextboxTab5LinkPractice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // iconTab5Send
            // 
            this.iconTab5Send.Image = global::PracticeClass.Properties.Resources.Icon_feather_send_2x;
            this.iconTab5Send.Location = new System.Drawing.Point(894, 95);
            this.iconTab5Send.Name = "iconTab5Send";
            this.iconTab5Send.Size = new System.Drawing.Size(40, 38);
            this.iconTab5Send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconTab5Send.TabIndex = 4;
            this.iconTab5Send.TabStop = false;
            this.iconTab5Send.Click += new System.EventHandler(this.iconTab5Send_Click);
            // 
            // iconTab5Brows
            // 
            this.iconTab5Brows.Image = global::PracticeClass.Properties.Resources.Icon_metro_attachment_2x;
            this.iconTab5Brows.Location = new System.Drawing.Point(848, 95);
            this.iconTab5Brows.Name = "iconTab5Brows";
            this.iconTab5Brows.Size = new System.Drawing.Size(40, 38);
            this.iconTab5Brows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconTab5Brows.TabIndex = 5;
            this.iconTab5Brows.TabStop = false;
            this.iconTab5Brows.Click += new System.EventHandler(this.iconTab5Brows_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage6.Controls.Add(this.panel6);
            this.tabPage6.Location = new System.Drawing.Point(4, 5);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1219, 744);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.iconTab6EditPractice);
            this.panel6.Controls.Add(this.iconTab6BackArrow);
            this.panel6.Controls.Add(this.labelTab6Grade);
            this.panel6.Controls.Add(this.labelTab6NumberPartPractice);
            this.panel6.Controls.Add(this.labelTab6Date);
            this.panel6.Location = new System.Drawing.Point(126, 204);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(956, 100);
            this.panel6.TabIndex = 13;
            // 
            // iconTab6EditPractice
            // 
            this.iconTab6EditPractice.Image = global::PracticeClass.Properties.Resources.Icon_awesome_edit_2x;
            this.iconTab6EditPractice.Location = new System.Drawing.Point(904, 28);
            this.iconTab6EditPractice.Name = "iconTab6EditPractice";
            this.iconTab6EditPractice.Size = new System.Drawing.Size(40, 38);
            this.iconTab6EditPractice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconTab6EditPractice.TabIndex = 15;
            this.iconTab6EditPractice.TabStop = false;
            // 
            // iconTab6BackArrow
            // 
            this.iconTab6BackArrow.Image = global::PracticeClass.Properties.Resources.Icon_ionic_ios_arrow_back_2x;
            this.iconTab6BackArrow.Location = new System.Drawing.Point(3, 28);
            this.iconTab6BackArrow.Name = "iconTab6BackArrow";
            this.iconTab6BackArrow.Size = new System.Drawing.Size(40, 38);
            this.iconTab6BackArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconTab6BackArrow.TabIndex = 14;
            this.iconTab6BackArrow.TabStop = false;
            this.iconTab6BackArrow.Click += new System.EventHandler(this.iconTab6BackArrow_Click);
            // 
            // labelTab6Grade
            // 
            this.labelTab6Grade.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab6Grade.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab6Grade.Location = new System.Drawing.Point(690, 28);
            this.labelTab6Grade.Name = "labelTab6Grade";
            this.labelTab6Grade.Size = new System.Drawing.Size(208, 32);
            this.labelTab6Grade.TabIndex = 12;
            this.labelTab6Grade.Text = "Sign out";
            this.labelTab6Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTab6NumberPartPractice
            // 
            this.labelTab6NumberPartPractice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab6NumberPartPractice.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab6NumberPartPractice.Location = new System.Drawing.Point(41, 28);
            this.labelTab6NumberPartPractice.Name = "labelTab6NumberPartPractice";
            this.labelTab6NumberPartPractice.Size = new System.Drawing.Size(317, 32);
            this.labelTab6NumberPartPractice.TabIndex = 10;
            this.labelTab6NumberPartPractice.Text = "Sign out";
            // 
            // labelTab6Date
            // 
            this.labelTab6Date.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTab6Date.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelTab6Date.Location = new System.Drawing.Point(397, 28);
            this.labelTab6Date.Name = "labelTab6Date";
            this.labelTab6Date.Size = new System.Drawing.Size(287, 32);
            this.labelTab6Date.TabIndex = 11;
            this.labelTab6Date.Text = "Sign out";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.AddStudent_warningLbl);
            this.tabPage7.Controls.Add(this.AddStudent_checkBox);
            this.tabPage7.Controls.Add(this.AddStudent_lable);
            this.tabPage7.Controls.Add(this.AddStudent_submitBtn);
            this.tabPage7.Controls.Add(this.AddStudent_studentIdLbl);
            this.tabPage7.Controls.Add(this.AddStudent_stdID_TextBox);
            this.tabPage7.Controls.Add(this.panel7);
            this.tabPage7.Controls.Add(this.dataGridView_StudentList);
            this.tabPage7.Controls.Add(this.label1);
            this.tabPage7.Location = new System.Drawing.Point(4, 5);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1219, 744);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // AddStudent_warningLbl
            // 
            this.AddStudent_warningLbl.AutoSize = true;
            this.AddStudent_warningLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudent_warningLbl.ForeColor = System.Drawing.Color.Red;
            this.AddStudent_warningLbl.Location = new System.Drawing.Point(651, 604);
            this.AddStudent_warningLbl.Name = "AddStudent_warningLbl";
            this.AddStudent_warningLbl.Size = new System.Drawing.Size(107, 32);
            this.AddStudent_warningLbl.TabIndex = 27;
            this.AddStudent_warningLbl.Text = "Warning";
            this.AddStudent_warningLbl.Visible = false;
            // 
            // AddStudent_checkBox
            // 
            this.AddStudent_checkBox.AutoSize = true;
            this.AddStudent_checkBox.Location = new System.Drawing.Point(579, 616);
            this.AddStudent_checkBox.Name = "AddStudent_checkBox";
            this.AddStudent_checkBox.Size = new System.Drawing.Size(18, 17);
            this.AddStudent_checkBox.TabIndex = 26;
            this.AddStudent_checkBox.UseVisualStyleBackColor = true;
            this.AddStudent_checkBox.CheckedChanged += new System.EventHandler(this.AddStudent_checkBox_CheckedChanged);
            // 
            // AddStudent_lable
            // 
            this.AddStudent_lable.AutoSize = true;
            this.AddStudent_lable.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudent_lable.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.AddStudent_lable.Location = new System.Drawing.Point(422, 606);
            this.AddStudent_lable.Name = "AddStudent_lable";
            this.AddStudent_lable.Size = new System.Drawing.Size(151, 32);
            this.AddStudent_lable.TabIndex = 25;
            this.AddStudent_lable.Text = "Add Student";
            // 
            // AddStudent_submitBtn
            // 
            this.AddStudent_submitBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudent_submitBtn.Location = new System.Drawing.Point(235, 606);
            this.AddStudent_submitBtn.Name = "AddStudent_submitBtn";
            this.AddStudent_submitBtn.Size = new System.Drawing.Size(133, 36);
            this.AddStudent_submitBtn.TabIndex = 24;
            this.AddStudent_submitBtn.Text = "Submit";
            this.AddStudent_submitBtn.UseVisualStyleBackColor = true;
            this.AddStudent_submitBtn.Visible = false;
            this.AddStudent_submitBtn.Click += new System.EventHandler(this.AddStudent_submitBtn_Click);
            // 
            // AddStudent_studentIdLbl
            // 
            this.AddStudent_studentIdLbl.AutoSize = true;
            this.AddStudent_studentIdLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudent_studentIdLbl.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.AddStudent_studentIdLbl.Location = new System.Drawing.Point(49, 571);
            this.AddStudent_studentIdLbl.Name = "AddStudent_studentIdLbl";
            this.AddStudent_studentIdLbl.Size = new System.Drawing.Size(128, 32);
            this.AddStudent_studentIdLbl.TabIndex = 22;
            this.AddStudent_studentIdLbl.Text = "Student ID";
            this.AddStudent_studentIdLbl.Visible = false;
            // 
            // AddStudent_stdID_TextBox
            // 
            this.AddStudent_stdID_TextBox.Location = new System.Drawing.Point(55, 615);
            this.AddStudent_stdID_TextBox.Multiline = true;
            this.AddStudent_stdID_TextBox.Name = "AddStudent_stdID_TextBox";
            this.AddStudent_stdID_TextBox.Size = new System.Drawing.Size(133, 30);
            this.AddStudent_stdID_TextBox.TabIndex = 21;
            this.AddStudent_stdID_TextBox.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Controls.Add(this.Tab7_TALable);
            this.panel7.Controls.Add(this.Tab7_ProfessorLable);
            this.panel7.Controls.Add(this.Tab7_nameCourseLable);
            this.panel7.Location = new System.Drawing.Point(3, 30);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1219, 46);
            this.panel7.TabIndex = 6;
            // 
            // Tab7_TALable
            // 
            this.Tab7_TALable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab7_TALable.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Tab7_TALable.Location = new System.Drawing.Point(933, 0);
            this.Tab7_TALable.Name = "Tab7_TALable";
            this.Tab7_TALable.Size = new System.Drawing.Size(274, 45);
            this.Tab7_TALable.TabIndex = 8;
            this.Tab7_TALable.Text = "TA";
            this.Tab7_TALable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab7_ProfessorLable
            // 
            this.Tab7_ProfessorLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab7_ProfessorLable.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Tab7_ProfessorLable.Location = new System.Drawing.Point(432, 1);
            this.Tab7_ProfessorLable.Name = "Tab7_ProfessorLable";
            this.Tab7_ProfessorLable.Size = new System.Drawing.Size(392, 45);
            this.Tab7_ProfessorLable.TabIndex = 7;
            this.Tab7_ProfessorLable.Text = "professor";
            this.Tab7_ProfessorLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab7_nameCourseLable
            // 
            this.Tab7_nameCourseLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab7_nameCourseLable.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Tab7_nameCourseLable.Location = new System.Drawing.Point(9, 1);
            this.Tab7_nameCourseLable.Name = "Tab7_nameCourseLable";
            this.Tab7_nameCourseLable.Size = new System.Drawing.Size(260, 45);
            this.Tab7_nameCourseLable.TabIndex = 6;
            this.Tab7_nameCourseLable.Text = "nameCourse";
            this.Tab7_nameCourseLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_StudentList
            // 
            this.dataGridView_StudentList.AllowCustomTheming = false;
            this.dataGridView_StudentList.AllowUserToAddRows = false;
            this.dataGridView_StudentList.AllowUserToDeleteRows = false;
            this.dataGridView_StudentList.AllowUserToOrderColumns = true;
            this.dataGridView_StudentList.AllowUserToResizeRows = false;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_StudentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dataGridView_StudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_StudentList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_StudentList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_StudentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_StudentList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_StudentList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_StudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridView_StudentList.ColumnHeadersHeight = 40;
            this.dataGridView_StudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName});
            this.dataGridView_StudentList.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridView_StudentList.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView_StudentList.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_StudentList.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridView_StudentList.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_StudentList.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridView_StudentList.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridView_StudentList.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView_StudentList.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView_StudentList.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_StudentList.CurrentTheme.Name = null;
            this.dataGridView_StudentList.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_StudentList.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView_StudentList.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_StudentList.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridView_StudentList.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_StudentList.DefaultCellStyle = dataGridViewCellStyle37;
            this.dataGridView_StudentList.EnableHeadersVisualStyles = false;
            this.dataGridView_StudentList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridView_StudentList.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView_StudentList.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridView_StudentList.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView_StudentList.Location = new System.Drawing.Point(53, 141);
            this.dataGridView_StudentList.Name = "dataGridView_StudentList";
            this.dataGridView_StudentList.ReadOnly = true;
            this.dataGridView_StudentList.RowHeadersVisible = false;
            this.dataGridView_StudentList.RowHeadersWidth = 40;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_StudentList.RowsDefaultCellStyle = dataGridViewCellStyle38;
            this.dataGridView_StudentList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_StudentList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_StudentList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Teal;
            this.dataGridView_StudentList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView_StudentList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_StudentList.RowTemplate.Height = 40;
            this.dataGridView_StudentList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_StudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_StudentList.Size = new System.Drawing.Size(479, 429);
            this.dataGridView_StudentList.TabIndex = 5;
            this.dataGridView_StudentList.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(45, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "List of Students";
            // 
            // Column4
            // 
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.Name = "Column8";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label11.Location = new System.Drawing.Point(16, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(393, 51);
            this.label11.TabIndex = 3;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.2F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label10.Location = new System.Drawing.Point(93, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 32);
            this.label10.TabIndex = 4;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label9.Location = new System.Drawing.Point(40, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 32);
            this.label9.TabIndex = 5;
            // 
            // bunifuMaterialTextboxTab4PreviewPassword
            // 
            this.bunifuMaterialTextboxTab4PreviewPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextboxTab4PreviewPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextboxTab4PreviewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuMaterialTextboxTab4PreviewPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextboxTab4PreviewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxTab4PreviewPassword.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.bunifuMaterialTextboxTab4PreviewPassword.ForeColor = System.Drawing.Color.Navy;
            this.bunifuMaterialTextboxTab4PreviewPassword.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxTab4PreviewPassword.HintText = "";
            this.bunifuMaterialTextboxTab4PreviewPassword.isPassword = false;
            this.bunifuMaterialTextboxTab4PreviewPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab4PreviewPassword.LineIdleColor = System.Drawing.Color.Teal;
            this.bunifuMaterialTextboxTab4PreviewPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab4PreviewPassword.LineThickness = 3;
            this.bunifuMaterialTextboxTab4PreviewPassword.Location = new System.Drawing.Point(46, 167);
            this.bunifuMaterialTextboxTab4PreviewPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMaterialTextboxTab4PreviewPassword.MaxLength = 32767;
            this.bunifuMaterialTextboxTab4PreviewPassword.Name = "bunifuMaterialTextboxTab4PreviewPassword";
            this.bunifuMaterialTextboxTab4PreviewPassword.Size = new System.Drawing.Size(336, 36);
            this.bunifuMaterialTextboxTab4PreviewPassword.TabIndex = 6;
            this.bunifuMaterialTextboxTab4PreviewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label8.Location = new System.Drawing.Point(40, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 32);
            this.label8.TabIndex = 7;
            // 
            // bunifuMaterialTextboxTab4NewPassword
            // 
            this.bunifuMaterialTextboxTab4NewPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextboxTab4NewPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextboxTab4NewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuMaterialTextboxTab4NewPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextboxTab4NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxTab4NewPassword.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.bunifuMaterialTextboxTab4NewPassword.ForeColor = System.Drawing.Color.Navy;
            this.bunifuMaterialTextboxTab4NewPassword.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxTab4NewPassword.HintText = "";
            this.bunifuMaterialTextboxTab4NewPassword.isPassword = false;
            this.bunifuMaterialTextboxTab4NewPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab4NewPassword.LineIdleColor = System.Drawing.Color.Teal;
            this.bunifuMaterialTextboxTab4NewPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab4NewPassword.LineThickness = 3;
            this.bunifuMaterialTextboxTab4NewPassword.Location = new System.Drawing.Point(46, 261);
            this.bunifuMaterialTextboxTab4NewPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMaterialTextboxTab4NewPassword.MaxLength = 32767;
            this.bunifuMaterialTextboxTab4NewPassword.Name = "bunifuMaterialTextboxTab4NewPassword";
            this.bunifuMaterialTextboxTab4NewPassword.Size = new System.Drawing.Size(336, 36);
            this.bunifuMaterialTextboxTab4NewPassword.TabIndex = 8;
            this.bunifuMaterialTextboxTab4NewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label12.Location = new System.Drawing.Point(40, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 32);
            this.label12.TabIndex = 12;
            // 
            // bunifuMaterialTextboxTab4ReapeatNewPassword
            // 
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.ForeColor = System.Drawing.Color.Navy;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.HintText = "";
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.isPassword = false;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.LineIdleColor = System.Drawing.Color.Teal;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.LineThickness = 3;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.Location = new System.Drawing.Point(46, 351);
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.MaxLength = 32767;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.Name = "bunifuMaterialTextboxTab4ReapeatNewPassword";
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.Size = new System.Drawing.Size(336, 36);
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.TabIndex = 13;
            this.bunifuMaterialTextboxTab4ReapeatNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Location = new System.Drawing.Point(0, 447);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(430, 79);
            this.panel5.TabIndex = 6;
            // 
            // buttonTab4SaveNewPassword
            // 
            this.buttonTab4SaveNewPassword.Location = new System.Drawing.Point(0, 0);
            this.buttonTab4SaveNewPassword.Name = "buttonTab4SaveNewPassword";
            this.buttonTab4SaveNewPassword.Size = new System.Drawing.Size(75, 23);
            this.buttonTab4SaveNewPassword.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label6.Location = new System.Drawing.Point(47, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 32);
            this.label6.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label5.Location = new System.Drawing.Point(35, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 32);
            this.label5.TabIndex = 9;
            // 
            // formProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formProfessor";
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStudentToTa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTab1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTab2Quiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTab2Practice)).EndInit();
            this.panelTab2InfoClass.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconTab4BackArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTab4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.panelTab5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTab5Send)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTab5Brows)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconTab6EditPractice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTab6BackArrow)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.PictureBox iconSetting;
        private System.Windows.Forms.PictureBox iconProfile;
        private System.Windows.Forms.PictureBox iconSearch;
        private System.Windows.Forms.PictureBox iconHome;
        private System.Windows.Forms.PictureBox iconStudentToTa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelTab1Title;
        private System.Windows.Forms.Label labelTab2Quiz;
        private System.Windows.Forms.Label labelTab2Pracitce;
        private System.Windows.Forms.Panel panelTab2InfoClass;
        private System.Windows.Forms.Label labelTab2NameTa;
        private System.Windows.Forms.Label labelTab2NameProfessor;
        private System.Windows.Forms.Label labelTab2NameCourse;
        private System.Windows.Forms.Button buttonTab1Archve;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn TA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewTab1;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewTab2Quiz;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewTab2Practice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonTab4SaveNewPassword;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxTab4ReapeatNewPassword;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxTab4NewPassword;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxTab4PreviewPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxTab3RepeatNewPassword;
        private System.Windows.Forms.Label labelTab3RepeatNewPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxTab3NewPassword;
        private System.Windows.Forms.Label labelTab3NewPass;
        private System.Windows.Forms.Label labelTab3FullNameProfessor;
        private System.Windows.Forms.Label labelTab3Id;
        private System.Windows.Forms.Label labelTab3TitleCurrentPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxCurrentPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTab3Title;
        private System.Windows.Forms.Button buttonTab3SaveNewPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewImageColumn tab2UploadPractice;
        private System.Windows.Forms.DataGridViewImageColumn tab2DownloadPractice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tab2NumberPractice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tab2PartPractice;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelTab4nameCourse;
        private System.Windows.Forms.DataGridView dataGridViewTab4;
        private System.Windows.Forms.PictureBox iconTab4BackArrow;
        private System.Windows.Forms.DataGridViewLinkColumn linkResourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameResource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberResource;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.PictureBox iconTab5Send;
        private System.Windows.Forms.Panel panelTab5;
        private System.Windows.Forms.PictureBox iconTab5Brows;
        private System.Windows.Forms.Label labelTab5NumberPractice;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextboxTab5LinkPractice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox iconTab6BackArrow;
        private System.Windows.Forms.Label labelTab6Grade;
        private System.Windows.Forms.Label labelTab6NumberPartPractice;
        private System.Windows.Forms.Label labelTab6Date;
        private System.Windows.Forms.PictureBox iconTab6EditPractice;
        private System.Windows.Forms.DataGridViewTextBoxColumn tab2DateQuiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn tab2NumberQuiz;
        private System.Windows.Forms.TextBox AddClass_courseTextbox;
        private System.Windows.Forms.Label AddClassLable;
        private System.Windows.Forms.Button AddClass_submitButt;
        private System.Windows.Forms.Label AddClass_ProfessorName;
        private System.Windows.Forms.Label AddClass_TALable;
        private System.Windows.Forms.TextBox AddClass_TATextbox;
        private System.Windows.Forms.Label AddClass_professorLable;
        private System.Windows.Forms.Label AddClass_courseLable;
        private System.Windows.Forms.CheckBox AddClass_CheckBox;
        private System.Windows.Forms.TabPage tabPage7;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridView_StudentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goto_Student_Btn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label Tab7_TALable;
        private System.Windows.Forms.Label Tab7_ProfessorLable;
        private System.Windows.Forms.Label Tab7_nameCourseLable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.CheckBox AddStudent_checkBox;
        private System.Windows.Forms.Label AddStudent_lable;
        private System.Windows.Forms.Button AddStudent_submitBtn;
        private System.Windows.Forms.Label AddStudent_studentIdLbl;
        private System.Windows.Forms.TextBox AddStudent_stdID_TextBox;
        private System.Windows.Forms.Label AddStudent_warningLbl;
        private System.Windows.Forms.Label addClass_warningLbl;
    }
}