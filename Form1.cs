namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        private string equation;
        private Queue<int> nums;
        private Queue<char> opers;

        enum Operation
        {
            None,
            Addition,
            Substraction,
            Multiplication,
            Division
        }
        

        public Form1()
        {
            this.nums = new Queue<int>();
            this.opers = new Queue<char>();
            this.equation = string.Empty;
            
            InitializeComponent();
        }

        private void Click(object sender, EventArgs e)
        {
            string Clicked_Val = (sender as Button).Text;

            if (textBox1.Text == "0")
                textBox1.Text = string.Empty;

            equation += Convert.ToChar(Clicked_Val);
            textBox1.Text += Clicked_Val;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.nums.Clear();
            this.opers.Clear();
            equation = string.Empty;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            string current_val = string.Empty;
            

            for(int i = 0; i < equation.Length; i++)
            {
                if (equation[i].Equals('+') || equation[i].Equals('-') || equation[i].Equals('/') || equation[i].Equals('*'))
                {
                    this.opers.Enqueue(equation[i]);
                    this.nums.Enqueue(Convert.ToInt32(current_val));
                    current_val = string.Empty;
                }
                else
                {
                    current_val += equation[i];
                }
                
            }

            nums.Enqueue(Convert.ToInt32(current_val));

            int result = nums.Dequeue();
            

            while (nums.Count != 0) 
            {
                char op = opers.Dequeue();

                switch(op)
                {
                    case '+': result += nums.Dequeue(); break;
                    case '-': result -= nums.Dequeue(); break;
                    case '/': result /= nums.Dequeue(); break;
                    case '*': result *= nums.Dequeue(); break;
                }

            }

            
            textBox1.Text = string.Empty;
            textBox1.Text = result.ToString();
            //nums.Enqueue(result);
            equation = result.ToString();
            
        }

        private void MathSign_Click(object sender, EventArgs e)
        {
            string operation = (sender as Button).Text;

            this.equation += operation;

            textBox1.Text += operation;
            
        }
    }
}