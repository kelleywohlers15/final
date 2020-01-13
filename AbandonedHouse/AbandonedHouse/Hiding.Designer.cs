namespace AbandonedHouse
{
    partial class Hiding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hiding));
            this.btn_GettingIn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_GettingIn
            // 
            this.btn_GettingIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_GettingIn.Location = new System.Drawing.Point(321, 296);
            this.btn_GettingIn.Name = "btn_GettingIn";
            this.btn_GettingIn.Size = new System.Drawing.Size(145, 23);
            this.btn_GettingIn.TabIndex = 1;
            this.btn_GettingIn.Text = "Duck behind parked car";
            this.btn_GettingIn.UseVisualStyleBackColor = false;
            this.btn_GettingIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(123, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Walk like you don\'t see them";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(168, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 78);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Hiding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AbandonedHouse.Properties.Resources.LocationInHouse;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_GettingIn);
            this.Name = "Hiding";
            this.Text = "Hiding";
            this.Load += new System.EventHandler(this.Hiding_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_GettingIn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}