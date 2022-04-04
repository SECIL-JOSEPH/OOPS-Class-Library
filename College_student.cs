using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Class_Library
{
    public class College_student
    {
        static int Id = 101;
        int dno;
        string name;
        DOB dob;        
        int age;
        Gender gender_Choice;
        Department department_choice;
        Degree degree_choice;
        Student_year stud_year;
        string address;                  
        string date_of_joining;

        #region GET Properties
        public int Dno
        {
            get { return dno; }
        }
        public string Name
        {
            get { return name; }
        }
        public DOB Dob
        {
            get { return dob; }            
        }
        public int Age
        {
            get { return age; }
        }
        public Gender Gender_Choice
        {
            get { return gender_Choice; }
        }
        public Department Department_choice
        {
            get { return department_choice; }            
        }
        public Degree Degree_choice
        {
            get { return degree_choice; }            
        }
        public Student_year StudentYear
        {
            get { return stud_year; }            
        }
        public string Address
        {
            get { return address; }            
        }
        public string Date_of_joining
        {
            get { return date_of_joining; }            
        }
        #endregion

        public College_student(string name, DOB dob, int genderchoice, int departmentchoice, int degreechoice, int studentyear,string address)
        {            
            for (int i = 0; i < name.Length; i++)
            {
                if ((name[i] < 65 && name[i] > 90) || (name[i] < 97 && name[i] > 122))
                {
                    throw new Exception("Invalid Name");
                }
            }
            if (genderchoice > 3 || genderchoice < 1)
            {
                throw new Exception("Invalid Gender");
            }
            if (departmentchoice > 12 || departmentchoice < 1)
            {
                throw new Exception("Invalid Department");
            }
            if (degreechoice> 2|| degreechoice< 1)
            {
                throw new Exception("Invalid Degree");
            }
            if ((studentyear > 3 || studentyear < 1) || (degreechoice == 2 && studentyear == 3))
            {
                throw new Exception("Invalid Student Year");
            }

            this.dno= Id++;
            this.name = name;
            this.age = DateTime.Now.Year - dob.Year;
            this.gender_Choice = (Gender)genderchoice;
            this.department_choice = (Department)departmentchoice;
            this.degree_choice = (Degree)degreechoice;
            this.stud_year = (Student_year)studentyear;
            this.date_of_joining = DateTime.Now.ToString("dd'-'MM'-'yyyy");
            this.address = address;
        }              
    }
     public enum Department
        {
        BA = 1,
        BSC = 2,
        BCA = 3,
        BBA=4,
        BCOM=5,
        BVOC = 6,        
        MA = 7,
        MSC = 8,
        MCA = 9,
        MBA=10,
        MCOM=11,        
        MVOC =12
     }
    public enum Degree
    {
        UG=1,PG=2
    }
    public enum Student_year
    {
        First=1,Second=2,Thrid=3
    }
}