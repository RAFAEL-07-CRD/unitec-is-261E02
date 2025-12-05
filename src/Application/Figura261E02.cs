namespace Application;

public class Figura261E02
{
    public static double Perimetro(double lado1, double lado2)
    {
        return 2 * (lado1 + lado2);
    }
    public static double Area(double lado1, double lado2)
    {
        return lado1 * lado2;
    }
    public static double Volumen(double areaBase, double altura)
    {
        return areaBase * altura;
    }

}