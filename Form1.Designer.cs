namespace homework1_oop
{
    partial class app
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameButton = new System.Windows.Forms.Button();
            this._nameLabel = new System.Windows.Forms.Label();
            this.magicButton = new System.Windows.Forms.Button();
            this.operandBox1 = new System.Windows.Forms.TextBox();
            this.operandBox2 = new System.Windows.Forms.TextBox();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.diviButton = new System.Windows.Forms.Button();
            this.multipButton = new System.Windows.Forms.Button();
            this.calculationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.disclaimer = new System.Windows.Forms.Label();
            this._sentenceLabel = new System.Windows.Forms.Label();
            this.sentenceButton = new System.Windows.Forms.Button();
            this.sentenceLabel = new System.Windows.Forms.Label();
            this.sentenceBox = new System.Windows.Forms.TextBox();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.birthdateBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.phoneNb = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(22, 60);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(125, 20);
            this.nameBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(19, 31);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(199, 58);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(75, 23);
            this.nameButton.TabIndex = 2;
            this.nameButton.Text = "Greet me";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(324, 63);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(0, 13);
            this._nameLabel.TabIndex = 3;
            // 
            // magicButton
            // 
            this.magicButton.Location = new System.Drawing.Point(22, 126);
            this.magicButton.Name = "magicButton";
            this.magicButton.Size = new System.Drawing.Size(252, 23);
            this.magicButton.TabIndex = 4;
            this.magicButton.Text = "Do Magic";
            this.magicButton.UseVisualStyleBackColor = true;
            this.magicButton.Click += new System.EventHandler(this.magicButton_Click);
            // 
            // operandBox1
            // 
            this.operandBox1.Location = new System.Drawing.Point(22, 253);
            this.operandBox1.Name = "operandBox1";
            this.operandBox1.Size = new System.Drawing.Size(52, 20);
            this.operandBox1.TabIndex = 5;
            // 
            // operandBox2
            // 
            this.operandBox2.Location = new System.Drawing.Point(222, 253);
            this.operandBox2.Name = "operandBox2";
            this.operandBox2.Size = new System.Drawing.Size(52, 20);
            this.operandBox2.TabIndex = 6;
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(90, 251);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(21, 23);
            this.plusButton.TabIndex = 7;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(126, 251);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(21, 23);
            this.minusButton.TabIndex = 8;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // diviButton
            // 
            this.diviButton.Location = new System.Drawing.Point(189, 253);
            this.diviButton.Name = "diviButton";
            this.diviButton.Size = new System.Drawing.Size(21, 23);
            this.diviButton.TabIndex = 10;
            this.diviButton.Text = "/";
            this.diviButton.UseVisualStyleBackColor = true;
            this.diviButton.Click += new System.EventHandler(this.diviButton_Click);
            // 
            // multipButton
            // 
            this.multipButton.Location = new System.Drawing.Point(153, 253);
            this.multipButton.Name = "multipButton";
            this.multipButton.Size = new System.Drawing.Size(21, 23);
            this.multipButton.TabIndex = 9;
            this.multipButton.Text = "*";
            this.multipButton.UseVisualStyleBackColor = true;
            this.multipButton.Click += new System.EventHandler(this.multipButton_Click);
            // 
            // calculationLabel
            // 
            this.calculationLabel.AutoSize = true;
            this.calculationLabel.Location = new System.Drawing.Point(324, 256);
            this.calculationLabel.Name = "calculationLabel";
            this.calculationLabel.Size = new System.Drawing.Size(43, 13);
            this.calculationLabel.TabIndex = 11;
            this.calculationLabel.Text = "output: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Operand 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Operand 2";
            // 
            // disclaimer
            // 
            this.disclaimer.AutoSize = true;
            this.disclaimer.Location = new System.Drawing.Point(465, 89);
            this.disclaimer.Name = "disclaimer";
            this.disclaimer.Size = new System.Drawing.Size(324, 13);
            this.disclaimer.TabIndex = 14;
            this.disclaimer.Text = "MASSIVE disclaimer i\'m not a designer so this is just for functionality";
            // 
            // _sentenceLabel
            // 
            this._sentenceLabel.AutoSize = true;
            this._sentenceLabel.Location = new System.Drawing.Point(324, 378);
            this._sentenceLabel.Name = "_sentenceLabel";
            this._sentenceLabel.Size = new System.Drawing.Size(0, 13);
            this._sentenceLabel.TabIndex = 18;
            // 
            // sentenceButton
            // 
            this.sentenceButton.Location = new System.Drawing.Point(180, 373);
            this.sentenceButton.Name = "sentenceButton";
            this.sentenceButton.Size = new System.Drawing.Size(94, 23);
            this.sentenceButton.TabIndex = 17;
            this.sentenceButton.Text = "How big is this?";
            this.sentenceButton.UseVisualStyleBackColor = true;
            this.sentenceButton.Click += new System.EventHandler(this.sentenceButton_Click);
            // 
            // sentenceLabel
            // 
            this.sentenceLabel.AutoSize = true;
            this.sentenceLabel.Location = new System.Drawing.Point(19, 346);
            this.sentenceLabel.Name = "sentenceLabel";
            this.sentenceLabel.Size = new System.Drawing.Size(53, 13);
            this.sentenceLabel.TabIndex = 16;
            this.sentenceLabel.Text = "Sentence";
            // 
            // sentenceBox
            // 
            this.sentenceBox.Location = new System.Drawing.Point(22, 375);
            this.sentenceBox.Name = "sentenceBox";
            this.sentenceBox.Size = new System.Drawing.Size(125, 20);
            this.sentenceBox.TabIndex = 15;
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(23, 552);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(0, 13);
            this.birthdateLabel.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Compute days, age and all";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Birthdate (DD/MM/YYYY)";
            // 
            // birthdateBox
            // 
            this.birthdateBox.Location = new System.Drawing.Point(26, 505);
            this.birthdateBox.Name = "birthdateBox";
            this.birthdateBox.Size = new System.Drawing.Size(125, 20);
            this.birthdateBox.TabIndex = 19;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(639, 508);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(217, 20);
            this.numericUpDown1.TabIndex = 23;
            // 
            // phoneNb
            // 
            this.phoneNb.AutoSize = true;
            this.phoneNb.Location = new System.Drawing.Point(636, 492);
            this.phoneNb.Name = "phoneNb";
            this.phoneNb.Size = new System.Drawing.Size(184, 13);
            this.phoneNb.TabIndex = 24;
            this.phoneNb.Text = "Input your phone number for a cookie";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(883, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(854, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 42);
            this.button3.TabIndex = 26;
            this.button3.Text = "View Code";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // app
            // 
            this.ClientSize = new System.Drawing.Size(970, 595);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.phoneNb);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.birthdateBox);
            this.Controls.Add(this._sentenceLabel);
            this.Controls.Add(this.sentenceButton);
            this.Controls.Add(this.sentenceLabel);
            this.Controls.Add(this.sentenceBox);
            this.Controls.Add(this.disclaimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculationLabel);
            this.Controls.Add(this.diviButton);
            this.Controls.Add(this.multipButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.operandBox2);
            this.Controls.Add(this.operandBox1);
            this.Controls.Add(this.magicButton);
            this.Controls.Add(this._nameLabel);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Name = "app";
            this.Text = "Armand-Alexandru Balint";
            this.Load += new System.EventHandler(this.app_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.Button magicButton;
        private System.Windows.Forms.TextBox operandBox1;
        private System.Windows.Forms.TextBox operandBox2;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button diviButton;
        private System.Windows.Forms.Button multipButton;
        private System.Windows.Forms.Label calculationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label disclaimer;
        private System.Windows.Forms.Label _sentenceLabel;
        private System.Windows.Forms.Button sentenceButton;
        private System.Windows.Forms.Label sentenceLabel;
        private System.Windows.Forms.TextBox sentenceBox;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox birthdateBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label phoneNb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

