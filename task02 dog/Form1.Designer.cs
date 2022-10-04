namespace task02_dog
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.breedTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.introButton = new System.Windows.Forms.Button();
            this.dogLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "Dog Name";
            // 
            // breedTextBox
            // 
            this.breedTextBox.Location = new System.Drawing.Point(12, 41);
            this.breedTextBox.Name = "breedTextBox";
            this.breedTextBox.Size = new System.Drawing.Size(100, 23);
            this.breedTextBox.TabIndex = 1;
            this.breedTextBox.Text = "Dog Breed";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(12, 70);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 23);
            this.ageTextBox.TabIndex = 2;
            this.ageTextBox.Text = "Dog Age";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(12, 99);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 23);
            this.colorTextBox.TabIndex = 3;
            this.colorTextBox.Text = "Dog Color";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(12, 128);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 23);
            this.weightTextBox.TabIndex = 4;
            this.weightTextBox.Text = "Dog Weight";
            // 
            // introButton
            // 
            this.introButton.Location = new System.Drawing.Point(103, 172);
            this.introButton.Name = "introButton";
            this.introButton.Size = new System.Drawing.Size(108, 23);
            this.introButton.TabIndex = 5;
            this.introButton.Text = "Dog Introduction";
            this.introButton.UseVisualStyleBackColor = true;
            this.introButton.Click += new System.EventHandler(this.introButton_Click);
            // 
            // dogLabel
            // 
            this.dogLabel.AutoSize = true;
            this.dogLabel.Location = new System.Drawing.Point(146, 15);
            this.dogLabel.Name = "dogLabel";
            this.dogLabel.Size = new System.Drawing.Size(0, 15);
            this.dogLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 207);
            this.Controls.Add(this.dogLabel);
            this.Controls.Add(this.introButton);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.breedTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextBox;
        private TextBox breedTextBox;
        private TextBox ageTextBox;
        private TextBox colorTextBox;
        private TextBox weightTextBox;
        private Button introButton;
        private Label dogLabel;
    }
}