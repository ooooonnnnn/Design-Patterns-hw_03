using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    internal class Character
    {
        private CombatManager comnbatManager;
        private string name;
        private float maxHP;
        private float currentHP;
        private float damage;
        private bool isDead = false;

        public string Name => name;
        public float CurrentHP => currentHP;
        public float Damage => damage;
        public bool IsDead => isDead;

        public Character(CombatManager combatManager, string name, float maxHP, float damage)
        {
            this.comnbatManager = combatManager;
            this.name = name;
            this.maxHP = maxHP;
            currentHP = maxHP;
            this.damage = damage;
        }

        public void TakeDamage(Character actor)
        {
            currentHP -= actor.Damage;

            if (currentHP <= 0)
            {
                currentHP = 0;
                isDead = true;
            }
        }

        public void Heal(float amount)
        {
            currentHP += amount;

            if (currentHP > maxHP) 
                currentHP = maxHP;
        }

        public void DealDamage()
        {
            comnbatManager.DealDamage(this);
        }
    }
}
