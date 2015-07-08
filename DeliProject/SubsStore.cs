using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliProject
{

    public class SubsStore
    {


        private TraditionalSub[] TS;
        internal TraditionalSub[] TS1
        {
            get { return TS; }
            set { TS = value; }
        }

        private AddOnes[] AO;

        internal AddOnes[] AO1
        {
            get { return AO; }
            set { AO = value; }
        }

        private SpecialitySubs[] SS;

        internal SpecialitySubs[] SS1
        {
            get { return SS; }
            set { SS = value; }
        }

        private Beverages[] BS;

        internal Beverages[] BS1
        {
            get { return BS; }
            set { BS = value; }
        }

        private Slides[] SL;

        internal Slides[] SL1
        {
            get { return SL; }
            set { SL = value; }
        }


        public SubsStore()
        {
            

             TS = new TraditionalSub[3];
             AO = new AddOnes[2];
             SS = new SpecialitySubs[3];
             BS = new Beverages[4];
             SL = new Slides[4];

             InitializeMenu();
        }


        private void InitializeMenu()
        {
            
            TS[0].Name = "Ham and Cheese";
            TS[0].Regular = 4;
            TS[0].Large = 6;

            TS[1].Name = "Italian";
            TS[1].Regular = 4.50;
            TS[1].Large = 7;

            TS[2].Name = "American";
            TS[2].Regular = 4.50;
            TS[2].Large = 7;



            AO[0].Name = "Pickels";
            AO[0].Price = 0.25;

            AO[1].Name = "Tomatoes";
            AO[1].Price = 0.25;
          


            SS[0].Name = "Chicken Salad";
            SS[0].Regular = 4.50;
            SS[0].Large = 7;

            SS[1].Name = "The Works";
            SS[1].Regular = 5;
            SS[1].Large = 8;

            SS[2].Name = "The Veggie";
            SS[2].Regular = 4;
            SS[2].Large = 6;




            BS[0].Name = "Water";
            BS[0].Regular = 0; //free
            BS[0].Large = 0;

            BS[1].Name = "Fountain Soda";
            BS[1].Regular = 1.50;
            BS[1].Large = 2;

            BS[2].Name = "Bottled Soda";
            BS[2].Regular = 1.75;
            BS[2].Large = 2.50;

            BS[3].Name = "Fresh Iced Tea/Lemonade";
            BS[3].Regular = -1; // -1 is to indicate  n/a
            BS[3].Large = 2.00;





            SL[0].Name = "Chips (any variety)";
            SL[0].Price = 1;

            SL[1].Name = "Cookie";
            SL[1].Price = 1.50;

            SL[2].Name = "Coleslaw Salad";
            SL[2].Price = 2;

            SL[3].Name = "Potato Salad";
            SL[3].Price = 2.50;

        }   
    }
}
