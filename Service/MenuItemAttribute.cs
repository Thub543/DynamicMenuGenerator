using System;

namespace DynamicMenuGenerator.Service;

public class MenuItemAttribute : Attribute
{
        public string Route { get; set; }
        public string MenuItemName { get; set; }
        public Type OwnType { get; set; }
        public Type? Parent { get; set; }
    
    public MenuItemAttribute(string route, string menuItemName,Type ownType, Type? parent = null)
    {
        Route = route;
        MenuItemName = menuItemName;
        OwnType = ownType;
        Parent = parent;
    }
}