namespace Example_01
{
    partial class MenuForm
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
            btnExample01 = new Button();
            button2 = new Button();
            btn03 = new Button();
            SuspendLayout();
            // 
            // btnExample01
            // 
            btnExample01.BackColor = SystemColors.GradientActiveCaption;
            btnExample01.Location = new Point(41, 25);
            btnExample01.Name = "btnExample01";
            btnExample01.Size = new Size(150, 100);
            btnExample01.TabIndex = 0;
            btnExample01.Text = "Example01";
            btnExample01.UseVisualStyleBackColor = false;
            btnExample01.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(310, 28);
            button2.Name = "button2";
            button2.Size = new Size(228, 179);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn03
            // 
            btn03.Location = new Point(564, 33);
            btn03.Name = "btn03";
            btn03.Size = new Size(208, 174);
            btn03.TabIndex = 2;
            btn03.Text = "button3";
            btn03.UseVisualStyleBackColor = true;
            btn03.Click += btn03_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn03);
            Controls.Add(button2);
            Controls.Add(btnExample01);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExample01;
        private Button button2;
        private Button btn03;
    }
}