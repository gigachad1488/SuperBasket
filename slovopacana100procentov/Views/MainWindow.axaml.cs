using System;
using System.Threading.Tasks;
using Avalonia.Controls;
using slovopacana100procentov.Models;
using slovopacana100procentov.ViewModels;

namespace slovopacana100procentov.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        SetPlayerTab();

        if (MainWindowViewModel.role == Role.Manager)
        {
            deletePlayerButton.IsEnabled = false;
        }
    }

    public void SetPlayerTab()
    {
        MainWindowViewModel.TeamPlayersView.Filter = PlayerFilter;

        addPlayerButton.Click += delegate
        {
            AddPlayerWindow window = new AddPlayerWindow();
            window.DataContext = this.DataContext;
            window.ShowDialog(this);
        };

        playerFilterTextbox.TextChanged += delegate { MainWindowViewModel.TeamPlayersView.Refresh(); };

        deletePlayerButton.Click += async delegate
        {
            if (playersGrid.SelectedIndex >= 0)
            {
                MessageBox mb = new MessageBox(MessageBoxType.YesNo, "хочите удалить?");
                var res = await mb.ShowDialog<bool>(this);

                if (res)
                {
                    TeamPlayer tp = playersGrid.SelectedItem as TeamPlayer;
                    
                    MainWindowViewModel.Players.Remove(tp.player);
                    MainWindowViewModel.TeamPlayers.Remove(tp);
                }
            }
        };
    }

    private bool PlayerFilter(object arg)
    {
        if (playerFilterTextbox != null && !string.IsNullOrEmpty(playerFilterTextbox.Text))
        {
            Player player = ((TeamPlayer)arg).player;

            if (player.name.Contains(playerFilterTextbox.Text, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }

        return true;
    }
}