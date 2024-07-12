using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Diagnostics;

namespace test_app.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.FindControl<Button>("CalculateButton").Click += OnCalculateButtonClick;
        }
        public void OnCalculateButtonClick(object source, RoutedEventArgs args)
        {
            if (Double.TryParse(Celsius.Text, out double C))
            {
                var F = C * (9d / 5d) + 32;
                Fahrenheit.Text = F.ToString();
            }
            else
            {
                Celsius.Text = "0";
                Fahrenheit.Text = "0";
            }
        }
    }
}