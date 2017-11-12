namespace Dorm_and_Meal_Plan_Calculator
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnUnivSuites = new System.Windows.Forms.RadioButton();
            this.rbtnFarthingHall = new System.Windows.Forms.RadioButton();
            this.rbtnPikeHall = new System.Windows.Forms.RadioButton();
            this.rbtnAllenHall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnUnlimited = new System.Windows.Forms.RadioButton();
            this.rbtn14Meals = new System.Windows.Forms.RadioButton();
            this.rbtn7Meals = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnUnivSuites);
            this.groupBox1.Controls.Add(this.rbtnFarthingHall);
            this.groupBox1.Controls.Add(this.rbtnPikeHall);
            this.groupBox1.Controls.Add(this.rbtnAllenHall);
            this.groupBox1.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(35, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Dormitory";
            // 
            // rbtnUnivSuites
            // 
            this.rbtnUnivSuites.AllowDrop = true;
            this.rbtnUnivSuites.AutoSize = true;
            this.rbtnUnivSuites.Location = new System.Drawing.Point(6, 87);
            this.rbtnUnivSuites.Name = "rbtnUnivSuites";
            this.rbtnUnivSuites.Size = new System.Drawing.Size(203, 16);
            this.rbtnUnivSuites.TabIndex = 0;
            this.rbtnUnivSuites.Text = "University Suites   $2,500 per semester";
            this.rbtnUnivSuites.UseVisualStyleBackColor = true;
            // 
            // rbtnFarthingHall
            // 
            this.rbtnFarthingHall.AllowDrop = true;
            this.rbtnFarthingHall.AutoSize = true;
            this.rbtnFarthingHall.Location = new System.Drawing.Point(6, 66);
            this.rbtnFarthingHall.Name = "rbtnFarthingHall";
            this.rbtnFarthingHall.Size = new System.Drawing.Size(204, 16);
            this.rbtnFarthingHall.TabIndex = 0;
            this.rbtnFarthingHall.Text = "Farthing Hall         $1,800 per semester";
            this.rbtnFarthingHall.UseVisualStyleBackColor = true;
            // 
            // rbtnPikeHall
            // 
            this.rbtnPikeHall.AllowDrop = true;
            this.rbtnPikeHall.AutoSize = true;
            this.rbtnPikeHall.Location = new System.Drawing.Point(6, 44);
            this.rbtnPikeHall.Name = "rbtnPikeHall";
            this.rbtnPikeHall.Size = new System.Drawing.Size(203, 16);
            this.rbtnPikeHall.TabIndex = 0;
            this.rbtnPikeHall.Text = "Pike Hall               $1,600 per semester";
            this.rbtnPikeHall.UseVisualStyleBackColor = true;
            // 
            // rbtnAllenHall
            // 
            this.rbtnAllenHall.AllowDrop = true;
            this.rbtnAllenHall.AutoSize = true;
            this.rbtnAllenHall.Location = new System.Drawing.Point(7, 22);
            this.rbtnAllenHall.Name = "rbtnAllenHall";
            this.rbtnAllenHall.Size = new System.Drawing.Size(202, 16);
            this.rbtnAllenHall.TabIndex = 0;
            this.rbtnAllenHall.Text = "Allen Hall             $1,500 per semester\r\n";
            this.rbtnAllenHall.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnUnlimited);
            this.groupBox2.Controls.Add(this.rbtn14Meals);
            this.groupBox2.Controls.Add(this.rbtn7Meals);
            this.groupBox2.Location = new System.Drawing.Point(35, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Meal Plan";
            // 
            // rbtnUnlimited
            // 
            this.rbtnUnlimited.AllowDrop = true;
            this.rbtnUnlimited.AutoSize = true;
            this.rbtnUnlimited.Location = new System.Drawing.Point(7, 66);
            this.rbtnUnlimited.Name = "rbtnUnlimited";
            this.rbtnUnlimited.Size = new System.Drawing.Size(221, 16);
            this.rbtnUnlimited.TabIndex = 0;
            this.rbtnUnlimited.Text = "Unlimited meals          $1,700 per semester";
            this.rbtnUnlimited.UseVisualStyleBackColor = true;
            // 
            // rbtn14Meals
            // 
            this.rbtn14Meals.AllowDrop = true;
            this.rbtn14Meals.AutoSize = true;
            this.rbtn14Meals.Location = new System.Drawing.Point(7, 44);
            this.rbtn14Meals.Name = "rbtn14Meals";
            this.rbtn14Meals.Size = new System.Drawing.Size(220, 16);
            this.rbtn14Meals.TabIndex = 0;
            this.rbtn14Meals.Text = "14 meals per week      $1,200 per semester";
            this.rbtn14Meals.UseVisualStyleBackColor = true;
            // 
            // rbtn7Meals
            // 
            this.rbtn7Meals.AllowDrop = true;
            this.rbtn7Meals.AutoSize = true;
            this.rbtn7Meals.Location = new System.Drawing.Point(7, 22);
            this.rbtn7Meals.Name = "rbtn7Meals";
            this.rbtn7Meals.Size = new System.Drawing.Size(214, 16);
            this.rbtn7Meals.TabIndex = 0;
            this.rbtn7Meals.Text = "7 meals per week        $ 600 per semester";
            this.rbtn7Meals.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Your Dormitory and Meal Plan";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(125, 299);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Dorm & Meal Plan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnUnivSuites;
        private System.Windows.Forms.RadioButton rbtnFarthingHall;
        private System.Windows.Forms.RadioButton rbtnPikeHall;
        private System.Windows.Forms.RadioButton rbtnAllenHall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnUnlimited;
        private System.Windows.Forms.RadioButton rbtn14Meals;
        private System.Windows.Forms.RadioButton rbtn7Meals;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
    }
}

