namespace task02_dog
{


    public class Dog
    {
        string name;
        string breed;
        int age;
        string color;
        float weight;

        public Dog(string name, string breed, int age, string color, float weight)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
            this.weight = weight;
        }

        public String getName()
        {
            return name;
        }

        public String getBreed()
        {
            return breed;
        }

        public int getAge()
        {
            return age;
        }
        public String getColor()
        {
            return color;
        }

        public float getWeight()
        {
            return weight;
        }

        public float foodAmt(float weight)
        {
            float output = 0f;
            switch (weight)
            {
                case <= 5.5f:
                    //output = weight * 0.7f / 5.5f + 0.3f;
                    output = 0.3f + ((weight - 1.5f) * ((1f - 0.3f) / (5.5f - 1.5f)));
                    break;
                case <= 9.0f:
                    //output = weight * 0.3f / 9f + 1;
                    output = 1 + ((weight - 5.6f) * ((1.3f - 1) / (9f - 5.6f)));
                    break;
                case <= 15.9f:
                    //output = weight * 0.7f / 15.9f + 1.3f;
                    output = 1.3f + ((weight - 9.1f) * ((2f - 1.3f) / (15.9f - 9.1f)));
                    break;
                case <= 22.5f:
                    //output = weight * 0.6f / 22.5f + 2;
                    output = 2 + ((weight - 16f) * ((2.6f - 2f) / (22.5f - 16)));
                    break;
                case <= 34:
                    //output = weight * 0.7f / 34 + 2.6f;
                    output = 2.6f + ((weight - 22.6f) * ((3.3f - 2.6f) / (34 - 22.6f)));
                    break;
                case <= 45:
                    //output = weight * 0.95f / 34.1f + 3.3f;
                    output = 3.3f + ((weight - 34.1f) * ((4.25f - 3.3f) / (45f - 34.1f)));
                    break;
                default:
                    output = 4.25f + 0.25f * (int)((weight - 45) / 4.5f); //for linear scaling just remove the (int)
                    break;

            }

            return output;
        }

        public String dogIntroduction()
        {
            return String.Format("Hi my name is {0},\nmy breed, age and color are\n{1}, {2}, {3}",this.getName(),this.getBreed(),this.getAge(),this.getColor()) + String.Format(".\nTo feed me, give me\n{0} cups of dry food per day", this.foodAmt(this.getWeight()));
        }

    }



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void introButton_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(ageTextBox.Text);
                float weight = float.Parse(weightTextBox.Text);
                Dog newDog = new Dog(nameTextBox.Text, breedTextBox.Text, int.Parse(ageTextBox.Text), colorTextBox.Text, float.Parse(weightTextBox.Text));
                dogLabel.Text = newDog.dogIntroduction();
            }
            catch
            {
                dogLabel.Text = "Parsing error.";
            }
            
        }
    }
}