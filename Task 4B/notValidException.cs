using System;

public class notValidException : Exception
{
    public notValidException(string id) : base(String.Format("Invalid ID: {0}", id)) { }
}
