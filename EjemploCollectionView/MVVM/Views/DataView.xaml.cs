using EjemploCollectionView.MVVM.ViewModels;

namespace EjemploCollectionView.MVVM.Views;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();
		BindingContext = new DataViewModel();
	}
}