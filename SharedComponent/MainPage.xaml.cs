namespace SharedComponent;

public partial class MainPage : ContentPage
{
    int count = 0;

    public static readonly BindableProperty TitleTextProperty = BindableProperty.Create(nameof(TitleText), typeof(string), typeof(MainPage), default(string));

    public string TitleText
    {
        get => (string)GetValue(TitleTextProperty);
        set => SetValue(TitleTextProperty, value);
    }

    public static readonly BindableProperty ValueConvertedProperty = BindableProperty.Create(nameof(ValueConverted), typeof(int), typeof(MainPage), default(int));

    public int ValueConverted
    {
        get => (int)GetValue(ValueConvertedProperty);
        set => SetValue(ValueConvertedProperty, value);
    }


    public MainPage():base()
    {
        InitializeComponent();
    }
}