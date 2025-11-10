using AppRpgEtec.ViewModels.Disputas;

namespace AppRpgEtec.Views.Disputas;
// Gabriel Freitas de Lucca
// Cassia Freitas Molinaro
public partial class ListagemView : ContentPage
{
    DisputaViewModel viewModel;
    public ListagemView()
	{
		InitializeComponent();

		viewModel = new DisputaViewModel();
		BindingContext = viewModel;
	}
}