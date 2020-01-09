namespace AbondonedHouse_SearchingForm4
{
    partial class TalkOrLeave
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
            this.btn_Talk = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.lbl_Footsteps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Talk
            // 
            this.btn_Talk.Location = new System.Drawing.Point(149, 216);
            this.btn_Talk.Name = "btn_Talk";
            this.btn_Talk.Size = new System.Drawing.Size(113, 59);
            this.btn_Talk.TabIndex = 0;
            this.btn_Talk.Text = "Stay and see who the person is and talk to them. ";
            this.btn_Talk.UseVisualStyleBackColor = true;
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(446, 216);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(95, 62);
            this.btn_Run.TabIndex = 1;
            this.btn_Run.Text = "Leave and run home.";
            this.btn_Run.UseVisualStyleBackColor = true;
            // 
            // lbl_Footsteps
            // 
            this.lbl_Footsteps.AutoSize = true;
            this.lbl_Footsteps.Location = new System.Drawing.Point(182, 66);
            this.lbl_Footsteps.Name = "lbl_Footsteps";
            this.lbl_Footsteps.Size = new System.Drawing.Size(341, 39);
            this.lbl_Footsteps.TabIndex = 2;
            this.lbl_Footsteps.Text = "You did the right thing, but while you\'re upstairs-you hear someone say,\r\n \"What " +
    "are you doing here?\" There footsteps are coming towards you. \r\nWhat is your next" +
    " move? ";
            // 
            // TalkOrLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Footsteps);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.btn_Talk);
            this.Name = "TalkOrLeave";
            this.Text = "TalkOrLeave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Talk;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label lbl_Footsteps;
    }
}