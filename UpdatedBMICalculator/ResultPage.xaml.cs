using System.Reflection;

namespace UpdatedBMICalculator;

public partial class ResultPage : ContentPage
{
    double BMI;
    string gender;
    string healthStatus;

    public ResultPage(double BMI, string gender, string healthStatus)
    {
        InitializeComponent();
        LblBMI.Text = BMI.ToString("F2");
        this.BMI = BMI;
        LblGender.Text = gender;
        this.gender = gender;
        LblHealthStatus.Text = healthStatus;
        this.healthStatus = healthStatus;
    }

    private void BtnRecommendation_Clicked(object sender, EventArgs e)
    {
        string recommendation = "";
        if (healthStatus == "Underweight")
        {
            recommendation = "Increase calorie intake with nutrient-dense foods. " +
                "Incorporate strength training to build muscle mass. " +
                "Consult a healthcare provider for personalized advice.";
        }
        else if (healthStatus == "Normal Weight")
        {
            recommendation = "Maintain a balanced diet with proteins, healthy fats, and fiber. " +
                "Stay physically active with at least 150 minutes of exercise per week. " +
                "Keep regular check-ups to monitor overall health.";
        }
        else if (healthStatus == "Overweight")
        {
            recommendation = "Reduce processed foods and focus on portion control. " +
                "Engage in regular aerobic exercises and strength training. " +
                "Drink plenty of water and track your progress.";
        }
        else if (healthStatus == "Obese")
        {
            recommendation = "Consult a doctor for personalized guidance. " +
                "Start with low-impact exercises." +
                "Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes.";
        }
        Navigation.PushAsync(new RecommendationPage(recommendation));
    }

    private void BtnHome_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

}