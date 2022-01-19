namespace Dice;

public class Dice
{
    //create method roll a Dice
    public int Roll(int sides)
    {
        Random rd = new Random();
        int number = rd.Next(1, sides + 1);
        return number;
    }
    
}