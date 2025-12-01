# 1. Foundations of C#
    - basic syntax
    - Variables & data Types
    - Operator & expressions
    - Conditions (if, switch, loops, ...)
    - Namespaces
    - Errorhandling
    - Methods/Functions
    - Arrays & Tables & Dictionaries
    - Input/Output


  ## Simple Banking System in C#

This is a simple console-based banking system that allows you to:
- Create accounts
- Deposit money
- Show all account balances

```csharp
using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        Dictionary<string, double> accounts = new Dictionary<string, double>();
        string command;

        do {
            Console.WriteLine("Enter command (create/deposit/withdraw/show/exit):");
            command = Console.ReadLine();

            switch(command) {
                case "create":
                    Console.Write("Account name: ");
                    string name = Console.ReadLine();
                    accounts[name] = 0;
                    break;

                case "deposit":
                    Console.Write("Account name: ");
                    name = Console.ReadLine();
                    Console.Write("Amount: ");
                    double amount = double.Parse(Console.ReadLine());
                    accounts[name] += amount;
                    break;

                case "show":
                    foreach(var kvp in accounts)
                        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                    break;

                case "exit":
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        } while(command != "exit");
    }
}
