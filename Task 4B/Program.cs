using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{

    internal class Program
    {
       #region nothing to see here
    private static string link = "https://www.youtube.com/watch?v=r24Oq8sEaZ8";
    #endregion
        public static void ValidateStudent(Student stud)
        {
            Regex re = new Regex("^[0-9]*$");
            var match = re.IsMatch(stud.StudentID);
            if (!match) throw new notValidException(stud.StudentID);
            else Console.WriteLine("Success");
        }

        public static void Main(string[] args)
        {
            Student newStudent = null;
            try
            {
                newStudent = new Student();
                newStudent.StudentID = "James007";
                ValidateStudent(newStudent);
            }
            catch (notValidException e)
            { 
                Console.WriteLine(e.Message);
            }
            finally 
            {
                Console.WriteLine("\t\t\t\t(c) Armand");
                Thread.Sleep(2250);
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:" + link)
                {
                    CreateNoWindow = true
                });
            }
        }
    }
}