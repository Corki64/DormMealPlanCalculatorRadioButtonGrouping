namespace DormMealPlanCalculator
{
     partial class Results
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
               this.totalOutput = new System.Windows.Forms.Label();
               this.totalCostDescrip = new System.Windows.Forms.Label();
               this.exitButton = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // totalOutput
               // 
               this.totalOutput.AutoSize = true;
               this.totalOutput.Location = new System.Drawing.Point(168, 43);
               this.totalOutput.Name = "totalOutput";
               this.totalOutput.Size = new System.Drawing.Size(114, 13);
               this.totalOutput.TabIndex = 1;
               this.totalOutput.Text = "Total Cost will go here.";
               this.totalOutput.Click += new System.EventHandler(this.totalOutput_Click);
               // 
               // totalCostDescrip
               // 
               this.totalCostDescrip.AutoSize = true;
               this.totalCostDescrip.Location = new System.Drawing.Point(12, 43);
               this.totalCostDescrip.Name = "totalCostDescrip";
               this.totalCostDescrip.Size = new System.Drawing.Size(150, 13);
               this.totalCostDescrip.TabIndex = 2;
               this.totalCostDescrip.Text = "Total Dorm and Meal fees are:";
               // 
               // exitButton
               // 
               this.exitButton.Location = new System.Drawing.Point(107, 89);
               this.exitButton.Name = "exitButton";
               this.exitButton.Size = new System.Drawing.Size(75, 23);
               this.exitButton.TabIndex = 3;
               this.exitButton.Text = "Exit";
               this.exitButton.UseVisualStyleBackColor = true;
               this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
               // 
               // Results
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(299, 145);
               this.Controls.Add(this.exitButton);
               this.Controls.Add(this.totalCostDescrip);
               this.Controls.Add(this.totalOutput);
               this.Name = "Results";
               this.Text = "Total Meal and Dorm Cost";
               this.Load += new System.EventHandler(this.Results_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.Label totalOutput;
          private System.Windows.Forms.Label totalCostDescrip;
          private System.Windows.Forms.Button exitButton;
     }
}