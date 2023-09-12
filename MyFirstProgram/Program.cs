using MyFirstProgram;

var menu = new Menu();

var date = DateTime.UtcNow;

// List<string> games = new List<string>();
// List<string> games = new();
var games = new List<string>();

string name = Helpers.GetName();

menu.ShowMenu(name, date);