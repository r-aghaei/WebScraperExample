namespace WindowsFormsExample
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button100 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.ButtonMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 96);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 334);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Click Me";
            // 
            // Button100
            // 
            this.Button100.Location = new System.Drawing.Point(172, 12);
            this.Button100.Name = "Button100";
            this.Button100.Size = new System.Drawing.Size(289, 35);
            this.Button100.TabIndex = 2;
            this.Button100.Text = "Load Google 100 times";
            this.Button100.UseVisualStyleBackColor = true;
            this.Button100.Click += new System.EventHandler(this.Button100_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 14);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(154, 35);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Load Google once";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ButtonMessage
            // 
            this.ButtonMessage.Location = new System.Drawing.Point(12, 55);
            this.ButtonMessage.Name = "ButtonMessage";
            this.ButtonMessage.Size = new System.Drawing.Size(449, 35);
            this.ButtonMessage.TabIndex = 4;
            this.ButtonMessage.Text = "Click me during loading 100 sites!";
            this.ButtonMessage.UseVisualStyleBackColor = true;
            this.ButtonMessage.Click += new System.EventHandler(this.ButtonMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 442);
            this.Controls.Add(this.ButtonMessage);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button100);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Button100;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button ButtonMessage;
    }
}

