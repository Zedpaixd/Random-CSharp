using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;




namespace homework1_oop
{
    public partial class app : Form
    {
        private bool changedColour = false;
        private string[] dates;
        private string[] currentDates;
        
        public app()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nameButton_Click(object sender, EventArgs e)
        {

            if (nameBox.Text.Length != 0)
                _nameLabel.Text = "Hey, " + nameBox.Text + "!";
            else
                _nameLabel.Text = "Come on, you have a name, don't you?";

        }

        private void magicButton_Click(object sender, EventArgs e)
        {
            this.BackColor = changedColour ? Color.White : Color.GreenYellow;
            changedColour = !(changedColour && true);
        }


        #region ugly code
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                calculationLabel.Text = String.Format("output: {0:0.00}", (float.Parse(operandBox1.Text.Replace(",", ".")) + float.Parse(operandBox2.Text.Replace(",", "."))));
            }
            catch
            {
                calculationLabel.Text = "only digits allowed";
            }

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            try
            {
                calculationLabel.Text = String.Format("output: {0:0.00}", (float.Parse(operandBox1.Text.Replace(",", ".")) - float.Parse(operandBox2.Text.Replace(",", "."))));
            }
            catch
            {
                calculationLabel.Text = "only digits allowed";
            }
        }

        private void multipButton_Click(object sender, EventArgs e)
        {
            try
            {
                calculationLabel.Text = String.Format("output: {0:0.00}", (float.Parse(operandBox1.Text.Replace(",", ".")) * float.Parse(operandBox2.Text.Replace(",", "."))));
            }
            catch
            {
                calculationLabel.Text = "only digits allowed";
            }
        }

        private void diviButton_Click(object sender, EventArgs e)
        {
            try
            {
                calculationLabel.Text = String.Format("output: {0:0.00}", (float.Parse(operandBox1.Text.Replace(",", ".")) / float.Parse(operandBox2.Text.Replace(",", "."))));
            }
            catch
            {
                calculationLabel.Text = "only digits allowed";
            }
        }
        #endregion


        private void sentenceButton_Click(object sender, EventArgs e)
        {
            _sentenceLabel.Text = "Your string length is: " + sentenceBox.Text.Length;
            // i mean yes this can also be done with a for loop of the sorts for (int i = 0; textInArray[i] != null; i++) in the case of C
            // but this is just faster and it's the same thing.
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
            dates = birthdateBox.Text.Replace('.','/').Split('/');
            currentDates = DateTime.Now.ToString("dd/MM/yyyy").Split('/');

            int[] differences = new int[dates.Length > currentDates.Length ? currentDates.Length : dates.Length];

            for (int i = 0; i < dates.Length || i < currentDates.Length; i++)
            {
                differences[i] = int.Parse(currentDates[i]) - int.Parse(dates[i]);
                Console.WriteLine(differences[i]);
            }
            birthdateLabel.Text = String.Format("You are {0} days old, your age is {1} and your korean age is {2}",Math.Ceiling(differences[2] * 365.25 + differences[1] * 30.416 + differences[0]),
                                                                                                                   differences[1] > 0 ? differences[2] : differences[2] - 1,    
                                                                                                                   differences[2]+1);
            }
            catch
            {
                birthdateLabel.Text = "DD/MM/YYYY format where DD MM and YYYY mean numbers. Thank you for your cooperation";
            }
            
        }

        private void app_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:" + "https://www.youtube.com/watch?v=PRxdz9uNf2o")
            {
                CreateNoWindow = true
            });
            System.Windows.Forms.Application.Exit();
            // i hope this is fine
        }
    }
}
