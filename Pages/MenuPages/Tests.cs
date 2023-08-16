using DynamicMenuGenerator.Service;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DynamicMenuGenerator.Pages.MenuPages;

public class Tests
{
    [MenuItem(route: "/MenuPages/Impressum", menuItemName: "Impressum", ownType: typeof(Impressum), parent: null)]
    public class Impressum : PageModel { }
    
    [MenuItem(route:"/MenuPages/SubImpressum1", menuItemName: "Subimpressum 1", ownType: typeof(SubImpressum1),parent: typeof(Impressum))]
    public class SubImpressum1 : PageModel { }
    
    [MenuItem(route:"/MenuPages/SubImpressum2", menuItemName: "Subimpressum 2", ownType: typeof(SubImpressum2), parent: typeof(Impressum))]
    public class SubImpressum2 : PageModel { }

    [MenuItem(route:"/MenuPages/SubPrivacy1", menuItemName: "SubPrivacy 1", ownType: typeof(SubPrivacy1),parent: typeof(PrivacyModel))]
    public class SubPrivacy1 : PageModel { }
    
    [MenuItem(route:"/MenuPages/SubSubPrivacy1", menuItemName: "SubSubPrivacy1", ownType: typeof(SubSubPrivacy1),parent: typeof(SubPrivacy1))]
    public class SubSubPrivacy1 : PageModel { }

    [MenuItem(route:"/MenuPages/Team" ,menuItemName: "Team", ownType: typeof(Team), parent: null)]
    public class Team : PageModel { }
    
    [MenuItem(route:"/MenuPages/SubTeam1", menuItemName: "SubTeam1", ownType: typeof(SubTeam1), parent: typeof(Team))]
    public class SubTeam1 : PageModel { }
    
    [MenuItem(route:"/MenuPages/SubTeam2", menuItemName: "SubTeam2", ownType: typeof(SubTeam2), parent: typeof(Team))]
    public class SubTeam2 : PageModel { }
    
    [MenuItem(route:"/MenuPages/SubSubTeam1", menuItemName: "SubSubTeam1", ownType: typeof(SubSubTeam1), parent: typeof(SubTeam1))]
    public class SubSubTeam1 : PageModel { }
    
    [MenuItem(route:"/MenuPages/SubSubSubTeam1", menuItemName: "SubSubSubTeam1", ownType: typeof(SubSubSubTeam1), parent: typeof(SubSubTeam1))]
    public class SubSubSubTeam1 : PageModel { }
    
    [MenuItem(route:"/MenuPages/SubSubTeam2", menuItemName: "SubSubTeam2", ownType: typeof(SubSubTeam2), parent: typeof(SubTeam2))]
    public class SubSubTeam2 : PageModel { }
}