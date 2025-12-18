namespace Level1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Harry age is  " + findAge());
        Console.WriteLine("Sam's Average marks is " + averageMarks());
        Console.WriteLine("The distance 10.8 km in miles is " + kiloToMiles());
        percent();

        penDivison();
        university();
        earth();
        milesToKilo();

        univer();
        centiToFeet();
        areaTriangle();
        Calculator();

        Perimeter();
        Distance();
        CalculateTotalPrice();
        Handshake();
    }

    // Problem 1
    static int findAge()
    {
        int currYear = 2024;
        int birthYear = 2000;
        int harryAge = currYear - birthYear;
        return harryAge;

    }

    // Problem 2
    static double averageMarks()
    {
        double physics = 95;
        double chemistry = 96;
        double maths = 94;

        return (physics + chemistry + maths) / 3;
    }

    // Problem 3
    static double kiloToMiles()
    {
        double miles = 1.6;
        double km = 10.8;
        double cv = km * miles;
        return cv;
    }

    // Problem 4
    static void percent()
    {
        double costPrice = 129;
        double sellPrice = 191;

        double profit = sellPrice - costPrice;

        double percentage = profit / costPrice * 100;

        Console.WriteLine($"The Cost Price in INR {costPrice} and Selling Price is INR {sellPrice}");
        Console.WriteLine($"The Profit is INR {profit} and the Profit Percentage is {percentage}");

    }

    // Problem 5
    static void penDivison()
    {
        int pen = 14;
        int students = 3;

        int penPerStud = pen / students;
        int remaining = pen % students;

        Console.WriteLine($"The Pen Per Student is {penPerStud} and the remaining pen not distributed is {remaining}");

    }

    // Problem 6
    static void university()
    {
        int fee = 125000;
        int discountPercent = 10;
        int discount = fee * discountPercent / 100;
        int discountFee = fee - discount;
        Console.WriteLine($"The discount amout in INR {discount} and final discounted fee is INR {discountFee}");
    }

    // Problem 7
    static void earth()
    {
        double earthRadius = 6378;
        double miles = 1.6;
        double volumeSphere = (4 / 3) * Math.PI * earthRadius;
        double cubicMiles = volumeSphere * miles;
        Console.WriteLine($"The volume of earth in cubic kilometers is {volumeSphere} and cubic miles is {cubicMiles}");
    }

    // Problem 8
    static void milesToKilo()
    {
        double km, miles;

        Console.Write("Enter distance in kilometers: ");
        km = Convert.ToDouble(Console.ReadLine());

        miles = km / 16;

        Console.WriteLine($"The total miles is {miles} for the given {km}");
    }

    // Problem 9
    static void univer()
    {
        int fee, discountPercent;
        Console.WriteLine("Enter fee and discountPercent ");
        fee = Convert.ToInt32(Console.ReadLine());
        discountPercent = Convert.ToInt32(Console.ReadLine());

        int discount = fee * discountPercent / 100;
        int discountFee = fee - discount;
        Console.WriteLine($"The discount amout in INR {discount} and final discounted fee is INR {discountFee}");
    }

    // Problem 10
    static void centiToFeet()
    {
        Console.Write("Enter your height ");
        double height = Convert.ToDouble(Console.ReadLine());

        double inches = height / 2.54;
        double feet = inches / 12;

        Console.WriteLine($"Your Height in cm is {height} while in feet is {feet} and inches is {inches}");
    }

    // Problem 11
    static void Calculator()
    {
        Console.WriteLine("Enter num1: ");
        String userInput = Console.ReadLine();
        float num1 = float.Parse(userInput);

        Console.WriteLine("Enter num2: ");
        float num2 = Convert.ToSingle(Console.ReadLine());

        float add = num1 + num2;
        Console.WriteLine("Addition: " + add);

        float sub = num1 - num2;
        Console.WriteLine("Subtraction: " + sub);

        float multiply = num1 * num2;
        Console.WriteLine("Multiplication: " + multiply);

        float divide = num1 / num2;
        Console.WriteLine("Divide: " + divide);
    }

    // Problem 12
    static void areaTriangle()
    {
        Console.WriteLine("Enter the base: ");
        double bs = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height: ");
        double ht = Convert.ToDouble(Console.ReadLine());

        double inches = ht / 2.54;
        double feet = inches / 12;
        double Area = 1 / 2 * bs * ht;
        Console.WriteLine($"Your Triangle Height in cm is {ht} while in feet is {feet} and inches is {inches}");

    }

    // Problem 13
    static void Perimeter()
    {
        Console.WriteLine("Enter side: ");
        int side = Convert.ToInt32(Console.ReadLine());

        int perimeter = 4 * side;
        Console.WriteLine($"The length of the side is {side} whose permiter is {perimeter}");
    }

    // Problem 14
    static void Distance()
    {
        double distanceInFeet, yards, miles;

        Console.Write("Enter distance in feet: ");
        distanceInFeet = Convert.ToDouble(Console.ReadLine());

        yards = distanceInFeet / 3;
        miles = yards / 1760;

        Console.WriteLine($"The distance in feet is {distanceInFeet} while in yards is {yards} and in miles is {miles}");

    }

    // Problem 15
    static void CalculateTotalPrice()
    {
        Console.WriteLine("Enter unitPrice & Quantity: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());
        int quantity = Convert.ToInt32(Console.ReadLine());
        double totalPrice = unitPrice * quantity;

        Console.WriteLine(
            "The total purchase price is INR {0} if the quantity {1} and unit price is INR {2}",
            totalPrice, quantity, unitPrice
        );
    }

    // Problem 16
    static void Handshake()
    {
        Console.WriteLine("Enter the no of students: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int totalHandshake = (num * (num - 1)) / 2;
        Console.WriteLine($"Maximum no of handshake possible is {totalHandshake}");
    }
}
