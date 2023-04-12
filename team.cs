public class Team 
{
    private Pet[] pets = new Pet[5]; //deixando colocar apenas 5 pets no seu time

    public override string ToString()
    {
        string str = "Seu time :\n";
        for(int i = 0; i< pets.Length; i++)
            str += (pets[i]?.ToString() ?? "(Vazio)") + "\n";
        return str;
    }
    
    public void Add(Pet pet)
    {
        for (int i = 0; i < 5; i++)
        {
            if (pets[i] != null)
                continue;

            pets[i] = pet;
            break;
        }
        for (int i = 0; i < 5; i++)
        {
            if (pets[i] is null)
                continue;
            pets[i].AllySummonedEffect();
        }
    }
}