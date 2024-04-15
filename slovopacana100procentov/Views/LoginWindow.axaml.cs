using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using slovopacana100procentov.ViewModels;

namespace slovopacana100procentov.Views;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
        roleCombobox.Items.Add(Role.Admin);
        roleCombobox.Items.Add(Role.Manager);

        loginButton.Click += delegate
        {
            MainWindowViewModel.role = (Role)roleCombobox.SelectedItem;
            MainWindow window = new MainWindow();
            window.DataContext = this.DataContext;
            window.Show();
            this.Hide();
        };
    }
}

public enum Role
{
    Admin,
    Manager
}