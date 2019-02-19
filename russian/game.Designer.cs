namespace russian
{
    partial class game
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnload = new System.Windows.Forms.Button();
            this.btnspin = new System.Windows.Forms.Button();
            this.btnshoot = new System.Windows.Forms.Button();
            this.btnplayagain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Russian Roullete";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(48, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(471, 203);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnload
            // 
            this.btnload.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(35, 319);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(84, 29);
            this.btnload.TabIndex = 3;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.Load_Click);
            // 
            // btnspin
            // 
            this.btnspin.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspin.Location = new System.Drawing.Point(182, 319);
            this.btnspin.Name = "btnspin";
            this.btnspin.Size = new System.Drawing.Size(78, 29);
            this.btnspin.TabIndex = 4;
            this.btnspin.Text = "Spin";
            this.btnspin.UseVisualStyleBackColor = true;
            this.btnspin.Click += new System.EventHandler(this.btnspin_Click);
            // 
            // btnshoot
            // 
            this.btnshoot.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshoot.Location = new System.Drawing.Point(316, 319);
            this.btnshoot.Name = "btnshoot";
            this.btnshoot.Size = new System.Drawing.Size(87, 29);
            this.btnshoot.TabIndex = 5;
            this.btnshoot.Text = "Shoot";
            this.btnshoot.UseVisualStyleBackColor = true;
            this.btnshoot.Click += new System.EventHandler(this.buttonshoot_Click);
            // 
            // btnplayagain
            // 
            this.btnplayagain.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplayagain.Location = new System.Drawing.Point(471, 312);
            this.btnplayagain.Name = "btnplayagain";
            this.btnplayagain.Size = new System.Drawing.Size(116, 36);
            this.btnplayagain.TabIndex = 6;
            this.btnplayagain.Text = "Play Again";
            this.btnplayagain.UseVisualStyleBackColor = true;
            this.btnplayagain.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::russian.Properties.Resources.uberti_replica_colt_1851;
            this.ClientSize = new System.Drawing.Size(595, 379);
            this.Controls.Add(this.btnplayagain);
            this.Controls.Add(this.btnshoot);
            this.Controls.Add(this.btnspin);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Name = "game";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnspin;
        private System.Windows.Forms.Button btnshoot;
        private System.Windows.Forms.Button btnplayagain;
    }
}