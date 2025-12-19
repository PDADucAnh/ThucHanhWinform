namespace Example_01
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo các Control theo Slide 77 và Slide 76
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button btDot;
        private System.Windows.Forms.Button btEquals;

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
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisplay.Location = new System.Drawing.Point(30, 20);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(260, 38);
            this.tbDisplay.TabIndex = 0;
            this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right; // Căn phải giống máy tính thật
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(30, 80);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(60, 60);
            this.bt0.TabIndex = 1;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click); // Slide 77
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(96, 80);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(60, 60);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click); // Slide 77
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(162, 80);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(60, 60);
            this.bt2.TabIndex = 3;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click); // Slide 77
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(228, 80);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(60, 60);
            this.bt3.TabIndex = 4;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(30, 146);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(60, 60);
            this.btPlus.TabIndex = 5;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click); // Slide 77
            // 
            // btMul
            // 
            this.btMul.Location = new System.Drawing.Point(96, 146);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(60, 60);
            this.btMul.TabIndex = 6;
            this.btMul.Text = "*";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.btMul_Click); // Slide 77
            // 
            // btDot
            // 
            this.btDot.Location = new System.Drawing.Point(162, 146);
            this.btDot.Name = "btDot";
            this.btDot.Size = new System.Drawing.Size(60, 60);
            this.btDot.TabIndex = 7;
            this.btDot.Text = ".";
            this.btDot.UseVisualStyleBackColor = true;
            this.btDot.Click += new System.EventHandler(this.btDot_Click);
            // 
            // btEquals
            // 
            this.btEquals.Location = new System.Drawing.Point(228, 146);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(60, 60);
            this.btEquals.TabIndex = 8;
            this.btEquals.Text = "=";
            this.btEquals.UseVisualStyleBackColor = true;
            this.btEquals.Click += new System.EventHandler(this.btEquals_Click); // Slide 77
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 230);
            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.btDot);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.tbDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator"; // Slide 76
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}