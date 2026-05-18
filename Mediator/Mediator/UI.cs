using Mediator;

public class UI
{
    private CombatManager combatManager;

    public void SetCombatManager(CombatManager cm)
    {
        combatManager = cm;
    }
    public void PlayerAttackText(float dmg)
    {
        Console.WriteLine($"Player attacked enemy for {dmg} damage!");
        UpdateUi();
    }

    private void UpdateUi()
    {
        Console.WriteLine($"Player health : {combatManager.GetPlayer().CurrentHP}");
        foreach (var enemy in combatManager.GetEnemies())
        {
            Console.WriteLine($"Enemy {enemy.Name} health : {enemy.CurrentHP}");
        }
    }
}