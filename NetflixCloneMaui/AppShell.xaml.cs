using NetflixCloneMaui.Pages;

namespace NetflixCloneMaui
{
    public partial class AppShell : Shell
    {
		public AppShell()
		{
			InitializeComponent();

			Routing.RegisterRoute(nameof(CategoriesPage), typeof(CategoriesPage));
		}
	}
}