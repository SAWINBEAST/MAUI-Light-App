using System.Net;

namespace MauiApp2
{
    /// <summary>
    /// 52
    /// </summary>
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string food = "cookie";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 2)
                food = "cookies";

            CounterBtn.Text = $"Eaten {count} " + food;

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
