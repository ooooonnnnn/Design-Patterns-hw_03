using System.Runtime.InteropServices;

namespace Mediator;

/// <summary>
/// Manages characters dealing damage to each other and updates the UI
/// </summary>
public class CombatManager(UI ui)
{
    //Character player, enemy;

    public void PlayerDealDamage()
    {
        Console.WriteLine("Player Deals Damage");
        ui.enemyHealth = 0;
    }

    public void EnemyDealDamage()
    {
        Console.WriteLine("Enemy Deals Damage");
        ui.playerHealth = 0;
    }
}