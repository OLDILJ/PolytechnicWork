namespace Task_1
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
            this.Form3Button = new System.Windows.Forms.Button();
            this.Form2Button = new System.Windows.Forms.Button();
            this.Form1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form3Button
            // 
            this.Form3Button.Location = new System.Drawing.Point(569, 161);
            this.Form3Button.Name = "Form3Button";
            this.Form3Button.Size = new System.Drawing.Size(200, 129);
            this.Form3Button.TabIndex = 0;
            this.Form3Button.Text = "Form 3";
            this.Form3Button.UseVisualStyleBackColor = true;
            this.Form3Button.Click += new System.EventHandler(this.Form3Button_Click);
            // 
            // Form2Button
            // 
            this.Form2Button.Location = new System.Drawing.Point(300, 161);
            this.Form2Button.Name = "Form2Button";
            this.Form2Button.Size = new System.Drawing.Size(200, 129);
            this.Form2Button.TabIndex = 0;
            this.Form2Button.Text = "Form 2";
            this.Form2Button.UseVisualStyleBackColor = true;
            this.Form2Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1Button
            // 
            this.Form1Button.Location = new System.Drawing.Point(31, 161);
            this.Form1Button.Name = "Form1Button";
            this.Form1Button.Size = new System.Drawing.Size(200, 129);
            this.Form1Button.TabIndex = 0;
            this.Form1Button.Text = "Form 1";
            this.Form1Button.UseVisualStyleBackColor = true;
            this.Form1Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Form2Button);
            this.Controls.Add(this.Form1Button);
            this.Controls.Add(this.Form3Button);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Form3Button;
        private System.Windows.Forms.Button Form2Button;
        private System.Windows.Forms.Button Form1Button;
    }
}