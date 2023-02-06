using EjemploCollectionView.MVVM.ViewModels;

namespace EjemploCollectionView.MVVM.Views;

public partial class LayoutsPage : ContentPage
{
	public LayoutsPage()
	{
		InitializeComponent();
        BindingContext = new DataViewModel();
    }

    private void SelectableItemsView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        
    }
}