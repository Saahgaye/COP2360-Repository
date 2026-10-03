using System;

Bunny myBunny = new Bunny("Snowflake")
{
    LikesCarrots = true,
    EatsKale = false
};       

Console.WriteLine($"My bunny's name is: {myBunny.Name}");       
Console.WriteLine($"My bunny likes carrots: {myBunny.LikesCarrots}");
Console.WriteLine($"My bunny likes humans: {myBunny.LikesHumans}");

public class Bunny
{
    public string Name ;
    public bool LikesCarrots;
    public bool LikesHumans ;

    public Bunny(string name)
    {
        Name = name;
    }
}
