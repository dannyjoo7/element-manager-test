namespace element_manager
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.minButton = new FontAwesome.Sharp.IconButton();
            this.SignUplabel = new System.Windows.Forms.Label();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.maxButton = new FontAwesome.Sharp.IconButton();
            this.SU_Id_label = new System.Windows.Forms.Label();
            this.SU_ID_text = new System.Windows.Forms.TextBox();
            this.SU_Pw_text = new System.Windows.Forms.TextBox();
            this.SU_Pw_label = new System.Windows.Forms.Label();
            this.SU_Name_text = new System.Windows.Forms.TextBox();
            this.SU_Name_label = new System.Windows.Forms.Label();
            this.SU_VerPw_text = new System.Windows.Forms.TextBox();
            this.SU_VerPw_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SU_man_rb = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SU_addr_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SU_phone_label = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SU_email_label = new System.Windows.Forms.Label();
            this.SignUp_Btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.minButton);
            this.panel1.Controls.Add(this.SignUplabel);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.maxButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 50);
            this.panel1.TabIndex = 2;
            // 
            // minButton
            // 
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minButton.IconColor = System.Drawing.Color.White;
            this.minButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.minButton.IconSize = 20;
            this.minButton.Location = new System.Drawing.Point(246, 12);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(25, 25);
            this.minButton.TabIndex = 4;
            this.minButton.UseVisualStyleBackColor = true;
            // 
            // SignUplabel
            // 
            this.SignUplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignUplabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SignUplabel.Location = new System.Drawing.Point(0, 0);
            this.SignUplabel.Name = "SignUplabel";
            this.SignUplabel.Size = new System.Drawing.Size(91, 50);
            this.SignUplabel.TabIndex = 0;
            this.SignUplabel.Text = "SignUp";
            this.SignUplabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.X;
            this.closeButton.IconColor = System.Drawing.Color.White;
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.closeButton.IconSize = 20;
            this.closeButton.Location = new System.Drawing.Point(302, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.FlatAppearance.BorderSize = 0;
            this.maxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxButton.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.maxButton.IconColor = System.Drawing.Color.White;
            this.maxButton.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.maxButton.IconSize = 20;
            this.maxButton.Location = new System.Drawing.Point(274, 12);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(25, 25);
            this.maxButton.TabIndex = 3;
            this.maxButton.UseVisualStyleBackColor = true;
            // 
            // SU_Id_label
            // 
            this.SU_Id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SU_Id_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SU_Id_label.Location = new System.Drawing.Point(22, 74);
            this.SU_Id_label.Name = "SU_Id_label";
            this.SU_Id_label.Size = new System.Drawing.Size(47, 20);
            this.SU_Id_label.TabIndex = 6;
            this.SU_Id_label.Text = "아이디";
            this.SU_Id_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SU_ID_text
            // 
            this.SU_ID_text.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SU_ID_text.Location = new System.Drawing.Point(22, 97);
            this.SU_ID_text.Name = "SU_ID_text";
            this.SU_ID_text.Size = new System.Drawing.Size(286, 43);
            this.SU_ID_text.TabIndex = 7;
            // 
            // SU_Pw_text
            // 
            this.SU_Pw_text.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SU_Pw_text.Location = new System.Drawing.Point(22, 172);
            this.SU_Pw_text.Name = "SU_Pw_text";
            this.SU_Pw_text.Size = new System.Drawing.Size(286, 43);
            this.SU_Pw_text.TabIndex = 9;
            // 
            // SU_Pw_label
            // 
            this.SU_Pw_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SU_Pw_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SU_Pw_label.Location = new System.Drawing.Point(22, 149);
            this.SU_Pw_label.Name = "SU_Pw_label";
            this.SU_Pw_label.Size = new System.Drawing.Size(69, 20);
            this.SU_Pw_label.TabIndex = 8;
            this.SU_Pw_label.Text = "비밀번호";
            this.SU_Pw_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SU_Name_text
            // 
            this.SU_Name_text.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SU_Name_text.Location = new System.Drawing.Point(22, 323);
            this.SU_Name_text.Name = "SU_Name_text";
            this.SU_Name_text.Size = new System.Drawing.Size(286, 43);
            this.SU_Name_text.TabIndex = 13;
            // 
            // SU_Name_label
            // 
            this.SU_Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SU_Name_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SU_Name_label.Location = new System.Drawing.Point(22, 300);
            this.SU_Name_label.Name = "SU_Name_label";
            this.SU_Name_label.Size = new System.Drawing.Size(37, 20);
            this.SU_Name_label.TabIndex = 12;
            this.SU_Name_label.Text = "이름";
            this.SU_Name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SU_VerPw_text
            // 
            this.SU_VerPw_text.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SU_VerPw_text.Location = new System.Drawing.Point(22, 248);
            this.SU_VerPw_text.Name = "SU_VerPw_text";
            this.SU_VerPw_text.Size = new System.Drawing.Size(286, 43);
            this.SU_VerPw_text.TabIndex = 11;
            // 
            // SU_VerPw_label
            // 
            this.SU_VerPw_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SU_VerPw_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SU_VerPw_label.Location = new System.Drawing.Point(22, 225);
            this.SU_VerPw_label.Name = "SU_VerPw_label";
            this.SU_VerPw_label.Size = new System.Drawing.Size(92, 20);
            this.SU_VerPw_label.TabIndex = 10;
            this.SU_VerPw_label.Text = "비밀번호 확인";
            this.SU_VerPw_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "성별";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SU_man_rb
            // 
            this.SU_man_rb.AutoSize = true;
            this.SU_man_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SU_man_rb.Location = new System.Drawing.Point(56, 417);
            this.SU_man_rb.Name = "SU_man_rb";
            this.SU_man_rb.Size = new System.Drawing.Size(58, 28);
            this.SU_man_rb.TabIndex = 15;
            this.SU_man_rb.TabStop = true;
            this.SU_man_rb.Text = "남자";
            this.SU_man_rb.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(200, 417);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 28);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "여자";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(22, 646);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 43);
            this.textBox1.TabIndex = 22;
            // 
            // SU_addr_label
            // 
            this.SU_addr_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SU_addr_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SU_addr_label.Location = new System.Drawing.Point(22, 623);
            this.SU_addr_label.Name = "SU_addr_label";
            this.SU_addr_label.Size = new System.Drawing.Size(37, 20);
            this.SU_addr_label.TabIndex = 21;
            this.SU_addr_label.Text = "주소";
            this.SU_addr_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(22, 571);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(286, 43);
            this.textBox2.TabIndex = 20;
            // 
            // SU_phone_label
            // 
            this.SU_phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SU_phone_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SU_phone_label.Location = new System.Drawing.Point(22, 548);
            this.SU_phone_label.Name = "SU_phone_label";
            this.SU_phone_label.Size = new System.Drawing.Size(47, 20);
            this.SU_phone_label.TabIndex = 19;
            this.SU_phone_label.Text = "연락처";
            this.SU_phone_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(22, 495);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(286, 43);
            this.textBox3.TabIndex = 18;
            // 
            // SU_email_label
            // 
            this.SU_email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SU_email_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SU_email_label.Location = new System.Drawing.Point(22, 472);
            this.SU_email_label.Name = "SU_email_label";
            this.SU_email_label.Size = new System.Drawing.Size(81, 20);
            this.SU_email_label.TabIndex = 17;
            this.SU_email_label.Text = "이메일 주소";
            this.SU_email_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SignUp_Btn
            // 
            this.SignUp_Btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SignUp_Btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SignUp_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignUp_Btn.Location = new System.Drawing.Point(22, 720);
            this.SignUp_Btn.Name = "SignUp_Btn";
            this.SignUp_Btn.Size = new System.Drawing.Size(286, 44);
            this.SignUp_Btn.TabIndex = 23;
            this.SignUp_Btn.Text = "Sign Up";
            this.SignUp_Btn.UseVisualStyleBackColor = false;
            this.SignUp_Btn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 800);
            this.Controls.Add(this.SignUp_Btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SU_addr_label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SU_phone_label);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.SU_email_label);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.SU_man_rb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SU_Name_text);
            this.Controls.Add(this.SU_Name_label);
            this.Controls.Add(this.SU_VerPw_text);
            this.Controls.Add(this.SU_VerPw_label);
            this.Controls.Add(this.SU_Pw_text);
            this.Controls.Add(this.SU_Pw_label);
            this.Controls.Add(this.SU_ID_text);
            this.Controls.Add(this.SU_Id_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton minButton;
        private Label SignUplabel;
        private FontAwesome.Sharp.IconButton closeButton;
        private FontAwesome.Sharp.IconButton maxButton;
        private Label SU_Id_label;
        private TextBox SU_ID_text;
        private TextBox SU_Pw_text;
        private Label SU_Pw_label;
        private TextBox SU_Name_text;
        private Label SU_Name_label;
        private TextBox SU_VerPw_text;
        private Label SU_VerPw_label;
        private Label label1;
        private RadioButton SU_man_rb;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private Label SU_addr_label;
        private TextBox textBox2;
        private Label SU_phone_label;
        private TextBox textBox3;
        private Label SU_email_label;
        private Button SignUp_Btn;
    }
}