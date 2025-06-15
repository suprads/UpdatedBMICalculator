namespace UpdatedBMICalculator;

public partial class RecommendationPage : ContentPage
{
    double BMI;
    public RecommendationPage()
    {
        InitializeComponent();
    }
    private void BtnResult_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void BtnHome_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}