namespace NapoleonFateTeller
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.guess_input_txtbox = new System.Windows.Forms.TextBox();
            this.guess_btn = new System.Windows.Forms.Button();
            this.result_show_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcome_alert_txtbox = new System.Windows.Forms.TextBox();
            this.guess_alert_lbl = new System.Windows.Forms.Label();
            this.back_home_btn = new System.Windows.Forms.Button();
            this.close_app_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Krasar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "សូមបញ្ចូលឈ្មោះដែលអ្នកចង់ទស្សន៍ទាយ ៖";
            // 
            // guess_input_txtbox
            // 
            this.guess_input_txtbox.BackColor = System.Drawing.Color.Black;
            this.guess_input_txtbox.Font = new System.Drawing.Font("Krasar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guess_input_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.guess_input_txtbox.Location = new System.Drawing.Point(72, 238);
            this.guess_input_txtbox.Name = "guess_input_txtbox";
            this.guess_input_txtbox.PlaceholderText = "បញ្ចូលឈ្មោះ... (ex : SOK SOVANN)";
            this.guess_input_txtbox.Size = new System.Drawing.Size(424, 45);
            this.guess_input_txtbox.TabIndex = 1;
            // 
            // guess_btn
            // 
            this.guess_btn.BackColor = System.Drawing.Color.Gold;
            this.guess_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guess_btn.Font = new System.Drawing.Font("Krasar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guess_btn.ForeColor = System.Drawing.Color.Black;
            this.guess_btn.Location = new System.Drawing.Point(72, 339);
            this.guess_btn.Name = "guess_btn";
            this.guess_btn.Size = new System.Drawing.Size(170, 50);
            this.guess_btn.TabIndex = 2;
            this.guess_btn.Text = "ទស្សន៍ទាយ";
            this.guess_btn.UseVisualStyleBackColor = false;
            this.guess_btn.Click += new System.EventHandler(this.guess_btn_Click);
            // 
            // result_show_txtbox
            // 
            this.result_show_txtbox.BackColor = System.Drawing.Color.Black;
            this.result_show_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_show_txtbox.Font = new System.Drawing.Font("Krasar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_show_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.result_show_txtbox.Location = new System.Drawing.Point(588, 228);
            this.result_show_txtbox.Multiline = true;
            this.result_show_txtbox.Name = "result_show_txtbox";
            this.result_show_txtbox.ReadOnly = true;
            this.result_show_txtbox.Size = new System.Drawing.Size(602, 299);
            this.result_show_txtbox.TabIndex = 5;
            this.result_show_txtbox.Text = "មិនទាន់បានបញ្ចូលតម្លៃ!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Krasar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(588, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "លទ្ធផល ៖";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 2);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // welcome_alert_txtbox
            // 
            this.welcome_alert_txtbox.BackColor = System.Drawing.Color.Black;
            this.welcome_alert_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.welcome_alert_txtbox.Font = new System.Drawing.Font("Krasar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcome_alert_txtbox.ForeColor = System.Drawing.Color.Gold;
            this.welcome_alert_txtbox.Location = new System.Drawing.Point(12, 32);
            this.welcome_alert_txtbox.Name = "welcome_alert_txtbox";
            this.welcome_alert_txtbox.Size = new System.Drawing.Size(1238, 38);
            this.welcome_alert_txtbox.TabIndex = 8;
            this.welcome_alert_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guess_alert_lbl
            // 
            this.guess_alert_lbl.AutoSize = true;
            this.guess_alert_lbl.BackColor = System.Drawing.Color.Transparent;
            this.guess_alert_lbl.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guess_alert_lbl.ForeColor = System.Drawing.Color.Red;
            this.guess_alert_lbl.Location = new System.Drawing.Point(405, 204);
            this.guess_alert_lbl.Name = "guess_alert_lbl";
            this.guess_alert_lbl.Size = new System.Drawing.Size(0, 31);
            this.guess_alert_lbl.TabIndex = 9;
            // 
            // back_home_btn
            // 
            this.back_home_btn.BackColor = System.Drawing.Color.Gold;
            this.back_home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_home_btn.Font = new System.Drawing.Font("Krasar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_home_btn.ForeColor = System.Drawing.Color.Black;
            this.back_home_btn.Location = new System.Drawing.Point(72, 570);
            this.back_home_btn.Name = "back_home_btn";
            this.back_home_btn.Size = new System.Drawing.Size(424, 50);
            this.back_home_btn.TabIndex = 4;
            this.back_home_btn.Text = "ទំព័រដើម";
            this.back_home_btn.UseVisualStyleBackColor = false;
            this.back_home_btn.Click += new System.EventHandler(this.back_home_btn_Click);
            // 
            // close_app_btn
            // 
            this.close_app_btn.BackColor = System.Drawing.Color.Maroon;
            this.close_app_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_app_btn.Font = new System.Drawing.Font("Krasar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close_app_btn.ForeColor = System.Drawing.Color.White;
            this.close_app_btn.Location = new System.Drawing.Point(1020, 570);
            this.close_app_btn.Name = "close_app_btn";
            this.close_app_btn.Size = new System.Drawing.Size(170, 50);
            this.close_app_btn.TabIndex = 5;
            this.close_app_btn.Text = "បិទកម្មវិធី";
            this.close_app_btn.UseVisualStyleBackColor = false;
            this.close_app_btn.Click += new System.EventHandler(this.close_app_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.Gold;
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.Font = new System.Drawing.Font("Krasar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear_btn.ForeColor = System.Drawing.Color.Black;
            this.clear_btn.Location = new System.Drawing.Point(326, 339);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(170, 50);
            this.clear_btn.TabIndex = 3;
            this.clear_btn.Text = "សម្អាត";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.close_app_btn);
            this.Controls.Add(this.back_home_btn);
            this.Controls.Add(this.guess_alert_lbl);
            this.Controls.Add(this.welcome_alert_txtbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result_show_txtbox);
            this.Controls.Add(this.guess_btn);
            this.Controls.Add(this.guess_input_txtbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Napoleon Fate Teller, Input your name to know your luck!";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox guess_input_txtbox;
        private Button guess_btn;
        private TextBox result_show_txtbox;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox welcome_alert_txtbox;
        private Label guess_alert_lbl;
        private Button back_home_btn;
        private Button close_app_btn;
        private Button clear_btn;
    }
}