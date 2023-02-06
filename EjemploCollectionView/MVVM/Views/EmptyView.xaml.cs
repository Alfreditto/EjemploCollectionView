namespace EjemploCollectionView.MVVM.Views;

public partial class EmptyView : ContentPage
{
	public EmptyView()
	{
		InitializeComponent();
	}

    private void Switch_OnToggled(object sender, ToggledEventArgs e)
    {
        var isToggled = e.Value;
        CollectionView.EmptyView = isToggled ? Resources["NoResultsView"] : Resources["ConnectivityIssue"];
    }
}