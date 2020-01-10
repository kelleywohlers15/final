namespace AbandonedHouse
{
    partial class start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            this.Title = new System.Windows.Forms.Label();
            this.btn_Escaping = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.Control;
            this.Title.Location = new System.Drawing.Point(220, 53);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(96, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Abandoned House";
            // 
            // btn_Escaping
            // 
            this.btn_Escaping.Location = new System.Drawing.Point(204, 302);
            this.btn_Escaping.Name = "btn_Escaping";
            this.btn_Escaping.Size = new System.Drawing.Size(141, 44);
            this.btn_Escaping.TabIndex = 1;
            this.btn_Escaping.Text = "PLAY";
            this.btn_Escaping.UseVisualStyleBackColor = true;
            this.btn_Escaping.Click += new System.EventHandler(this.btn_Escaping_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 120);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Escaping);
            this.Controls.Add(this.Title);
            this.Name = "start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btn_Escaping;
        private System.Windows.Forms.Label label1;
    }
}

