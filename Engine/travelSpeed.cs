using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{

    public class TravelSpeed
    {
        private void Travel()
        {
            //Earth to Alpha Centauri and reverse
            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = -4.367;


            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Distance = " + distance);
            Console.ReadLine();

        }
        private void EarthToMGP()
        {
            //Earth to MGP and reverse
            double x1 = 0;
            double y1 = 0;
            double x2 = -4.6;
            double y2 = 5;


            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Distance = " + distance);
            Console.ReadLine();

        }
        private void MGPtoALpha()
        {
            //MGP to Alpha Centauri and reverse
            double x1 = -4.6;
            double y1 = 5;
            double x2 = 0;
            double y2 = -4.367;


            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Distance = " + distance);
            Console.ReadLine();







        }
        public void WarpSpeed()
        {
            int w;
            double speed;
            Console.WriteLine("Please enter your speed, warp 2 or warp 3");
            w = Convert.ToInt32(Console.ReadLine());

            speed = Math.Pow(w, 10 / 3) + Math.Pow((10 - w), -11 / 3);

        }



    }



}