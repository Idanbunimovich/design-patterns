namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    partial class WelcomeForm
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
            this.userProfilePicture = new System.Windows.Forms.PictureBox();
            this.findStalkerButton = new System.Windows.Forms.Button();
            this.groupPopularity_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // userProfilePicture
            // 
            this.userProfilePicture.Location = new System.Drawing.Point(500, 3);
            this.userProfilePicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userProfilePicture.Name = "userProfilePicture";
            this.userProfilePicture.Size = new System.Drawing.Size(150, 154);
            this.userProfilePicture.TabIndex = 0;
            this.userProfilePicture.TabStop = false;
            // 
            // findStalkerButton
            // 
            this.findStalkerButton.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.findStalkerButton.Location = new System.Drawing.Point(18, 385);
            this.findStalkerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findStalkerButton.Name = "findStalkerButton";
            this.findStalkerButton.Size = new System.Drawing.Size(237, 68);
            this.findStalkerButton.TabIndex = 1;
            this.findStalkerButton.Text = "Find Your Soulmate";
            this.findStalkerButton.UseVisualStyleBackColor = true;
            this.findStalkerButton.Click += new System.EventHandler(this.findStalkerButton_Click);
            // 
            // groupPopularity_button
            // 
            this.groupPopularity_button.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.groupPopularity_button.Location = new System.Drawing.Point(395, 389);
            this.groupPopularity_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupPopularity_button.Name = "groupPopularity_button";
            this.groupPopularity_button.Size = new System.Drawing.Size(237, 68);
            this.groupPopularity_button.TabIndex = 2;
            this.groupPopularity_button.Text = "Group Popularity";
            this.groupPopularity_button.UseVisualStyleBackColor = true;
            this.groupPopularity_button.Click += new System.EventHandler(this.groupPopularity_button_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 471);
            this.Controls.Add(this.groupPopularity_button);
            this.Controls.Add(this.findStalkerButton);
            this.Controls.Add(this.userProfilePicture);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WelcomeForm";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.userProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox userProfilePicture;
        private System.Windows.Forms.Button findStalkerButton;
        private System.Windows.Forms.Button groupPopularity_button;
    }
}