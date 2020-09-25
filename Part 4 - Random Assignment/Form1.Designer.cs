namespace Part_4___Random_Assignment
{
    partial class RandomNumbers
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnInt = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnDouble = new System.Windows.Forms.Button();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblRound = new System.Windows.Forms.Label();
            this.txtRound = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(27, 26);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(312, 26);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter a minimum and maximum value.";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInt
            // 
            this.btnInt.BackColor = System.Drawing.Color.Indigo;
            this.btnInt.Location = new System.Drawing.Point(31, 251);
            this.btnInt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(124, 46);
            this.btnInt.TabIndex = 1;
            this.btnInt.Text = "Get Integer";
            this.btnInt.UseVisualStyleBackColor = false;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(27, 70);
            this.lblMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(95, 26);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Minimum:";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(27, 122);
            this.lblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(97, 26);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "Maximum:";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(31, 308);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(293, 88);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "???";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDouble
            // 
            this.btnDouble.BackColor = System.Drawing.Color.Indigo;
            this.btnDouble.Location = new System.Drawing.Point(203, 251);
            this.btnDouble.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(124, 46);
            this.btnDouble.TabIndex = 5;
            this.btnDouble.Text = "Get Double";
            this.btnDouble.UseVisualStyleBackColor = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(121, 69);
            this.txtMin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(201, 30);
            this.txtMin.TabIndex = 6;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(121, 120);
            this.txtMax.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(201, 30);
            this.txtMax.TabIndex = 7;
            // 
            // lblRound
            // 
            this.lblRound.Location = new System.Drawing.Point(-1, 152);
            this.lblRound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(361, 46);
            this.lblRound.TabIndex = 8;
            this.lblRound.Text = "What do you want to round your answer to?";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRound
            // 
            this.txtRound.Location = new System.Drawing.Point(31, 202);
            this.txtRound.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(291, 30);
            this.txtRound.TabIndex = 9;
            // 
            // RandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(360, 408);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.lblInstructions);
            this.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "RandomNumbers";
            this.Text = "Random numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.TextBox txtRound;
    }
}

