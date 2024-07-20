namespace Inheritance;

public class Bird: Animal
{
    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class
    
    public int Wings { get; set; }
    public string Type { get; set; }
    public bool IsWarmBlooded { get; set; }
    public bool HasFeathers { get; set; }


    public Bird()
    {
        
    }

    public Bird(string name, int age, int legs, bool hasBackBone, bool isWarmBlooded, bool hasfeathers, int wings)
    {
        Name = name;
        Age = age;
        Legs = legs;
        HasBackBone = hasBackBone;
        IsWarmBlooded = isWarmBlooded;
        HasFeathers = hasfeathers;
        Wings = wings;
    }



}