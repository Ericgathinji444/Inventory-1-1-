namespace CST_150_Activity_1
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
            this.lblEarth = new System.Windows.Forms.Label();
            this.txtEarthWeight = new System.Windows.Forms.TextBox();
            this.lblMars = new System.Windows.Forms.Label();
            this.lblMarsWeight = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEarth
            // 
            this.lblEarth.AutoSize = true;
            this.lblEarth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEarth.Location = new System.Drawing.Point(155, 86);
            this.lblEarth.Name = "lblEarth";
            this.lblEarth.Size = new System.Drawing.Size(233, 24);
            this.lblEarth.TabIndex = 0;
            this.lblEarth.Text = "Enter your weight on Earth";
            // 
            // txtEarthWeight
            // 
            this.txtEarthWeight.Location = new System.Drawing.Point(401, 90);
            this.txtEarthWeight.Name = "txtEarthWeight";
            this.txtEarthWeight.Size = new System.Drawing.Size(100, 22);
            this.txtEarthWeight.TabIndex = 1;
            this.txtEarthWeight.Text = "12";
            // 
            // lblMars
            // 
            this.lblMars.AutoSize = true;
            this.lblMars.Font = new System.Drawing.Font("Arial", 11F);
            this.lblMars.Location = new System.Drawing.Point(158, 186);
            this.lblMars.Name = "lblMars";
            this.lblMars.Size = new System.Drawing.Size(178, 22);
            this.lblMars.TabIndex = 2;
            this.lblMars.Text = "Your weight on Mars";
            // 
            // lblMarsWeight
            // 
            this.lblMarsWeight.AutoSize = true;
            this.lblMarsWeight.Location = new System.Drawing.Point(374, 192);
            this.lblMarsWeight.Name = "lblMarsWeight";
            this.lblMarsWeight.Size = new System.Drawing.Size(37, 16);
            this.lblMarsWeight.TabIndex = 3;
            this.lblMarsWeight.Text = "label";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnConvert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConvert.Location = new System.Drawing.Point(360, 268);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(117, 39);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.ConvertButtonClickEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "lbs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblMarsWeight);
            this.Controls.Add(this.lblMars);
            this.Controls.Add(this.txtEarthWeight);
            this.Controls.Add(this.lblEarth);
            this.Name = "Form1";
            this.Text = "Your weight on Mars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEarth;
        private System.Windows.Forms.TextBox txtEarthWeight;
        private System.Windows.Forms.Label lblMars;
        private System.Windows.Forms.Label lblMarsWeight;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
    }
}

