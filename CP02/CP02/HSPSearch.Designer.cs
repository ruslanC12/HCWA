namespace CP02
{
    partial class HSPSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.hspNameTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.HSPFound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the name of the HSP you are looking for:";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // hspNameTxtBox
            // 
            this.hspNameTxtBox.Location = new System.Drawing.Point(35, 41);
            this.hspNameTxtBox.Name = "hspNameTxtBox";
            this.hspNameTxtBox.Size = new System.Drawing.Size(224, 20);
            this.hspNameTxtBox.TabIndex = 1;
            this.hspNameTxtBox.UseWaitCursor = true;
            this.hspNameTxtBox.TextChanged += new System.EventHandler(this.HspNameTxtBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // HSPFound
            // 
            this.HSPFound.AutoSize = true;
            this.HSPFound.Location = new System.Drawing.Point(103, 129);
            this.HSPFound.Name = "HSPFound";
            this.HSPFound.Size = new System.Drawing.Size(65, 13);
            this.HSPFound.TabIndex = 5;
            this.HSPFound.Text = "HSP found: ";
            this.HSPFound.Click += new System.EventHandler(this.HSPFound_Click);
            // 
            // HSPSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 194);
            this.Controls.Add(this.HSPFound);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hspNameTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "HSPSearch";
            this.Text = "HSPSearch";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.HSPSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hspNameTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label HSPFound;
    }
}