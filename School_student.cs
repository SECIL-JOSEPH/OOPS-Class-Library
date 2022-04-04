using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Class_Library
{
    public class School_student
    {
        static int Id = 101;
        int roll_no;
        string name;
        DOB dob;
        int age;
        Gender gender_Choice;
        int stud_Class;
        char section;
        string address;        
        string date_of_joining;

        #region GET Properties
        public int Roll_no
        {
            get { return roll_no; }
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
        public int Stud_Class
        {
            get { return stud_Class; }
        }
        public char Section
        {
            get { return section; }
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

        public School_student(string name, DOB dob, int genderchoice, int Class, char section,string address)
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
            if (Class > 12 || Class < 1)
            {
                throw new Exception("Invalid Class");
            }

            this.roll_no = Id++;
            this.name = name;
            this.age = DateTime.Now.Year - dob.Year;
            this.gender_Choice = (Gender)genderchoice;
            this.stud_Class = Class;
            this.section = section;
            this.date_of_joining = DateTime.Now.ToString("dd'-'MM'-'yyyy");
            this.address = address;
        }
    }   
}