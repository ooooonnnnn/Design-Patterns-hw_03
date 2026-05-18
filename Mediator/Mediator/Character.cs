namespace Mediator
{
    public class Character
    {
        private static readonly Random _rand = new();

        private string _name;
        private float _maxHP;
        private float _currentHP;
        private float _damage;
        private bool _isDead = false;

        public string Name => _name;
        public float CurrentHP => _currentHP;
        public bool IsDead => _isDead;

        public Character(string name, float maxHP, float damage)
        {
            _name = name;
            _maxHP = maxHP;
            _currentHP = maxHP;
            _damage = damage;
        }


        public float GetDamage()
        {
            return _damage * _rand.Next(1, 3);
        }

        public void TakeDamage(float damage)
        {
            _currentHP -= damage;

            if (_currentHP <= 0)
            {
                _currentHP = 0;
                _isDead = true;
            }
        }
        public void Heal(float amount)
        {
            if (_isDead) return;

            _currentHP += amount;

            if (_currentHP > _maxHP)
                _currentHP = _maxHP;
        }
    }
}
