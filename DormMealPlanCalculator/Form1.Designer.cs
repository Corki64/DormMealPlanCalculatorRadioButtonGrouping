namespace DormMealPlanCalculator
{
     partial class Form1
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
               this.label2 = new System.Windows.Forms.Label();
               this.radioButton6 = new System.Windows.Forms.RadioButton();
               this.radioButton7 = new System.Windows.Forms.RadioButton();
               this.radioButton8 = new System.Windows.Forms.RadioButton();
               this.SuspendLayout();
               // 
               // AllenHall_selectionOne
               // 
               this.AllenHall_selectionOne.AutoSize = true;
               this.AllenHall_selectionOne.Location = new System.Drawing.Point(35, 69);
               this.AllenHall_selectionOne.Name = "AllenHall_selectionOne";
               this.AllenHall_selectionOne.Size = new System.Drawing.Size(171, 17);
               this.AllenHall_selectionOne.TabIndex = 4;
               this.AllenHall_selectionOne.TabStop = true;
               this.AllenHall_selectionOne.Text = "Allen Hall: $1,500 per semester";
               this.AllenHall_selectionOne.UseVisualStyleBackColor = true;
               // 
               // PikeHall_selectionTwo
               // 
               this.PikeHall_selectionTwo.AutoSize = true;
               this.PikeHall_selectionTwo.Location = new System.Drawing.Point(35, 118);
               this.PikeHall_selectionTwo.Name = "PikeHall_selectionTwo";
               this.PikeHall_selectionTwo.Size = new System.Drawing.Size(169, 17);
               this.PikeHall_selectionTwo.TabIndex = 5;
               this.PikeHall_selectionTwo.TabStop = true;
               this.PikeHall_selectionTwo.Text = "Pike Hall: $1,600 per semester";
               this.PikeHall_selectionTwo.UseVisualStyleBackColor = true;
               // 
               // FarthingHall_selectionThree
               // 
               this.FarthingHall_selectionThree.AutoSize = true;
               this.FarthingHall_selectionThree.Location = new System.Drawing.Point(35, 164);
               this.FarthingHall_selectionThree.Name = "FarthingHall_selectionThree";
               this.FarthingHall_selectionThree.Size = new System.Drawing.Size(186, 17);
               this.FarthingHall_selectionThree.TabIndex = 6;
               this.FarthingHall_selectionThree.TabStop = true;
               this.FarthingHall_selectionThree.Text = "Farthing Hall: $1,800 per semester";
               this.FarthingHall_selectionThree.UseVisualStyleBackColor = true;
               // 
               // UniversitySuites_selectionFour
               // 
               this.UniversitySuites_selectionFour.AutoSize = true;
               this.UniversitySuites_selectionFour.Location = new System.Drawing.Point(35, 208);
               this.UniversitySuites_selectionFour.Name = "UniversitySuites_selectionFour";
               this.UniversitySuites_selectionFour.Size = new System.Drawing.Size(205, 17);
               this.UniversitySuites_selectionFour.TabIndex = 7;
               this.UniversitySuites_selectionFour.TabStop = true;
               this.UniversitySuites_selectionFour.Text = "University Suites: $2,500 per semester";
               this.UniversitySuites_selectionFour.UseVisualStyleBackColor = true;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(32, 37);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(217, 13);
               this.label1.TabIndex = 8;
               this.label1.Text = "Please select the dorm you will be staying at:";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(373, 37);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(144, 13);
               this.label2.TabIndex = 9;
               this.label2.Text = "Please select your meal plan:";
               // 
               // radioButton6
               // 
               this.radioButton6.AutoSize = true;
               this.radioButton6.Location = new System.Drawing.Point(376, 164);
               this.radioButton6.Name = "radioButton6";
               this.radioButton6.Size = new System.Drawing.Size(200, 17);
               this.radioButton6.TabIndex = 12;
               this.radioButton6.TabStop = true;
               this.radioButton6.Text = "Unlimited meals: $1,700 per semester";
               this.radioButton6.UseVisualStyleBackColor = true;
               // 
               // radioButton7
               // 
               this.radioButton7.AutoSize = true;
               this.radioButton7.Location = new System.Drawing.Point(376, 118);
               this.radioButton7.Name = "radioButton7";
               this.radioButton7.Size = new System.Drawing.Size(216, 17);
               this.radioButton7.TabIndex = 11;
               this.radioButton7.TabStop = true;
               this.radioButton7.Text = "14 meals per week: $1,200 per semester";
               this.radioButton7.UseVisualStyleBackColor = true;
               // 
               // radioButton8
               // 
               this.radioButton8.AutoSize = true;
               this.radioButton8.Location = new System.Drawing.Point(376, 69);
               this.radioButton8.Name = "radioButton8";
               this.radioButton8.Size = new System.Drawing.Size(201, 17);
               this.radioButton8.TabIndex = 10;
               this.radioButton8.TabStop = true;
               this.radioButton8.Text = "7 meals per week: $600 per semester";
               this.radioButton8.UseVisualStyleBackColor = true;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(847, 367);
               this.Controls.Add(this.radioButton6);
               this.Controls.Add(this.radioButton7);
               this.Controls.Add(this.radioButton8);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.UniversitySuites_selectionFour);
               this.Controls.Add(this.FarthingHall_selectionThree);
               this.Controls.Add(this.PikeHall_selectionTwo);
               this.Controls.Add(this.AllenHall_selectionOne);
               this.Name = "Form1";
               this.Text = "Dorm and Meal Plan Selector";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.RadioButton AllenHall_selectionOne;
          private System.Windows.Forms.RadioButton PikeHall_selectionTwo;
          private System.Windows.Forms.RadioButton FarthingHall_selectionThree;
          private System.Windows.Forms.RadioButton UniversitySuites_selectionFour;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.RadioButton radioButton6;
          private System.Windows.Forms.RadioButton radioButton7;
          private System.Windows.Forms.RadioButton radioButton8;
     }
}

