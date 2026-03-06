
class Person{
    string firstName;
    string lastName;
    int age;

    public Person(string fname, string lname, int a){
        if(string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname)){
            throw new ArgumentException("Please enter Name");
        }else{
            firstName = fname;
            lastName = lname;
        }
        if(a < 0){
            throw new ArgumentException("Age must be positive");
        }else{
            age = a;
        }
    }

    public void FullName(){
        Console.WriteLine($"{lastName}, {firstName}");
    }

    public bool isAdult(){
        return age>17;
    }
}