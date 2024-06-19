namespace DangerBug;

public class App
{
List<Bug> bugs = new List<Bug>()
{
    new Bee("Bee",true,true,true,true,"ichiness"),
    new Mosquito("Mosquito",true,true,true,true,"too many bites cause fever",
        true),
    new Spider("Spider",true,true,true, false,"can cause serious problems","eat mosquiroes and houseflies"),
    new Tick("Ticks",true,true,true,false,"can cause infections"),
    new HouseFlies("Houseflies",false,true,true,true,"can spread diseases")
};

public void ShowInfo()
{
    Console.WriteLine("Bugs Info: ");
    foreach (var bug in bugs)
    {
        Console.WriteLine(bug);
    }
}

public void Menu()
{
    Console.WriteLine($"\tMenu\npress 1 to show all bugs\npress 2 to add new bug\npress 5 to exit");
}

public void Run()
{
    while (true)
    {
        Menu();
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1: 
                ShowInfo();
                break;
            case 2: 
                AddNewBug();
                break;
            case 5: 
                return;
            default:
                Console.WriteLine("wrong input!");
                break;
            
        }
    }
}

public void AddNewBug()
{
    Console.Write("Enter Name: ");
    string name = Console.ReadLine();
    Console.Write("can bite? ");
    bool canBite = Console.ReadLine()=="true";
    Console.Write("has legs? ");
    bool hasLegs = Console.ReadLine()=="true";
    Console.Write("can move? ");
    bool canMove = Console.ReadLine()=="true";
    Console.Write("can fly? ");
    bool canFly = Console.ReadLine()=="true";
    Console.Write("cause problems? ");
    string problem = Console.ReadLine();
    
    bugs.Add(new CustomBug(name,canBite,hasLegs,canMove,canFly,problem));
    Console.WriteLine($"Info Added : {name}");
}
}