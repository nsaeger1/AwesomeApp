using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AwesomeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

      
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            int drinkAge = 21;
            
            DateTime birth = Picker.Date;
            TimeSpan age = DateTime.Today.Subtract(birth);
            int year21 = age.Days / 365;
            int day21 = age.Days%365;
            Lbl_BMI.Text = $"You have {year21} years, and  {day21 - (year21/4)} days until you can drink.";
        }
    }
}