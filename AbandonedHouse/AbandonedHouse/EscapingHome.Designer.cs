namespace AbandonedHouse
{
    partial class EscapingHome
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
            this.btn_escaping = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_escaping
            // 
            this.btn_escaping.Location = new System.Drawing.Point(97, 238);
            this.btn_escaping.Name = "btn_escaping";
            this.btn_escaping.Size = new System.Drawing.Size(174, 23);
            this.btn_escaping.TabIndex = 1;
            this.btn_escaping.Text = "Through Window ";
            this.btn_escaping.UseVisualStyleBackColor = true;
            this.btn_escaping.Click += new System.EventHandler(this.btn_escaping_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Through front door ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "You decide to go now you have to decide how you are going to leave the house. DO " +
    "YOU";
            // 
            // EscapingHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_escaping);
            this.Name = "EscapingHome";
            this.Text = "EscapingHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_escaping;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}