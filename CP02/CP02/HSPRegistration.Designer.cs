namespace CP02
{
    partial class HSPRegistration
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
            this.CompanyName = new System.Windows.Forms.Label();
            this.companyNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneNumberTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bankTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.accountNumTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.routingNumTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.companyEmailTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.loginPinTxtBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Location = new System.Drawing.Point(16, 22);
            this.CompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(188, 17);
            this.CompanyName.TabIndex = 0;
            this.CompanyName.Text = "Enter your company\'s name:";
            // 
            // companyNameTxtBox
            // 
            this.companyNameTxtBox.Location = new System.Drawing.Point(20, 42);
            this.companyNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.companyNameTxtBox.Name = "companyNameTxtBox";
            this.companyNameTxtBox.Size = new System.Drawing.Size(303, 22);
            this.companyNameTxtBox.TabIndex = 1;
            this.companyNameTxtBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Check all the services you offer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your company\'s phone number:";
            // 
            // phoneNumberTxtBox
            // 
            this.phoneNumberTxtBox.Location = new System.Drawing.Point(20, 103);
            this.phoneNumberTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberTxtBox.Name = "phoneNumberTxtBox";
            this.phoneNumberTxtBox.Size = new System.Drawing.Size(303, 22);
            this.phoneNumberTxtBox.TabIndex = 5;
            this.phoneNumberTxtBox.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter a remittance address:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(20, 223);
            this.addressTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(303, 22);
            this.addressTxtBox.TabIndex = 7;
            this.addressTxtBox.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Optionally, enter the following:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Your bank\'s name";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // bankTxtBox
            // 
            this.bankTxtBox.Location = new System.Drawing.Point(20, 383);
            this.bankTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.bankTxtBox.Name = "bankTxtBox";
            this.bankTxtBox.Size = new System.Drawing.Size(303, 22);
            this.bankTxtBox.TabIndex = 10;
            this.bankTxtBox.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 422);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Account number:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // accountNumTxtBox
            // 
            this.accountNumTxtBox.Location = new System.Drawing.Point(20, 443);
            this.accountNumTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.accountNumTxtBox.Name = "accountNumTxtBox";
            this.accountNumTxtBox.Size = new System.Drawing.Size(303, 22);
            this.accountNumTxtBox.TabIndex = 12;
            this.accountNumTxtBox.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 482);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Routing number:";
            // 
            // routingNumTxtBox
            // 
            this.routingNumTxtBox.Location = new System.Drawing.Point(20, 503);
            this.routingNumTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.routingNumTxtBox.Name = "routingNumTxtBox";
            this.routingNumTxtBox.Size = new System.Drawing.Size(303, 22);
            this.routingNumTxtBox.TabIndex = 14;
            this.routingNumTxtBox.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 604);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Enter your company\'s email address:";
            // 
            // companyEmailTxtBox
            // 
            this.companyEmailTxtBox.Location = new System.Drawing.Point(16, 163);
            this.companyEmailTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.companyEmailTxtBox.Name = "companyEmailTxtBox";
            this.companyEmailTxtBox.Size = new System.Drawing.Size(307, 22);
            this.companyEmailTxtBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 262);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Enter a login PIN:";
            // 
            // loginPinTxtBox
            // 
            this.loginPinTxtBox.Location = new System.Drawing.Point(20, 283);
            this.loginPinTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginPinTxtBox.Name = "loginPinTxtBox";
            this.loginPinTxtBox.Size = new System.Drawing.Size(303, 22);
            this.loginPinTxtBox.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 604);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 20;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Inpatient",
            "Inpatient (Behavioral Health)",
            "Emergency Room",
            "Outpatient Surgery (level 1)",
            "Outpatient Surgery (level 2)",
            "Outpatient Surgery (level 3)",
            "Diagnostic Lab & X-Ray",
            "Physician Office Visits",
            "Specialist Office Visits",
            "Preventive Services",
            "Baby Care",
            "Durable Medical Equipment",
            "Nursing Facility",
            "Physical Therapy"});
            this.checkedListBox1.Location = new System.Drawing.Point(516, 68);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(250, 242);
            this.checkedListBox1.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(463, 443);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 22);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(463, 503);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(303, 22);
            this.textBox2.TabIndex = 23;
            this.textBox2.PasswordChar = '*';
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Enter a username";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(460, 482);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Enter a password";
            // 
            // HSPRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 647);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loginPinTxtBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.companyEmailTxtBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.routingNumTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.accountNumTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bankTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneNumberTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.companyNameTxtBox);
            this.Controls.Add(this.CompanyName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HSPRegistration";
            this.Text = "HSP Registration";
            this.Load += new System.EventHandler(this.HSPRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.TextBox companyNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneNumberTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bankTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox accountNumTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox routingNumTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox companyEmailTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox loginPinTxtBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}