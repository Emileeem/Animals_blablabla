public class Game
{
    public Team YourTeam {get; set;} = new Team();
    public Team EnemyTeam {get; set;} = new Team();
    public Shop YourShop {get; set;} = new Shop();
    public Shop EnemySho {get; set;} = new Shop();

    public void Start()
    {
        YourShop.Add(new Duck());
        YourShop.Add(new Pig());
        YourShop.Add(new Cricket());

        EnemySho.Add(new Duck());
        EnemySho.Add(new Pig());
        EnemySho.Add(new Cricket());

        YourShop.FreeRefill();
        EnemySho.FreeRefill();
        
    }
    public override string ToString()
    {
        return
            YourTeam.ToString() + "\n" +
            YourShop.ToString() + "\n" +
            EnemyTeam.ToString() + "\n" +
            EnemySho.ToString() + "\n";
    }
}