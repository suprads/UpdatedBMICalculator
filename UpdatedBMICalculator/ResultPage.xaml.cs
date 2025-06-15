namespace UpdatedBMICalculator;

public partial class ResultPage : ContentPage
{
    double BMI;
    public ResultPage(double BMI)
    {
        InitializeComponent();
        LblBMI.Text = BMI.ToString("F2");
        this.BMI = BMI;
    }

    private void BtnRecommendation_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RecommendationPage());
    }

    private void BtnHome_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

}