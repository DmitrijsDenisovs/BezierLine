
namespace BezierLine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pointCountTextBox = new System.Windows.Forms.TextBox();
            this.pointCountButton = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pointCountTextBox
            // 
            this.pointCountTextBox.Location = new System.Drawing.Point(629, 12);
            this.pointCountTextBox.Name = "pointCountTextBox";
            this.pointCountTextBox.Size = new System.Drawing.Size(159, 23);
            this.pointCountTextBox.TabIndex = 0;
            // 
            // pointCountButton
            // 
            this.pointCountButton.Location = new System.Drawing.Point(629, 41);
            this.pointCountButton.Name = "pointCountButton";
            this.pointCountButton.Size = new System.Drawing.Size(159, 23);
            this.pointCountButton.TabIndex = 1;
            this.pointCountButton.Text = "Enter new point count";
            this.pointCountButton.UseVisualStyleBackColor = true;
            this.pointCountButton.Click += new System.EventHandler(this.pointCountButton_Click);
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(629, 70);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(159, 23);
            this.drawButton.TabIndex = 2;
            this.drawButton.Text = "Draw Bezier curve";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.pointCountButton);
            this.Controls.Add(this.pointCountTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pointCountTextBox;
        private System.Windows.Forms.Button pointCountButton;
        private System.Windows.Forms.Button drawButton;
    }
}

