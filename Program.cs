using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public abstract class CPerson //employee name and employee number.
    {
        public string Name { get; set; }
        public int ENum { get; set; }
        public CPerson(string Name, int ENum)
        {
            this.Name = Name;
            this.ENum = ENum;
        }
        public CPerson()
        {
            Name = " ";
            ENum = 0;
        }
        public CPerson(int ENum)
        {
            Name = " ";
            this.ENum = ENum ;
        }
      // public abstract void data(string Name, int ENum); //data for the other employee classes.
      // public abstract void ShowDetails();
    }
    public class CWagedEmployee : CPerson //hourly rate of pay and number of hours worked this week - overtime - 1.5 - over 40 hours.
    {
        public double hrlyRate { get; set; } //hourly rate.
        public int hrsWorked { get; set; } //hours worked.
        public CWagedEmployee(int ENum) : base(ENum)
        {
            hrlyRate = 0;
            hrsWorked = 0;
        }
        public CWagedEmployee() : base()
        {
            hrlyRate = 0;
            hrsWorked = 0;
        }
        public CWagedEmployee(string Name, int ENum, double hrlyRate, int hrsWorked) : base(Name, ENum)
        {
            hrlyRate = 0;
            hrsWorked = 0;
        }
       /* public override void data(string Name, int ENum) //data for employee with name, ENum, hrlyRate and hrsWorked.
        {

        }*/
        public void WagedEmployee(string Name, int ENum, double hrlyRate, int hrsWorked, int Sal, int Sal1)
        {

        }
        /*public override void ShowDetails()
        {
            Console.WriteLine();
        }*/
    }
    public class CSalariedEmployee : CPerson //annual salary - weekly pay - 1/52 of salary.
    {
       // public int months { get; set; } //weeks in a year
        public int AnnualSal { get; set; } //annual salary
        public CSalariedEmployee(int ENum) : base (ENum)
        {
           // months = 12;
            AnnualSal = 0;
        }
        public CSalariedEmployee() : base()
        {
          //  months = 12;
            AnnualSal = 0;
        }
        public CSalariedEmployee(string Name, int ENum, int AnnualSal) : base(Name, ENum)
        {
           // week = 12;
            AnnualSal = 0;
        }
       /* public override void data(string Name, int ENum) //data for employee with name, ENum, weeks of year and annual salary.
        {

        }*/

        /*public void SalEmployee(string Name, int ENum, int AnnualSal, int salary, int salary1)
        {
            Console.Write("Joe Bloggs" + "004" + "45000");
            salary = AnnualSal / 12;
            Console.WriteLine(salary);
            Console.WriteLine("\n");
            Console.Write("Bob Jones" + "006" + "50000");
            salary1 = AnnualSal / 12;
            Console.WriteLine(salary1);
            
        }*/
        /*public override void ShowDetails()
        {
            Console.WriteLine(Name, ENum);
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Salaried Employee
            double Salary, Salary1;
            Console.WriteLine("Salaried Employees: ");
            CSalariedEmployee salaryEmployee = new CSalariedEmployee();
            salaryEmployee.Name = "John";
            salaryEmployee.ENum = 100;
            salaryEmployee.AnnualSal = 45000;
            Salary = salaryEmployee.AnnualSal / 52;
            Console.WriteLine("Name" + "\t " + "ID" + "\t " + "Salary");
            Console.WriteLine(salaryEmployee.Name + "\t " + salaryEmployee.ENum + "\t "  + Salary);
            salaryEmployee.Name = "Bob";
            salaryEmployee.ENum = 51;
            salaryEmployee.AnnualSal = 95100;
            Salary1 = salaryEmployee.AnnualSal / 52;
            Console.WriteLine(salaryEmployee.Name + "\t " + salaryEmployee.ENum + "\t " + Salary1);
            Console.WriteLine("\n");
            //Waged Employee
            double WSalary, WSalary1;
            Console.WriteLine("Waged Employees: ");
            CWagedEmployee wagedEmployee = new CWagedEmployee();
            wagedEmployee.Name = "Bill";
            wagedEmployee.ENum = 251;
            wagedEmployee.hrlyRate = 9.0;
            wagedEmployee.hrsWorked = 41;
            double Overtime1 = 0;
            if (wagedEmployee.hrsWorked > 40)
            {
                Overtime1 = wagedEmployee.hrsWorked - 40 + 1.5;
            }
            WSalary = (wagedEmployee.hrsWorked * wagedEmployee.hrlyRate) + Overtime1;
            Console.WriteLine("Name" + "\t " + "ID" + "\t " +
                               "Hourly Rate" + " \t" + "Hours Worked" + " \t" + "Salary");
            Console.WriteLine(wagedEmployee.Name + "\t" + wagedEmployee.ENum + "\t " +
                               wagedEmployee.hrlyRate + "\t\t" + wagedEmployee.hrsWorked + "\t\t " + WSalary);
            wagedEmployee.Name = "Jack";
            wagedEmployee.ENum = 23;
            wagedEmployee.hrlyRate = 7.5;
            wagedEmployee.hrsWorked = 50;
            double Overtime2 = 0;
            if (wagedEmployee.hrsWorked > 40)
            {
                Overtime2 = wagedEmployee.hrsWorked - 40 + 1.5;
            }
            WSalary1 = (wagedEmployee.hrsWorked * wagedEmployee.hrlyRate) + Overtime2;
            Console.WriteLine(wagedEmployee.Name + "\t" + wagedEmployee.ENum + "\t " +
                               wagedEmployee.hrlyRate + "\t\t" + wagedEmployee.hrsWorked + "\t\t " + WSalary1);

        }
    }
}