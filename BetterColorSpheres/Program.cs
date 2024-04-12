using System;

namespace BetterColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            int bolasAtiradasTotal = 0;
            //cria as cores
            Color red = new Color(255, 0,0,255);
            Color green = new Color(0, 255,0,255);
            Color blue = new Color(0, 0,255,255);
            //cria as esferas
            Sphere redSphere = new Sphere(red, 2f);
            Sphere GreenSphere = new Sphere(green, 4f);
            Sphere BlueSphere = new Sphere(blue, 6f);

            redSphere.Pop = 9;
            redSphere.Throw = 10;
            GreenSphere.Throw = 11;
            GreenSphere.Throw = 5;
            GreenSphere.Throw = 13;
            GreenSphere.Throw = 10;
            BlueSphere.Throw = 2;
            bolasAtiradasTotal += redSphere.GetTimesThrown;
            bolasAtiradasTotal += GreenSphere.GetTimesThrown;
            bolasAtiradasTotal += BlueSphere.GetTimesThrown;

            Console.WriteLine(bolasAtiradasTotal);
        }
    }
}