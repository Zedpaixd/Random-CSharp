using System;

public class Info
{
    public string Name;                 // this
    public string Address;              // is
    public string companyName;          // very
    public int employeeID;              // much
    public int salary;                  // ugly

    public Info(string name, string address, string companyName, int employeeID, int salary)
    {
        this.Name = name;               // but
        this.Address = address;         // anyway
        this.companyName = companyName; // might
        this.employeeID = employeeID;   // as
        this.salary = salary;           // well
    }
}

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region assigning programmers
            List<Programmer> programmers = new List<Programmer>();
            programmers.Add(new Programmer(new Info("John", "Address", "IBM", 123, 55555)));
            programmers.Add(new Programmer(new Info("Doe", "Address", "IBM", 123, 44444)));
            programmers.Add(new Programmer(new Info("Name1", "Address", "IBM", 123, 33333)));
            programmers.Add(new Programmer(new Info("Name2", "Address", "IBM", 123, 222222)));
            #endregion
            #region assigning marketers
            List<Marketer> marketers = new List<Marketer>();
            marketers.Add(new Marketer(new Info("Name3", "Address", "IBM", 123, 00005)));
            marketers.Add(new Marketer(new Info("Name4", "Address", "IBM", 123, 11111)));
            marketers.Add(new Marketer(new Info("Name5", "Address", "IBM", 123, 123456)));
            marketers.Add(new Marketer(new Info("Name6", "Address", "IBM", 123, 654321)));
            #endregion
            #region assigning testers
            List<Tester> testers = new List<Tester>();
            testers.Add(new Tester(new Info("Jhonny", "Address", "IBM", 123, 777777)));
            testers.Add(new Tester(new Info("Doey", "Address", "IBM", 123, 888888)));
            testers.Add(new Tester(new Info("Lorem", "Address", "IBM", 123, 9999)));
            testers.Add(new Tester(new Info("Ipsum", "Address", "IBM", 123, 123)));
            #endregion

            Driver mainDriver = new Driver(programmers, marketers, testers);
            mainDriver.FindEmployee("John");
            mainDriver.EmpAmt(Driver.empType.testers);
            mainDriver.EmpAmt(Driver.empType.programmers);
            mainDriver.EmpAmt(Driver.empType.marketers);

            mainDriver.allEmployees();
        }
    }
}