using System;

class Program{

    static void Main(){
        Person p = new Person("John", "Smith", 25);

        p.FullName();
        Console.WriteLine(p.isAdult());
    }

}

