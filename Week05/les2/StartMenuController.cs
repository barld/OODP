// See https://aka.ms/new-console-template for more information

// access modifiers
// public, private, protected, 
//
// en ook nog: internal, private internal, protected internal, file
class StartMenuController : MenuController
{
    private void PrintMenu()
    {
        this.PrintMenu(new (){ "login as user", "login as admin", "exit" });
    }

    protected override void HandleInput(string index)
    {
        switch (index)
        {
            case "0":
                Console.WriteLine("login as user");
                break;
            case "1":
                Console.WriteLine("login as admin");
                break;
            case "2":
                Console.WriteLine("exit");
                break;
            default:
                Console.WriteLine("unknown menu item");
                break;
        }
    }

    public void Start()
    {
        PrintMenu();
    }
}