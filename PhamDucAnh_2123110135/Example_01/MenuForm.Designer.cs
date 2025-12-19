namespace Example_01
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnExample01 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnExample05 = new Button();
            btnExample06 = new Button();
            btnExample07 = new Button();
            btnExample08 = new Button();
            btnExample09 = new Button();
            btnExample10 = new Button();
            button1 = new Button();
            btnExample11 = new Button();
            btnExample12 = new Button();
            btnExample13 = new Button();
            SuspendLayout();
            // 
            // btnExample01
            // 
            btnExample01.BackColor = SystemColors.Info;
            btnExample01.Location = new Point(41, 25);
            btnExample01.Name = "btnExample01";
            btnExample01.Size = new Size(158, 100);
            btnExample01.TabIndex = 0;
            btnExample01.Text = "Example01";
            btnExample01.UseVisualStyleBackColor = false;
            btnExample01.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Location = new Point(310, 28);
            button2.Name = "button2";
            button2.Size = new Size(168, 97);
            button2.TabIndex = 1;
            button2.Text = "Example02";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Location = new Point(572, 28);
            button3.Name = "button3";
            button3.Size = new Size(158, 100);
            button3.TabIndex = 2;
            button3.Text = "Example03";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click_1;
            // 
            // btnExample05
            // 
            btnExample05.BackColor = SystemColors.Info;
            btnExample05.Location = new Point(41, 165);
            btnExample05.Name = "btnExample05";
            btnExample05.Size = new Size(158, 100);
            btnExample05.TabIndex = 3;
            btnExample05.Text = "Example05";
            btnExample05.UseVisualStyleBackColor = false;
            btnExample05.Click += btnExample05_Click;
            // 
            // btnExample06
            // 
            btnExample06.BackColor = SystemColors.Info;
            btnExample06.Location = new Point(310, 165);
            btnExample06.Name = "btnExample06";
            btnExample06.Size = new Size(158, 100);
            btnExample06.TabIndex = 4;
            btnExample06.Text = "Example06";
            btnExample06.UseVisualStyleBackColor = false;
            btnExample06.Click += btnExample06_Click;
            // 
            // btnExample07
            // 
            btnExample07.BackColor = SystemColors.Info;
            btnExample07.Location = new Point(572, 165);
            btnExample07.Name = "btnExample07";
            btnExample07.Size = new Size(158, 100);
            btnExample07.TabIndex = 5;
            btnExample07.Text = "Example07";
            btnExample07.UseVisualStyleBackColor = false;
            btnExample07.Click += btnExample07_Click;
            // 
            // btnExample08
            // 
            btnExample08.BackColor = SystemColors.Info;
            btnExample08.Location = new Point(41, 304);
            btnExample08.Name = "btnExample08";
            btnExample08.Size = new Size(158, 100);
            btnExample08.TabIndex = 6;
            btnExample08.Text = "Example08";
            btnExample08.UseVisualStyleBackColor = false;
            btnExample08.Click += btnExample08_Click;
            // 
            // btnExample09
            // 
            btnExample09.BackColor = SystemColors.Info;
            btnExample09.Location = new Point(310, 304);
            btnExample09.Name = "btnExample09";
            btnExample09.Size = new Size(158, 100);
            btnExample09.TabIndex = 7;
            btnExample09.Text = "Example09";
            btnExample09.UseVisualStyleBackColor = false;
            btnExample09.Click += btnExample09_Click;
            // 
            // btnExample10
            // 
            btnExample10.BackColor = SystemColors.Info;
            btnExample10.Location = new Point(572, 304);
            btnExample10.Name = "btnExample10";
            btnExample10.Size = new Size(158, 100);
            btnExample10.TabIndex = 8;
            btnExample10.Text = "Example10";
            btnExample10.UseVisualStyleBackColor = false;
            btnExample10.Click += btnExample10_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // btnExample11
            // 
            btnExample11.BackColor = SystemColors.Info;
            btnExample11.Location = new Point(41, 440);
            btnExample11.Name = "btnExample11";
            btnExample11.Size = new Size(158, 100);
            btnExample11.TabIndex = 9;
            btnExample11.Text = "Example11";
            btnExample11.UseVisualStyleBackColor = false;
            btnExample11.Click += btnExample11_Click;
            // 
            // btnExample12
            // 
            btnExample12.BackColor = SystemColors.Info;
            btnExample12.Location = new Point(310, 440);
            btnExample12.Name = "btnExample12";
            btnExample12.Size = new Size(158, 100);
            btnExample12.TabIndex = 10;
            btnExample12.Text = "Example12";
            btnExample12.UseVisualStyleBackColor = false;
            btnExample12.Click += btnExample12_Click;
            // 
            // btnExample13
            // 
            btnExample13.BackColor = SystemColors.Info;
            btnExample13.Location = new Point(572, 440);
            btnExample13.Name = "btnExample13";
            btnExample13.Size = new Size(158, 100);
            btnExample13.TabIndex = 11;
            btnExample13.Text = "Example13";
            btnExample13.UseVisualStyleBackColor = false;
            btnExample13.Click += btnExample13_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExample13);
            Controls.Add(btnExample12);
            Controls.Add(btnExample11);
            Controls.Add(button1);
            Controls.Add(btnExample10);
            Controls.Add(btnExample09);
            Controls.Add(btnExample08);
            Controls.Add(btnExample07);
            Controls.Add(btnExample06);
            Controls.Add(btnExample05);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnExample01);
            Name = "MenuForm";
            Text = "MenuForm";
            Load += MenuForm_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExample01;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnExample05;
        private System.Windows.Forms.Button btnExample06;
        private System.Windows.Forms.Button btnExample07;
        private System.Windows.Forms.Button btnExample08;
        private System.Windows.Forms.Button btnExample09;
        private System.Windows.Forms.Button btnExample10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExample11;
        private Button btnExample12;
        private Button btnExample13;
    }
}