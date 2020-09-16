using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace InterviewQuestion
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }

    }
    public class LinqQuery
    {
        public delegate int del(int i, int y);
        public delegate string stringResult();

        List<Student> stu = new List<Student> {
            new Student {  Id=1,Name="Peeyush",Age=30},
            new Student { Id = 2, Name = "Maneesh", Age = 20 },
            new Student {  Id=3,Name="Psdsds",Age=40},
            new Student {  Id=4,Name="Psfdsfs",Age=null}
            };

        public void SelectQuery()
        {
            
            //1
            int[] marks = { 1, 2, 3, 4, 5, 6, 7 };
            IEnumerable<int> resilt = from ppp in marks
                                      where ppp % 2 == 0
                                      select ppp;
            var dd = marks.Where(s => s % 2 == 0);

            foreach (var a in dd)
            {
                Console.WriteLine("Even Numbber:" + a);
            }
            //2 && and ||
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            IEnumerable<int> result = from spp in data
                                      where spp % 2 == 0 && spp > 100
                                      select spp;
            foreach (var i in result)
            {
                Console.WriteLine("And operator:" + i);
            }
            IEnumerable<int> or = from a in data
                                  where a % 2 == 0 || a > 100
                                  select a;
            foreach (var i in or)
            {
                Console.WriteLine("And operator:" + i);
            }

            //3 string array
            string[] name = { "aad", "baa", "cad", "dad", "adas fdsf" };
            IEnumerable<String> ds = from s in name
                                     where s.StartsWith("a")
                                     select s;

            foreach (var i in ds)
            {
                Console.WriteLine("StartWith A:" + i);
            }

            //4- object type data 
            

            IEnumerable<Student> students = from s in stu
                                            where s.Name.StartsWith("P") && s.Age>20
                                            select s;

            foreach(var ss in students)
            {
                Console.WriteLine("Id:{0} and Name:{1}  and  Age:{2}",ss.Id,ss.Name,ss.Age);
            }
            Console.WriteLine("===========================================================");
            //5 Shorting
            IEnumerable<Student> students1 = from dddd in stu
                                             orderby dddd.Name
                                             select dddd;
            foreach (var ss in students1)
            {
                Console.WriteLine("Id:{0} and Name:{1}  and  Age:{2}", ss.Id, ss.Name, ss.Age);
            }

            // Lambda expression : kind of anonymous function as written in in line function which dont have function name
            del d = (a, b) => a + b;
            int p = d(2, 3);
            Console.WriteLine("Sum:",p);
            stringResult dss = () => "peeyush";
            Console.WriteLine("Delegate:",dss());

            int[] datas = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> dsa = datas.Where(s => s % 2 == 0);
            foreach (var i in dsa)
            {
                Console.WriteLine(" Lambda check :" + i);
            }


            // aggregate functions   sum extention method lambda for student class 
            int? students2 = stu.Where(x => x.Age > 20).Sum(s => s.Age);
            //min and max
            int minvalue = datas.Min();
            int maxvalue = datas.Max();
            int? dstud = stu.Where(a => a.Age > 20).Min(ss => ss.Age);
            Console.WriteLine("min student :"+dstud);
            //count and long count 


            //Practice Query 

            //Average extension function
            double? ff = stu.Average(s => s.Age);
            Console.WriteLine("Average Age:"+ff);
        }


    }
}
