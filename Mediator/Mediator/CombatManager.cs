using System.Runtime.InteropServices;

namespace Mediator;

/// <summary>
/// Manages characters dealing damage to each other and updates the UI
/// </summary>
public class CombatManager
{
    //Character player, enemy;
    //UI ui;

    public CombatManager()
    {
        // Set characters and UI
    }
    
    public void PlayerDealDamage()
    {
        Console.WriteLine("Player Deals Damage");
        Console.WriteLine("Updating UI");
    }

    public void EnemyDealDamage()
    {
        Console.WriteLine("Enemy Deals Damage");
        Console.WriteLine("Updating UI");
    }
}