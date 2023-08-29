using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NapoleonFateTeller
{
    public partial class Form3 : Form
    {
        public static string name = "";

        public Form3()
        {
            InitializeComponent();
        }

        private void back_home_btn_Click(object sender, EventArgs e)
        {
            Form1 fns = new Form1();
            fns.showForm(this, fns);
        }
        
        private void submit_btn_Click(object sender, EventArgs e)
        {
            Form1 fns = new Form1();

            //getting the value from textbox and validate
            string username =  fns.validate(username_txtbox.Text, username_alert_lbl);
            // if the value is null, do nothing, else open next form
            if(fns.checkFill(username))
            {
                Form4 frm4 = new Form4();
                // passing the value into global variable
                name = username;
                // show form4
                fns.showForm(this, frm4);
            }
        }
    }
}
