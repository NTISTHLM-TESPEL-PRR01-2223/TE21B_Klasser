using System;

public class Hero
{
  public string name;
  public int hp;

  public int minDamage = 5;
  public int maxDamage = 10;

  public void Attack(Hero target)
  {
    Random generator = new();
    int damage = generator.Next(minDamage, maxDamage);

    target.hp -= damage;
  }


}
