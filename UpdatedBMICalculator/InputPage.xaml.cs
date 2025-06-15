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

        if (gender == "Male" && BMI < 18.5)
        {
            healthStatus = "Underweight";
        }
        else if (gender == "Male" && BMI < 25 && BMI >= 18.5)
        {
            healthStatus = "Normal Weight";
        }
        else if (gender == "Male" && BMI < 30 && BMI >= 25)
        {
            healthStatus = "Overweight";
        }
        else if (gender == "Male" && BMI >= 30)
        {
            healthStatus = "Obese";
        }
        else if (gender == "Female" && BMI < 18)
        {
            healthStatus = "Underweight";
        }
        else if (gender == "Female" && BMI < 24 && BMI >= 18)
        {
            healthStatus = "Normal Weight";
        }
        else if (gender == "Female" && BMI < 29 && BMI >= 24)
        {
            healthStatus = "Overweight";
        }
        else if (gender == "Female" && BMI >= 29)
        {
            healthStatus = "Obese";
        }
        else
        {
            DisplayAlert("Error", "Please enter value.", "Ok");
        }

        Navigation.PushAsync(new ResultPage(BMI,gender,healthStatus));

        
    }
}