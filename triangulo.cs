using System; 

class URI {

    static void Main(string[] args) { 

        string[] inputs = Console.ReadLine().Split();
        
        double A = double.Parse(inputs[0]);
        double B = double.Parse(inputs[1]);
        double C = double.Parse(inputs[2]);

        if (A + B > C && A + C > B && B + C > A)
        {
            double perimetro = A + B + C;
            Console.WriteLine($"Perimetro = {perimetro:F1}");
        }
        else
        {
            double area = ((A + B) * C) / 2;
            Console.WriteLine($"Area = {area:F1}");
        }

    }

}