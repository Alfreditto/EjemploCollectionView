using EjemploCollectionView.MVVM.Views;

namespace EjemploCollectionView;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new EmptyView();
    }
}
