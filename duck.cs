public class Duck : Pet //criando o pet pato
{
    public Duck ()
    {
        this.Attack = 2;
        this.Life = 3;
        this.Experience = 1;
    }

    public override void AllySummonedEffect() { }

    public override void BuyEffect() { }

    public override Pet Clone()
    {
        Duck duck = new Duck();

        duck.Attack = this.Attack;
        duck.Life = this.Life;
        duck.Experience = this.Experience;

        return duck;
    }

    public override void FaintEffect() { }

    public override void LevelUpEffect(){ }

    public override void SellEffect()
    {
        throw new NotImplementedException();
    }

    public override void StartBattleEffect(){ }
}