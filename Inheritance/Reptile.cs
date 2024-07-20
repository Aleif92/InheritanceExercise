namespace Inheritance;

public class Reptile: Animal
{
    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class



    public bool LivesNearWater { get; set; }

    public bool BirthEggs { get; set; }

    public int Length { get; set; }
    public int LandSpeed { get; set; }

    public Reptile()
    {
        
    }

    public Reptile(string name, int age, int legs, bool livesNearWater, bool birthEggs,int length,int landSpeed)
    {


        Name = name;
        Age = age;
        Legs = legs;
        LivesNearWater = livesNearWater;
        BirthEggs = birthEggs;
        Length = length;
        LandSpeed = landSpeed;



    }


}