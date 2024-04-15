using System;
using System.Collections.ObjectModel;
using DynamicData;
using slovopacana100procentov.ViewModels;

namespace slovopacana100procentov.Models;

public class Team
{
    public int id;
    public string name { get; set; }

    public Team()
    {
        id = MainWindowViewModel.GenerateKey();
    }
    
    public Team(string name) : this()
    {
        this.name = name;
    }

    public override string ToString()
    {
        return name;
    }
}