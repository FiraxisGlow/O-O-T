using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.System;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ButterflyGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // butterfly
        private Butterfly butterfly;

        //flower
        private Flower flower;

        //audio
        private MediaElement mediaElement;

        // random
        private Random random = new Random();

        // canvas width heigth
        private double CanvasWidth;
        private double CanvasHeight;

        // which keys are pressed
        private bool UpPressed;
        private bool LeftPressed;
        private bool RightPressed;

        // timer "game loop"
        private DispatcherTimer timer;
                  
        public MainPage()
        {
            this.InitializeComponent();

            // windows size 800*600
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            ApplicationView.PreferredLaunchViewSize = new Size(800, 600);

            // get Canvas size 
            CanvasWidth = MyCanvas.Width -150;
            CanvasHeight = MyCanvas.Height -132;

            // add butterfly
            butterfly = new Butterfly
            {
                LocationX = CanvasWidth/2,
                LocationY = CanvasHeight/2
            };
            MyCanvas.Children.Add(butterfly);
            butterfly.UpdatePosition();

            //add flower
            AddFlower();

            //Load Audio
            LoadAudio();

            // key listeners
            Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown;
            Window.Current.CoreWindow.KeyUp += CoreWindow_KeyUp;

            // initialize game loop
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000/120); //try 120fps
            timer.Start();
        }
        //Load audio from assets
        public async void LoadAudio()
        {
            mediaElement = new MediaElement();
            mediaElement.AutoPlay = false;

            StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            StorageFile file = await folder.GetFileAsync("tada.wav");
            var stream = await file.OpenAsync(FileAccessMode.Read);
            mediaElement.SetSource(stream, file.ContentType);
        }

        //add a new flower
        public void AddFlower()
        {
            flower = new Flower
            {
                LocationX = random.Next(1, (int)CanvasWidth - 50),
                LocationY = random.Next(1, (int)CanvasHeight - 50)
            };
            //Add to Canvas
            MyCanvas.Children.Add(flower);
            //location
            flower.UpdatePosition();
        }

        // game loop... 120fps
        private void Timer_Tick(object sender, object e)
        {
            if (UpPressed) butterfly.Move();
            // rotate
            if (LeftPressed) butterfly.Rotate(-1); // -1 == left
            if (RightPressed) butterfly.Rotate(1); // 1 == right
            // collision... flower.
            CheckCollision();
            //update
            butterfly.UpdatePosition();
            
        }
        //Check collision with flower and butterfly
        public void CheckCollision()
        {
            // get rectangles
            Rect r1 = new Rect(butterfly.LocationX, butterfly.LocationY, butterfly.ActualWidth, butterfly.ActualHeight);
            Rect r2 = new Rect(flower.LocationX, flower.LocationY, flower.ActualWidth, flower.ActualHeight);
            // does intersect...
            r1.Intersect(r2);
            if(!r1.IsEmpty) //not empty --> intersect happened
            {
                //remove flower
                MyCanvas.Children.Remove(flower);
                //play tada
                mediaElement.Play();
                //Add a new flower
                AddFlower();
            }
        }
        

        private void CoreWindow_KeyUp(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
        {
            switch (args.VirtualKey)
            {

                case VirtualKey.Up:
                    UpPressed = false;
                    break;
                case VirtualKey.Left:
                    LeftPressed = false;
                    break;
                case VirtualKey.Right:
                    RightPressed = false;
                    break;
                case VirtualKey.W:
                    UpPressed = false;
                    break;
                case VirtualKey.A:
                    LeftPressed = false;
                    break;
                case VirtualKey.D:
                    RightPressed = false;
                    break;
                default:
                    break;
            }
        }

        private void CoreWindow_KeyDown(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
        {
            switch (args.VirtualKey)
            {
            
                case VirtualKey.Up:
                    UpPressed = true;
                    break;
                case VirtualKey.Left:
                    LeftPressed = true;
                    break;
                case VirtualKey.Right:
                    RightPressed = true;
                    break;
                case VirtualKey.W:
                    UpPressed = true;
                    break;
                case VirtualKey.A:
                    LeftPressed = true;
                    break;
                case VirtualKey.D:
                    RightPressed = true;
                    break;
                default:
                    break;
            }
        }
    }
}
