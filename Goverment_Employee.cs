using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Class_Library
{
    public class Goverment_Employee
    {
        static int Id = 1001;
        int emp_id;
        string name;
        DOB dob;
        int age;
        Gender gender_Choice;
        marital_status marital_status;
        string phone_no;
        string email_id;
        string address;
        string department;
        int salary;
        string date_of_joining;

        #region GET Properties
        public int Emp_id
        {
            get { return emp_id; }
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
        public marital_status Marital_status
        {
            get { return marital_status; }
        }
        public string Phone_no
        {
            get { return phone_no; }
        }
        public string Email_id
        {
            get { return email_id; }
        }
        public string Address
        {
            get { return address; }
        }
        public string Department
        {
            get { return department; }
        }        
        public int Salary
        {
            get { return salary; }
        }
        public string Date_of_joining
        {
            get { return date_of_joining; }
        }
        #endregion
        public Goverment_Employee(string name, DOB dob, int genderchoice, int maritalchoice, string phoneNo, string email_id, string address, string department,int salary)
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
            if (maritalchoice > 2 || maritalchoice < 1)
            {
                throw new Exception("Invalid Detail");
            }
            if (phoneNo.Length != 10)
            {
                throw new Exception("Invalid Phone number");
            }            

            this.name = name;
            this.age = DateTime.Now.Year - dob.Year;
            this.gender_Choice = (Gender)genderchoice;
            this.marital_status =(marital_status) maritalchoice;
            this.phone_no = phoneNo;
            this.email_id = email_id;
            this.address= address;
            this.department = department;
            this.salary = salary;
            this.date_of_joining = DateTime.Now.ToString("dd'-'MM'-'yyyy");           
        }
    }
    public enum marital_status
    {
        Married=1,
        Unmarried=2
    }
}