using System;
using System.Security.Cryptography;
class Car
{
    bool hasSunroof, hasfrontWiper, hasbackWiper;
    public Car(bool sunroof, bool frontwiper, bool backwiper)
    {
        hasSunroof = sunroof;
        hasfrontWiper = frontwiper;
        hasbackWiper = backwiper;
    }

    public void PrintDetails()
    {
        Console.WriteLine($" Car Has Sunroof ? : {hasSunroof} ");
        Console.WriteLine($" Car Has frontWiper & backWiper ? : {hasfrontWiper} {hasbackWiper} ");

    }
    public enum Colour
    {
        RED,
        GREEN,
        BLUE,
        BLACK,
        WHITE,
        GREY

    }

    public enum Seater
    {
        TWO,
        FOUR,
        FIVE,
        SEVEN
    }

    public enum FuelType
    {
        PETROL,
        DIESEL,
        CNG,
        CNG_PETROL,
        CNG_DIESEL,
        ELECTRIC
    }

    public enum PowerWindow
    {
        ONE, TWO, THREE, FOUR
    }

    public int ShiftGear(int x, double y)
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

class TestCar
{
    public static void Main()
    {
        Car c1 = new Car(true, false, true);
        c1.PrintDetails();
        Console.WriteLine(c1.ShiftGear(4, 89.67));


    }
}


