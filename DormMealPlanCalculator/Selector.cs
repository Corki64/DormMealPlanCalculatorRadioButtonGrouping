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
          public Selector()
          {
               InitializeComponent();
          }

          private void label1_Click(object sender, EventArgs e)
          {

          }

          private void label2_Click(object sender, EventArgs e)
          {

          }

          private void label4_Click(object sender, EventArgs e)
          {

          }

          private void dormPanel_Paint(object sender, PaintEventArgs e)
          {

          }

          private void mealPanel_Paint(object sender, PaintEventArgs e)
          {

          }

          private void calculateTotalDescrip_Click(object sender, EventArgs e)
          {

          }

          private void AnyDormButton_CheckedChanged(object sender, EventArgs e)
          {
               if (((RadioButton)sender).Checked)
               {
                    RadioButton dormRadioButton = (RadioButton) sender;
                    MessageBox.Show("You selected: " + dormRadioButton.Text);
               }
          }

          private void AnyMealButton_CheckedChanged(object sender, EventArgs e)
          {
               if (((RadioButton)sender).Checked)
               {
                    RadioButton mealRadioButton = (RadioButton)sender;
                    MessageBox.Show("You selected: " + mealRadioButton.Text);
               }
          }

          private void AllenHall_selectionOne_CheckedChanged(object sender, EventArgs e)
          {
               AnyDormButton_CheckedChanged(sender, e);
          }

          private void PikeHall_selectionTwo_CheckedChanged(object sender, EventArgs e)
          {
               AnyDormButton_CheckedChanged(sender, e);
          }

          private void FarthingHall_selectionThree_CheckedChanged(object sender, EventArgs e)
          {
               AnyDormButton_CheckedChanged(sender, e);
          }

          private void UniversitySuites_selectionFour_CheckedChanged(object sender, EventArgs e)
          {
               AnyDormButton_CheckedChanged(sender, e);
          }

          private void radioButton11_CheckedChanged(object sender, EventArgs e)
          {
               AnyMealButton_CheckedChanged(sender, e);
          }

          private void radioButton12_CheckedChanged(object sender, EventArgs e)
          {
               AnyMealButton_CheckedChanged(sender, e);
          }

          private void radioButton13_CheckedChanged(object sender, EventArgs e)
          {
               AnyMealButton_CheckedChanged(sender, e);
          }
     }
}
