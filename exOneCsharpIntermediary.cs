public class Pet
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Making sound...");
    }
}

public class Dog : Pet
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof woof!");
    }
}

