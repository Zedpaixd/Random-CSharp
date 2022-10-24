using System;
using System.Linq;

public class Driver
{

    public enum empType
    {
        all,
        programmers,
        marketers,
        testers
    };

	List<Programmer> programmers;
	List<Marketer> marketers;
	List<Tester> testers;

	public Driver(List<Programmer> programmers, List<Marketer> marketers, List<Tester> testers)
	{
		this.programmers = programmers;
		this.marketers = marketers;
		this.testers = testers;
	}

    public void allEmployees()
    {
        List<Employee> EmployeeList = new List<Employee>();
        EmployeeList.AddRange(programmers);
        EmployeeList.AddRange(marketers);
        EmployeeList.AddRange(testers);
        foreach (var employee in EmployeeList)
        {
            Console.WriteLine(employee.ToString());
        }
        EmpAmt(empType.all);
        SumSal(empType.all);
    }

	public void FindEmployee(string Keyword)
	{
		List<Employee> EmployeeList = new List<Employee>();
        EmployeeList.AddRange(programmers.FindAll(X => X.Name == Keyword || X.companyName == Keyword || X.Address == Keyword).ToList());
        EmployeeList.AddRange(marketers.FindAll(X => X.Name == Keyword || X.companyName == Keyword || X.Address == Keyword).ToList());
        EmployeeList.AddRange(testers.FindAll(X => X.Name == Keyword || X.companyName == Keyword || X.Address == Keyword).ToList());

		foreach(var employee in EmployeeList)
		{
            Console.WriteLine(employee.ToString());
		}

    }
    public void FindEmployee(int id)
    {
        List<Employee> EmployeeList = new List<Employee>();
        EmployeeList.AddRange(programmers.FindAll(X => X.employeeID == id).ToList());
        EmployeeList.AddRange(marketers.FindAll(X => X.employeeID == id).ToList());
        EmployeeList.AddRange(testers.FindAll(X => X.employeeID == id).ToList());

        foreach (var employee in EmployeeList)
        {
            Console.WriteLine(employee.ToString());
        }

    }

    public void EmpAmt(empType type)
    {
        switch (type)
        {
            case empType.programmers:
                Console.WriteLine(Programmer.Amount);
                break;
            case empType.marketers:
                Console.WriteLine(Marketer.Amount);
                break;
            case empType.testers:
                Console.WriteLine(Tester.Amount);
                break;
            case empType.all:
                Console.WriteLine((Tester.Amount + Marketer.Amount + Programmer.Amount));
                break;
            default:
                Console.WriteLine("typo");
                break;
        }
    }

    public void SumSal(empType type)
    {
        switch (type)    // this is good code
        {
            case empType.all:
                SalaryThing.addToList(programmers);
                SalaryThing.addToList(marketers);
                SalaryThing.addToList(testers);
                Console.WriteLine(SalaryThing.getSalaryCost());
                SalaryThing.removeFromList(marketers);
                SalaryThing.removeFromList(testers);
                SalaryThing.removeFromList(programmers);
                
                break;
            case empType.programmers:
                SalaryThing.addToList(programmers);
                Console.WriteLine(SalaryThing.getSalaryCost());
                SalaryThing.removeFromList(programmers);
                break;
            case empType.marketers:
                SalaryThing.addToList(marketers);
                Console.WriteLine(SalaryThing.getSalaryCost());
                SalaryThing.removeFromList(marketers);
                break;
            case empType.testers:
                SalaryThing.addToList(testers);
                Console.WriteLine(SalaryThing.getSalaryCost());
                SalaryThing.removeFromList(testers);
                break;
            default:
                Console.WriteLine("typo");
                break;
        }
    }

}
