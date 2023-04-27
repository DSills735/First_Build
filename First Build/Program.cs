using First_Build;
var menu = new Menu();

var games = new List<string>();

string name = GetName();
var date = DateTime.UtcNow;
 string GetName()
{
    Console.WriteLine("Please type your name!");

    var name = Console.ReadLine();
    return name;
}

menu.ShowMenu(name, date);
