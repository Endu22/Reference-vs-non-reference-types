namespace Reference_vs_non_reference_types;

public struct MonsterStruct
{
    public string Name { get; set; }
    public int Health { get; set; }

    public MonsterStruct(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
    }

}
