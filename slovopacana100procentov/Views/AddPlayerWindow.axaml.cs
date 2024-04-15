using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using slovopacana100procentov.Models;
using slovopacana100procentov.ViewModels;

namespace slovopacana100procentov.Views;

public partial class AddPlayerWindow : Window
{
    public AddPlayerWindow()
    {
        InitializeComponent();

        addButton.Click += delegate { Add(); };
        cancelButton.Click += delegate { Close(null); };


    }

    public void Add()
    {
        Player player = new Player();
        if (nameText == null || string.IsNullOrEmpty(nameText.Text))
        {
            MessageBox b = new MessageBox(MessageBoxType.Ok, "имя ведено неверне или отсутствует");
            b.ShowDialog(this);
            return;
        }

        player.name = nameText.Text;

        int po = 1;
        
        if (positionNumeric == null || !Int32.TryParse(positionNumeric.Value.ToString(), out po))
        {
            MessageBox b = new MessageBox(MessageBoxType.Ok, "позиция ведено неверне или отсутствует");
            b.ShowDialog(this);
            return;
        }

        player.position = po;

        float we = 1;

        if (weightText == null || !float.TryParse(weightText.Value.ToString(), out we))
        {
            MessageBox b = new MessageBox(MessageBoxType.Ok, "вес ведено неверне или отсутствует");
            b.ShowDialog(this);
            return;
        }

        player.weight = we;

        int he = 1;
        
        if (heightText == null || !Int32.TryParse(heightText.Value.ToString(), out he))
        {
            MessageBox b = new MessageBox(MessageBoxType.Ok, "рост ведено неверне или отсутствует");
            b.ShowDialog(this);
            return;
        }

        player.height = he;

        if (birthDayDate == null || birthDayDate.SelectedDate == null)
        {
            MessageBox b = new MessageBox(MessageBoxType.Ok, "день рожденя ведено неверне или отсутствует");
            b.ShowDialog(this);
            return;
        }

        player.birthDay = birthDayDate.SelectedDate.Value.Date;
        
        if (gameDate == null || gameDate.SelectedDate == null)
        {
            MessageBox b = new MessageBox(MessageBoxType.Ok, "дата игры ведено неверне или отсутствует");
            b.ShowDialog(this);
            return;
        }

        player.gameDate = gameDate.SelectedDate.Value.DateTime;

        if (teamCombobox == null || teamCombobox.SelectedIndex < 0 && teamCombobox.Items.Count <= 0)
        {
            MessageBox b = new MessageBox(MessageBoxType.Ok, "команда ведено неверне или отсутствует");
            b.ShowDialog(this);
            return;
        }

        TeamPlayer tp = new TeamPlayer();
        tp.player = player;
        tp.team = teamCombobox.SelectedItem as Team;
        
        MainWindowViewModel.Players.Add(player);
        MainWindowViewModel.TeamPlayers.Add(tp);
        
        Close(null);
    }
}