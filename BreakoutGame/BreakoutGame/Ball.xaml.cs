using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace BreakoutGame
{
    public sealed partial class Ball : UserControl
    {
        //Location
        public double LocationX { get; set; }
        public double LocationY { get; set; }

        //Speed
        public double SpeedX { get; set; }
        public double SpeedY { get; set; }

        public Ball()
        {
            this.InitializeComponent();
            Width = 15;
            Height = 15;
            SpeedX = -10;    //The ball goes to the left upper corner
            SpeedY = -10;

        }
        //Return balls rect
        public Rect GetRect()
        {
            return new Rect(LocationX, LocationY, Width, Height);
        }
        //Move the ball
        public void Move()
        {
            //Change X
            LocationX = LocationX + SpeedX;
            if (LocationX < 0)
            {
                LocationX = 0;
                SpeedX *= -1;
            } else if(LocationX + Width > MainPage.CanvasWidth) //Right
            {
                LocationX = MainPage.CanvasWidth - Width; // Canvas - ball constraint on the right edge to keep it on screen.
                SpeedX *= -1;
            }
            //Change Y
            LocationY = LocationY + SpeedY;
            if (LocationY < 0)
            {
                LocationY = 0;
                SpeedY *= -1;
            }
            //Move the ball in canvas
            SetValue(Canvas.LeftProperty, LocationX);
            SetValue(Canvas.TopProperty, LocationY);
        }
        
        public void SetSpeed(double hitPercent)
        {
            SpeedX = hitPercent * 10; // -5 <-> 5
            SpeedY *= -1;
        }   
    }

}
