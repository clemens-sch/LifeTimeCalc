using System;
using System.Windows.Forms;

namespace WF_LifeTimeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            CalcLifeTime();
        }

        private void CalcLifeTime()
        {
            string inputDate = maskedTextBoxInput.Text;
            DateTime birthDate;

            if (DateTime.TryParse(inputDate, out birthDate))
            {
                TimeSpan LifeTime = DateTime.Now - birthDate;

                // YEARS
                double LifeTimeInYears = LifeTime.TotalDays / 365;
                double RoundedLifeTimeYears = RoundValue(LifeTimeInYears);

                labelYears.Text = FormatNumberWithSpaces(RoundedLifeTimeYears) + "Y";

                // DAYS
                double LifeTimeInDays = LifeTime.TotalDays;
                double RoundedLifeTimeDays = RoundValue(LifeTimeInDays);

                labelDays.Text = FormatNumberWithSpaces(RoundedLifeTimeDays) + "d";

                // HOURS
                double LifeTimeInHours = LifeTime.TotalHours;
                double RoundedLifeTimeHours = RoundValue(LifeTimeInHours);

                labelHours.Text = FormatNumberWithSpaces(RoundedLifeTimeHours) + "h";

                // MINUTES
                double LifeTimeInMinutes = LifeTime.TotalMinutes;
                double RoundedLifeTimeMinutes = RoundValue(LifeTimeInMinutes);

                labelMinutes.Text = FormatNumberWithSpaces(RoundedLifeTimeMinutes) + "min";

                // SECONDS
                double LifeTimeInSeconds = LifeTime.TotalSeconds;
                double RoundedLifeTimeSeconds = RoundValue(LifeTimeInSeconds);

                labelSeconds.Text = FormatNumberWithSpaces(RoundedLifeTimeSeconds) + "s";
            }
            else
            {
                MessageBox.Show("Invalid date format!");
            }
        }

        public double RoundValue(double value)
        {
            return Math.Round(value, 2);
        }

        public string FormatNumberWithSpaces(double number)
        {
            string numberString = number.ToString();
            string formattedString = "";

            int commaIndex = numberString.IndexOf(",");
            int startIndex = (commaIndex >= 0) ? commaIndex : numberString.Length;

            for (int i = 0; i < numberString.Length; i++)
            {
                if (i > 0 && (startIndex - i) % 3 == 0 && i != commaIndex)
                {
                    formattedString += " ";
                }

                formattedString += numberString[i];
            }

            return formattedString;
        }
    }
}
