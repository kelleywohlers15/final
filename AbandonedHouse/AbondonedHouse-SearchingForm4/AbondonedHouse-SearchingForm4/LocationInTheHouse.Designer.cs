namespace AbondonedHouse_SearchingForm4
{
    partial class LocationInTheHouse
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
            this.lbl_Rumors = new System.Windows.Forms.Label();
            this.btn_basement = new System.Windows.Forms.Button();
            this.btn_StayClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Rumors
            // 
            this.lbl_Rumors.AutoSize = true;
            this.lbl_Rumors.Location = new System.Drawing.Point(78, 99);
            this.lbl_Rumors.Name = "lbl_Rumors";
            this.lbl_Rumors.Size = new System.Drawing.Size(559, 13);
            this.lbl_Rumors.TabIndex = 0;
            this.lbl_Rumors.Text = "You\'ve heard rumors about the kids that died in the house. Their bodies have been" +
    " hidden in the basement. Do you.. ";
            // 
            // btn_basement
            // 
            this.btn_basement.Location = new System.Drawing.Point(179, 191);
            this.btn_basement.Name = "btn_basement";
            this.btn_basement.Size = new System.Drawing.Size(123, 67);
            this.btn_basement.TabIndex = 1;
            this.btn_basement.Text = "Go explore the basement";
            this.btn_basement.UseVisualStyleBackColor = true;
            // 
            // btn_StayClear
            // 
            this.btn_StayClear.Location = new System.Drawing.Point(408, 191);
            this.btn_StayClear.Name = "btn_StayClear";
            this.btn_StayClear.Size = new System.Drawing.Size(123, 67);
            this.btn_StayClear.TabIndex = 2;
            this.btn_StayClear.Text = "Stay clear and go upstairs";
            this.btn_StayClear.UseVisualStyleBackColor = true;
            // 
            // LocationInTheHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_StayClear);
            this.Controls.Add(this.btn_basement);
            this.Controls.Add(this.lbl_Rumors);
            this.Name = "LocationInTheHouse";
            this.Text = "LocationInTheHouse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Rumors;
        private System.Windows.Forms.Button btn_basement;
        private System.Windows.Forms.Button btn_StayClear;
    }
}