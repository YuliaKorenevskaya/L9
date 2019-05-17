using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9
{
    struct Coordinates
    {
        public int x;
        public int y;
        public int z;

        public Coordinates(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Deconstruct(out int x1, out int y1, out int z1)
        {
            x1 = x;
            y1 = y;
            z1 = z;
        }
    }

    class Program
    {
        static void Main()
        {
            Random r = new Random();
            Coordinates xyz;
            xyz.x = r.Next(1, 11);
            xyz.y = r.Next(1, 11);
            xyz.z = r.Next(1, 11);

            int l = (int)Math.Sqrt(xyz.x * xyz.x + xyz.y * xyz.y + xyz.z * xyz.z);
            Console.WriteLine($"Length = {l};   {xyz.x},{xyz.y},{xyz.z}");
            Console.ReadKey();

            xyz.Deconstruct(out xyz.x, out xyz.y, out xyz.z);
        }
    }
}