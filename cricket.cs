public class Cricket : Pet
{
    public Cricket ()
    {
        this.Attack = 2;
        this.Life = 1;
        this.Experience = 1;
    }
    
    public override void AllySummonedEffect() { }

    public override void BuyEffect() { }

    public override Pet Clone()
    {
        Cricket cricked = new Cricket();

        cricked.Attack = this.Attack;
        cricked.Life = this.Life;
        cricked.Experience = this.Experience;

        return cricked;
    }

    public override void FaintEffect()
    {
        throw new NotImplementedException();
    }

    public override void LevelUpEffect() { }

    public override void SellEffect() { }

    public override void StartBattleEffect(){ }
}