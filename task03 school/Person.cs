using System;

public class Person
{
	public int age;

	public Person()
	{
	}

	public void Greet()
	{
		Console.WriteLine("Inherited Class: Hi");
	}

	public void setAge(int newAge)
	{
		this.age = newAge;
	}
}
