namespace AbondonedHouse_SearchingForm4
{
    partial class LocationInHouse
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
            this.btn_basement = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_bodies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_basement
            // 
            this.btn_basement.Location = new System.Drawing.Point(177, 244);
            this.btn_basement.Name = "btn_basement";
            this.btn_basement.Size = new System.Drawing.Size(115, 64);
            this.btn_basement.TabIndex = 0;
            this.btn_basement.Text = "Go explore the basement ";
            this.btn_basement.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(404, 244);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(123, 64);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "Stay clear and go upstairs";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_bodies
            // 
            this.lbl_bodies.AutoSize = true;
            this.lbl_bodies.Location = new System.Drawing.Point(174, 139);
            this.lbl_bodies.Name = "lbl_bodies";
            this.lbl_bodies.Size = new System.Drawing.Size(321, 39);
            this.lbl_bodies.TabIndex = 2;
            this.lbl_bodies.Text = "You have heard rumors about kids who have died in that house, \r\nthier bodies have" +
    " been hidden in the basement. You really want to \r\nexplore the entire house thou" +
    "gh. What do you choose? ";
            // 
            // LocationInHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_bodies);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_basement);
            this.Name = "LocationInHouse";
            this.Text = "LocationInHouse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_basement;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_bodies;
    }
}