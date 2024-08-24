namespace EjemloDuolinguo
{
    partial class Pregunta2
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
            this.Opcion3 = new System.Windows.Forms.Button();
            this.Opcion1 = new System.Windows.Forms.Button();
            this.Opcion2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Opcion3
            // 
            this.Opcion3.Location = new System.Drawing.Point(20, 258);
            this.Opcion3.Name = "Opcion3";
            this.Opcion3.Size = new System.Drawing.Size(371, 40);
            this.Opcion3.TabIndex = 8;
            this.Opcion3.Text = "BYE";
            this.Opcion3.UseVisualStyleBackColor = true;
            this.Opcion3.Click += new System.EventHandler(this.Opcion3_Click);
            // 
            // Opcion1
            // 
            this.Opcion1.Location = new System.Drawing.Point(20, 166);
            this.Opcion1.Name = "Opcion1";
            this.Opcion1.Size = new System.Drawing.Size(371, 40);
            this.Opcion1.TabIndex = 7;
            this.Opcion1.Text = "Hi";
            this.Opcion1.UseVisualStyleBackColor = true;
            this.Opcion1.Click += new System.EventHandler(this.Opcion1_Click);
            // 
            // Opcion2
            // 
            this.Opcion2.Location = new System.Drawing.Point(20, 212);
            this.Opcion2.Name = "Opcion2";
            this.Opcion2.Size = new System.Drawing.Size(371, 40);
            this.Opcion2.TabIndex = 6;
            this.Opcion2.Text = "GOD";
            this.Opcion2.UseVisualStyleBackColor = true;
            this.Opcion2.Click += new System.EventHandler(this.Opcion2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::EjemloDuolinguo.Properties.Resources.DUOPNG;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(361, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 316);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pregunta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.Opcion3);
            this.Controls.Add(this.Opcion1);
            this.Controls.Add(this.Opcion2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Pregunta2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregunta2";
            this.Load += new System.EventHandler(this.Pregunta2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Opcion3;
        private System.Windows.Forms.Button Opcion1;
        private System.Windows.Forms.Button Opcion2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}