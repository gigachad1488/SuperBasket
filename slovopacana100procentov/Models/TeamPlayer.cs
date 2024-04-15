using slovopacana100procentov.ViewModels;

namespace slovopacana100procentov.Models;

public class TeamPlayer
{
    public int id;
    public Team team { get; set; }
    public Player player { get; set; }
    
    public TeamPlayer()
    {
        id = MainWindowViewModel.GenerateKey();
    }
}