using System;

public class Employee : Person
{

	public string companyName;
	public int employeeID;

    protected int salary;

    public Employee(string name, string address, string companyName, int employeeID) : base(name,address)
	{
		this.companyName = companyName;
		this.employeeID = employeeID;
	}

	public override string ToString()
	{
		return string.Format("{0} {1} {2} {3} {4}", this.Name, this.employeeID, this.companyName, this.Address, this.salary);

    }

	public int getSalary()
	{
		return salary;
	}
}
