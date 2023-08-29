namespace NapoleonFateTeller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // SUB FUNCTIONS (supporting functions)

        // show form
        public void showForm(Form curForm, Form frm)
        {
            frm.Show();
            curForm.Hide();
        }
        // concatenate welcome word
        public string concateWelcomeWord(string src)
        {
            string result;
            if (string.IsNullOrEmpty(src))
            {
                result = "សូមស្វាគមន៍";
                return result;
            }
            else
            {
                result = $"សូមស្វាគមន៍, {src}";
                return result;
            }
        }
        // validate with alert
        public string validate(string src, Label lbl)
        {
            string result;
            if (string.IsNullOrEmpty(src))
            {
                result = "";
                lbl.Text = "require*";
                return result;
            }
            else
            {
                result = src;
                lbl.Text = "";
                return result;
            }
        }
        // check fill 
        public bool checkFill(string src)
        {
            return string.IsNullOrEmpty(src) ? false : true;
        }

        // return the sum of indices of English alphabets from a name
        public long getTotalCharIndex(string str)
        {
            string name = str.ToLower();
            long str_len = name.Length;
            long result = 0;
            char[] alphabets = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
                'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
                'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < str_len; i++)
            {
                if(!Char.IsLetter(name[i]))
                {
                    int temp_idx = 0;
                    result += temp_idx;
                } else
                {
                    int temp_idx = Array.IndexOf(alphabets, name[i]);
                    result += temp_idx;
                }
            }

            return result;
        }

        // adding total number of each digit until it goes under 10
        public long sumEachDigit(long num)
        {
            long result = 0;
            while (num != 0)
            {
                long digit = num % 10;
                num /= 10;
                result += digit;
            }
            if (result > 9)
            {
                return sumEachDigit(result);
            }
            return result;
        }

        // clear the textbox
        public void clearInput(TextBox txtbox)
        {
            txtbox.Text = "";
        }

        // -------------------------------

        private void about_app_btn_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            showForm(this, frm2);
        }

        private void start_using_btn_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            showForm(this, frm3);
        }

        private void about_dev_btn_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            showForm(this, frm5);
        }
    }
}