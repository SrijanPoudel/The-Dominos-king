//Shrijan Paudel
//01/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Dominion_of_Kings
{
    public class Dominion_of_kings
    {

        // declaring a private variable;
        private int provinces=-1;  
        private int duchies=-1;
        private int estates = -1;


        //Getters and setters
        public int Provinces
        {
            get { return this.provinces; }
            set { this.provinces = value;}
        }
        public int Duchies
        {
            get { return this.duchies; }
            set { this.duchies = value; }
        }
        public int Estates
        {
            get { return this.estates; }
            set { this.estates = value; }
        }

        //method to calculate total point 
        public int Calculate()
        {
            int total_points = (Provinces * 6) + (Duchies * 3) + (Estates * 1);
            return total_points;
        }


    }
}
