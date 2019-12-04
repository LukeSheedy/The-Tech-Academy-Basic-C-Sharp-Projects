using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();
        //ASKED AND STORED VALUE STRING


        Console.WriteLine("What page number?");
        string pageNum = Console.ReadLine();
        int numPage = Convert.ToInt32(pageNum);
        //ASKED AND STORED VALUE OF INTEGER AFTER CONVERTING

        Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
        string or = Console.ReadLine();
        //ASKED AND STORED VALUE STRING

    
        Console.ReadLine();
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string share = Console.ReadLine();
        Console.ReadLine();
        //ASKED AND STORED VALUE STRING

        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string feedback = Console.ReadLine();
        //ASKED AND STORED VALUE STRING

        Console.WriteLine("How many hours did you study today?");
        string study = Console.ReadLine();
        int hours = Convert.ToInt32(study);
        //ASKED AND STORED VALUE OF INTEGER AFTER CONVERTING


        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();
    }
}
