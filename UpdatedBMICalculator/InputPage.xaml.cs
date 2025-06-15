namespace UpdatedBMICalculator;

public partial class InputPage : ContentPage
{
    public InputPage()
    {
        InitializeComponent();
    }
    string gender = "Male";

    private void TapMale_Tapped(object sender, TappedEventArgs e)
    {
        gender = "Male";
        FrameMale.BorderColor = Color.FromArgb("#fdfdfd");
        FrameFemale.BorderColor = Color.FromArgb("#0a0e29");
    }

    private void TapFemale_Tapped(object sender, TappedEventArgs e)
    {
        gender = "Female";
        FrameFemale.BorderColor = Color.FromArgb("#fdfdfd");
        FrameMale.BorderColor = Color.FromArgb("#0a0e29");
    }

    private void BtnCalculateBMI_Clicked(object sender, EventArgs e)
    {
        double height = double.Parse(LblHeight.Text);
        double weight = double.Parse(LblWeight.Text);
        double BMI = (weight * 703) / (height * height);
        string healthStatus = "";

        Navigation.PushAsync(new ResultPage(BMI));

        /* if (gender == "Male" && BMI < 18.5)
        {
            healthStatus = "Underweight";

            DisplayAlert(
                "BMI Information",
                $"Gender: {gender}\n" +
                $"BMI: {BMI}\n" +
                $"Health Status: {healthStatus}\n" +
                $"Recommendations: Increase calorie intake with nutrient-rich foods. " +
                $"Incorporate strength training to build muscle mass. " +
                $"Consult a nutritionist if needed.",
                "Ok");
        }
        else if (gender == "Male" && BMI < 25 && BMI >= 18.5)
        {
            healthStatus = "Normal Weight";

            DisplayAlert(
                "BMI Information",
                $"Gender: {gender}\n" +
                $"BMI: {BMI}\n" +
                $"Health Status: {healthStatus}\n" +
                $"Maintain a balanced diet with proteins, healthy fats, and fiber. " +
                $"Stay physically active with at least 150 minutes of exercise per week. " +
                $"Keep regular check-ups to monitor overall health.",
                "Ok");
        }
        else if (gender == "Male" && BMI < 30 && BMI >= 25)
        {
            healthStatus = "Overweight";

            DisplayAlert(
                "BMI Information",
                $"Gender: {gender}\n" +
                $"BMI: {BMI}\n" +
                $"Health Status: {healthStatus}\n" +
                $"Reduce processed foods and focus on portion control. " +
                $"Engage in regular aerobic exercises and strength training. " +
                $"Drink Plenty of water and track your progress.",
                "Ok");
        }
        else if (gender == "Male" && BMI >= 30)
        {
            healthStatus = "Obese";

            DisplayAlert(
                "BMI Information",
                $"Gender: {gender}\n" +
                $"BMI: {BMI}\n" +
                $"Health Status: {healthStatus}\n" +
                $"Consult a doctor for personalized guidance. " +
                $"Start with low-impact exercises. " +
                $"Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes.",
                "Ok");
        }
        else if (gender == "Female" && BMI < 18)
        {
            healthStatus = "Underweight";

            DisplayAlert(
                "BMI Information",
                $"Gender: {gender}\n" +
                $"BMI: {BMI}\n" +
                $"Health Status: {healthStatus}\n" +
                $"Recommendations: Increase calorie intake with nutrient-rich foods. " +
                $"Incorporate strength training to build muscle mass. " +
                $"Consult a nutritionist if needed.",
                "Ok");
        }
        else if (gender == "Female" && BMI < 24 && BMI >= 18)
        {
            healthStatus = "Normal Weight";

            DisplayAlert(
                "BMI Information",
                $"Gender: {gender}\n" +
                $"BMI: {BMI}\n" +
                $"Health Status: {healthStatus}\n" +
                $"Maintain a balanced diet with proteins, healthy fats, and fiber. " +
                $"Stay physically active with at least 150 minutes of exercise per week. " +
                $"Keep regular check-ups to monitor overall health.",
                "Ok");
        }
        else if (gender == "Female" && BMI < 29 && BMI >= 24)
        {
            healthStatus = "Overweight";

            DisplayAlert(
                "BMI Information",
                $"Gender: {gender}\n" +
                $"BMI: {BMI}\n" +
                $"Health Status: {healthStatus}\n" +
                $"Reduce processed foods and focus on portion control. " +
                $"Engage in regular aerobic exercises and strength training. " +
                $"Drink Plenty of water and track your progress.",
                "Ok");
        }
        else if (gender == "Female" && BMI >= 29)
        {
            healthStatus = "Obese";

            DisplayAlert(
                "BMI Information",
                $"Gender: {gender}\n" +
                $"BMI: {BMI}\n" +
                $"Health Status: {healthStatus}\n" +
                $"Consult a doctor for personalized guidance. " +
                $"Start with low-impact exercises. " +
                $"Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes.",
                "Ok");
        }
        else 
        {
            DisplayAlert("Error", "Please enter value.", "Ok");
        } */
    }
}