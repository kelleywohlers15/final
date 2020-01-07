namespace AbondonedHouse_SearchingForm4
{
    partial class FindingLight
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
            this.btn_Light1 = new System.Windows.Forms.Button();
            this.btn_Light2 = new System.Windows.Forms.Button();
            this.lbl_Choose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Light1
            // 
            this.btn_Light1.Location = new System.Drawing.Point(64, 165);
            this.btn_Light1.Name = "btn_Light1";
            this.btn_Light1.Size = new System.Drawing.Size(152, 62);
            this.btn_Light1.TabIndex = 0;
            this.btn_Light1.Text = "Look for Flashlights";
            this.btn_Light1.UseVisualStyleBackColor = true;
            this.btn_Light1.Click += new System.EventHandler(this.btn_Light1_Click);
            // 
            // btn_Light2
            // 
            this.btn_Light2.Location = new System.Drawing.Point(495, 165);
            this.btn_Light2.Name = "btn_Light2";
            this.btn_Light2.Size = new System.Drawing.Size(161, 62);
            this.btn_Light2.TabIndex = 1;
            this.btn_Light2.Text = "Use very little phone light ";
            this.btn_Light2.UseVisualStyleBackColor = true;
            this.btn_Light2.Click += new System.EventHandler(this.btn_Light2_Click);
            // 
            // lbl_Choose
            // 
            this.lbl_Choose.AutoSize = true;
            this.lbl_Choose.Location = new System.Drawing.Point(280, 50);
            this.lbl_Choose.Name = "lbl_Choose";
            this.lbl_Choose.Size = new System.Drawing.Size(166, 13);
            this.lbl_Choose.TabIndex = 4;
            this.lbl_Choose.Text = "You got in! What do you choose?";
            // 
            // FindingLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Choose);
            this.Controls.Add(this.btn_Light2);
            this.Controls.Add(this.btn_Light1);
            this.Name = "FindingLight";
            this.Text = "FindingLight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Light1;
        private System.Windows.Forms.Button btn_Light2;
        private System.Windows.Forms.Label lbl_Choose;
    }
}

