using Mediator;

Character player = new Character("Player", 100, 10);
Character enemy1 = new Character("Enemy 1", 50, 5);
Character enemy2 = new Character("Enemy 2", 50, 5);
Character enemy3 = new Character("Enemy 3", 50, 5);

var ui = new UI();
CombatManager combatManager = new CombatManager(ui, player);
ui.SetCombatManager(combatManager);

combatManager.AddEnemy(enemy1);
combatManager.AddEnemy(enemy2);
combatManager.AddEnemy(enemy3);

Console.WriteLine("Combat started.\n");

while (true){
    combatManager.PlayerAttackRandomEnemy();
    Console.ReadLine();
}