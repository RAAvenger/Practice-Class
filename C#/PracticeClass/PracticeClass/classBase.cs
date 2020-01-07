using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeClass {
    ///Streucts
    //taples of ClassList
    struct ShowClass {
        public string nameCourse;
        public string fullNameTA;
        public string fullNameProfessor;
        public short groupNumber;
        public bool term;
        public short year;
        //"grade = -1" means no grade or profrssor/TA class list
        public Nullable<float> grade;
    }
    //taples of QuizList
    struct ShowQuiz {
        public DateTime date;
        public short number;
    }
    //taples of PracticeList
    struct ShowPractice {
        public short number;
        public string link;
        public short part;
        public string idUploader;
    }
    struct ShowStudent {
        public string fullName;
        public string id;
        //"grade = -1" means no grade
        public Nullable<float> grade;
    }
    struct ShowResource {
        public string idCourse;
        public string idProfessor;
        public string linkResource;
        public string nameResource;
        public short numberResource;
    }
    struct ShowCourse {
        public string id;
        public string name;
    }
    class classBase {
        ///Class Varibles
        private database_practiceclass database;
        private classUser user { get; set; }
        private bool userType;
        private short numberYearFromStart;
        private bool term;
        ///Class Methods
        public classBase() {
            database = new database_practiceclass();
            //test basic data
            //set basic App Datas
            //term=this.database.table_systemDatas.termNow;
            term = true;
            //numberYearFromStart= this.database.table_systemDatas.numberYearNow;
            numberYearFromStart = 98;
        }
        public classStudent LoginStudent(string id, string password) {
            //first check if user exists as a Student then check if password is true
            if (database.table_student.Any(user => user.idStudent == id) && database.table_user.Any(user => user.idUser == id && user.password == password)) {
                //return Class student
                this.user = new classStudent(id, database, this.IsTA(id), numberYearFromStart, term);
                return (classStudent)this.user;
            }
            return null;
        }
        //return true if user is a TA for a Class or some classes
        public bool IsTA(string id) {
            //return true if exist a class that (TA id = this.id) in this term
            return database.table_practiceclass.Any(practiceClass =>
            practiceClass.idTA == id &&
            practiceClass.numberYearFromStart == this.numberYearFromStart &&
            practiceClass.termPracticeClass == this.term
            );
        }
        //login method and creater of professor
        public classProfessor LoginProfessor(string id, string password) {
            //first check if user exists as a professor then check if password is true
            if (database.table_professor.Any(user => user.idProfessor == id) &&
                database.table_user.Any(user => user.idUser == id && user.password == password)) {
                //return professor if user is valid
                this.user = new classProfessor(id, database, this.IsPrimeProfessor(id), numberYearFromStart, term);
                return (classProfessor)this.user;
            }
            return null;
        }
        //return true if user is a PrimeProfessor
        public bool IsPrimeProfessor(string id) {
            return database.table_professor.Any(professor => professor.idProfessor == id && professor.isPrime == true);
        }
        //edit first name , last name , password
        //empty string("") means attribute is "unchenged" 
        //"return -1" means "ErroR" and "return 1" means "Done"
        public int EditUser(string newFirstName = "", string newLastName = "", string newPassword = "") {
            var selectedUser = (from item in this.database.table_user
                                where (item.idUser == this.user.GetID())
                                select item).ToList().First();
            if (selectedUser == null)
                return -1;
            if (newFirstName != "")
                selectedUser.firstNameUser = newFirstName;
            if (newLastName != "")
                selectedUser.lastNameUser = newLastName;
            if (newPassword != "")
                selectedUser.password = newPassword;
            this.database.SaveChanges();
            return 1;
        }
        //add new user to database
        //"return -2" means "User exists", "return -3" means "wrong accessLevel" and "return 1" means "Done"
        public int AddNewUser(string id, int accessLevel) {
            if (this.database.table_user.Any(item => item.idUser == id))
                return -2;
            this.database.table_user.Add(new table_user { idUser = id, firstNameUser = "", lastNameUser = "", password = "" });
            if (accessLevel == 1) {
                this.database.table_student.Add(new table_student { idStudent = id });
                this.database.SaveChanges();
                return 1;
            }
            else if (accessLevel == 3 || accessLevel == 4) {
                this.database.table_professor.Add(new table_professor {
                    idProfessor = id,
                    isPrime = (accessLevel == 3) ? false : true
                });
                this.database.SaveChanges();
                return 1;
            }
            else
                return -3;
        }
        //add new class to database
        //"-2" means "access violation" , "-3" means "wrong course","-4" means "wrong idTA", "-1" means "general error" and "1" means "done"
        public int AddNewPracticeClass(string idCourse, string idTA, short numberYearFromStart, bool termPracticeClass) {
            if (this.user.GetAccessLevel() < 3)
                return -2;
            if (!this.database.table_course.Any(course => course.idCourse == idCourse))
                return -3;
            if (!this.database.table_student.Any(student => student.idStudent == idTA))
                return -4;
            try {
                //class already exists
                if (this.database.table_practiceclass.Any(practiceClass =>
                    practiceClass.numberYearFromStart == numberYearFromStart &&
                    practiceClass.termPracticeClass == term &&
                    practiceClass.idCourse == idCourse &&
                    practiceClass.idProfessor == this.user.GetID() &&
                    practiceClass.idTA == idTA)) {
                    var temp = this.database.table_practiceclass.Where(practiceClass =>
                     practiceClass.numberYearFromStart == numberYearFromStart &&
                     practiceClass.termPracticeClass == term &&
                     practiceClass.idCourse == idCourse &&
                     practiceClass.idProfessor == this.user.GetID() &&
                     practiceClass.idTA == idTA).First();
                    //class is deleted so unDelete it
                    if (temp.deleted) {
                        temp.deleted = false;
                        temp.groupeNumberPracticeClass = (short)(this.database.table_practiceclass.Max(groupnum => groupnum.groupeNumberPracticeClass) + 1);
                        this.database.SaveChanges();
                        return 1;
                    }
                    //class already exists and not deleted
                    else
                        return -5;
                }
                else {
                    table_practiceclass newClass = new table_practiceclass {
                        groupeNumberPracticeClass = (short)(this.database.table_practiceclass.Max(groupnum => groupnum.groupeNumberPracticeClass) + 1),
                        idCourse = idCourse,
                        idProfessor = this.user.GetID(),
                        idTA = idTA,
                        numberYearFromStart = numberYearFromStart,
                        termPracticeClass = termPracticeClass
                    };
                    this.database.table_practiceclass.Add(newClass);
                    this.database.SaveChanges();
                    return 1;
                }
            }
            catch (Exception) {
                return -1;
            }
        }
        //get course's resources
        public List<ShowResource> GetCourseResourcesList(string idCourse) {
            var resources = (from resourse in database.table_resource
                             where (resourse.idCourse == idCourse)
                             select new {
                                 idCourse = resourse.idCourse,
                                 idProfessor = resourse.idProfessor,
                                 linkResource = resourse.linkResource,
                                 nameResource = resourse.nameResource,
                                 numberResource = resourse.numberResource
                             }).ToList();
            List<ShowResource> result = new List<ShowResource>();
            foreach (var item in resources)
                result.Add(new ShowResource {
                    idCourse = item.idCourse,
                    idProfessor = item.idProfessor,
                    linkResource = item.linkResource,
                    nameResource = item.nameResource,
                    numberResource = item.numberResource
                });
            return result;
        }
        //delete a PracticeClass
        public int DeletePracticeClass(short groupNumber, short numberYearFromStart, bool termPracticeClass) {
            if (this.user.GetAccessLevel() < 3)
                return -2;
            if (!this.database.table_practiceclass.Any(practiceClass =>
             practiceClass.groupeNumberPracticeClass == groupNumber &&
             practiceClass.numberYearFromStart == numberYearFromStart &&
             practiceClass.termPracticeClass == term))
                return -3;
            try {
                //delete students from class
                var student_Class_relations = this.database.table_studentpracticeclass.Where(studentPrClass =>
                  studentPrClass.groupeNumberPracticeClass == groupNumber &&
               studentPrClass.numberYearFromStart == numberYearFromStart &&
               studentPrClass.termPracticeClass == term).ToList();
                foreach (var item in student_Class_relations)
                    item.deleted = true;
                //DeletePracticeClass Class
                this.database.table_practiceclass.Where(practiceClass =>
                  practiceClass.groupeNumberPracticeClass == groupNumber &&
               practiceClass.numberYearFromStart == numberYearFromStart &&
               practiceClass.termPracticeClass == term).First().deleted = true;
                var temp = this.database.table_practiceclass.Where(practiceClass =>
                  practiceClass.groupeNumberPracticeClass > groupNumber &&
               practiceClass.numberYearFromStart == numberYearFromStart &&
               practiceClass.termPracticeClass == term).ToList();
                foreach (var item in temp)
                    item.groupeNumberPracticeClass--;
                this.database.SaveChanges();
                return 1;
            }
            catch (Exception) {
                return -1;
            }
        }
        //get all courses from database
        public List<ShowCourse> GetAllCourses() {
            var temp = this.database.table_course.ToList();
            List<ShowCourse> result = new List<ShowCourse>();
            foreach (var item in temp) {
                result.Add(new ShowCourse { id = item.idCourse, name = item.nameCourse });
            }
            return result;
        }
      //get a id for course
       public string GetIdCourse(short groupNumber, bool term, short year)
        {
            string idCours="";
            var ID = from practiceClass in database.viewstudentlistclass
                     where (
                         practiceClass.numberYearFromStart == year &&
                         practiceClass.termPracticeClass == term &&
                         practiceClass.groupeNumberPracticeClass == groupNumber
                         )
                     select new
                     {  idCours = practiceClass.idCourse };
            foreach (var item in ID)
                idCours = item.idCours;
                             
            return idCours;
        }
    }
}


