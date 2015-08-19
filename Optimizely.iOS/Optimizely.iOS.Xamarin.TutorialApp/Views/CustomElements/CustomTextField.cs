﻿using UIKit;
using Optimizely.iOS.Xamarin.TutorialApp.Lib;
using Cirrious.FluentLayouts.Touch;

namespace Optimizely.iOS.Xamarin.TutorialApp
{
  public class CustomTextField : UIView
  {
    readonly UITextField textField;

    public string Placeholder
    {
      get { return textField.Placeholder; }
      set { textField.Placeholder = value; }
    }

    public bool SecureTextEntry
    {
      get { return textField.SecureTextEntry; }
      set { textField.SecureTextEntry = value; }
    }

    public CustomTextField()
    {
      textField = new UITextField();

      BackgroundColor = UIColor.White;

      Layer.BorderColor = Styling.Colors.BorderColor.CGColor;
      Layer.BorderWidth = 1;
      Layer.CornerRadius = 5;
      ClipsToBounds = true;

      Add(textField);

      this.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

      this.AddConstraints(
        textField.WithSameLeft(this).Plus(5),
        textField.WithSameRight(this).Minus(5),
        textField.WithSameTop(this).Plus(3),
        textField.WithSameBottom(this).Minus(3)
      );
    }
  }
}