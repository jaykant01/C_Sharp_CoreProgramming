namespace Method_Level2;

public class QuadraticRoots
{
    public void Roots()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = Math.Pow(b, 2) - 4 * a * c;

        if(delta == 0)
        {
            double root = -(b) / (2 * a);
            Console.WriteLine(root);
        }
        else
        {
            double root1 = ((-b + delta) / 2 * a);
            double root2 = ((-b - delta) / 2 * a);
            Console.WriteLine(root1);
            Console.WriteLine(root2);
        }

    }
}
