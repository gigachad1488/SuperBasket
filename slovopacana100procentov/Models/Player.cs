using System;
using System.Security.Policy;
using slovopacana100procentov.ViewModels;

namespace slovopacana100procentov.Models;

public class Player
{
    public int id;
    
    public string name { get; set; }
    public int position { get; set; }
    public float weight { get; set; }
    public int height { get; set; }
    public DateTime birthDay { get; set; }
    public DateTime gameDate { get; set; }

    public Player()
    {
        id = MainWindowViewModel.GenerateKey();
    }
    
    public Player(string name, int position, float weight, int height, DateTime birthDay, DateTime gameDate) : this()
    {
        this.name = name;
        this.position = position;
        this.weight = weight;
        this.height = height;
        this.birthDay = birthDay;
        this.gameDate = gameDate;
    }

}