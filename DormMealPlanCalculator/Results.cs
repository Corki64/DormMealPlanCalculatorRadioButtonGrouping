using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * This program is designed to use radio buttons to calculate total
 * dorm and meal plan expenses for a user.
 *
 * This is the result pop-up window form.
 *
 * @author Luis Cortez (lac0084@auburn.edu)
 * @version 0406191347
 */
namespace DormMealPlanCalculator
{
     public partial class Results : Form
     {

          public Results(int totalCost)
          {
               this.TotalCost = totalCost;
               InitializeComponent();

               totalOutput.Text = totalCost.ToString("C");

          }

          public int TotalCost { get; set; }


          private void Results_Load(object sender, EventArgs e)
          {

          }

          private void exitButton_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void totalOutput_Click(object sender, EventArgs e)
          {

          }
     }
}
