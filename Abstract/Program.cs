using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class MEDKARTA            
    {
        public abstract double IMT();
        

    }
    public class People : MEDKARTA
    {
        public string name;
        public int weight;
        public double height;
        public People (string name, int weight, double height)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
        }
        public override double IMT()
        {
            return weight / (height*height);
        }



    }


    class Program
    {
        static void Main(string[] args)
        {
            People people = new People("Инсаф", 58, 1.8);
            Console.WriteLine(" имя: " + people.name + " рост: "+ people.height + " вес: "+people.weight);
            Console.WriteLine();
            Console.Write("IMT = ");

            Console.Write(people.IMT());
            //if(people.IMT < 18.5 || people.IMT > 25)
            //{
            //    Console.WriteLine("IMT НЕ В  НОРМЕэ)
            //}
            Console.ReadLine();
        }
    }
}
