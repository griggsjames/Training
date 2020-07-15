using System;

namespace HelloCSharp
{
    class Program
    {
       static void Main()
        {
         Console.Write("enter first name:  ");   
         
         var firstName = Console.ReadLine(); // lazy, datatype is given based on content of ReadLine
         
         Console.Write("enter last name:  ");
         
         string lastName = Console.ReadLine(); // eager, datatype is explicit prior to context of ReadLine
         
         Console.WriteLine(firstName + " " + lastName);
         Console.WriteLine("{0} {1}", firstName, lastName);
         Console.WriteLine($"{firstName} {lastName}");
         //Console.WriteLine(firstName);
         //Console.WriteLine(lastName);

         Console.ReadLine();
        }
    }
}