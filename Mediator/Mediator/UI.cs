public class UI
{
    private int playerHealth
    {
        set
        {
            playerHealth = value;
            updateUI();
        }
        get
        {
            return playerHealth;
        }
    };
    private int enemyHealth
    {
        set
        {
            enemyHealth = value;
            updateUI();
        }
        get
        {
            return enemyHealth;
        }
    };

    private updateUI()
    {
        Console.WriteLine($"Player health : {playerHealth}");
        Console.WriteLine($"Enemy health : {enemyHealth}");
    }
}