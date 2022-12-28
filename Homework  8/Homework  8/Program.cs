using System;
using System.ComponentModel;

namespace Homework__8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CodeAcademy course1=new CodeAcademy();
            course1.EducationalMethod();
            Console.WriteLine(course1);
            BakuITAcademy course2= new BakuITAcademy();
            course2.EducationalMethod();
            Console.WriteLine(course2);
            StepAcademy course3= new StepAcademy();
            course3.EducationalMethod();
            Console.WriteLine(course3);
        }
    }
}
