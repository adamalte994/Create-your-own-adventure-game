namespace Create_your_own_adventure_game
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
            this.redButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.sceneImages = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImages)).BeginInit();
            this.SuspendLayout();
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(29, 292);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(85, 23);
            this.redButton.TabIndex = 0;
            this.redButton.Text = "Left Arrow";
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(29, 323);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(85, 23);
            this.blueButton.TabIndex = 1;
            this.blueButton.Text = "Right Arrow";
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 32);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(135, 16);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "You are in a dungeon";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(139, 297);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(49, 13);
            this.redLabel.TabIndex = 3;
            this.redLabel.Text = "Continue";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(139, 328);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(32, 13);
            this.blueLabel.TabIndex = 4;
            this.blueLabel.Text = "Back";
            // 
            // sceneImages
            // 
            this.sceneImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sceneImages.Location = new System.Drawing.Point(281, 168);
            this.sceneImages.Name = "sceneImages";
            this.sceneImages.Size = new System.Drawing.Size(291, 194);
            this.sceneImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sceneImages.TabIndex = 5;
            this.sceneImages.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 366);
            this.Controls.Add(this.sceneImages);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Create your own adventure game";
            ((System.ComponentModel.ISupportInitialize)(this.sceneImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.PictureBox sceneImages;
    }
}

