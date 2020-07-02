using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChartSampleApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var charts = Data.CreateXamarinSample();
            this.chart1.Chart = charts[0];
            this.chart2.Chart = charts[1];
            this.chart3.Chart = charts[2];
            this.chart4.Chart = charts[3];
            this.chart5.Chart = charts[4];
            this.chart6.Chart = charts[5];
        }
    }
}
