public class UI
{
    public int playerHealth
    {
        set
        {
            playerHealth = value;
            updateUI();
        }
        private get
        {
            return playerHealth;
        }
    }
    public int enemyHealth
    {
        set
        {
            enemyHealth = value;
            updateUI();
        }
        private get
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