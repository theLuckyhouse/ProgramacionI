namespace EjemloDuolinguo
{
    partial class Pregunta1
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
            this.Opcion2 = new System.Windows.Forms.Button();
            this.Opcion1 = new System.Windows.Forms.Button();
            this.Opcion3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Opcion2
            // 
            this.Opcion2.Location = new System.Drawing.Point(44, 226);
            this.Opcion2.Name = "Opcion2";
            this.Opcion2.Size = new System.Drawing.Size(371, 40);
            this.Opcion2.TabIndex = 1;
            this.Opcion2.Text = "if";
            this.Opcion2.UseVisualStyleBackColor = true;
            // 
            // Opcion1
            // 
            this.Opcion1.Location = new System.Drawing.Point(44, 180);
            this.Opcion1.Name = "Opcion1";
            this.Opcion1.Size = new System.Drawing.Size(371, 40);
            this.Opcion1.TabIndex = 2;
            this.Opcion1.Text = "Hi";
            this.Opcion1.UseVisualStyleBackColor = true;
            this.Opcion1.Click += new System.EventHandler(this.Opcion1_Click);
            // 
            // Opcion3
            // 
            this.Opcion3.Location = new System.Drawing.Point(44, 272);
            this.Opcion3.Name = "Opcion3";
            this.Opcion3.Size = new System.Drawing.Size(371, 40);
            this.Opcion3.TabIndex = 3;
            this.Opcion3.Text = "while";
            this.Opcion3.UseVisualStyleBackColor = true;
            this.Opcion3.Click += new System.EventHandler(this.Opcion3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hola";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::EjemloDuolinguo.Properties.Resources.DUOPNG;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(385, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 316);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Pregunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Opcion3);
            this.Controls.Add(this.Opcion1);
            this.Controls.Add(this.Opcion2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Pregunta1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregunta1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Opcion2;
        private System.Windows.Forms.Button Opcion1;
        private System.Windows.Forms.Button Opcion3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}