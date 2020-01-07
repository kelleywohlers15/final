namespace AbondonedHouse_SearchingForm4
{
    partial class Exploring
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
            this.lbl_phone = new System.Windows.Forms.Label();
            this.btn_SplittingUp = new System.Windows.Forms.Button();
            this.btn_Staying = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(238, 51);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(218, 13);
            this.lbl_phone.TabIndex = 1;
            this.lbl_phone.Text = "You are good with little phone light. Do you.. ";
            // 
            // btn_SplittingUp
            // 
            this.btn_SplittingUp.Location = new System.Drawing.Point(167, 129);
            this.btn_SplittingUp.Name = "btn_SplittingUp";
            this.btn_SplittingUp.Size = new System.Drawing.Size(120, 64);
            this.btn_SplittingUp.TabIndex = 2;
            this.btn_SplittingUp.Text = "split up with your friend and explore";
            this.btn_SplittingUp.UseVisualStyleBackColor = true;
            // 
            // btn_Staying
            // 
            this.btn_Staying.Location = new System.Drawing.Point(374, 129);
            this.btn_Staying.Name = "btn_Staying";
            this.btn_Staying.Size = new System.Drawing.Size(133, 66);
            this.btn_Staying.TabIndex = 3;
            this.btn_Staying.Text = "stay together and explore";
            this.btn_Staying.UseVisualStyleBackColor = true;
            // 
            // Exploring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Staying);
            this.Controls.Add(this.btn_SplittingUp);
            this.Controls.Add(this.lbl_phone);
            this.Name = "Exploring";
            this.Text = "Exploring";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Button btn_SplittingUp;
        private System.Windows.Forms.Button btn_Staying;
    }
}