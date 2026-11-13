public class Person <T , U>
{
    public T FirstName { get; set; }
    public T LastName {get; set ;}
    public U age { get; set; }
    public Person(T FirstName , T LastName , U age)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;   
        this.age = age;
    }

    public void display ()
    {
    Console.WriteLine ($"My name is : {FirstName} {LastName} , is age {age}");
    }
}
public class sutdent<I> : Repository <Person>
{
    public I id { get; set; }
    public void display()
    {
        Console.WriteLine($"Student is {FirstName} {LastName} ");
    }
}
class Program
{
    static void Main()
    {
        Person<string , int> s1 = new Person<string, int> ("Mostafa" ,"Khaled", 20);
        s1.display ();

    }
}