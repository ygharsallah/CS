using System;
using System.Data.SqlTypes;

public class Class1
{
    static string? giveTipp(int age, string lastTipp)
    {
        switch (lastTipp)
        {
            case null:
                if (age >= 50)
                    return "between 50 and 100";

                return "between 0 and 49";

            case "between 50 and 100":
                if (age >= 75)
                    return "between 75 and 100";

                return "between 50 and 74";

            case "between 0 and 49":
                if (age >= 25)
                    return "between 25 and 50";

                return "between 0 and 24";

                
                
        }

        return null;
    }


    static void Main(string[] args)
    {
        string command;

        do
        {
            Console.WriteLine("Enter command (guess/calc/exit):");
            command = Console.ReadLine();

            switch (command)
            {
                case "guess":
                    Random rnd = new Random();
                    int age = rnd.Next(1, 100);
                    int guess;
                    string lastTipp = null;
                    int tries = 0;
                    do
                    {
                        guess = Int32.Parse(Console.ReadLine());
                        tries++;

                        if (tries >= 3)
                        {
                            Console.WriteLine("You are not allowed to divide by zero!");
                            break;
                        }

                        if (guess != age)
                        {
                            lastTipp = giveTipp(age, lastTipp);
                            Console.WriteLine($"Wrong! Tipp {lastTipp}");
                        }
                    } while (guess != age);

                    if (tries >= 3)
                    {
                        Console.WriteLine($"You tried {tries} times and you lost");
                    }
                    else
                    {
                        Console.WriteLine($"You got it, I am {age} years old.");
                    }

                    break;
                case "calc":
                    float a = float.Parse(Console.ReadLine());
                    float b = float.Parse(Console.ReadLine());
                    String option = Console.ReadLine();

                    switch (option)
                    {
                        case "add":
                            Console.WriteLine($"You added {a} {b} and got {a + b}");
                            break;
                        case "subtract":
                            Console.WriteLine($"You subtracted {a} {b} and got {a - b}");
                            break;
                        case "multiply":
                            Console.WriteLine($"You multiplied {a} {b} and got {a * b}");
                            break;
                        case "divide":
                            if (b == 0)
                            {
                                Console.WriteLine($"You are not allowed to divide by zero!");
                                return;
                            }

                            Console.WriteLine($"You divided {a} {b} and got {a / b}");
                            break;
                    }

                    break;
                case "exit":
                    Console.WriteLine($"Exiting...");
                    break;

                default;
                    break;
            }
        } while (command != "exit");
    }
}
