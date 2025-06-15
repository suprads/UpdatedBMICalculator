namespace UpdatedBMICalculator;

public partial class RecommendationPage : ContentPage
{
    public RecommendationPage(string recommendation)
    {
        InitializeComponent();
        LblRecommendation.Text = recommendation;
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