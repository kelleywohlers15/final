namespace AbandonedHouse
{
    partial class theEnding
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
            this.btn_ending = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ending
            // 
            this.btn_ending.Location = new System.Drawing.Point(121, 213);
            this.btn_ending.Name = "btn_ending";
            this.btn_ending.Size = new System.Drawing.Size(189, 60);
            this.btn_ending.TabIndex = 0;
            this.btn_ending.Text = "Click To Play Again";
            this.btn_ending.UseVisualStyleBackColor = true;
            this.btn_ending.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "YOU DIED! That was not the smart thign to do, if \r\nyou would like to play again c" +
    "lick the button below.";
            // 
            // theEnding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ending);
            this.Name = "theEnding";
            this.Text = "theEnding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ending;
        private System.Windows.Forms.Label label1;
    }
}