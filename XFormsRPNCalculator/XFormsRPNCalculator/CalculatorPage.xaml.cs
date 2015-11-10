
//ref: http://www.wintellect.com/devcenter/jprosise/supercharging-xamarin-forms-with-custom-renderers-part-2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XFormsRPNCalculator
{
	

    public partial class CalculatorPage : ContentPage
    {

		public CalculatorPage()
        {
			
            InitializeComponent();
            this.BindingContext = ((App)Application.Current).GetCalculatorViewModel();

			this.SizeChanged += (s, e) =>
			{
				if (this.Width != this.Height)
					ShowExtraButtons(this.Width > this.Height);
			};
		}

		private void ShowExtraButtons(bool visible)
		{
			foreach (View child in LayoutRoot.Children)
			{
				if (child is Button && (int)child.GetValue(Grid.ColumnProperty) < 2)
				{
					child.IsVisible = visible;
				}
			}
		}
    
	
		private async void OnCallspringBrd(object sender, EventArgs e)
		{
			Output.FadeTo (0, 0, Easing.Linear);

			if ((Output.Text.Length > 0) && (Output.Text.Length < 4))  { // == string.empty
				delBttn.IsEnabled = true;
			} else
				delBttn.IsEnabled = false;

			if (Output.Text.Length == 4) {
				if (Output.Text == "1237") {
				//if (Calculator. == "1237") {
				Navigation.PushAsync (new springBoard ());
					//Output1.Text = "";
					//Output.Text = "";
				} else {
					//Output1.Text = "....";
					//Output.Text = "0.00";
					 await Output1.TranslateTo (15, 0, 300, Easing.Linear); //90

					await Output1.TranslateTo (-15, 0, 400, Easing.Linear);
					await Output1.TranslateTo (0, 0, 400, Easing.Linear);
					//this.Output1.TranslationX = 160;
					// Output1.TranslateTo (90, 0, 300, Easing.Linear);

					// Output1.TranslateTo (-90, 0, 400, Easing.Linear);
					//this.OnAppearing;
					//this.ShowExtraButtons;
					//var task1 =  Output1.TranslateTo (90, 0, 400, Easing.Linear); // Output1.ScaleTo (100,100);
					//task1.Wait ();
					//var taskDelay1 = Task.Delay(2000);
					//taskDelay.Wait ();
					//var task2 = Output1.TranslateTo (-90, 0, 400, Easing.Linear);
					//var taskDelay2 = Task.Delay(5000);
					//taskDelay.Wait ();
					//var task3 = Output1.TranslateTo (0, 0, 400, Easing.Linear);
					//task2.Wait ();
					//Task.WaitAll (new []{ taskDelay, task2 });


					//await Task.WhenAll(taskAnimation, taskDelay);
					//await Output1.FadeTo(0);


			    
				}
			}

			//Output.Text = "{Binding Output}";
			//Output1.Text = "{Binding Output1}";
		}




		 


	}
}
