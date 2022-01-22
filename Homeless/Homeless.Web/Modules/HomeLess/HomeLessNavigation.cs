using Serenity.Navigation;
using MyPages = Homeless.HomeLess.Pages;

[assembly: NavigationLink(int.MaxValue, "HomeLess/Category", typeof(MyPages.CategoryController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "HomeLess/Cities", typeof(MyPages.CountryController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "HomeLess/Contactus", typeof(MyPages.ContactusController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "HomeLess/Topics", typeof(MyPages.TopicsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "HomeLess/Abotut Us", typeof(MyPages.AbotutUsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "HomeLess/Fe2at", typeof(MyPages.CityController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "HomeLess/Aytam Places", typeof(MyPages.AytamPlacesController), icon: null)]