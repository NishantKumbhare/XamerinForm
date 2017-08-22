using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FormSample
{
    public partial class HomePage : ContentPage
    {
         
        public HomePage()
        {
            InitializeComponent();
        }

        private void Result_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNumber.Text) || string.IsNullOrEmpty(secondNumber.Text)){
                showAlertWith("FormSample", "Please enter valid number");
            }
            else{
                int inputValue1 = int.Parse(firstNumber.Text);
                int inputValue2 = int.Parse(secondNumber.Text);
                outputLabel.Text = $"Addition Result: {Add(inputValue1, inputValue2)}";
            }
        }

        private int Add(int value1, int value2)
        {
            // Iterate till there is no carry  
            while (value2 != 0)
            {
                // carry now contains common set bits of x and y
                int carry = value1 & value2;

                // Sum of bits of x and y where at least one of the bits is not set
                value1 = value1 ^ value2;

                // Carry is shifted by one so that adding it to x gives the required sum
                value2 = carry << 1;
            }
            return value1;
        }

        private void showAlertWith(string title, string message){
            DisplayAlert (title, message, "OK");
        }
    }
}
