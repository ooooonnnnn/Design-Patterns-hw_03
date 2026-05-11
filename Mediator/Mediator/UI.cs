public class UI
{
    private int playerHealth
    {
        public set
        {
            playerHealth = value;
            updateUI();
        }
        get
        {
            return playerHealth;
        }
    }
    private int enemyHealth
    {
        public set
        {
            enemyHealth = value;
            updateUI();
        }
        get
        {
            return enemyHealth;
        }
    }

    void updateUI()
    {
        Console.WriteLine($"Player health : {playerHealth}");
        Console.WriteLine($"Enemy health : {enemyHealth}");
    }
}