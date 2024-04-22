namespace MovieCatalog.Views;

public partial class MoviesDetailPage : ContentPage
{
	public MoviesDetailPage(ViewModels.MovieViewModel movie)
	{
		BindingContext = movie;
		InitializeComponent();
	}
}