namespace nng_one.Menu;

public enum MainMenuItem
{
    Block = 1,
    Unblock = 2,
    Editors = 3,
    Search = 4,
    Misc = 5
}

public static class MainMenuExtensions
{
    public static string GetMenuItem(this MainMenuItem menuItem)
    {
        return menuItem switch
        {
            MainMenuItem.Block => "Блокировка",
            MainMenuItem.Unblock => "Разблокировка",
            MainMenuItem.Editors => "Редакторы",
            MainMenuItem.Search => "Поиск",
            MainMenuItem.Misc => "Прочее",
            _ => ""
        };
    }
}
