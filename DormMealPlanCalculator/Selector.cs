using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormMealPlanCalculator
{
     public partial class Selector : Form
     {
          // Arrays containing all values in order of appearance.
          private int[] dormPrices = {1500, 1600, 1800, 2500};
          private int[] mealPrices = {600, 1200, 1700};
          
          // Int declaring index selected in panel boxes.
          private int dormSelection = 0;
          private int mealSelection = 0;

          public Selector()
          {
               InitializeComponent();
          }

          private void calculateTotalDescrip_Click(object sender, EventArgs e)
          {

          }

          private void AnyDormButton_CheckedChanged(object sender, EventArgs e)
          {
               if (((RadioButton)sender).Checked)
               {
                    RadioButton dormRadioButton = (RadioButton) sender;

                    // Button test - commented out
                    //MessageBox.Show("You selected: " + dormRadioButton.Text);
               }
          }

          private void AnyMealButton_CheckedChanged(object sender, EventArgs e)
          {
               if (((RadioButton)sender).Checked)
               {
                    RadioButton mealRadioButton = (RadioButton)sender;

                    // Button test - commented out
                    //MessageBox.Show("You selected: " + mealRadioButton.Text);
               }
          }

          private void AllenHall_selectionOne_CheckedChanged(object sender, EventArgs e)
          {
               dormSelection = dormPrices[0];
               AnyDormButton_CheckedChanged(sender, e);
          }

          private void PikeHall_selectionTwo_CheckedChanged(object sender, EventArgs e)
          {
               dormSelection = dormPrices[1];
               AnyDormButton_CheckedChanged(sender, e);
          }

          private void FarthingHall_selectionThree_CheckedChanged(object sender, EventArgs e)
          {
               dormSelection = dormPrices[2];
               AnyDormButton_CheckedChanged(sender, e);
          }

          private void UniversitySuites_selectionFour_CheckedChanged(object sender, EventArgs e)
          {
               dormSelection = dormPrices[3];
               AnyDormButton_CheckedChanged(sender, e);
          }

          private void radioButton11_CheckedChanged(object sender, EventArgs e)
          {
               mealSelection = mealPrices[0];
               AnyMealButton_CheckedChanged(sender, e);
          }

          private void radioButton12_CheckedChanged(object sender, EventArgs e)
          {
               mealSelection = mealPrices[1];
               AnyMealButton_CheckedChanged(sender, e);
          }

          private void radioButton13_CheckedChanged(object sender, EventArgs e)
          {
               mealSelection = mealPrices[2];
               AnyMealButton_CheckedChanged(sender, e);
          }

          private void calculateTotal_Click(object sender, EventArgs e)
          {

               var totalCost = dormSelection + mealSelection;

               Results resultShow = new Results(totalCost);
               resultShow.Show();
          }
     }
}
