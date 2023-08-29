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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void back_home_btn_Click(object sender, EventArgs e)
        {
            Form1 fns = new Form1();
            fns.showForm(this, fns);
        }
    }
}
