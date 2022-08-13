// BMI Checker
abstract class Base
{
    // Variables
    private float Height, Weight;
    public Base(float H, float W)
    {
        Height = H;
        Weight = W;
    }

    public float getHeight()
    {
        return Height;
    }
    public float getWeight()
    {
        return Weight;
    }
}

class BMI : Base
{
    private float bmi;
    private string msg;
    public BMI(float H, float W) : base(H, W) {}
    public string displayBMI()
    {
        bmi = getWeight() / (getHeight() * getHeight());
        msg = "Your BMI is: " + bmi;
        if(bmi > 25)
        {
            return msg + "\n" + "You are overweight";
        }
        else if (bmi >= 18)
        {
            return msg + "\n" + "You are healthy";
        }
        else
        {
            return msg + "\n" + "You are underweight";
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to BMI checker");
        Console.WriteLine("Please enter your Height (in meters)");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your Weight (in kg)");
        float y = float.Parse(Console.ReadLine());
        BMI bmi = new BMI(x, y);
        Console.WriteLine(bmi.displayBMI());
    }
}