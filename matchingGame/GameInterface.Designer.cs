namespace matchingGame
{
    partial class GameInterface
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.btnNovice = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(73, 89);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(386, 31);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Welcome to Matching Game!";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(132, 143);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(257, 26);
            this.lblDifficulty.TabIndex = 1;
            this.lblDifficulty.Text = "Select Game Difficulty:";
            this.lblDifficulty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNovice
            // 
            this.btnNovice.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNovice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovice.Location = new System.Drawing.Point(137, 194);
            this.btnNovice.Name = "btnNovice";
            this.btnNovice.Padding = new System.Windows.Forms.Padding(1);
            this.btnNovice.Size = new System.Drawing.Size(252, 58);
            this.btnNovice.TabIndex = 2;
            this.btnNovice.Text = "Novice - 8 Cards";
            this.btnNovice.UseVisualStyleBackColor = true;
            this.btnNovice.Click += new System.EventHandler(this.btnNovice_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.Location = new System.Drawing.Point(137, 286);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Padding = new System.Windows.Forms.Padding(1);
            this.btnNormal.Size = new System.Drawing.Size(252, 58);
            this.btnNormal.TabIndex = 3;
            this.btnNormal.Text = "Normal - 16 Cards";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnHard
            // 
            this.btnHard.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(137, 378);
            this.btnHard.Name = "btnHard";
            this.btnHard.Padding = new System.Windows.Forms.Padding(1);
            this.btnHard.Size = new System.Drawing.Size(252, 58);
            this.btnHard.TabIndex = 4;
            this.btnHard.Text = "Hard - 36 Cards";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // GameInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnNovice);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblHeading);
            this.Name = "GameInterface";
            this.Text = "Matching Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameInterface_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Button btnNovice;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnHard;
    }
}

