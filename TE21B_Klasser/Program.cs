// Hjälte
//  Vapen
// Fiender


Hero h = new Hero() { hp = 100, name = "Superman"};
Hero h2 = new Hero() {hp = 50, name = "Batman"};



// Miss / crit?
// Block, armor
h2.Attack(h);

h.hp = Math.Max(h.hp, 0);


Console.ReadLine();
