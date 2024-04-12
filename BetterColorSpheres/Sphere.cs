using System;
using System.Drawing;

namespace BetterColorSpheres
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
        public void Pop(){
            Console.WriteLine("Esfera explodiu!");
            raio = 0f;
        }
        public void Throw(){
            if (raio > 0){
                disparos +=1; 
                Console.WriteLine("Esfera foi lançada.");
            } else{
                Console.WriteLine("Esfera não pode ser lançada.");
            }

        }
        public void GetTimesThrown(){
            Console.WriteLine($"Esfera foi lançada {disparos} vezes");
        }

        public static implicit operator Sphere(int v)
        {
            throw new NotImplementedException();
        }
    }
}