using System.Reflection;

namespace DynamicMenuGenerator.Service;

public record MenuItem(string Route, 
    string MenuItemName, 
    Type OwnType, 
    List<MenuItem>? SubMenus = null,
    Type? Parent = null);

public class MenuItemService
{
    public List<MenuItem> MenuItems { get; }
    private readonly Type[] _types;

    public MenuItemService()
    {
        _types = Assembly.GetEntryAssembly()?.GetTypes() ?? Array.Empty<Type>();
        MenuItems = GetMenuItems(null);
    }
    
    private List<MenuItem> GetMenuItems(Type? parent)
    {
        var menuItems = _types.SelectMany(t => t.GetCustomAttributes(typeof(MenuItemAttribute), true))
            .OfType<MenuItemAttribute>()
            .Where(m => m.Parent == parent)
            .Select(m => new MenuItem(m.Route, m.MenuItemName, m.OwnType, GetMenuItems(m.OwnType), m.Parent))
            .ToList();
        return menuItems;
    }
}