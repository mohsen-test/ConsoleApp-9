public class person
{
    public string Name { get; }
    public int Age { get; }
    public int Height { get; }
    public int Weight { get; }
    public GenderEnum Gender { get; }

    public int DailyNeededCalories { get; }

    public int ConsumedCalories { get; private set; }


    public person(string name, int age, int height, int weight, GenderEnum gender)
    {
        Name = name;
        Age = age;
        Height = height;
        Weight = weight;
        Gender = gender;
        DailyNeededCalories = CalculateDailyNeededCalories();
        ConsumedCalories = 0;
    }

    private int CalculateDailyNeededCalories()
    {
        var constValue = 0;
        if (Gender == GenderEnum.Male)
            constValue = 66;
        else
            constValue = 655;
        return (int)(constValue + (13.7 * Weight) + (5 * Height) - (8.6 * Age));
    }




}




