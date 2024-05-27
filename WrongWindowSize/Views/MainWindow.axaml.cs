using Avalonia.Controls;
using Avalonia.Interactivity;

namespace WrongWindowSize.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        SizeLabel.Content = $"Window size: {this.ClientSize}";
    }
}
