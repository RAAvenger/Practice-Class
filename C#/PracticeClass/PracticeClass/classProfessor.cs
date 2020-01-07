using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeClass {
    class classProfessor : classUser {
        //variables
        private string id;
        private string firstName;
        private string lastName;
        private short numberYearFromStart;
        private bool term;
        //3 = professor, 2 = PrimeProfessor
        private int accessLevel;
        //to access to app database
        private database_practiceclass database;

        //methods
        public classProfessor(string newID, database_practiceclass newDatabase, bool newIsPrimeProfessor, short newNumberYearFromStart, bool newTerm) {
            //set values on creat
            this.id = newID;
            this.accessLevel = newIsPrimeProfessor ? 4 : 3;
            this.database = newDatabase;
            this.numberYearFromStart = newNumberYearFromStart;
            this.term = newTerm;
            var firstAndLastName = from professor in database.table_user
                                   where (professor.idUser == this.id)
                                   select new {
                                       firstName = professor.firstNameUser,
                                       lastName = professor.lastNameUser
                                   };
            this.firstName = firstAndLastName.First().firstName;
            this.lastName = firstAndLastName.First().lastName;

        }
        //returns student homePage's list of classes as a list of struct "ShowClass"
        public override string GetID() {
            return this.id;
        }
        //return full name
        public override string GetFullName() {
            return firstName + ' ' + lastName;
        }
        public override int GetAccessLevel() {
            return this.accessLevel;
        }
        //get professor's classes for this term and year
        public List<ShowClass> GetProfessorOnGoingClassesList() {
            //select values from database and add them to list
            var practiceClasses = (from practiceClass in database.viewlistclass
                                   where (
                                   practiceClass.numberYearFromStart == this.numberYearFromStart &&
                                   practiceClass.termPracticeClass == this.term &&
                                   //   practiceClass.status == true &&
                                   practiceClass.idProfessor == this.id
                                   )
                                   select new {
                                       fullNameProfessor = practiceClass.prffn + " " + practiceClass.pfln,
                                       fullNameTA = practiceClass.tafn + " " + practiceClass.taln,
                                       groupNumber = practiceClass.groupeNumberPracticeClass,
                                       nameCourse = practiceClass.nameCourse.ToString(),
                                       term = this.term,
                                       year = this.numberYearFromStart,
                                       grade = -1
                                   }).ToList();
            List<ShowClass> result = new List<ShowClass>();
            foreach (var item in practiceClasses)
                result.Add(new ShowClass {
                    fullNameProfessor = item.fullNameProfessor,
                    fullNameTA = item.fullNameTA,
                    groupNumber = item.groupNumber,
                    nameCourse = item.nameCourse,
                    term = item.term,
                    year = item.year
                });
            return result;
        }
        //add new resource for a course
        //"-2" means wrong idCourse, "-3" means "resourceName or Link already exists","-4" means "this resource alrady exists", "-1" means "general error" and "1" means "done"
        public int AddResource(string idCourse, string linkResource, string nameResource) {
            if (!this.database.table_course.Any(course => course.idCourse == idCourse))
                return -2;
            if (this.database.table_resource.Any(resource => resource.nameResource == nameResource || resource.linkResource == linkResource && resource.deleted == false))
                return -3;
            try {
                //resource already exists
                if (this.database.table_resource.Any(resource =>
                   resource.idCourse == idCourse &&
                       resource.idProfessor == this.id &&
                       resource.linkResource == linkResource &&
                       resource.nameResource == nameResource
                    )) {
                    var res = this.database.table_resource.Where(resource =>
                      resource.idCourse == idCourse &&
                          resource.idProfessor == this.id &&
                          resource.linkResource == linkResource &&
                          resource.nameResource == nameResource
                        ).First();
                    //resource is deleted so unDelete it
                    if (res.deleted) {
                        res.deleted = false;
                        //res.numberResource = (short)((from selectres in database.table_resource
                        //                              where selectres.idCourse == idCourse
                        //                              select selectres)
                        //                      .ToList()
                        //                      .Max(num => num.numberResource) + 1);
                        this.database.SaveChanges();
                        return 1;
                    }
                    //resource is not deleted
                    else
                        return -4;
                }
                table_resource newResourse = new table_resource {
                    idCourse = idCourse,
                    idProfessor = this.id,
                    linkResource = linkResource,
                    nameResource = nameResource,
                    numberResource = (short)((from res in database.table_resource
                                              where res.idCourse == idCourse
                                              select res)
                                              .ToList()
                                              .Max(num => num.numberResource) + 1),
                    deleted = false
                };
                return 1;
            }
            catch (Exception) {
                return -1;
            }
        }
        public List<ShowResource> GetProfessorResourcesList() {
            var resources = (from resourse in database.table_resource
                             where (resourse.idProfessor == this.id)
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
        //edit Professor's Resources
        public int EditProfessorResource(string idCourse, short numberResource, string newIDCourse, string newLinkResource, string newNameResource) {

            if (!this.database.table_resource.Any(res =>
            res.idCourse == idCourse &&
            res.numberResource == numberResource &&
            res.idProfessor == this.id))
                return -2;
            try {
                var resource = (from res in this.database.table_resource
                                where (res.idCourse == idCourse &&
                                res.numberResource == numberResource &&
                                res.idProfessor == this.id)
                                select res).ToList().First();
                if (newIDCourse != resource.idCourse) {
                    resource.idCourse = newIDCourse;
                    resource.numberResource = (short)((from res in this.database.table_resource
                                                       where (res.idCourse == newIDCourse)
                                                       select res).ToList().Max(num => num.numberResource) + 1);
                    var temp = (from res in this.database.table_resource
                                where (res.idCourse == idCourse && res.numberResource > numberResource)
                                select res).ToList();
                    foreach (var item in temp)
                        item.numberResource--;
                }
                if (newLinkResource != resource.linkResource)
                    resource.linkResource = newLinkResource;
                if (newNameResource != resource.nameResource)
                    resource.nameResource = newNameResource;
                database.SaveChanges();
                return 1;
            }
            catch (Exception) {
                return -1;
            }
        }
        //delete professor's resource
        //"-2" means "resource doesen't exists", "-1" means "general ErroR" and "1" means "done"
        public int DeleteProfessorResource(short numberResource, string idCourse) {
            var resource = this.database.table_resource.Where(res => res.idCourse == idCourse && res.numberResource == numberResource).First();
            if (resource == null)
                return -2;
            try {
                resource.deleted = true;
                this.database.SaveChanges();
                return 1;
            }
            catch (Exception) {
                return -1;
            }
        }
        //get professor's classes but not for this term and year
        public List<ShowClass> GetProfessorArchivedClassesList() {
            //select values from database and add them to list
            var practiceClasses = (from practiceClass in database.viewlistclass
                                   where (
                                   (practiceClass.numberYearFromStart != this.numberYearFromStart ||
                                   practiceClass.termPracticeClass != this.term) &&
                                   //   practiceClass.status == true &&
                                   practiceClass.idProfessor == this.id
                                   )
                                   select new {
                                       fullNameProfessor = practiceClass.prffn + " " + practiceClass.pfln,
                                       fullNameTA = practiceClass.tafn + " " + practiceClass.taln,
                                       groupNumber = practiceClass.groupeNumberPracticeClass,
                                       nameCourse = practiceClass.nameCourse.ToString(),
                                       term = this.term,
                                       year = this.numberYearFromStart,
                                       grade = -1
                                   }).ToList();
            List<ShowClass> result = new List<ShowClass>();
            foreach (var item in practiceClasses)
                result.Add(new ShowClass {
                    fullNameProfessor = item.fullNameProfessor,
                    fullNameTA = item.fullNameTA,
                    groupNumber = item.groupNumber,
                    nameCourse = item.nameCourse,
                    term = item.term,
                    year = item.year
                });
            return result;
        }
    }
}
