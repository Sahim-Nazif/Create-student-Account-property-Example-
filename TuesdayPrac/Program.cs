using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuesdayPrac
{
    class Student
    {
        //
        private string StName;
        private int Age;
        private double TuitionFees;
        private int StdId;//want to force it as a property
        
        // Constructors
        public Student()
        {

        }
        // overloaded constructor
        public Student(string StName, int Age, double TuitionFees)
        {
            this.StName = StName;
            this.Age = Age;
            this.TuitionFees = TuitionFees;
        }

     // Forced property

     public int StdID
        {
            get
            {
                return StdId;
            }
            set
            {
                this.StdId = value;
            }
        }

            // auto. impemented property
            public double TotalFeesPaid
        {
            get;
            set;
        }
        // methods to mainpulate the instance variables
        public void setStName (string StName)
        {
            this.StName = StName;
        }
        public string getName()
        {
            return StName;
        }
        public void setAge(int age)
        {
            Age = age;
        }
        public int getAge()
        {
            return Age;
        }
        public void SetTuitionFees(double TuitionFees)
        {

            this.TuitionFees = TuitionFees;
            
        }
        public double getTuitionFees()
        {
            return TuitionFees;
        }
        
        static void Main(string[] args)
        {
            Student Std1 = new Student();// empty student 
            Std1.setStName("Kate Kialon");
            Std1.setAge(30);
            Std1.SetTuitionFees(150);
            Console.WriteLine("\nName: " + Std1.getName() + "\nAge: " + Std1.getAge() + "\nTuition fees: " + Std1.getTuitionFees());

            Student std2 = new Student("John", 25, 3000.18); //calling the overloading constructor, loaded.
            Console.WriteLine("\nName: " + std2.getName() + "\nAge: " + std2.getAge() + "\nTuition fees: " + std2.getTuitionFees());

            Std1.StdId = 1222333; // using forced property
            Std1.TotalFeesPaid = 499.78;
            Console.WriteLine("\nStudent ID:" + Std1.StdId + "\nTotol Fees:" + Std1.TotalFeesPaid);

            Console.ReadKey();
               
        }
    }
}
