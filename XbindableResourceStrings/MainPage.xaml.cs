using ResourceStrings;
using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace XbindableResourceStrings
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void ShowMessageClick(object sender, RoutedEventArgs e)
        {
            var message = R.ImportantMessage; // get resource string in a type safe way!

            var dialog = new MessageDialog(message);
            await dialog.ShowAsync();
        }
    }
}
