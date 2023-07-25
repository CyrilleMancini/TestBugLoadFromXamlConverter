#define NO_SUCCESS  

using CustomerProjet;
using SharedComponent;

namespace MainApplication;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

#if SUCCESS 
		// Converter Works when this page is used 
		MainPage = new SharedPage();
#else
		// LoadFromXaml Fails to find Converter when this page is used 
		MainPage = new CustomerPage();
#endif
    }
}
