namespace KrisKringle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scrollTextBox2 = new ScrollTextBox();
            this.scrollTextBox1 = new ScrollTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enter ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Calculate Pairs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Names : 0 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Results";
            // 
            // scrollTextBox2
            // 
            this.scrollTextBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.scrollTextBox2.Location = new System.Drawing.Point(13, 55);
            this.scrollTextBox2.Multiline = true;
            this.scrollTextBox2.Name = "scrollTextBox2";
            this.scrollTextBox2.ReadOnly = true;
            this.scrollTextBox2.Size = new System.Drawing.Size(185, 92);
            this.scrollTextBox2.TabIndex = 3;
            // 
            // scrollTextBox1
            // 
            this.scrollTextBox1.Location = new System.Drawing.Point(13, 172);
            this.scrollTextBox1.Multiline = true;
            this.scrollTextBox1.Name = "scrollTextBox1";
            this.scrollTextBox1.ReadOnly = true;
            this.scrollTextBox1.Size = new System.Drawing.Size(320, 78);
            this.scrollTextBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(345, 265);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.scrollTextBox2);
            this.Controls.Add(this.scrollTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(361, 303);
            this.MinimumSize = new System.Drawing.Size(361, 303);
            this.Name = "Form1";
            this.Text = "Joe Bentley - Kris Kringle Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private ScrollTextBox scrollTextBox1;
        private ScrollTextBox scrollTextBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

