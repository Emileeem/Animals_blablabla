using System;

public abstract class Pet
{
    public int Attack { get; set; } // ataque
    public int Life { get; set; } // vida
    public int Experience  { get; set; } //nivel
    public bool Fainted  { get; private set; } //desmaiado

    public int Level =>
        Experience switch
        {
            < 3 => 1,
            < 6 => 2,
            _ => 3
        };

    public void AttackPet(Pet pet) 
    {
        this.ReciveDamage(pet.Attack);
        pet.ReciveDamage(this.Attack);

    }

    public void ReciveDamage(int damage) //controle de dano 
    {
        this.Life -= damage;
        if(this.Life <= 0) // se a vida for menor que 0
            this.Fainted = true; // pet desmaia
    }

    public void Union (Pet pet)
    {
        if (this.GetType() != pet.GetType()) //caso tente juntar pets diferentes
            throw new InvalidOperationException(
                "Você não pode juntar peças diferentes"
            );
        int oldLevel = this.Experience;

        this.Attack = this.Attack > pet.Attack ? //se o ataque do pet maior for melhor que o ataque da outra pegue ele, senhao fique com o ataque daquele
            this.Attack : pet.Attack;
        
        this.Life = this.Life > pet.Life ?
            this.Life : pet.Life;
        
        int levelUp = this.Experience > pet.Experience ? // fica com o pet com o maior nivel e adiciona nivel nele logo abaixo
            pet.Experience : this.Experience;
        
        this.Attack += levelUp; //juntando sobe mais um de nivel de acordo com o nivel 
        this.Life += levelUp; // subindo mais um de vida de acordo com a melhor vida 

        this.Experience += pet.Experience;
        if(this.Experience > 6)
            this.Experience = 6;

        if (this.Level > oldLevel)//se o nivel atual for maior que o nivel antigo
            LevelUpEffect(); //vai gerar o efeito de subir de nivel, caso ele tenha ou não
    }
    public abstract void FaintEffect(); //efeito ao desmaiar
    public abstract void SellEffect(); //efeito ao vender
    public abstract void BuyEffect(); // efeito ao comprar
    public abstract void LevelUpEffect(); //efeito ao subir de nvl
    public abstract void StartBattleEffect(); //efeito no comeco da batalha
    public abstract void AllySummonedEffect(); //efeito de aliado sumonado
    public abstract Pet Clone (); //clonar as peças para ir as batalhas e assim nao acabar deletando o pet sem querer

    public override string ToString()
    {
        return
        "╔=================================╗\n" +
        $" {Attack} ({Experience}) {GetType().Name} {Life}         |\n" +
        "╚================================";
    }
}