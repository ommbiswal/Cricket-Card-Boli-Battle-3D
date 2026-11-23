
using UnityEngine;

[System.Serializable]
public class PlayerProfile
{
    public string playerName;
    public string role;
    public int batting;
    public int bowling;
    public int fielding;
    public string rarity;

    public static PlayerProfile CreateRandomStarter()
    {
        string[] names = { "Arjun Mehta", "Kabir Singh", "Dev Malhotra", "Ayaan Rao" };
        string[] roles = { "Batter", "Bowler", "All-Rounder", "Wicketkeeper" };

        return new PlayerProfile
        {
            playerName = names[Random.Range(0, names.Length)],
            role = roles[Random.Range(0, roles.Length)],
            batting = Random.Range(55, 76),
            bowling = Random.Range(45, 71),
            fielding = Random.Range(50, 76),
            rarity = "Common"
        };
    }
}
