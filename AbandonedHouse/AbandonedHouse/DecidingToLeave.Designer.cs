namespace AbandonedHouse
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
            this.lbl_Footsteps = new System.Windows.Forms.Label();
            this.btn_Run = new System.Windows.Forms.Button();
            this.btn_Talk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Footsteps
            // 
            this.lbl_Footsteps.AutoSize = true;
            this.lbl_Footsteps.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Footsteps.Location = new System.Drawing.Point(188, 142);
            this.lbl_Footsteps.Name = "lbl_Footsteps";
            this.lbl_Footsteps.Size = new System.Drawing.Size(341, 39);
            this.lbl_Footsteps.TabIndex = 5;
            this.lbl_Footsteps.Text = "You did the right thing, but while you\'re upstairs-you hear someone say,\r\n \"What " +
    "are you doing here?\" There footsteps are coming towards you. \r\nWhat is your next" +
    " move? ";
            // 
            // btn_Run
            // 
            this.btn_Run.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Run.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Run.Location = new System.Drawing.Point(434, 239);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(95, 62);
            this.btn_Run.TabIndex = 4;
            this.btn_Run.Text = "Leave and run home.";

            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // btn_Talk
            // 
            this.btn_Talk.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Talk.Location = new System.Drawing.Point(191, 241);
            this.btn_Talk.Name = "btn_Talk";
            this.btn_Talk.Size = new System.Drawing.Size(113, 59);
            this.btn_Talk.TabIndex = 3;
            this.btn_Talk.Text = "Stay and see who the person is and talk to them. ";
            this.btn_Talk.UseVisualStyleBackColor = false;
            this.btn_Talk.Click += new System.EventHandler(this.btn_Talk_Click);
            // 
            // DecidingToLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AbandonedHouse.Properties.Resources.LocationInHouse;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.lbl_Footsteps);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.btn_Talk);
            this.Name = "DecidingToLeave";
            this.Text = "DecidingToLeave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Footsteps;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Button btn_Talk;
    }
}