using System;

public class Programmer : Employee
{
	private static int amt = 0;

	public static int Amount { get { return amt; } }

	public Programmer(Info information) : base (information.Name,information.Address,information.companyName,information.employeeID)
	{
		this.salary = information.salary;
		amt++;
	}
}
