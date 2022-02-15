namespace PlayGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playGameButton = new System.Windows.Forms.Button();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.goLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playGameButton
            // 
            this.playGameButton.BackColor = System.Drawing.Color.Black;
            this.playGameButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.playGameButton.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGameButton.ForeColor = System.Drawing.Color.White;
            this.playGameButton.Location = new System.Drawing.Point(218, 136);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(192, 65);
            this.playGameButton.TabIndex = 1;
            this.playGameButton.Text = "Play Game";
            this.playGameButton.UseVisualStyleBackColor = false;
            this.playGameButton.Click += new System.EventHandler(this.playGameButton_Click);
            // 
            // countdownLabel
            // 
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.BackColor = System.Drawing.Color.Transparent;
            this.countdownLabel.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel.ForeColor = System.Drawing.Color.White;
            this.countdownLabel.Location = new System.Drawing.Point(172, 178);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(0, 44);
            this.countdownLabel.TabIndex = 3;
            this.countdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goLabel
            // 
            this.goLabel.AutoSize = true;
            this.goLabel.BackColor = System.Drawing.Color.Transparent;
            this.goLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goLabel.ForeColor = System.Drawing.Color.White;
            this.goLabel.Location = new System.Drawing.Point(279, 160);
            this.goLabel.Name = "goLabel";
            this.goLabel.Size = new System.Drawing.Size(65, 28);
            this.goLabel.TabIndex = 4;
            this.goLabel.Text = "Go!!!!";
            this.goLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(632, 348);
            this.Controls.Add(this.goLabel);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.playGameButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "The Most Amazing Game Ever (100% True)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.Label goLabel;
    }
}

