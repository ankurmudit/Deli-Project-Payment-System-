using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DeliProject
{
    public partial class frmMenu : Form
    {
        
        public ArrayList TraditionalSubsStore;
        public ArrayList SpecialSubsStore;
        public ArrayList BeveragesStore;
        public ArrayList SlidesStore;
        public ArrayList AddOnesStore;

        public string CustomerType, DeliveryAddres;
        public double total, specialAmount;
        public int specialQuantity;
        public bool isRestart;
        bool isToDeliver,isRepeat;
        double deliveryCost ,specialCost,discounts,tax;
        double totTSHumReg, totTSHumLrg,totTSItalianReg,totTSItalianLrg ,totTSAmericanReg,totTSAmericanLrg;
        double totBevWaterReg, totBevWaterLrg, totBevFountSodaReg, totBevFountSodaLrg, totBevBtlSodaReg,totBevBtlSodaLrg, totBevIceTeaLrg;
        double totSSChickenReg, totSSChickenLrg,totSSWorksReg,totSSWorksLrg,totSSVegReg,totSSVegLrg;
        double totSLChips , totSLCookie , totSLCole , totSLPotato;
        double totAOPick, totAOTomoato;
        SubsStore newSubsStore;


        public frmMenu()
        {
            InitializeComponent();

            newSubsStore = new SubsStore();
            TraditionalSubsStore = new ArrayList();
            SpecialSubsStore = new ArrayList();
            BeveragesStore = new ArrayList();
            SlidesStore = new ArrayList();
            AddOnesStore = new ArrayList();
            CustomerType = String.Empty ;
            DeliveryAddres = String.Empty;
            total = 0;
            isToDeliver = false;
   
        }

        # region "Traditional Subs"
        private void chkTSHam_CheckedChanged(object sender, EventArgs e)
        {
           
            if(chkTSHam.Checked ==true)
            {
                numTSHamLrg.Enabled = true;
                numTSHamReg.Enabled = true;
                numTSHamReg.Value = 1;

            }
            else
            {
                numTSHamLrg.Enabled = false;
                numTSHamReg.Enabled = false;
                total -= newSubsStore.TS1[0].Regular * totTSHumReg;
                total -= newSubsStore.TS1[0].Large * totTSHumLrg;
                totTSHumReg = 0;
                totTSHumLrg = 0;
                numTSHamLrg.Value = 0;
                numTSHamReg.Value = 0;

                if (total - deliveryCost == 0)
                    chkDilivery.Checked = false;
               
            }
        }

        private void numTSHamReg_ValueChanged(object sender, EventArgs e)
        {
            if (numTSHamReg.Value == 0 && numTSHamLrg.Value == 0)
            {
                chkTSHam.Checked = false;
                totTSHumReg = 0;

            }

         
            total -=  newSubsStore.TS1[0].Regular * totTSHumReg;
            totTSHumReg = (double)numTSHamReg.Value;
            total += newSubsStore.TS1[0].Regular * totTSHumReg;

            SetCurrentTotal();


        }

        private void numTSHamLrg_ValueChanged(object sender, EventArgs e)
        {
            if (numTSHamReg.Value == 0 && numTSHamLrg.Value == 0)
            {
                chkTSHam.Checked = false;
                totTSHumLrg = 0;
            }
                

            total -= newSubsStore.TS1[0].Large * totTSHumLrg;
            totTSHumLrg = (double)numTSHamLrg.Value;
            total += newSubsStore.TS1[0].Large * totTSHumLrg;

            SetCurrentTotal();

        }

        private void chkTSItalian_CheckedChanged(object sender, EventArgs e)
        {
           

            if (chkTSItalian.Checked == true)
            {

                numTSItalianLrg.Enabled = true;
                numTSItalianReg.Enabled = true;
                numTSItalianReg.Value = 1;
            }
            else
            {

                numTSItalianLrg.Enabled = false;
                numTSItalianReg.Enabled = false;
                total -= newSubsStore.TS1[1].Regular * totTSItalianReg;
                total -= newSubsStore.TS1[1].Large * totTSItalianLrg;
                totTSItalianReg= 0;
                totTSItalianLrg = 0;
                numTSItalianLrg.Value = 0;
                numTSItalianReg.Value = 0;

                if (total - deliveryCost == 0)
                    chkDilivery.Checked = false;

            }
        }

        private void numTSItalianReg_ValueChanged(object sender, EventArgs e)
        {
            if (numTSItalianReg.Value == 0 && numTSItalianLrg.Value == 0)
            {
                chkTSItalian.Checked = false;
                totTSItalianReg = 0;

            }

            total -= newSubsStore.TS1[1].Regular * totTSItalianReg;
            totTSItalianReg = (double)numTSItalianReg.Value;
            total += newSubsStore.TS1[1].Regular * totTSItalianReg;
            SetCurrentTotal();
        }

        private void numTSItalianLrg_ValueChanged(object sender, EventArgs e)
        {
            if (numTSItalianReg.Value == 0 && numTSItalianLrg.Value == 0)
            {
                chkTSItalian.Checked = false;
                totTSItalianLrg = 0;

            }

            total -= newSubsStore.TS1[1].Large * totTSItalianLrg;
            totTSItalianLrg = (double)numTSItalianLrg.Value;
            total += newSubsStore.TS1[1].Large * totTSItalianLrg;
            SetCurrentTotal();
        }

        private void chkTSAmerican_CheckedChanged(object sender, EventArgs e)
        {
         

            if (chkTSAmerican.Checked == true)
            {

                numTSAmericanLrg.Enabled = true;
                numTSAmericanReg.Enabled = true;
                numTSAmericanReg.Value = 1;
            }
            else
            {

                numTSAmericanLrg.Enabled = false;
                numTSAmericanReg.Enabled = false;
                total -= newSubsStore.TS1[2].Regular * totTSAmericanReg;
                total -= newSubsStore.TS1[2].Large * totTSAmericanLrg;
                totTSAmericanReg = 0;
                totTSAmericanLrg = 0;
                numTSAmericanLrg.Value = 0;
                numTSAmericanReg.Value = 0;

                if (total - deliveryCost == 0)
                    chkDilivery.Checked = false;
               
            }
        }

        private void numTSAmericanReg_ValueChanged(object sender, EventArgs e)
        {
            if (numTSAmericanReg.Value == 0 && numTSAmericanLrg.Value == 0)
            {
                chkTSAmerican.Checked = false;
                totTSAmericanReg = 0;

            }

            total -= newSubsStore.TS1[2].Regular * totTSAmericanReg;
            totTSAmericanReg = (double)numTSAmericanReg.Value;
            total += newSubsStore.TS1[2].Regular * totTSAmericanReg;
            SetCurrentTotal();
        }

        private void numTSAmericanLrg_ValueChanged(object sender, EventArgs e)
        {
            if (numTSAmericanReg.Value == 0 && numTSAmericanLrg.Value == 0)
            {
                chkTSAmerican.Checked = false;
                totTSAmericanLrg = 0;

            }

            total -= newSubsStore.TS1[2].Large * totTSAmericanLrg;
            totTSAmericanLrg = (double)numTSAmericanLrg.Value;
            total += newSubsStore.TS1[2].Large * totTSAmericanLrg;
            SetCurrentTotal();
        }

        # endregion

        # region "Beverages"

        private void chkBevWater_CheckedChanged(object sender, EventArgs e)
        {
          
            if (chkBevWater.Checked == true)
            {

              
                numBevWaterLrg.Enabled = true;
                numBevWaterReg.Enabled = true;
                numBevWaterReg.Value = 1;
                
            }
            else
            {
   
                numBevWaterLrg.Enabled = false;
                numBevWaterReg.Enabled = false;
                total -= newSubsStore.BS1[0].Regular * totBevWaterReg;
                total -= newSubsStore.BS1[0].Large * totBevWaterLrg;
                totBevWaterReg = 0;
                totBevWaterLrg = 0;
                numBevWaterLrg.Value = 0;
                numBevWaterReg.Value = 0;

                if (total - deliveryCost == 0)
                    chkDilivery.Checked = false;
               
            }
          
        }

        private void numBevWaterReg_ValueChanged(object sender, EventArgs e)
        {
            if (numBevWaterReg.Value == 0 && numBevWaterLrg.Value == 0)
            {
                chkBevWater.Checked = false;
                totBevWaterReg = 0;

            }
            
            total -= newSubsStore.BS1[0].Regular * totBevWaterReg;
            totBevWaterReg = (double)numBevWaterReg.Value;
            total += newSubsStore.BS1[0].Regular * totBevWaterReg;
            SetCurrentTotal();
        }

        private void numBevWaterLrg_ValueChanged(object sender, EventArgs e)
        {

            if (numBevWaterReg.Value == 0 && numBevWaterLrg.Value == 0)
            {
                chkBevWater.Checked = false;
                totBevWaterLrg = 0;

            }
            
            total -= newSubsStore.BS1[0].Large * totBevWaterLrg;
            totBevWaterLrg = (double)numBevWaterLrg.Value;
            total += newSubsStore.BS1[0].Large * totBevWaterLrg;
            SetCurrentTotal();
        }

        private void chkFountSoda_CheckedChanged(object sender, EventArgs e)
        {
           

            if (chkBevFountSoda.Checked == true)
            {

                
                numBevFounSodaLrg.Enabled = true;
                numBevFounSodaReg.Enabled = true;
                numBevFounSodaReg.Value = 1;
            }
            else
            {
              
                numBevFounSodaLrg.Enabled = false;
                numBevFounSodaReg.Enabled = false;
                total -= newSubsStore.BS1[1].Regular * totBevFountSodaReg;
                total -= newSubsStore.BS1[1].Large * totBevFountSodaLrg;
                totBevFountSodaReg = 0;
                totBevFountSodaLrg = 0;
                numBevFounSodaLrg.Value = 0;
                numBevFounSodaReg.Value = 0;

                if (total - deliveryCost == 0)
                    chkDilivery.Checked = false;

            }
        
        }

        private void numBevFounSodaReg_ValueChanged(object sender, EventArgs e)
        {
            if (numBevFounSodaReg.Value == 0 && numBevFounSodaLrg.Value == 0)
            {
                chkBevFountSoda.Checked = false;
                totBevFountSodaReg = 0;

            }
            
            total -= newSubsStore.BS1[1].Regular * totBevFountSodaReg;
            totBevFountSodaReg = (double)numBevFounSodaReg.Value;
            total += newSubsStore.BS1[1].Regular * totBevFountSodaReg;
            SetCurrentTotal();
        }

        private void numBevFounSodaLrg_ValueChanged(object sender, EventArgs e)
        {

            if (numBevFounSodaReg.Value == 0 && numBevFounSodaLrg.Value == 0)
            {
                chkBevFountSoda.Checked = false;
                totBevFountSodaLrg = 0;

            }
            
            total -= newSubsStore.BS1[1].Large * totBevFountSodaLrg;
            totBevFountSodaLrg = (double)numBevFounSodaLrg.Value;
            total += newSubsStore.BS1[1].Large * totBevFountSodaLrg;
            SetCurrentTotal();
        }

        private void chkBotlSoda_CheckedChanged(object sender, EventArgs e)
        {
           

            if (chkBevBotlSoda.Checked == true)
            {

               
                numBevBtlSodaLrg.Enabled = true;
                numBevBtlSodaReg.Enabled = true;
                numBevBtlSodaReg.Value = 1;
            }
            else
            {
                
                numBevBtlSodaLrg.Enabled = false;
                numBevBtlSodaReg.Enabled = false;
                total -= newSubsStore.BS1[2].Regular * totBevBtlSodaReg;
                total -= newSubsStore.BS1[2].Large * totBevBtlSodaLrg;
                totBevBtlSodaReg = 0;
                totBevBtlSodaLrg = 0;
                numBevBtlSodaLrg.Value = 0;
                numBevBtlSodaReg.Value = 0;

                if (total - deliveryCost == 0)
                    chkDilivery.Checked = false;
            }
            
        }

        private void numBevBtlSodaReg_ValueChanged(object sender, EventArgs e)
        {
            if (numBevBtlSodaReg.Value == 0 && numBevBtlSodaLrg.Value == 0)
            {
                chkBevBotlSoda.Checked = false;
                totBevBtlSodaReg = 0;
            }
            
            total -= newSubsStore.BS1[2].Regular * totBevBtlSodaReg;
            totBevBtlSodaReg = (double)numBevBtlSodaReg.Value;
            total += newSubsStore.BS1[2].Regular * totBevBtlSodaReg;
            SetCurrentTotal();
        }

        private void numBevBtlSodaLrg_ValueChanged(object sender, EventArgs e)
        {
            if (numBevBtlSodaReg.Value == 0 && numBevBtlSodaLrg.Value == 0)
            {
                chkBevBotlSoda.Checked = false;
                totBevBtlSodaLrg = 0;

            }
            
            total -= newSubsStore.BS1[2].Large * totBevBtlSodaLrg;
            totBevBtlSodaLrg = (double)numBevBtlSodaLrg.Value;
            total += newSubsStore.BS1[2].Large * totBevBtlSodaLrg;
            SetCurrentTotal();
        }

        private void chkFreshTead_CheckedChanged(object sender, EventArgs e)
        {

            if (chkBevFreshTead.Checked == true)
            {

                numBevFreshTeaLrg.Enabled = true;
                numBevFreshTeaLrg.Value = 1;
            }
            else
            {
               
                numBevFreshTeaLrg.Enabled = false;
                total -= newSubsStore.BS1[3].Large * totBevIceTeaLrg;
                totBevIceTeaLrg = 0;
                numBevFreshTeaLrg.Value = 0;

                if (total - deliveryCost == 0)
                    chkDilivery.Checked = false;
            }
            
        }

        private void numBevFreshTeaLrg_ValueChanged(object sender, EventArgs e)
        {

            if (numBevFreshTeaLrg.Value == 0)
            {
                chkBevFreshTead.Checked = false;
                totBevIceTeaLrg = 0;

            }
            
            total -= newSubsStore.BS1[3].Large * totBevIceTeaLrg;
            totBevIceTeaLrg = (double)numBevFreshTeaLrg.Value;
            total += newSubsStore.BS1[3].Large * totBevIceTeaLrg;
            SetCurrentTotal();
        }

     

        #endregion

        # region "Specialty Subs"

        private void chkSSChicken_CheckedChanged(object sender, EventArgs e)
        {
            

            if (chkSSChicken.Checked == true)
            {

                numSSChickenLrg.Enabled = true;
                numSSChickenReg.Enabled = true;
                numSSChickenReg.Value = 1;
            
            }
            else
            {
              
                numSSChickenLrg.Enabled = false;
                numSSChickenReg.Enabled = false;
                total -= newSubsStore.SS1[0].Regular * totSSChickenReg;
                total -= newSubsStore.SS1[0].Large * totSSChickenLrg;
                totSSChickenReg = 0;
                totSSChickenLrg = 0;
                numSSChickenLrg.Value = 0;
                numSSChickenReg.Value = 0;

                if (total - deliveryCost == 0)
                    chkDilivery.Checked = false;

            }
        }

        private void numSSChickenReg_ValueChanged(object sender, EventArgs e)
        {
            if (numSSChickenReg.Value == 0 && numSSChickenLrg.Value == 0)
            {
                chkSSChicken.Checked = false;
                totSSChickenReg = 0;
            }

            total -= newSubsStore.SS1[0].Regular * totSSChickenReg;
            totSSChickenReg = (double)numSSChickenReg.Value;
            total += newSubsStore.SS1[0].Regular * totSSChickenReg;
            SetCurrentTotal();
        }

        private void numSSChickenLrg_ValueChanged(object sender, EventArgs e)
        {
            if (numSSChickenReg.Value == 0 && numSSChickenLrg.Value == 0)
            {
                chkSSChicken.Checked = false;
                totSSChickenLrg = 0;
            }
            
            total -= newSubsStore.SS1[0].Large * totSSChickenLrg;
            totSSChickenLrg = (double)numSSChickenLrg.Value;
            total += newSubsStore.SS1[0].Large * totSSChickenLrg;
            SetCurrentTotal();
        }

        private void chkSSWorks_CheckedChanged(object sender, EventArgs e)
        {

            if (chkSSWorks.Checked == true)
            {

                numSSWorksLrg.Enabled = true;
                numSSWorksReg.Enabled = true;
                numSSWorksReg.Value = 1;
             
            }
            else
            {

                numSSWorksLrg.Enabled = false;
                numSSWorksReg.Enabled = false;
                total -= newSubsStore.SS1[1].Regular * totSSWorksReg;
                total -= newSubsStore.SS1[1].Large * totSSWorksLrg;
                totSSWorksReg = 0;
                totSSWorksLrg = 0;
                numSSWorksLrg.Value = 0;
                numSSWorksReg.Value = 0;

                if (total - deliveryCost == 0)
                    chkDilivery.Checked = false;
            }
        }

        private void numSSWorksReg_ValueChanged(object sender, EventArgs e)
        {
            if (numSSWorksReg.Value == 0 && numSSWorksLrg.Value == 0)
            {
                chkSSWorks.Checked = false;
                totSSWorksReg = 0;
            }

            total -= newSubsStore.SS1[1].Regular * totSSWorksReg;
            totSSWorksReg = (double)numSSWorksReg.Value;
            total += newSubsStore.SS1[1].Regular * totSSWorksReg;
            SetCurrentTotal();
        }

        private void numSSWorksLrg_ValueChanged(object sender, EventArgs e)
        {
            if (numSSWorksReg.Value == 0 && numSSWorksLrg.Value == 0)
            {
                chkSSWorks.Checked = false;
                totSSWorksLrg = 0;
            }

            total -= newSubsStore.SS1[1].Large * totSSWorksLrg;
            totSSWorksLrg = (double)numSSWorksLrg.Value;
            total += newSubsStore.SS1[1].Large * totSSWorksLrg;
            SetCurrentTotal();
        }

        private void chkSSVeg_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkSSVeg.Checked == true)
            {

                
                numSSVegLrg.Enabled = true;
                numSSVegReg.Enabled = true;
                numSSVegReg.Value = 1;
               
            }
            else
            {
               
                numSSVegLrg.Enabled = false;
                numSSVegReg.Enabled = false;
                total -= newSubsStore.SS1[2].Regular * totSSVegReg;
                total -= newSubsStore.SS1[2].Large * totSSVegLrg;
                totSSVegReg = 0;
                totSSVegLrg = 0;
                numSSVegLrg.Value = 0;
                numSSVegReg.Value = 0;

                if (total - deliveryCost == 0)
                    chkDilivery.Checked = false;
            }
        }

        private void numSSVegReg_ValueChanged(object sender, EventArgs e)
        {

            if (numSSVegReg.Value == 0 && numSSVegLrg.Value == 0)
            {
                chkSSVeg.Checked = false;
                totSSVegReg = 0;
            }
            
            total -= newSubsStore.SS1[2].Regular * totSSVegReg;
            totSSVegReg = (double)numSSVegReg.Value;
            total += newSubsStore.SS1[2].Regular * totSSVegReg;
            SetCurrentTotal();
        }

        private void numSSVegLrg_ValueChanged(object sender, EventArgs e)
        {
            if (numSSVegReg.Value == 0 && numSSVegLrg.Value == 0)
            {
                chkSSVeg.Checked = false;
                totSSVegLrg = 0;
            }

            total -= newSubsStore.SS1[2].Large * totSSVegLrg;
            totSSVegLrg = (double)numSSVegLrg.Value;
            total += newSubsStore.SS1[2].Large * totSSVegLrg;
            SetCurrentTotal();
        }


        #endregion

        # region "Slides"

        private void chkSLChips_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSLChips.Checked == true)
            {
                numSLChips.Enabled = true;
                numSLChips.Value = 1;
            }
            else
            {
               
                numSLChips.Enabled = false;
                total -= newSubsStore.SL1[0].Price * totSLChips;
                totSLChips = 0;
                numSLChips.Value = 0;

            }
          
            if (total - deliveryCost == 0)
                chkDilivery.Checked = false;
        }

        private void numSLChips_ValueChanged(object sender, EventArgs e)
        {

            if (numSLChips.Value == 0)
            {
                chkSLChips.Checked = false;
                totSLChips = 0;
            }

            total -=  newSubsStore.SL1[0].Price * totSLChips;
            totSLChips = (double)numSLChips.Value;
            total += newSubsStore.SL1[0].Price * totSLChips;

            SetCurrentTotal();

        }

        private void chkSLCookie_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSLCookie.Checked == true)
            {
                numSLCoikie.Enabled = true;
                numSLCoikie.Value = 1;
            }
            else
            {

                numSLCoikie.Enabled = false;
                total -= newSubsStore.SL1[1].Price * totSLCookie;
                totSLCookie = 0;
                numSLCoikie.Value = 0;

            }

            if (total - deliveryCost == 0)
                chkDilivery.Checked = false;
        }

        private void numSLCoikie_ValueChanged(object sender, EventArgs e)
        {
            if (numSLCoikie.Value == 0)
            {
                chkSLCookie.Checked = false;
                totSLCookie = 0;
            }

            total -= newSubsStore.SL1[1].Price * totSLCookie;
            totSLCookie = (double)numSLCoikie.Value;
            total += newSubsStore.SL1[1].Price * totSLCookie;

            SetCurrentTotal();
        }
    
        private void chkColes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkColes.Checked == true)
            {
                numSLCole.Enabled = true;
                numSLCole.Value = 1;
            }
            else
            {

                numSLCole.Enabled = false;
                total -= newSubsStore.SL1[2].Price * totSLCole;
                totSLCole = 0;
                numSLCole.Value = 0;

            }

            if (total - deliveryCost == 0)
                chkDilivery.Checked = false;
        }

        private void numSLCole_ValueChanged(object sender, EventArgs e)
        {
            if (numSLCole.Value == 0)
            {
                chkColes.Checked = false;
                totSLCole = 0;
            }

            total -= newSubsStore.SL1[2].Price * totSLCole;
            totSLCole = (double)numSLCole.Value;
            total += newSubsStore.SL1[2].Price * totSLCole;

            SetCurrentTotal();
        }
      
        private void chkPotato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPotato.Checked == true)
            {
                numSLPotato.Enabled = true;
                numSLPotato.Value = 1;
            }
            else
            {

                numSLPotato.Enabled = false;
                total -= newSubsStore.SL1[3].Price * totSLPotato;
                totSLPotato = 0;
                numSLPotato.Value = 0;

            }

            if (total - deliveryCost == 0)
                chkDilivery.Checked = false; 
        }

        private void numSLPotato_ValueChanged(object sender, EventArgs e)
        {
            if (numSLPotato.Value == 0)
            {
                chkPotato.Checked = false;
                totSLPotato = 0;
            }

            total -= newSubsStore.SL1[3].Price * totSLPotato;
            totSLPotato = (double)numSLPotato.Value;
            total += newSubsStore.SL1[3].Price * totSLPotato;

            SetCurrentTotal();
        }

        #endregion

        # region "Add Ones"

        private void chkAOPickels_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAOPickels.Checked == true)
            {
                numAOPick.Enabled = true;
                numAOPick.Value = 1;
            }
            else
            {

                numAOPick.Enabled = false;
                total -= newSubsStore.AO1[0].Price * totAOPick;
                totAOPick = 0;
                numAOPick.Value = 0;

            }

            if (total - deliveryCost == 0)
                chkDilivery.Checked = false; 
        }

        private void numAOPick_ValueChanged(object sender, EventArgs e)
        {
            if (numAOPick.Value == 0)
            {
                chkAOPickels.Checked = false;
                totAOPick = 0;
            }

            total -= newSubsStore.AO1[0].Price * totAOPick;
            totAOPick = (double)numAOPick.Value;
            total += newSubsStore.AO1[0].Price * totAOPick;

            SetCurrentTotal();
        }

        private void chkAOTomato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAOTomato.Checked == true)
            {
                numAPTomato.Enabled = true;
                numAPTomato.Value = 1;
            }
            else
            {

                numAPTomato.Enabled = false;
                total -= newSubsStore.AO1[1].Price * totAOTomoato;
                totAOTomoato = 0;
                numAPTomato.Value = 0;

            }

            if (total - deliveryCost == 0)
                chkDilivery.Checked = false; 
        }

        private void numAPTomato_ValueChanged(object sender, EventArgs e)
        {
            if (numAPTomato.Value == 0)
            {
                chkAOTomato.Checked = false;
                totAOTomoato = 0;
            }

            total -= newSubsStore.AO1[1].Price * totAOTomoato;
            totAOTomoato = (double)numAPTomato.Value;
            total += newSubsStore.AO1[1].Price * totAOTomoato;

            SetCurrentTotal();
        }

        #endregion

        # region "Customer Type"

        private void radStudent_CheckedChanged(object sender, EventArgs e)
        {
            CustomerType = radStudent.Text;
        }

        private void radiFaculty_CheckedChanged(object sender, EventArgs e)
        {
            CustomerType = radFaculty.Text;
        }

        private void radStaff_CheckedChanged(object sender, EventArgs e)
        {
            CustomerType = radStaff.Text;
        }

        private void radOther_CheckedChanged(object sender, EventArgs e)
        {
            CustomerType = radOther.Text;
        }

        #endregion 


        private void chkDilivery_CheckedChanged(object sender, EventArgs e)
        {
            if (!isRepeat)
            {

                if (total != 0)
                {
                    if (chkDilivery.Checked == true)
                    {
                        isToDeliver = true;

                        DeliveryAddres = Microsoft.VisualBasic.Interaction.InputBox("Enter the Delivery Address", "Delivery Address");

                        if (DeliveryAddres.Equals(String.Empty))
                        {

                            MessageBox.Show("Please enter the delivery address.", "Required!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            isRepeat = true;
                            chkDilivery.Checked = false;
                            isRepeat = false;
                            isToDeliver = false;
                        }
                       // else
                           // CalculateDeliveryCharges();
                    
                    }
                    else
                    {
                        DeliveryAddres = String.Empty;
                        total -= deliveryCost;
                        deliveryCost = 0;
                        SetCurrentTotal();
                        isToDeliver = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please select something to deliver first.\nOnly water is not deliverable.", "Required!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    isRepeat = true;
                    chkDilivery.Checked = false;
                    isRepeat = false;
                    
                }
            }

           
               

        }

        private void chkSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpecial.Checked == true)
            {
                grpSpecial.Visible = true;
                txtExtraDescription.Enabled = true;
            }
               
            else
            {
                grpSpecial.Visible = false;
                txtExtraAmount.Clear();
                txtExtraDescription.Clear();
                txtExtraQuantity.Clear();
                total -= specialCost;
                specialCost = 0;
               
                if (total - deliveryCost == 0)
                    chkDilivery.Checked = false;
                SetCurrentTotal();
            }
               
        }

        private void txtExtraDescription_TextChanged(object sender, EventArgs e)
        {
            if(!txtExtraDescription.Text.Equals(String.Empty))
                txtExtraAmount.Enabled = true;
            else
            {
                txtExtraAmount.Enabled = false;
                txtExtraQuantity.Enabled = false;
                txtExtraAmount.Clear();
                txtExtraQuantity.Clear();

            }
               
        }

        private void txtExtraAmount_TextChanged(object sender, EventArgs e)
        {
            if (!txtExtraAmount.Text.Equals(String.Empty))
            {

                try
                {
                    specialAmount = double.Parse(txtExtraAmount.Text);
                    txtExtraQuantity.Enabled = true;
                    if (!txtExtraAmount.Text.Equals(String.Empty) && !txtExtraQuantity.Text.Equals(String.Empty))
                        CalculateSpecialAmount();

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a numeric value.\n" + ex.Message, "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a valid value.\n" + ex.Message, "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }


               
            }
            else if (txtExtraAmount.Text.Equals(String.Empty) && txtExtraQuantity.Text.Equals(String.Empty))
                txtExtraQuantity.Enabled = false;
            else if (txtExtraAmount.Text.Equals(String.Empty))
            {
                txtExtraQuantity.Clear();
                txtExtraQuantity.Enabled = false;
            }


        }

        private void txtExtraQuantity_TextChanged(object sender, EventArgs e)
        {

            if (!txtExtraAmount.Text.Equals(String.Empty) && !txtExtraQuantity.Text.Equals(String.Empty))
                CalculateSpecialAmount();
            else if (txtExtraQuantity.Text.Equals(String.Empty))
            {
                total -= specialCost;
                SetCurrentTotal();
                specialCost = 0;

            }
          
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            if (total > 0)
            {
                if (chkSpecial.Checked == false || (chkSpecial.Checked == true && !txtExtraAmount.Text.Equals(String.Empty) && !txtExtraDescription.Text.Equals(String.Empty) && !txtExtraQuantity.Text.Equals(String.Empty)))
                {
                    if (isToDeliver)
                        CalculateDeliveryCharges();

                    AddDiscounts();// BEOFRE TAX

                    CalculateTax();

                    GetOrderedDetails();

                    frmBill myBill = new frmBill();


                    foreach (string TS in TraditionalSubsStore)
                    {

                        myBill.lstItems.Items.Add(TS);
                    }

                    foreach (string SS in SpecialSubsStore)
                    {

                        myBill.lstItems.Items.Add(SS);
                    }

                    foreach (string BS in BeveragesStore)
                    {

                        myBill.lstItems.Items.Add(BS);
                    }

                    foreach (string SL in SlidesStore)
                    {

                        myBill.lstItems.Items.Add(SL);
                    }

                    foreach (string AO in AddOnesStore)
                    {

                        myBill.lstItems.Items.Add(AO);
                    }




                    if (DeliveryAddres.Equals(String.Empty))
                        DeliveryAddres = "No";
                    myBill.lblDeliveryAddress.Text = DeliveryAddres;
                    myBill.lblDeliveryCharges.Text = deliveryCost.ToString("N") + "$";
                    myBill.lblDiscounts.Text = discounts.ToString("N") + "$";
                    myBill.lblSubTotal.Text = (total + discounts - tax - deliveryCost).ToString("N") + "$";
                    myBill.lblTax.Text = tax.ToString("N") + "$";
                    myBill.lblTotal.Text = total.ToString("N") + "$";
                    myBill.lblSpecialItem.Text = txtExtraDescription.Text;
                    myBill.lblSpecialPrice.Text = specialCost.ToString("N") + "$";
                    myBill.lblSpQuantity.Text = specialQuantity.ToString("N") + "$";
                    myBill.lblSPUnit.Text = specialAmount.ToString("N") + "$";
                    myBill.ShowDialog();


                    if (this.isRestart)
                        Application.Restart();
                    else
                        Application.Exit();


                }
                else
                {
                    MessageBox.Show("Please provide special requirement details.", "Required!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Please select something to order.\nOnly water is not deliverable.", "Required!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to reset ?", "Reset Cofirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Restart();
        }

        /// <summary>
        /// Method to apply tax
        /// </summary>
        private void CalculateTax()
        {
            tax = (total * 0.06);
            total = total + tax;  // 6% tax  // 6/100 = 0.06

        }

        /// <summary>
        /// Method to Apply Delivery Charges
        /// </summary>
        private void CalculateDeliveryCharges()
        {
            
            if (total > 0 && total <= 10)
            {
                deliveryCost = 3;
                total += deliveryCost;
            }
            else if (total > 0 && total <= 30)
            {
                deliveryCost = 2;
                total += deliveryCost;
            }
            SetCurrentTotal();
          

        }

        /// <summary>
        /// Method to Apply Discounts
        /// </summary>
        private void AddDiscounts()
        {
            if (CustomerType.Equals(radStudent.Text) || CustomerType.Equals(radStaff.Text) || CustomerType.Equals(radFaculty.Text))
            {
                discounts = (total * 0.1);
                total = total - discounts;  //10% discount
            }

        }

        /// <summary>
        /// Method to calculate the special requirements cost
        /// </summary>
        private void CalculateSpecialAmount()
        {

            if (!txtExtraAmount.Text.Equals(String.Empty) && !txtExtraDescription.Text.Equals(String.Empty) && !txtExtraQuantity.Text.Equals(String.Empty))
            {
                try
                {
                    specialAmount = double.Parse(txtExtraAmount.Text);

                    specialQuantity = int.Parse(txtExtraQuantity.Text);

                    total -= specialCost;

                    specialCost = specialAmount * specialQuantity;

                    total += specialCost;

                    SetCurrentTotal();

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a numeric value.\n" + ex.Message, "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    specialCost = 0;
                    total -= specialCost;
                    SetCurrentTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a valid value.\n" + ex.Message, "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    specialCost = 0;
                    total -= specialCost;
                    SetCurrentTotal();
                }
            }
            else
            {
                MessageBox.Show("Please provide Description  ,the Amount and the Quantity.", "Missing Input!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        /// <summary>
        /// To Get the curent total after every purchase of items
        /// </summary>
        private void SetCurrentTotal()
        {

            lblCurrentTot.Text = total.ToString("N") + "$";

        }

        /// <summary>
        /// 
        /// </summary>
        private void GetOrderedDetails()
        {

            if (chkTSHam.Checked)
            {
                if (numTSHamReg.Enabled)
                    if (numTSHamReg.Value !=0)
                         TraditionalSubsStore.Add(newSubsStore.TS1[0].Name + "\t\t" + newSubsStore.TS1[0].Regular.ToString() + "\t\t" + numTSHamReg.Value.ToString() + "\t\t"  + ((newSubsStore.TS1[0].Regular * (double)numTSHamReg.Value)).ToString());

                if (numTSHamLrg.Enabled)
                    if (numTSHamLrg.Value != 0)
                        TraditionalSubsStore.Add(newSubsStore.TS1[0].Name + "\t\t" + newSubsStore.TS1[0].Large.ToString() + "\t\t" + numTSHamLrg.Value.ToString() + "\t\t" + ((newSubsStore.TS1[0].Large * (double)numTSHamLrg.Value)).ToString());
            }


            if (chkTSItalian.Checked)
            {
                if (numTSItalianReg.Enabled)
                    if (numTSItalianReg.Value != 0)
                        TraditionalSubsStore.Add(newSubsStore.TS1[1].Name + "\t\t" + newSubsStore.TS1[1].Regular.ToString() + "\t\t" + numTSItalianReg.Value.ToString() + "\t\t" + ((newSubsStore.TS1[1].Regular * (double)numTSItalianReg.Value)).ToString());

                if (numTSItalianLrg.Enabled)
                    if (numTSItalianLrg.Value != 0)
                        TraditionalSubsStore.Add(newSubsStore.TS1[1].Name + "\t\t" + newSubsStore.TS1[1].Large.ToString() + "\t\t" + numTSItalianLrg.Value.ToString() + "\t\t" + ((newSubsStore.TS1[1].Large * (double)numTSItalianLrg.Value)).ToString());
            }


            if (chkTSAmerican.Checked)
            {
                if (numTSAmericanReg.Enabled)
                    if (numTSAmericanReg.Value != 0)
                        TraditionalSubsStore.Add(newSubsStore.TS1[2].Name + "\t\t" + newSubsStore.TS1[2].Regular.ToString() + "\t\t" + numTSAmericanReg.Value.ToString() + "\t\t" + ((newSubsStore.TS1[2].Regular * (double)numTSAmericanReg.Value)).ToString());

                if (numTSAmericanLrg.Enabled)
                    if (numTSAmericanLrg.Value != 0)
                        TraditionalSubsStore.Add(newSubsStore.TS1[2].Name + "\t\t" + newSubsStore.TS1[2].Large.ToString() + "\t\t" + numTSAmericanLrg.Value.ToString() + "\t\t" + ((newSubsStore.TS1[2].Large * (double)numTSAmericanLrg.Value)).ToString());
            }



            //

            if (chkBevWater.Checked)
            {
                if (numBevWaterReg.Enabled)
                    if (numBevWaterReg.Value != 0)
                        BeveragesStore.Add(newSubsStore.BS1[0].Name + "\t\t" + newSubsStore.BS1[0].Regular.ToString() + "\t\t" + numBevWaterReg.Value.ToString() + "\t\t" + ((newSubsStore.BS1[0].Regular * (double)numBevWaterReg.Value)).ToString());

                if (numBevWaterLrg.Enabled)
                    if (numBevWaterLrg.Value != 0)
                        BeveragesStore.Add(newSubsStore.BS1[0].Name + "\t\t" + newSubsStore.BS1[0].Large.ToString() + "\t\t" + numBevWaterLrg.Value.ToString() + "\t\t" + ((newSubsStore.BS1[0].Large * (double)numBevWaterLrg.Value)).ToString());
            }


            if (chkBevFountSoda.Checked)
            {
                if (numBevFounSodaReg.Enabled)
                    if (numBevFounSodaReg.Value != 0)
                        BeveragesStore.Add(newSubsStore.BS1[1].Name + "\t\t" + newSubsStore.BS1[1].Regular.ToString() + "\t\t" + numBevFounSodaReg.Value.ToString() + "\t\t" + ((newSubsStore.BS1[1].Regular * (double)numBevFounSodaReg.Value)).ToString());

                if (numBevFounSodaLrg.Enabled)
                    if (numBevFounSodaLrg.Value != 0)
                        BeveragesStore.Add(newSubsStore.BS1[1].Name + "\t\t" + newSubsStore.BS1[1].Large.ToString() + "\t\t" + numBevFounSodaLrg.Value.ToString() + "\t\t" + ((newSubsStore.BS1[1].Large * (double)numBevFounSodaLrg.Value)).ToString());
            }


            if (chkBevBotlSoda.Checked)
            {
                if (numBevBtlSodaReg.Enabled)
                    if (numBevBtlSodaReg.Value != 0)
                        BeveragesStore.Add(newSubsStore.BS1[2].Name + "\t\t" + newSubsStore.BS1[2].Regular.ToString() + "\t\t" + numBevBtlSodaReg.Value.ToString() + "\t\t" + ((newSubsStore.BS1[2].Regular * (double)numBevBtlSodaReg.Value)).ToString());

                if (numBevBtlSodaLrg.Enabled)
                    if (numBevBtlSodaLrg.Value != 0)
                        BeveragesStore.Add(newSubsStore.BS1[2].Name + "\t\t" + newSubsStore.BS1[2].Large.ToString() + "\t\t" + numBevBtlSodaLrg.Value.ToString() + "\t\t" + ((newSubsStore.BS1[2].Large * (double)numBevBtlSodaLrg.Value)).ToString());
            }


            if (chkBevFreshTead.Checked)
            {

                if (numBevFreshTeaLrg.Enabled)
                    if (numBevFreshTeaLrg.Value != 0)
                        BeveragesStore.Add(newSubsStore.BS1[3].Name + "\t\t" + newSubsStore.BS1[3].Large.ToString() + "\t\t" + numBevFreshTeaLrg.Value.ToString() + "\t\t" + ((newSubsStore.BS1[3].Large * (double)numBevFreshTeaLrg.Value)).ToString());
            }

            //

            if (chkSSChicken.Checked)
            {
                if (numSSChickenReg.Enabled)
                    if (numSSChickenReg.Value != 0)
                        SpecialSubsStore.Add(newSubsStore.SS1[0].Name + "\t\t" + newSubsStore.SS1[0].Regular.ToString() + "\t\t" + numSSChickenReg.Value.ToString() + "\t\t" + ((newSubsStore.SS1[0].Regular * (double)numSSChickenReg.Value)).ToString());

                if (numSSChickenLrg.Enabled)
                    if (numSSChickenLrg.Value != 0)
                        SpecialSubsStore.Add(newSubsStore.SS1[0].Name + "\t\t" + newSubsStore.SS1[0].Large.ToString() + "\t\t" + numSSChickenLrg.Value.ToString() + "\t\t" + ((newSubsStore.SS1[0].Large * (double)numSSChickenLrg.Value)).ToString());
            }


            if (chkSSWorks.Checked)
            {
                if (numSSWorksReg.Enabled)
                    if (numSSWorksReg.Value != 0)
                        SpecialSubsStore.Add(newSubsStore.SS1[1].Name + "\t\t" + newSubsStore.SS1[1].Regular.ToString() + "\t\t" + numSSWorksReg.Value.ToString() + "\t\t" + ((newSubsStore.SS1[1].Regular * (double)numSSWorksReg.Value)).ToString());

                if (numSSWorksLrg.Enabled)
                    if (numSSWorksLrg.Value != 0)
                        SpecialSubsStore.Add(newSubsStore.SS1[1].Name + "\t\t" + newSubsStore.SS1[1].Large.ToString() + "\t\t" + numSSWorksLrg.Value.ToString() + "\t\t" + ((newSubsStore.SS1[1].Large * (double)numSSWorksLrg.Value)).ToString());
            }


            if (chkSSVeg.Checked)
            {
                if (numSSVegReg.Enabled)
                    if (numSSVegReg.Value != 0)
                        SpecialSubsStore.Add(newSubsStore.SS1[2].Name + "\t\t" + newSubsStore.SS1[2].Regular.ToString() + "\t\t" + numSSVegReg.Value.ToString() + "\t\t" + ((newSubsStore.SS1[2].Regular * (double)numSSVegReg.Value)).ToString());

                if (numSSVegLrg.Enabled)
                    if (numSSVegLrg.Value != 0)
                        SpecialSubsStore.Add(newSubsStore.SS1[2].Name + "\t\t" + newSubsStore.SS1[2].Large.ToString() + "\t\t" + numSSVegLrg.Value.ToString() + "\t\t" + ((newSubsStore.SS1[2].Large * (double)numSSVegLrg.Value)).ToString());
            }


            //


            if (chkSLChips.Checked)
            {
                if (numSLChips.Value != 0)
                    SlidesStore.Add(newSubsStore.SL1[0].Name + "\t\t" + newSubsStore.SL1[0].Price.ToString() + "\t\t" + numSLChips.Value.ToString() + "\t\t" + ((newSubsStore.SL1[0].Price * (double)numSLChips.Value)).ToString());
            }


            if (chkSSWorks.Checked)
            {
                if (numSLCoikie.Value != 0)
                    SlidesStore.Add(newSubsStore.SL1[1].Name + "\t\t" + newSubsStore.SL1[1].Price.ToString() + "\t\t" + numSLCoikie.Value.ToString() + "\t\t" + ((newSubsStore.SL1[1].Price * (double)numSLCoikie.Value)).ToString());
            }


            if (chkSSVeg.Checked)
            {
                if (numSLCole.Value != 0)
                    SlidesStore.Add(newSubsStore.SL1[2].Name + "\t\t" + newSubsStore.SL1[2].Price.ToString() + "\t\t" + numSLCole.Value.ToString() + "\t\t" + ((newSubsStore.SL1[2].Price * (double)numSLCole.Value)).ToString());
            }


            if (chkSSVeg.Checked)
            {
                if (numSLPotato.Value != 0)
                    SlidesStore.Add(newSubsStore.SL1[3].Name + "\t\t" + newSubsStore.SL1[3].Price.ToString() + "\t\t" + numSLPotato.Value.ToString() + "\t\t" + ((newSubsStore.SL1[3].Price * (double)numSLPotato.Value)).ToString());

            }

            //


            if (chkAOPickels.Checked)
            {
                if (numAOPick.Value != 0)
                    SlidesStore.Add(newSubsStore.AO1[0].Name + "\t\t" + newSubsStore.AO1[0].Price.ToString() + "\t\t" + numAOPick.Value.ToString() + "\t\t" + ((newSubsStore.AO1[0].Price * (double)numAOPick.Value)).ToString());
            }


            if (chkAOTomato.Checked)
            {
                if (numAPTomato.Value != 0)
                    SlidesStore.Add(newSubsStore.AO1[1].Name + "\t\t" + newSubsStore.AO1[1].Price.ToString() + "\t\t" + numAPTomato.Value.ToString() + "\t\t" + ((newSubsStore.AO1[1].Price * (double)numAPTomato.Value)).ToString());

            }
        }

    }
} 
