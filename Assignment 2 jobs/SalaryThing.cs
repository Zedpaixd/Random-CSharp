using System;
using System.Linq;

public class SalaryThing
{
    static List<Employee> employees = new List<Employee>();


    public static void addToList<T>(List<T> list) where T : Employee
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (!employees.Contains(list[i]))
            {
                employees.Add(list[i]);
            }
        }
    }

    public static void removeFromList<T>(List<T> list) where T : Employee
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (employees.Contains(list[i]))
            {
                employees.Remove(list[i]);
            }
        }
    }

    public static float getSalaryCost()
    {
        float sum = employees.Sum(X => X.getSalary());

        return sum;
    }

    public SalaryThing()
    {

    }
}
