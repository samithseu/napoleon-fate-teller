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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // on load, show the input name
            Form1 fns = new Form1();
            string welcome_word = fns.concateWelcomeWord(Form3.name);
            welcome_alert_txtbox.Text = welcome_word;
        }

        private void guess_btn_Click(object sender, EventArgs e)
        {
            Form1 fns = new Form1();
            // validate the guessing name
            string guess_name = fns.validate(guess_input_txtbox.Text, guess_alert_lbl);
            // each index to be showned from a name
            string[] luckiness = {"តម្លៃដែលបានបញ្ចូលមិនត្រឹមត្រូវ!",
                "លេខ 1 : លោកអ្នកដែលស្ថិតក្នុងលេខនេះគឺជាមនុស្សដែលមានជោគវាសនាខ្ពស់ មានគេគោរពស្រឡាញ់រាប់អានច្រើន អនាគតអាចក្លាយជាសេដ្ឋីមានទ្រព្យសម្បត្តិស្ដុកស្ដម្ភ ។ អ្នកដែលស្ថិតនៅក្នុងជំពូកលេខ 1 នេះ ជាមនុស្សដែលមានសុខភាពរឹងមាំល្អថែមទាំងជាមនុស្សដែលមានជោគវាសនាល្អក្នុងរឿងស្នេហា និង គ្រួសារមានសុភមង្គល ។ រីឯការងារ ធ្វើអ្វីក៏ជោគជ័យដែរ ។",
                "លេខ 2 : លោកអ្នកដែលស្ថិតក្នុងលេខនេះគឺជាមនុស្សសំណាង 1 ជីវិត ទាំងស្នេហា ការងារ និងជីវិតគ្រួសារ ។ លោកអ្នកដែលនៅជំពូកនេះនឹងរស់សោយសុខលើទ្រព្យសម្បត្តិដ៏មហាសាល ។ ចំពោះសុខភាពមនុស្សជំពូកទី 2 គឺមិនងាយឈឺផ្ដាសទេ សុខភាពរឹងមាំរហូតដល់ចាស់តែម្ដង ។",
                "លេខ 3 : លោកអ្នកដែលស្ថិតនៅលេខនេះគឺជាមនុស្សដែលមនុស្សគ្រប់គ្នាងាយនឹងច្រណែន ព្រោះគាត់ជាជំពូកមនុស្សដែលគួរឲស្រឡាញ់រាប់អានពីញាតិមិត្តជិតឆ្ងាយ ឬ ថ្នាក់លើជាដើម ។",
                "លេខ 4 : លោកអ្នកដែលស្ថិតនៅលេខ 4 គឺជាមនុស្ស ដែលនឹងទទួលបានទ្រព្យសម្បត្តិហូរចូលភ្លូកទឹកភ្លូកដីឆាប់ៗ ។ គ្រប់ការងារ មុខរបរ នឹងទទួលបានជោគជ័យទាំងអស់ ឯការបរាជ័យតិចបំផុតស្ទើរគ្មាន ។",
                "លេខ 5 : លោកអ្នកដែលស្ថិតនៅលេខ 5 ជាមនុស្សដែល​ឧស្សាហ៍ព្យាយាម ហើយអ្វីដែលពួកគាត់ធ្វើរមែងផ្ដល់ផលឲគាត់យ៉ាងអស្ចារ្យក្នុងឆាកជីវិត ។ ទ្រព្យសម្បត្តិ របស់មនុស្សជំពូកនេះនឹងស្ថិតនៅលេខរៀងខ្ពស់ ។ រីឯរឿងជីវិតរស់នៅគឺមានសេចក្ដីសុខ សុភមង្គល ជំងឺនឹងរត់ចេញ ឆ្ងាយមិនសូវហ៊ានមកក្បែរទេ ។",
                "លេខ 6 : លោកអ្នកដែលស្ថិតនៅលេខ 6 ជាមនុស្សដែលមានសម្ពាយបុណ្យពីជាតិមុន រួមមានទ្រព្យមហាសាល ដែលនឹងហូរចូលដូចទឹកបាក់ទំនប់ មករកម្ចាស់ដើម ។ ការងារ ស្នេហា គ្រួសារ មានភាពរលូន សុភមង្គលល្អ ជាទីច្រណែនពីអ្នកដទៃ ។",
                "លេខ 7 : លោកអ្នកដែលស្ថិតនៅលេខ 7 ជាជំពូកមនុស្សដែលមានកិត្តិយសខ្ពង់ខ្ពស់ វណ្ណៈសេដ្ឋី មានប្រាក់រាប់លាន ។ មានភព្វសំណាងខ្ពស់ ក្នុងជីវិតការងារ ស្នេហា សុខភាព គឺល្អដើរទន្ទឹមគ្នា ។",
                "លេខ 8 : លោកអ្នកដែលស្ថិតនៅលេខ 8 គឺជាមនុស្សដែលចេះ ជួយយកអាសារអ្នកដទៃ ដែលធ្វើឲមនុស្សនេះជួបតែសំណាងល្អក្នុងឆាកជីវិត ។ ទៅណាមកណាមានគេស្រឡាញ់រាប់អានច្រើន ដែលធ្វើឲការងារ ឬមុខរបរដែលគេកំពុងធ្វើងាយនឹងទទួលបានជោគជ័យ ។ រឿងស្នេហាគឺថាផ្អែមល្ហែមគ្មានអ្វីឲមនុស្សលេខ 8 សោកសៅឡើយ ។ ទ្រព្យសម្បត្តិក្រាលដេក ។",
                "លេខ 9 : លោកអ្នកដែលស្ថិតនៅលេខ 9 ជាលេខដែលខ្ពស់ជាងគេ រាសីវិញក៏ខ្ពស់ដែរ លុយកាក់ចាយមិនអស់ ចង់បានអ្វីបានហ្នឹង សំរាប់ឆាកជីវិតរបស់គេ ។ ស្នេហា ការងារ សុខភាព ក៏ល្អរកអ្វីមកផ្ទឹមពុំបាន ។"
            };
            
            // if there is no name, do nothing
            if (fns.checkFill(guess_name))
            {
                // error handling
                try
                {
                    // get total indices from a name
                    long total_index = fns.getTotalCharIndex(guess_name);
                    // sum each digit together
                    long lucky_num = fns.sumEachDigit(total_index);
                    // that SUM digit represent the luckiness.
                    result_show_txtbox.Text = luckiness[lucky_num];
                    // clear input
                    fns.clearInput(guess_input_txtbox);
                    // auto select input box
                    guess_input_txtbox.Select();
                } catch 
                {
                    result_show_txtbox.Text = "តម្លៃដែលបានបញ្ចូលមិនត្រឹមត្រូវ!";
                    fns.clearInput(guess_input_txtbox);
                    guess_input_txtbox.Select();
                }

            }
        }

        private void back_home_btn_Click(object sender, EventArgs e)
        {
            Form1 fns = new Form1();
            fns.showForm(this, fns);
        }

        private void close_app_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            guess_input_txtbox.Text = "";
            result_show_txtbox.Text = "មិនទាន់បានបញ្ចូលតម្លៃ!";
        }
    }
}
