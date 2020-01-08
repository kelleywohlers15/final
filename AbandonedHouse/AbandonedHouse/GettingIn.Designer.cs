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
            this.label1.Location = new System.Drawing.Point(149, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "You didn\'t get caught  when you ducked behind the parked car. \r\nYou are now at th" +
    "e hosue and have to decide how to get in. \r\nDO YOU GO IN";
            // 
            // btn_GettingIn
            // 
            this.btn_GettingIn.Location = new System.Drawing.Point(152, 255);
            this.btn_GettingIn.Name = "btn_GettingIn";
            this.btn_GettingIn.Size = new System.Drawing.Size(132, 23);
            this.btn_GettingIn.TabIndex = 1;
            this.btn_GettingIn.Text = "Back Window";
            this.btn_GettingIn.UseVisualStyleBackColor = true;
            this.btn_GettingIn.Click += new System.EventHandler(this.btn_GettingIn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Front Door";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GettingIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_GettingIn);
            this.Controls.Add(this.label1);
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