using System.Runtime.InteropServices;

namespace Mediator;

/// <summary>
/// Manages characters dealing damage to each other and updates the UI
/// </summary>
public class CombatManager(UI ui)
{
    Character player, enemy;

    public void DealDamage(Character damageDealer)
    {
        Console.WriteLine("Player Deals Damage");
        ui.enemyHealth = 0;
    }
}