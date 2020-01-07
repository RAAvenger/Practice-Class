using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeClass {
    class classPracticeClass {
        //variables
        //to access to app database
        private database_practiceclass database;
        private bool term { get; }
        private short numberYearFromStart { get; }
        private short groupNumber { get; }
        private string idCourse;
        private string nameCourse { get; }
        private string idProfessor { get; }
        private string fullNameProfessor { get; }
        private string idTA { get; }
        private string fullNameTA { get; }
        //methods
        public classPracticeClass(bool term, short numberYearFromStart, short groupNumber) {
            //set basic data
            this.database = new
database_practiceclass();
            this.term = term;
            this.numberYearFromStart = numberYearFromStart;
            this.groupNumber = groupNumber;
            //get other basic data from database
            var temp = from practiceClass in database.viewlistclass
                       where (
                                 practiceClass.numberYearFromStart == this.numberYearFromStart &&
                                 practiceClass.termPracticeClass == this.term &&
                                 practiceClass.groupeNumberPracticeClass == this.groupNumber
                                 )
                       select new {
                           nameCourse = practiceClass.nameCourse,
                           //idCourse = practiceClass.idCourse,
                           fullNameTA = practiceClass.tafn + " " + practiceClass.taln,
                           idTA = practiceClass.idTA,
                           fullNameProfessor = practiceClass.prffn + " " + practiceClass.pfln,
                           idProfessor = practiceClass.idProfessor,
                       };
            //this.idCourse = temp.First().idCourse;
            this.nameCourse = temp.First().nameCourse.ToString();
            this.idProfessor = temp.First().idProfessor;
            this.fullNameProfessor = temp.First().fullNameProfessor;
            this.idTA = temp.First().idTA;
            this.fullNameTA = temp.First().fullNameTA;
            this.idCourse = this.database.table_course.Where(course => course.nameCourse == this.nameCourse).First().idCourse;
        }
        public string getIDCourse() {
            return this.idCourse;
        }
        private bool IsStudentOfClass(string id) => this.database.table_studentpracticeclass.Any(
                    practiceClass =>
                    practiceClass.groupeNumberPracticeClass == this.groupNumber &&
                    practiceClass.numberYearFromStart == this.numberYearFromStart &&
                    practiceClass.termPracticeClass == this.term &&
                    practiceClass.idStudent == id &&
                    practiceClass.deleted == false
                );
        public List<ShowStudent> GetClassStudentList() {
            var students = (from practiceClass in database.viewlistclassmember
                            where (
                            practiceClass.numberYearFromStart == this.numberYearFromStart &&
                            practiceClass.termPracticeClass == this.term
                            )
                            select new {
                                fullName = practiceClass.stufn + " " + practiceClass.stuln,
                                id = practiceClass.idStudent,
                                // grade may be "null" 
                                grade = practiceClass.gradePracticeClassStudent
                            }).ToList();
            List<ShowStudent> result = new List<ShowStudent>();
            foreach (var item in students)
                result.Add(new ShowStudent {
                    fullName = item.fullName,
                    grade = item.grade,
                    id = item.id
                });
            return result;
        }
        //set final grade for student
        //"-2" means "wrong student id", "-3" means "wrong TAid", "-1" means "somthing went wrong" and "1" means "Done!" 
        public int SetStudentGrade(string idTA, string idStudent, float grade) {
            if (!IsStudentOfClass(idStudent))
                return -2;
            if (idTA != this.idTA)
                return -3;
            try {
                var student = (from item in database.table_studentpracticeclass
                               where (
                                    item.idStudent == idStudent &&
                                    item.groupeNumberPracticeClass == this.groupNumber &&
                                    item.termPracticeClass == this.term)
                               select item
                           ).ToList().First();
                student.gradePracticeClassStudent = grade;
                database.SaveChanges();
                return 1;
            }
            catch (Exception) {
                return -1;
            }
        }
        //add new student to class
        //"-2" means "wrong idStudent", "-3" means "idStudent = idTA", "-4" means "student_class relation already exists and not deleted", "-1" means "general error" and "1" means "done"
        public int AddStudentToClass(string idStudent) {
            if (!this.database.table_student.Any(student => student.idStudent == idStudent))
                return -2;
            if (idStudent == this.idTA)
                return -3;
            try {
                //Student_class relation already exists
                if (this.database.table_studentpracticeclass.Any(student =>
                 student.idStudent == idStudent &&
                 student.groupeNumberPracticeClass == this.groupNumber &&
                 student.numberYearFromStart == this.numberYearFromStart &&
                 student.termPracticeClass == this.term)) {
                    var temp = this.database.table_studentpracticeclass.Where(student =>
                                   student.idStudent == idStudent &&
                                   student.groupeNumberPracticeClass == this.groupNumber &&
                                   student.numberYearFromStart == this.numberYearFromStart &&
                                   student.termPracticeClass == this.term).First();
                    //Student_class relation is deleted so we unDelete it
                    if (temp.deleted) {
                        temp.deleted = false;
                        this.database.SaveChanges();
                        return 1;
                    }
                    //student_class relation is not deleted
                    else
                        return -4;
                }
                else {
                    table_studentpracticeclass newClassStudent = new table_studentpracticeclass {
                        groupeNumberPracticeClass = this.groupNumber,
                        idStudent = idStudent,
                        numberYearFromStart = this.numberYearFromStart,
                        termPracticeClass = this.term,
                        deleted = false
                    };
                    this.database.table_studentpracticeclass.Add(newClassStudent);
                    this.database.SaveChanges();
                    return 1;
                }
            }
            catch (Exception) {
                return -1;
            }
        }
        //edit this class
        //"-1" means "general ErroR" and "1" means "Done"
        public int EditPracticeClass(string newIDCourse, string newIDTA, short newNumberYearFromStart, bool newTermPracticeClass) {
            try {
                var practiceClass = (from pClass in this.database.table_practiceclass
                                     where (
                                     pClass.groupeNumberPracticeClass == this.groupNumber &&
                                     pClass.numberYearFromStart == this.numberYearFromStart &&
                                     pClass.termPracticeClass == this.term)
                                     select pClass).ToList().First();
                if (newIDCourse != practiceClass.idCourse)
                    practiceClass.idCourse = newIDCourse;
                if (newIDTA != practiceClass.idTA)
                    practiceClass.idTA = newIDTA;
                if (newNumberYearFromStart != practiceClass.numberYearFromStart || newTermPracticeClass != practiceClass.termPracticeClass) {
                    practiceClass.numberYearFromStart = newNumberYearFromStart;
                    practiceClass.termPracticeClass = newTermPracticeClass;
                    practiceClass.groupeNumberPracticeClass = (short)((from t in this.database.table_practiceclass
                                                                       where (
                                                                       t.numberYearFromStart == newNumberYearFromStart &&
                                                                       t.termPracticeClass == newTermPracticeClass)
                                                                       select t).ToList().Max(g => g.groupeNumberPracticeClass) + 1);
                    //select classes with biger groupNumber and "--" groupNumber of them
                    var shiftLeft = (from t in this.database.table_practiceclass
                                     where (
                                     t.numberYearFromStart == this.numberYearFromStart &&
                                     t.termPracticeClass == this.term)
                                     select t).ToList();
                    foreach (var item in shiftLeft)
                        item.groupeNumberPracticeClass--;
                }
                database.SaveChanges();
                return 1;
            }
            catch (Exception) {
                return -1;
            }
        }
        //delete student from this class
        //"-2" means wrong student, "-1" means "general ErroR" and "1" means "Done"
        public int DeleteStodentFromClass(string idStudent) {
            if (!this.database.table_studentpracticeclass.Any(studentPrClass =>
            studentPrClass.groupeNumberPracticeClass == this.groupNumber &&
            studentPrClass.numberYearFromStart == this.numberYearFromStart &&
            studentPrClass.termPracticeClass == this.term &&
            studentPrClass.idStudent == idStudent))
                return -2;
            try {
                this.database.table_studentpracticeclass.Where(studentPrClass =>
                studentPrClass.groupeNumberPracticeClass == this.groupNumber &&
                studentPrClass.numberYearFromStart == this.numberYearFromStart &&
                studentPrClass.termPracticeClass == this.term &&
                studentPrClass.idStudent == idStudent).First().deleted = true;
                database.SaveChanges();
                return 1;
            }
            catch (Exception) {
                return -1;
            }
        }
        //phase 2 or 3
        private bool IsPracticeOfClass(short number, short part) => this.database.table_practice.Any(
                    practice =>
                    practice.groupeNumberPracticeClass == this.groupNumber &&
                    practice.numberYearFromStart == this.numberYearFromStart &&
                    practice.termPracticeClass == this.term &&
                    practice.numberPractice == number &&
                    practice.partPractice == part &&
                    practice.deleted == false
                );
        public List<ShowPractice> GetClassPracticeList() {
            var practiceList = from practice in database.table_practice
                               where (
                               practice.groupeNumberPracticeClass == this.groupNumber &&
                               practice.numberYearFromStart == this.numberYearFromStart &&
                               practice.termPracticeClass == this.term &&
                               practice.deleted == false
                               )
                               select new {
                                   number = practice.numberPractice,
                                   link = practice.linkPractice,
                                   part = practice.partPractice,
                                   idUploader = practice.idUploader
                               };
            List<ShowPractice> result = new List<ShowPractice>();
            foreach (var item in practiceList)
                result.Add(new ShowPractice {
                    number = item.number,
                    link = item.link,
                    part = item.part,
                    idUploader = item.idUploader
                });
            return result;
        }
        public List<ShowQuiz> GetClassQuizList() {
            //get quizList from database
            var quizList = from quiz in database.table_quiz
                           where (
                           quiz.groupeNumberPracticeClass == this.groupNumber &&
                           quiz.numberYearFromStart == this.numberYearFromStart &&
                           quiz.termPracticeClass == this.term &&
                           quiz.deleted == false
                           )
                           select new {
                               date = quiz.dateQuiz.ToString(),
                               number = quiz.numberQuiz
                           };
            //convert quizList to a List of struct "ShoeQuiz"
            List<ShowQuiz> result = new List<ShowQuiz>();
            foreach (var item in quizList)
                result.Add(new ShowQuiz {
                    date = DateTime.Parse(item.date),
                    number = item.number
                });
            return result;
        }
        //"-2" means "wrong student id", "-3" means "wrong practice (does not exists)", "-4" means "reapeted solved pracrice or link"
        public int AddSolvedPractice(short practiceNumber, short practicePart, string userID, string SolvedPracticelink) {
            if (!IsStudentOfClass(userID))
                return -2;
            if (!IsPracticeOfClass(practiceNumber, practicePart))
                return -3;
            if (this.database.table_practicestudent.Any(solvedPractice =>
                        (solvedPractice.groupeNumberPracticeClass == this.groupNumber &&
                        solvedPractice.numberYearFromStart == this.numberYearFromStart &&
                        solvedPractice.termPracticeClass == this.term &&
                        solvedPractice.partPractice == practicePart &&
                        solvedPractice.numberPractice == practiceNumber &&
                        solvedPractice.idStudent == userID) ||
                        solvedPractice.linkSolvedPractice == SolvedPracticelink)
                )
                return -4;
            database.table_practicestudent.Add(new table_practicestudent {
                groupeNumberPracticeClass = this.groupNumber,
                numberYearFromStart = this.numberYearFromStart,
                termPracticeClass = this.term,
                partPractice = practicePart,
                numberPractice = practiceNumber,
                idStudent = userID,
                linkSolvedPractice = SolvedPracticelink,
                timePracticeStudent = DateTime.Now
            });
            return 1;
        }
      
        public string GetIdCourse()
        {
            classBase baseItem = new classBase();
            return baseItem.GetIdCourse(this.numberYearFromStart, this.term, this.groupNumber);       
        }
    }
}
