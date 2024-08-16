using System;
class Car
{
    private bool hasSunroof, hasAC, hasBackWiper;
    private string companyName, model, fuelType;
    private int year;

    public bool HasBackWiper { get; set; }
    public bool HasAC { get; set; }
    public bool HasSunroof { get; set; }
    public string CompanyName { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string FuelType { get; set; }

    public Car(string companyName, string model, int year, string fuelType, bool hasSunroof, bool hasAC, bool hasBackWiper)
    {
        CompanyName = companyName;
        Model = model;
        Year = year;
        FuelType = fuelType;
        HasSunroof = hasSunroof;
        HasAC = hasAC;
        HasBackWiper = hasBackWiper;

    }

    public void DisplayCarDetails()
    {
        Console.WriteLine($"Company Name : {CompanyName}, Model: {Model}, Year: {Year}, Fuel Type: {FuelType}, Sunroof: {HasSunroof}, AC : {HasAC}, BackWiper : {HasBackWiper}");
    }
    public enum Colour
    {
        RED, GREEN, BLUE, BLACK, WHITE, GREY
    }

    public enum Seater
    {
        TWO, FOUR, FIVE, SEVEN
    }

    //public enum FuelType
    //{
    //    PETROL,
    //    DIESEL,
    //    CNG,
    //    CNG_PETROL,
    //    CNG_DIESEL,
    //    ELECTRIC
    //}

    public enum PowerWindow
    {
        ONE, TWO, FOUR
    }

    public int ShiftGear(int x, double y) // y = Speed
    {
        switch (x)
        {
            case 1:
                if (y <= 10)
                    return 1;
                else
                    return 2;
            case 2:
                if (y <= 20)
                    return 2;
                else
                    return 3;
            case 3:
                if (y <= 30)
                    return 3;
                else
                    return 4;
            case 4:
                if (y <= 50)
                    return 4;
                else
                    return 5;
            case 5:
                if (y <= 50)
                    return 4;
                else
                    return 5;
            default:
                throw new ArgumentException("Invalid gear value.");
        }

    }

}


