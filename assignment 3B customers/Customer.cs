using MyApp;
using System;

public class Customer
{

	public string FullName;
	public int Age;
	public string Email;

	public Customer(string fullName, int age, string email)
	{
		FullName = fullName;
		Age = age;
		Email = email;
	}

	public string getInfo()
	{
		return string.Format("Name: {0} | Age: {1} | Email: {2}",FullName,Age,Email);
	}

}
