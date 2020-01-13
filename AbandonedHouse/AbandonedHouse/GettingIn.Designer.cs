namespace AbandonedHouse
{
    partial class GettingIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GettingIn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(88, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "You didn\'t get caught  when you ducked behind the parked car. \r\nYou are now at th" +
    "e hosue and have to decide how to get in. \r\nDO YOU GO IN";
            // 
            // btn_GettingIn
            // 
            this.btn_GettingIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_GettingIn.Location = new System.Drawing.Point(80, 273);
            this.btn_GettingIn.Name = "btn_GettingIn";
            this.btn_GettingIn.Size = new System.Drawing.Size(154, 27);
            this.btn_GettingIn.TabIndex = 1;
            this.btn_GettingIn.Text = "Back Window";
            this.btn_GettingIn.UseVisualStyleBackColor = false;
            this.btn_GettingIn.Click += new System.EventHandler(this.btn_GettingIn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(290, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Front Door";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GettingIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AbandonedHouse.Properties.Resources.LocationInHouse;
            this.ClientSize = new System.Drawing.Size(543, 519);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_GettingIn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GettingIn";
            this.Text = "GettingIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GettingIn;
        private System.Windows.Forms.Button button2;
    }
}