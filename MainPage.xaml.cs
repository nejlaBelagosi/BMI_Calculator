namespace BMI_Calculator;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void CalculateOnClick(object sender, EventArgs e)
	{
        double Height = double.Parse(HeightEntry.Text);
        double Weight = double.Parse(WeightEntry.Text);
        double BMI = Weight / (Height * Height);

        if (BMI < 18.5)
        {
            ResultLabel.Text = "Underweight";
            BMIimage.Source = "underweight.png";
        }
        else if (BMI > 18.5 && BMI <= 24.9)
        {
            ResultLabel.Text = "Normal";
            BMIimage.Source = "normal.png";
        }
        else if (BMI >= 25 && BMI <= 29.9)
        {
            ResultLabel.Text = "Overweight";
            BMIimage.Source = "overweight.png";
        }
        else if (BMI >= 30 && BMI <= 34.9)
        {
            ResultLabel.Text = "Obese";
            BMIimage.Source = "obese.png";
        }
        else
        {
            ResultLabel.Text = "Extra Obese";
            BMIimage.Source = "extreme_obese.png";
        }


        SemanticScreenReader.Announce(CalculateButton.Text);
    }
    private void ResetOnClick(object sender, EventArgs e)
    {
        HeightEntry.Text = "";
        WeightEntry.Text = "";
        ResultLabel.Text = "";
        BMIimage.Source = "bmi_calculator.png";

        SemanticScreenReader.Announce(ResetButton.Text);
    }
}

