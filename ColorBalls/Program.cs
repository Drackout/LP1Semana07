using System;

namespace ColorBalls
{

    public class Ball
    {
        private Color cor;
        private int raio;
        private int throwNumber;

        public Ball(Color cor, int raio)
        {
            this.cor = cor;
            this.raio = raio;
            this.throwNumber = 0;
        }

        public void Pop()
        {
            this.raio = 0;
        }
        public void Throw()
        {
            if (raio != 0)
            {
                throwNumber++;
            }
        }
        public int GetThrowNumber()
        {
            return throwNumber;
        }
        public int GetRaio()
        {
            return raio;
        }
        public Color GetColor()
        {
            return cor;
        }
    }

    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;

        }

        // GETS
        public int GetRed()
        {
            return red;
        }
        public int GetGreen()
        {
            return green;
        }
        public int GetBlue()
        {
            return blue;
        }
        public int GetAlpha()
        {
            return alpha;
        }
        public int GetGray()
        {
            int gray = (GetRed() + GetGreen() + GetBlue())/3;
            return gray;
        }


        // SETS
        public void SetRed(int red)
        {
            this.red = red;
        }
        public void SetGreen(int green)
        {
            this.green = green;
        }
        public void SetBlue(int blue)
        {
            this.blue = blue;
        }
        public void SetAlpha(int alpha)
        {
            this.alpha = alpha;
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Color red = new Color(255,0,0);
            Color green = new Color(0,255,0);
            Color blue = new Color(0,0,255);

            Ball ball1 = new Ball(red, 5);
            Ball ball2 = new Ball(green, 5);
            Ball ball3 = new Ball(blue, 5);
            
            ball1.Pop();
            ball2.Throw();
            ball2.Throw();
            ball2.Throw();
            ball2.Throw();
            ball2.Throw();
            ball2.Throw();

            ball1.Throw();
            ball1.Throw();

            Console.WriteLine("get red (1): " + ball1.GetColor().GetRed());
            Console.WriteLine("get green (1): " + ball1.GetColor().GetGreen());
            Console.WriteLine("get blue (1): " + ball1.GetColor().GetBlue());
            
            Console.WriteLine("get red (2): " + ball2.GetColor().GetRed());
            Console.WriteLine("get green (2): " + ball2.GetColor().GetGreen());
            Console.WriteLine("get blue (2): " + ball2.GetColor().GetBlue());

            Console.WriteLine("get throw number (1): " + ball1.GetThrowNumber());
            Console.WriteLine("get throw number (2): " + ball2.GetThrowNumber());

            
            Console.WriteLine("raio (1): " + ball1.GetRaio());
            Console.WriteLine("raio (2): " + ball2.GetRaio());
            

        }
    }
}
