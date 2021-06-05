using System;
namespace DataStructure.DesignPattern.Singleton
{
    public class Employee
    {

        public void notifyEmployee()
        {
            email.notifyEmployee();
        }

        IEmail email;
        public int empId;

        public string empName;

        public Employee(int empId, string empName, IEmail emailService)
        {
            this.empId = empId;
            this.empName = empName;
            this.email = emailService;
        }
    }


    public interface IEmail
    {
        public void notifyEmployee();
    }


    public class OutlookMail: IEmail
    {
        public void notifyEmployee()
        {
            Console.WriteLine("hello from employee: this message is from Outlook server!!");
        }
    }

    public class Gmail: IEmail
    {
        public void notifyEmployee()
        {
            Console.WriteLine("Hello from employee: this message is from Gmail server!!");
        }
    }
}
