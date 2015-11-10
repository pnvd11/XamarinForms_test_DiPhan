using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using XFormsRPNCalculator.iOS;
using XFormsRPNCalculator;

[assembly: ExportRenderer(typeof(RoundedButton), typeof(RoundedButtonRenderer))]
namespace XFormsRPNCalculator.iOS
{
	public class RoundedButtonRenderer : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				var button = (RoundedButton)e.NewElement;

				button.SizeChanged += (s, args) =>
				{
					var radius = Math.Min(button.Width, button.Height) / 2.0;
					button.BorderRadius = (int)(radius);
				};
			}
		}
	}
}