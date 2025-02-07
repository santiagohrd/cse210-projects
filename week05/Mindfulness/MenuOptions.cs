public class MenuOptions
{
    private List<string> _menuOptions;

    public MenuOptions()
    {
        _menuOptions = new List<string>{"1. Start breathing activity", "2. Start reflecting activity", "3. Start listening activity", "4. Quit"};
    }

    public void GetMenu()
    {
        foreach (var option in _menuOptions)
        {
            Console.WriteLine(option);
        }
    }
}