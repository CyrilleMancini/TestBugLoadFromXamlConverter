using System.Timers;
using Timer = System.Timers.Timer;

namespace SharedComponent;

public partial class SharedPage : MainPage
{
    Timer timer;
    public SharedPage():base()
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
        Random rnd = new Random();
        ValueConverted = rnd.Next(100);
    }
}