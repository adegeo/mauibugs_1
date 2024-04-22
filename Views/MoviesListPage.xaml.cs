namespace MovieCatalog.Views;

public partial class MoviesListPage : ContentPage
{
	public MoviesListPage()
	{
		InitializeComponent();
	}

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		ViewModels.MovieViewModel movie = (ViewModels.MovieViewModel)e.Item;
		Navigation.PushAsync(new Views.MoviesDetailPage(movie));
    }
}