public class Pig : Pet
{
    public Pig ()
    {
        this.Attack = 4;
        this.Life = 1;
        this.Experience = 1;
    }
    
    public override void AllySummonedEffect() { }

    public override void BuyEffect() { }

    public override Pet Clone()
    {
        Pig pig = new Pig();

        pig.Attack = this.Attack;
        pig.Life = this.Life;
        pig.Experience = this.Experience;

        return pig;
    }

    public override void FaintEffect() { }

    public override void LevelUpEffect() { }

    public override void SellEffect()
    {
        throw new NotImplementedException();
    }

    public override void StartBattleEffect() { }
}