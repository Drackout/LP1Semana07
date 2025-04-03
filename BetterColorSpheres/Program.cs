using System;

namespace BetterColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color cc1 = new Color(225,29,111,255);

            Console.WriteLine(cc1.Red);
            Console.WriteLine(cc1.Green);
            Console.WriteLine(cc1.Blue);

            //INCREMENTAR? NAO FOI EXPLICADO
            //PRECISA DE CONSTRUTOR? NAO FOI EXPLICADO
            //MUITO MAIS CONFUSO
            //DE 36 LINHAS PARA 50... NÃO AJUDA EM NADA!!
            Sphere coise = new Sphere(cc1, 24);
            coise.Throw = 0; 

        }
    }
}
