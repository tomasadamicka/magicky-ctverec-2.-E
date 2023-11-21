namespace magicky_ctverec
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.t1 = new System.Windows.Forms.Button();
            this.t3 = new System.Windows.Forms.Button();
            this.t2 = new System.Windows.Forms.Button();
            this.t6 = new System.Windows.Forms.Button();
            this.t5 = new System.Windows.Forms.Button();
            this.t4 = new System.Windows.Forms.Button();
            this.t9 = new System.Windows.Forms.Button();
            this.t8 = new System.Windows.Forms.Button();
            this.t7 = new System.Windows.Forms.Button();
            this.k = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(178, 117);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(75, 75);
            this.t1.TabIndex = 0;
            this.t1.UseVisualStyleBackColor = true;
            this.t1.Click += new System.EventHandler(this.t1_Click);
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(340, 117);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(75, 75);
            this.t3.TabIndex = 1;
            this.t3.UseVisualStyleBackColor = true;
            this.t3.Click += new System.EventHandler(this.t3_Click);
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(259, 117);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(75, 75);
            this.t2.TabIndex = 2;
            this.t2.UseVisualStyleBackColor = true;
            this.t2.Click += new System.EventHandler(this.button2_Click);
            // 
            // t6
            // 
            this.t6.Location = new System.Drawing.Point(340, 193);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(75, 75);
            this.t6.TabIndex = 3;
            this.t6.UseVisualStyleBackColor = true;
            this.t6.Click += new System.EventHandler(this.t6_Click);
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(259, 193);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(75, 75);
            this.t5.TabIndex = 4;
            this.t5.UseVisualStyleBackColor = true;
            this.t5.Click += new System.EventHandler(this.t5_Click);
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(178, 193);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(75, 75);
            this.t4.TabIndex = 5;
            this.t4.UseVisualStyleBackColor = true;
            this.t4.Click += new System.EventHandler(this.t4_Click);
            // 
            // t9
            // 
            this.t9.Location = new System.Drawing.Point(340, 269);
            this.t9.Name = "t9";
            this.t9.Size = new System.Drawing.Size(75, 75);
            this.t9.TabIndex = 6;
            this.t9.UseVisualStyleBackColor = true;
            this.t9.Click += new System.EventHandler(this.t9_Click);
            // 
            // t8
            // 
            this.t8.Location = new System.Drawing.Point(259, 269);
            this.t8.Name = "t8";
            this.t8.Size = new System.Drawing.Size(75, 75);
            this.t8.TabIndex = 7;
            this.t8.UseVisualStyleBackColor = true;
            this.t8.Click += new System.EventHandler(this.t8_Click);
            // 
            // t7
            // 
            this.t7.Location = new System.Drawing.Point(178, 269);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(75, 75);
            this.t7.TabIndex = 8;
            this.t7.UseVisualStyleBackColor = true;
            this.t7.Click += new System.EventHandler(this.t7_Click);
            // 
            // k
            // 
            this.k.BackColor = System.Drawing.Color.IndianRed;
            this.k.Font = new System.Drawing.Font("Segoe Script", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.k.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.k.Location = new System.Drawing.Point(489, 162);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(256, 66);
            this.k.TabIndex = 9;
            this.k.Text = "KONTROLA";
            this.k.UseVisualStyleBackColor = false;
            this.k.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Showcard Gothic", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb1.Location = new System.Drawing.Point(434, 300);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(354, 48);
            this.tb1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.k);
            this.Controls.Add(this.t7);
            this.Controls.Add(this.t8);
            this.Controls.Add(this.t9);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button t1;
        private Button t3;
        private Button t2;
        private Button t6;
        private Button t5;
        private Button t4;
        private Button t9;
        private Button t8;
        private Button t7;
        private Button k;
        private TextBox tb1;
    }
}