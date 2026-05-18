namespace Mediator;

public class CombatManager
{
    private readonly UI _ui;
    private Character _player;
    private List<Character> _enemies = new();
    private readonly Random _rand = new();

    public CombatManager(UI ui, Character player)
    {
        _ui = ui;
        _player = player;
    }

    public Character GetPlayer()
    {
        return _player;
    }

    public Character Player
    {
        get => _player;
        set => _player = value ?? throw new ArgumentNullException(nameof(value));
    }
    

    public void AddEnemy(Character enemy)
    {
        if (enemy != null && !_enemies.Contains(enemy))
        {
            _enemies.Add(enemy);
        }
    }

    public List<Character> GetEnemies()
    {
        return _enemies;
    }

    public void PlayerAttackRandomEnemy()
    {
        if (_enemies.Count == 0)
        {
            Console.WriteLine("No enemies left");
            return;
        }
        
        int idx = _rand.Next(_enemies.Count);
        Character target = _enemies[idx];

        float damage = _player.GetDamage();
        target.TakeDamage(damage);
        if (target.IsDead)
            _enemies.Remove(target);

        _ui.PlayerAttackText(damage);
    }
}