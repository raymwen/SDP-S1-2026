// See https://aka.ms/new-console-template for more information
using System;
class Program{

    static void Main(){

        List<string> toDoList = new List<string>{};
        bool exit = true;

        while (exit)
        {
            Console.WriteLine("Please input command [add|show|remove|clear|exit]: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "add": //If input id "add"
                    Console.WriteLine("Enter new Item: "); //Asks user for new item contents
                    string newItem = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(newItem))//input validation
                    {
                        Console.WriteLine("Item cannot be a whitespace or null. Please try again.");
                        break;
                    }
                    else
                    {
                        toDoList.Add(newItem);//adds item to list
                        break;
                    }

                case "show"://if user inputs "show"
                    for(int i = 0; i < toDoList.Count; i++) //loops through list and writes numbered elements
                    {
                        Console.WriteLine($"{i+1}. {toDoList[i]}");
                    }
                    break;

                case"remove"://if user inputs remove
                    Console.WriteLine("Input index of the item you would like to remove. Remember index starts at 1: ");
                    string idxstr = Console.ReadLine();
                    int idx;
                    if(!int.TryParse(idxstr, out idx)||idx>=toDoList.Count||idx<1)//input valudation, checking if is int or in range of list
                    {
                        Console.WriteLine("Not a valid index. Please try again.");
                        break;
                    }
                    else
                    {
                        toDoList.RemoveAt(idx-1);
                        break;
                    }
                
                case "clear"://if user inputs clear
                    toDoList.Clear();
                    break;

                case "exit"://added exit case to end program. does not save list.
                    exit = false;
                    break;

                default://if user inputs something else
                    Console.WriteLine("Invalid Input. Please try again.");
                    break;

            }

        }
        
    }
}