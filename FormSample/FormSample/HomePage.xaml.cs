using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Diagnostics;

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
            try
            {
                if (string.IsNullOrEmpty(firstNumber.Text) || string.IsNullOrEmpty(secondNumber.Text))
                {
                    showAlertWith(GlobalConstant.AlertTitle, 
                                  GlobalConstant.ErrorNumberInput);
                }
                else
                {
                    int inputValue1 = int.Parse(firstNumber.Text);
                    int inputValue2 = int.Parse(secondNumber.Text);
                    outputLabel.Text = $"Addition Result: {BinaryOperation.Add(inputValue1, inputValue2)}";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("HomePage::Excepetion::"+ex.Message);
                showAlertWith(GlobalConstant.AlertTitle,
                              ex.Message);
            }
        }

        private void showAlertWith(string title, string message){
            DisplayAlert (title, message, "OK");
        }
    }
}
