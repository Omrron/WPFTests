using System;
using System.Windows;
using System.Windows.Controls;
using WPF_Buttons.Extensions;

namespace WPF_Buttons.UserControls.Loaders
{
    public partial class ThreeDotWave : UserControl
    {
        #region Consts

        private const string BALL_PATH_TEMPALTE = "M {0} {1} a {2},{2} 0 1 1 {3},0 a {2},{2} 0 1 1 -{3},0";

        #endregion

        #region Dependency Properties

        public static readonly DependencyProperty TravelTimeProperty = 
            DependencyProperty.Register("TravelTime", typeof(Duration), typeof(ThreeDotWave), new PropertyMetadata(new Duration()));


        public static readonly DependencyProperty TimeBetweenRepetitionsProperty =
            DependencyProperty.Register("TimeBetweenRepetitions", typeof(Duration), typeof(ThreeDotWave), new PropertyMetadata(new Duration()));

        #endregion

        #region Properties

        public string BallPath1 { get => GenerateBallPath(0); }
        public string BallPath2 { get => GenerateBallPath(1); }
        public string BallPath3 { get => GenerateBallPath(2); }
        public int Radius { get; set; }
        public int TravelDistance { get; set; }
        public TimeSpan BeginTime1 { get => (TravelTime - (TravelTime.TimeSpan / 6)).TimeSpan; }
        public TimeSpan BeginTime2 { get => BeginTime1 * 2; }
        public Duration AnimationLength { get => TimeBetweenRepetitions + TravelTime.Multiply(3); }

        public Duration TravelTime
        {
            get { return (Duration)GetValue(TravelTimeProperty); }
            set { SetValue(TravelTimeProperty, value); }
        }

        public Duration TimeBetweenRepetitions
        {
            get { return (Duration)GetValue(TimeBetweenRepetitionsProperty); }
            set { SetValue(TimeBetweenRepetitionsProperty, value); }
        }

        #endregion

        #region Ctor

        public ThreeDotWave()
        {
            InitializeComponent();
            DataContext = this;
        }

        #endregion

        #region Private Methods

        private string GenerateBallPath(int ballId)
        {
            int diameter = 2 * Radius;
            int ballLeftCenterX = ballId == 0 ? 0 : ballId * (diameter + Radius / 2);
            int ballLeftCenterY = TravelDistance + Radius; 

            return string.Format(BALL_PATH_TEMPALTE, ballLeftCenterX, ballLeftCenterY, Radius, diameter);
        }

        #endregion
    }
}
