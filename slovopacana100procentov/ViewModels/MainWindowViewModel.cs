using System;
using System.Collections.ObjectModel;
using Avalonia.Collections;
using DynamicData;
using slovopacana100procentov.Models;
using slovopacana100procentov.Views;

namespace slovopacana100procentov.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public static MainWindowViewModel? instance;

    public static Role role;

    public static ObservableCollection<Player> Players { get; set; } = new ObservableCollection<Player>();
    public static DataGridCollectionView PlayersView { get; set; } = new DataGridCollectionView(Players);
    
    public static ObservableCollection<TeamPlayer> TeamPlayers { get; set; } = new ObservableCollection<TeamPlayer>();
    public static DataGridCollectionView TeamPlayersView { get; set; } = new DataGridCollectionView(TeamPlayers);

    public static ObservableCollection<Team> Teams { get; set; } = new ObservableCollection<Team>();
    public static DataGridCollectionView TeamsView { get; set; } = new DataGridCollectionView(Teams);

    public MainWindowViewModel()
    {
        instance ??= this;
        
        Teams.Add(new Team("shosa"));
        Teams.Add(new Team("naigers"));
        Teams.Add(new Team("virtus nub"));
    }

    public void UpdatePlayers()
    {
        
    }

    public void UpdateTeams()
    {
        
    }

    public static int GenerateKey()
    {
        string f = "";
        Random random = new Random();
        for (int i = 0; i < 4; i++)
        {
            f += random.Next(0, 100);
        }

        return Convert.ToInt32(f);
    }
}