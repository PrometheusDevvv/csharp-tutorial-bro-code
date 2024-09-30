using System;


namespace BroCode;

internal class Output
{
    public Output()
    {
        Console.Write("Hey! ");
        Console.WriteLine("Hello!");

        //This is a comment

        /* 
          This
           is
           a
           multiline 
           comment
         */

        Console.WriteLine("\tBroCode"); // Writes In Console
        Console.WriteLine("Bro\bCode");  // Writes In Console But Appends New Line
        Console.WriteLine("Bro\nCode");
        Console.ReadKey(); // Waits for user key press.

    }
}
