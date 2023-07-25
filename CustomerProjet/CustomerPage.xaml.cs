using SharedComponent;
using System.Timers;
using Timer = System.Timers.Timer;

namespace CustomerProjet;

public partial class CustomerPage : MainPage
{
    Timer timer;
    public CustomerPage() : base()
    {
        InitializeComponent();
        TitleText = "From CustomerPage";
        timer = new System.Timers.Timer();
        timer.Interval = 2000;
        timer.Elapsed += Timer_Elapsed;
        timer.Start();
    }

    private void Timer_Elapsed(object sender, ElapsedEventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {

            Random rnd = new Random();
            ValueConverted = rnd.Next(100);
        });
    }
}