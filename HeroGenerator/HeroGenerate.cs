namespace HeroGenerator;
public class HeroGenerate
{
    private readonly Random _rand;
    public HeroGenerate()
    {
        _rand = new Random();
    }
    private async Task<string> ChooseFirstName()
    {
        var firstNameList = await HeroInformation.GetFirstNameList();
        var randomNumber = _rand.Next(firstNameList.Names.Count);
        return firstNameList.Names[randomNumber];
    }
    private async Task<string> ChooseLastName()
    {
        var lastNameList = await HeroInformation.GetLastNameList();
        var randomNumber = _rand.Next(lastNameList.Names.Count);
        return lastNameList.Names[randomNumber];
    }
    private async Task<string> ChooseSuperPower()
    {
        var superPowerList = await HeroInformation.GetSuperPowerList();
        var randomNumber = _rand.Next(superPowerList.Powers.Count);
        return superPowerList.Powers[randomNumber];
    }
    private async Task<string> ChooseSuperWeakness()
    {
        var superWeaknessList = await HeroInformation.GetSuperWeaknessList();
        var randomNumber = _rand.Next(superWeaknessList.Weaknesses.Count);
        return superWeaknessList.Weaknesses[randomNumber];
    }
    private int ChooseAge()
    {
        return _rand.Next(0, 101);
    }
    public async Task Result()
    {
        Console.WriteLine($"O nome do héroi é {await ChooseFirstName()} {await ChooseLastName()}");
        Console.WriteLine($"O super poder é {await ChooseSuperPower()}");
        Console.WriteLine($"A super fraqueza é {await ChooseSuperWeakness()}");
        Console.WriteLine($"A idade é {ChooseAge()}");
    }
}
