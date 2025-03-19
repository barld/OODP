// See https://aka.ms/new-console-template for more information

// access modifiers
// public, private, protected, 
//
// en ook nog: internal, private internal, protected internal, file
class MenuController
{
    protected virtual void PrintMenuItem(int id, string menuItem)
    {
        Console.WriteLine($"{id} {menuItem}");
    }

    protected virtual void PrintMenu(List<string> menuItems)
    {
        for (int i = 0; i < menuItems.Count; i++)
        {
            PrintMenuItem(i, menuItems[i]);
        }

        bool validInput = false;
        string input = string.Empty;
        while (!validInput)
        {
            input = Console.ReadLine();
            validInput = int.TryParse(input, out int number) && number > 0 && number < menuItems.Count;
        }
        HandleInput(input);
    }

    protected virtual void HandleInput(string index)
    {
        Console.WriteLine($"menu item {index} is pressed");
    }

}
