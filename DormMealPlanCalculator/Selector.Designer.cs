namespace DormMealPlanCalculator
{
     partial class Selector
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.AllenHall_selectionOne = new System.Windows.Forms.RadioButton();
               this.PikeHall_selectionTwo = new System.Windows.Forms.RadioButton();
               this.FarthingHall_selectionThree = new System.Windows.Forms.RadioButton();
               this.UniversitySuites_selectionFour = new System.Windows.Forms.RadioButton();
               this.label1 = new System.Windows.Forms.Label();
               this.calculateTotalDescrip = new System.Windows.Forms.Label();
               this.calculateTotal = new System.Windows.Forms.Button();
               this.sevenMeal_600 = new System.Windows.Forms.RadioButton();
               this.label6 = new System.Windows.Forms.Label();
               this.fourteenMeal_1200 = new System.Windows.Forms.RadioButton();
               this.infiniteMeal_1700 = new System.Windows.Forms.RadioButton();
               this.dormPanel = new System.Windows.Forms.Panel();
               this.mealPanel = new System.Windows.Forms.Panel();
               this.dormPanel.SuspendLayout();
               this.mealPanel.SuspendLayout();
               this.SuspendLayout();
               // 
               // AllenHall_selectionOne
               // 
               this.AllenHall_selectionOne.AutoSize = true;
               this.AllenHall_selectionOne.Location = new System.Drawing.Point(6, 42);
               this.AllenHall_selectionOne.Name = "AllenHall_selectionOne";
               this.AllenHall_selectionOne.Size = new System.Drawing.Size(171, 17);
               this.AllenHall_selectionOne.TabIndex = 4;
               this.AllenHall_selectionOne.TabStop = true;
               this.AllenHall_selectionOne.Text = "Allen Hall: $1,500 per semester";
               this.AllenHall_selectionOne.UseVisualStyleBackColor = true;
               this.AllenHall_selectionOne.CheckedChanged += new System.EventHandler(this.AllenHall_selectionOne_CheckedChanged);
               // 
               // PikeHall_selectionTwo
               // 
               this.PikeHall_selectionTwo.AutoSize = true;
               this.PikeHall_selectionTwo.Location = new System.Drawing.Point(6, 91);
               this.PikeHall_selectionTwo.Name = "PikeHall_selectionTwo";
               this.PikeHall_selectionTwo.Size = new System.Drawing.Size(169, 17);
               this.PikeHall_selectionTwo.TabIndex = 5;
               this.PikeHall_selectionTwo.TabStop = true;
               this.PikeHall_selectionTwo.Text = "Pike Hall: $1,600 per semester";
               this.PikeHall_selectionTwo.UseVisualStyleBackColor = true;
               this.PikeHall_selectionTwo.CheckedChanged += new System.EventHandler(this.PikeHall_selectionTwo_CheckedChanged);
               // 
               // FarthingHall_selectionThree
               // 
               this.FarthingHall_selectionThree.AutoSize = true;
               this.FarthingHall_selectionThree.Location = new System.Drawing.Point(6, 137);
               this.FarthingHall_selectionThree.Name = "FarthingHall_selectionThree";
               this.FarthingHall_selectionThree.Size = new System.Drawing.Size(186, 17);
               this.FarthingHall_selectionThree.TabIndex = 6;
               this.FarthingHall_selectionThree.TabStop = true;
               this.FarthingHall_selectionThree.Text = "Farthing Hall: $1,800 per semester";
               this.FarthingHall_selectionThree.UseVisualStyleBackColor = true;
               this.FarthingHall_selectionThree.CheckedChanged += new System.EventHandler(this.FarthingHall_selectionThree_CheckedChanged);
               // 
               // UniversitySuites_selectionFour
               // 
               this.UniversitySuites_selectionFour.AutoSize = true;
               this.UniversitySuites_selectionFour.Location = new System.Drawing.Point(6, 181);
               this.UniversitySuites_selectionFour.Name = "UniversitySuites_selectionFour";
               this.UniversitySuites_selectionFour.Size = new System.Drawing.Size(205, 17);
               this.UniversitySuites_selectionFour.TabIndex = 7;
               this.UniversitySuites_selectionFour.TabStop = true;
               this.UniversitySuites_selectionFour.Text = "University Suites: $2,500 per semester";
               this.UniversitySuites_selectionFour.UseVisualStyleBackColor = true;
               this.UniversitySuites_selectionFour.CheckedChanged += new System.EventHandler(this.UniversitySuites_selectionFour_CheckedChanged);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(3, 10);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(217, 13);
               this.label1.TabIndex = 8;
               this.label1.Text = "Please select the dorm you will be staying at:";
               // 
               // calculateTotalDescrip
               // 
               this.calculateTotalDescrip.AutoSize = true;
               this.calculateTotalDescrip.Location = new System.Drawing.Point(83, 240);
               this.calculateTotalDescrip.Name = "calculateTotalDescrip";
               this.calculateTotalDescrip.Size = new System.Drawing.Size(321, 13);
               this.calculateTotalDescrip.TabIndex = 13;
               this.calculateTotalDescrip.Text = "Once you are ready for the damage please press the button below.";
               this.calculateTotalDescrip.Click += new System.EventHandler(this.calculateTotalDescrip_Click);
               // 
               // calculateTotal
               // 
               this.calculateTotal.Location = new System.Drawing.Point(148, 271);
               this.calculateTotal.Name = "calculateTotal";
               this.calculateTotal.Size = new System.Drawing.Size(162, 23);
               this.calculateTotal.TabIndex = 14;
               this.calculateTotal.Text = "Calculate Homelessness";
               this.calculateTotal.UseVisualStyleBackColor = true;
               this.calculateTotal.Click += new System.EventHandler(this.calculateTotal_Click);
               // 
               // sevenMeal_600
               // 
               this.sevenMeal_600.AutoSize = true;
               this.sevenMeal_600.Location = new System.Drawing.Point(15, 42);
               this.sevenMeal_600.Name = "sevenMeal_600";
               this.sevenMeal_600.Size = new System.Drawing.Size(201, 17);
               this.sevenMeal_600.TabIndex = 10;
               this.sevenMeal_600.TabStop = true;
               this.sevenMeal_600.Text = "7 meals per week: $600 per semester";
               this.sevenMeal_600.UseVisualStyleBackColor = true;
               this.sevenMeal_600.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Location = new System.Drawing.Point(12, 10);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(144, 13);
               this.label6.TabIndex = 9;
               this.label6.Text = "Please select your meal plan:";
               // 
               // fourteenMeal_1200
               // 
               this.fourteenMeal_1200.AutoSize = true;
               this.fourteenMeal_1200.Location = new System.Drawing.Point(15, 91);
               this.fourteenMeal_1200.Name = "fourteenMeal_1200";
               this.fourteenMeal_1200.Size = new System.Drawing.Size(216, 17);
               this.fourteenMeal_1200.TabIndex = 11;
               this.fourteenMeal_1200.TabStop = true;
               this.fourteenMeal_1200.Text = "14 meals per week: $1,200 per semester";
               this.fourteenMeal_1200.UseVisualStyleBackColor = true;
               this.fourteenMeal_1200.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
               // 
               // infiniteMeal_1700
               // 
               this.infiniteMeal_1700.AutoSize = true;
               this.infiniteMeal_1700.Location = new System.Drawing.Point(15, 137);
               this.infiniteMeal_1700.Name = "infiniteMeal_1700";
               this.infiniteMeal_1700.Size = new System.Drawing.Size(200, 17);
               this.infiniteMeal_1700.TabIndex = 12;
               this.infiniteMeal_1700.TabStop = true;
               this.infiniteMeal_1700.Text = "Unlimited meals: $1,700 per semester";
               this.infiniteMeal_1700.UseVisualStyleBackColor = true;
               this.infiniteMeal_1700.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
               // 
               // dormPanel
               // 
               this.dormPanel.Controls.Add(this.AllenHall_selectionOne);
               this.dormPanel.Controls.Add(this.label1);
               this.dormPanel.Controls.Add(this.PikeHall_selectionTwo);
               this.dormPanel.Controls.Add(this.UniversitySuites_selectionFour);
               this.dormPanel.Controls.Add(this.FarthingHall_selectionThree);
               this.dormPanel.Location = new System.Drawing.Point(11, 12);
               this.dormPanel.Name = "dormPanel";
               this.dormPanel.Size = new System.Drawing.Size(230, 208);
               this.dormPanel.TabIndex = 16;
               this.dormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dormPanel_Paint);
               // 
               // mealPanel
               // 
               this.mealPanel.Controls.Add(this.label6);
               this.mealPanel.Controls.Add(this.sevenMeal_600);
               this.mealPanel.Controls.Add(this.infiniteMeal_1700);
               this.mealPanel.Controls.Add(this.fourteenMeal_1200);
               this.mealPanel.Location = new System.Drawing.Point(247, 12);
               this.mealPanel.Name = "mealPanel";
               this.mealPanel.Size = new System.Drawing.Size(236, 208);
               this.mealPanel.TabIndex = 17;
               this.mealPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mealPanel_Paint);
               // 
               // Selector
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(495, 329);
               this.Controls.Add(this.mealPanel);
               this.Controls.Add(this.dormPanel);
               this.Controls.Add(this.calculateTotal);
               this.Controls.Add(this.calculateTotalDescrip);
               this.Name = "Selector";
               this.Text = "Dorm and Meal Plan Selector";
               this.dormPanel.ResumeLayout(false);
               this.dormPanel.PerformLayout();
               this.mealPanel.ResumeLayout(false);
               this.mealPanel.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.RadioButton AllenHall_selectionOne;
          private System.Windows.Forms.RadioButton PikeHall_selectionTwo;
          private System.Windows.Forms.RadioButton FarthingHall_selectionThree;
          private System.Windows.Forms.RadioButton UniversitySuites_selectionFour;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label calculateTotalDescrip;
          private System.Windows.Forms.Button calculateTotal;
          private System.Windows.Forms.RadioButton sevenMeal_600;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.RadioButton fourteenMeal_1200;
          private System.Windows.Forms.RadioButton infiniteMeal_1700;
          private System.Windows.Forms.Panel dormPanel;
          private System.Windows.Forms.Panel mealPanel;
     }
}

