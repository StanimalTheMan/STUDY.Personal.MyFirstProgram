using MyFirstProgram;

var menu = new Menu();

var date = DateTime.UtcNow;

// List<string> games = new List<string>();
// List<string> games = new();
var games = new List<string>();

string name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}