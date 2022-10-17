using System;

public class Student : Person
{
	public Student()
	{
	}
	
	public void Study()
	{
		Console.WriteLine("Student: I am not a studying student");
	}

	public void ShowAge()
	{
		Console.WriteLine(String.Format("Also Student: I am {0} year(s) old", age));
	}
}
