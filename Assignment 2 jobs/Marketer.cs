using System;

public class Marketer : Employee
{
    private static int amt = 0;

    public static int Amount { get { return amt; } }

    public Marketer(Info information) : base(information.Name, information.Address, information.companyName, information.employeeID)
    {
        this.salary = information.salary;
        amt++;
    }
}
