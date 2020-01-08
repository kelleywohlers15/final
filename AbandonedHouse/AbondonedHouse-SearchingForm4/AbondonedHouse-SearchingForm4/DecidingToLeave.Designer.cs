namespace AbondonedHouse_SearchingForm4
{
    partial class DecidingToLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecidingToLeave));
            this.lbl_stayedClear = new System.Windows.Forms.Label();
            this.btn_talk = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_stayedClear
            // 
            this.lbl_stayedClear.AutoSize = true;
            this.lbl_stayedClear.Location = new System.Drawing.Point(176, 132);
            this.lbl_stayedClear.Name = "lbl_stayedClear";
            this.lbl_stayedClear.Size = new System.Drawing.Size(316, 52);
            this.lbl_stayedClear.TabIndex = 0;
            this.lbl_stayedClear.Text = resources.GetString("lbl_stayedClear.Text");
            // 
            // btn_talk
            // 
            this.btn_talk.Location = new System.Drawing.Point(179, 264);
            this.btn_talk.Name = "btn_talk";
            this.btn_talk.Size = new System.Drawing.Size(101, 65);
            this.btn_talk.TabIndex = 1;
            this.btn_talk.Text = "Stay and talk to who is in the house";
            this.btn_talk.UseVisualStyleBackColor = true;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(400, 264);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(103, 74);
            this.btn_run.TabIndex = 2;
            this.btn_run.Text = "Leave and run home";
            this.btn_run.UseVisualStyleBackColor = true;
            // 
            // DecidingToLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.btn_talk);
            this.Controls.Add(this.lbl_stayedClear);
            this.Name = "DecidingToLeave";
            this.Text = "DecidingToLeave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_stayedClear;
        private System.Windows.Forms.Button btn_talk;
        private System.Windows.Forms.Button btn_run;
    }
}