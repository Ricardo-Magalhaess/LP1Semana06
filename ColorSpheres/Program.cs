using System;

namespace ColorSpheres
{
    class Color
    {
        private readonly byte r;
        private readonly byte g;
        private readonly  byte b;
        private readonly byte a;
        private const byte aplhamax = 255;
        public Color(byte red,byte green,byte blue,byte alpha){
            r = red;
            g = green;
            b = blue;
            a = alpha;
         }

         public Color(byte red,byte green,byte blue){
            r = red;
            g = green;
            b = blue;
            a = aplhamax;

        } 
        public byte Getred(){
            return r;
        }
        public byte Getgreen(){
            return g;
        }
        
        public byte Getblue(){
            return b;
        }
        public byte Getalpha(){
            return a;
        }
        public byte Getgrey(){
            int media = (r+g+b)/3;
            byte grey = (byte)media;
            return grey;
        }


    }
}
