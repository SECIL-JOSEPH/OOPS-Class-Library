using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Class_Library
{
    public class Centre_student
    {
        string name;
        DOB dob;
        int age;
        Gender gender_Choice;
        string phone_no;
        string email_id;
        string college;                
        Department department_choice;
        Degree degree_choice;
        Student_year stud_year;
        string date_of_joining;
        bool ispassedout;        
        int batch;        

        #region GET Properties
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
        public string Phone_no
        {
            get { return phone_no; }            
        }
        public string Email_id
        {
            get { return email_id; }            
        }
        public string College
        {
            get { return college; }            
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
        public string Date_of_joining
        {
            get { return date_of_joining; }
        }
        public int Batch
        {
            get { return batch; }            
        }
        public bool Ispassedout
        {
            get { return ispassedout; }
        }
        #endregion

        public Centre_student(string name, DOB dob, int genderchoice, string phoneNo,string email_id,string college,int departmentchoice, int degreechoice,int batch,bool ispassed)
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
            if (phoneNo.Length != 10)
            {
                throw new Exception("Invalid Phone number");
            }
            if (departmentchoice > 12 || departmentchoice < 1)
            {
                throw new Exception("Invalid Department");
            }
            if (degreechoice > 2 || degreechoice < 1)
            {
                throw new Exception("Invalid Degree");
            }            
            
            this.name = name;
            this.age = DateTime.Now.Year - dob.Year;
            this.gender_Choice = (Gender)genderchoice;
            this.phone_no = phoneNo;
            this.email_id=email_id;
            this.college = college;
            this.department_choice = (Department)departmentchoice;
            this.degree_choice = (Degree)degreechoice;            
            this.date_of_joining = DateTime.Now.ToString("dd'-'MM'-'yyyy");
            this.batch = batch;
            this.ispassedout = ispassed;
        }
     }
}
