﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class CountrySide
    {
        static void Main()
        {
            new CountrySide().Run();
        }
        // Create the LinkedList to reflect the Map in the PowerPoint Instructions
        Village Maeland;
        Village Helmholtz;
        Village Alst;
        Village Wessig;
        Village Badden;
        Village Uster;
        Village Schvenig;

        public void TravelVillages(Village currentVillage)
        {
            if (currentVillage.isAstrildgeHere)
            {
                Console.WriteLine("Astrildge is found in{ 0}", currentVillage.VillageName);

                Console.WriteLine("******FEELING HAPPY!!*************");
                return;
            }


            TravelVillages(currentVillage.west);
            TravelVillages(currentVillage.east);
        }

        public void Run()


        {

            Alst = new Village("Alst", false);
            Schvenig = new Village("Schvenig", false);
            Wessig = new Village("Wessig", true);

            Alst.distanceToEastVillage = 14;
            Alst.distanceToWestVillage = 19;
            Alst.west = Schvenig;
            Alst.east = Wessig;

            //Scheving.distanceToNextVillage=14;
            Schvenig.west = null;
            Schvenig.east = null;

            //Alst.distanceToNextVillage=14;
            Wessig.west = null;
            Wessig.east = null;

        }

    }    


        class Village
        {
            public Village(string _villageName, bool _isAHere) 
            {
                isAstrildgeHere = _isAHere;
                VillageName = _villageName;
            }

            public Village west;
            public Village east;
            public string VillageName;
            public int distanceToEastVillage;
            public int distanceToWestVillage;
            public bool isAstrildgeHere;

       
        }
    }