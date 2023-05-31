
using WorkingClassGuys;

Person joe = new Person() { Name = "Joe", Cash = 50 };

Person bob = new Person() { Name = "Bob", Cash = 100 };

while (true)
{
    joe.WriteMyInfo();
    bob.WriteMyInfo();

    Console.WriteLine("Enter an amount: ");
    string howMuch = Console.ReadLine();
    if (howMuch == "")
        return;

    if(int.TryParse(howMuch, out int amount))
    {
        Console.WriteLine("Who should give the money?");
        string whichGuy = Console.ReadLine();
        if(whichGuy == "Joe")
        {
            int joeGivesMoney = joe.GiveCash(amount);
            bob.RecievingCash(joeGivesMoney);
        }
        else if (whichGuy == "Bob")
        {
            int bobGivesMoney = bob.GiveCash(amount);
            joe.RecievingCash(bobGivesMoney);
        }
        else
        {
            Console.WriteLine("Please enter either 'Joe' or 'Bob'");
        }
    }
    else
    {
        Console.WriteLine("Please enter an amount (or a blank line to exit).");
    }
}
