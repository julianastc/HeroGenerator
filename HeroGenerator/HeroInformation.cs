using System.Text.Json;
using HeroGenerator.Entities;

namespace HeroGenerator;
public class HeroInformation
{
    public static async Task<FirstName> GetFirstNameList()
    {
        var firstNameFile = "./Data/FirstName.json";
        await using var firstNameOpenStream = File.OpenRead(firstNameFile);
        var firstName =
            await JsonSerializer.DeserializeAsync<FirstName>(firstNameOpenStream);
        return firstName;
    }
    public static async Task<LastName> GetLastNameList()
    {
        var lastNameFile = "./Data/LastName.json";
        await using var lastNameOpenStream = File.OpenRead(lastNameFile);
        var lastName =
            await JsonSerializer.DeserializeAsync<LastName>(lastNameOpenStream);
        return lastName;
    }
    public static async Task<SuperPower> GetSuperPowerList()
    {
        var superPowerFile = "./Data/SuperPower.json";
        await using var superPowerOpenStream = File.OpenRead(superPowerFile); 
        var superPower =
            await JsonSerializer.DeserializeAsync<SuperPower>(superPowerOpenStream);
        return superPower;
    }
    public static async Task<SuperWeakness> GetSuperWeaknessList()
    {
        var superWeaknessFile = "./Data/SuperWeakness.json";
        await using var superWeaknessOpenStream = File.OpenRead(superWeaknessFile);
        var superWeakness =
            await JsonSerializer.DeserializeAsync<SuperWeakness>(superWeaknessOpenStream);
        return superWeakness;
    }
}
