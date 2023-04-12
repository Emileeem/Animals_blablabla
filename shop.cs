using System;

public class Shop
{
    public int Gold { get; set; } = 10;
    private List <Pet> pets = new List <Pet>(); //criando a lista para gerar novos pets 

    private List <Pet> basePets = new List <Pet>(); 

    public void Buy (int index, Team team)
    {
        if (Gold <3)
            return;

        Gold -= 3;
        var bought = pets[index];
        pets.Remove(bought);
        team.Add(bought);
        bought.BuyEffect();
    }
    public void Add(Pet basePet)
        => this.basePets.Add(basePet);


    public void Refill() //rodando aleatorio as opcoes de pets
    {
        if (Gold < 1)
            return;

        Gold --; //perdendo 1 de gold ao rodar aleatoriamente os 3 pets
        pets.Clear();
        pets.Add(getRandomPet()); //pegando pet aleatorio e adicionando na loja 
        pets.Add(getRandomPet());
        pets.Add(getRandomPet());
    }
    public void FreeRefill()
    {
        pets.Clear();
        pets.Add(getRandomPet()); //pegando pet aleatorio e adicionando na loja 
        pets.Add(getRandomPet());
        pets.Add(getRandomPet());
    }
    private Pet getRandomPet()
    {
        int index = Random.Shared.Next(basePets.Count);
        var basePet = this.basePets[index];
        return basePet.Clone();

    }
    public override string ToString()
    {
        string str = $"Loja(Gold:{Gold})\n";
        for(int i = 0; i< pets.Count; i++)
            str += pets[i].ToString() + "\n";
        return str;

    }
}