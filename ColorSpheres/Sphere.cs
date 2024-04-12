using System;
using System.Drawing;

namespace ColorSpheres
{
    class Sphere{
        private readonly Color cor;
        private float raio;
        private  int disparos;

        private  const int disparosmin = 0;
        public Sphere(Color cor,float r){
            this.cor = cor;
            raio = r;
            disparos = disparosmin;

        }  
        public void pop(){
            Console.WriteLine("Sphere was popped");
            raio = 0f;
        }
        public void Throw(){
            if (raio > 0){
                disparos +=1; 
                Console.WriteLine("Sphere was Thrown");
            } else{
                Console.WriteLine("Sphere is popped cannot be thrown");
            }

        }
        public void GetTimesThrown(){
            Console.WriteLine($"Sphere was Thrown {disparos} times");
        }

    }
}