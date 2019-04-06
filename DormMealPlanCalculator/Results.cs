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
     public partial class Results : Form
     {

          public Results(int totalCost)
          {
               this.TotalCost = totalCost;
               InitializeComponent();

          }

          public int TotalCost { get; set; }


          private void Results_Load(object sender, EventArgs e)
          {

          }

          private void exitButton_Click(object sender, EventArgs e)
          {
               this.Close();
          }
     }
}
