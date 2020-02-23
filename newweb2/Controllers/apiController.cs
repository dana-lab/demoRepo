using newweb2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace newweb2.Controllers
{
    public class apiController : ApiController
    {

            private static List<Student> stdlist = new List<Student>{
                            new Student() { StudentId = 1, StudentName = "John", Age = 18} ,
                            new Student() { StudentId = 2, StudentName = "Steve", Age = 19} ,
                            new Student() { StudentId = 3, StudentName = "Bill", Age = 17} ,
                            new Student() { StudentId = 4, StudentName = "Ram" , Age = 14} ,
                            new Student() { StudentId = 5, StudentName = "Ron" ,  Age = 13} ,
                            new Student() { StudentId = 6, StudentName = "Chris" , Age = 12 } ,
                            new Student() { StudentId = 7, StudentName = "Rob" , Age = 15}
                        };




            public IEnumerable<Student> GetAll()
            {
                var list1 = stdlist.ToList();
                return list1;
            }
            

            public Student Get(int id)
            {
                return stdlist.FirstOrDefault(x => x.StudentId == id);
            }

            [System.Web.Http.HttpDelete]
            public Student Detlete(int id)
            {
                var stdRemove = stdlist.FirstOrDefault(x => x.StudentId == id);
                stdlist.Remove(stdRemove);
                return (stdRemove);
            }

            [System.Web.Http.HttpPut]
            public Student Update(Student std)
            {

                var index = stdlist.FirstOrDefault(x => x.StudentId == std.StudentId);
                stdlist.Remove(index);
                stdlist.Add(index);
                return (index);


            }
        }
    }

