namespace element_manager
{
    partial class UserUpdate
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
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.Upload_Btn = new System.Windows.Forms.Button();
            this.textUpdateName = new System.Windows.Forms.TextBox();
            this.textUpdateId = new System.Windows.Forms.TextBox();
            this.SignUp_Btn = new System.Windows.Forms.Button();
            this.textUpdateEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textIntro = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SU_man_rb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textUpdatePhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFindAdr = new System.Windows.Forms.Button();
            this.signUpLink = new System.Windows.Forms.LinkLabel();
            this.btnUpdatePw = new System.Windows.Forms.Button();
            this.btnUpdateConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.HotTrack;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox2.IconSize = 84;
            this.iconPictureBox2.Location = new System.Drawing.Point(52, 12);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(117, 84);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 10;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.UseGdi = true;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // Upload_Btn
            // 
            this.Upload_Btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Upload_Btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Upload_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Upload_Btn.Location = new System.Drawing.Point(65, 102);
            this.Upload_Btn.Name = "Upload_Btn";
            this.Upload_Btn.Size = new System.Drawing.Size(90, 25);
            this.Upload_Btn.TabIndex = 12;
            this.Upload_Btn.Text = "업로드";
            this.Upload_Btn.UseVisualStyleBackColor = false;
            this.Upload_Btn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // textUpdateName
            // 
            this.textUpdateName.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textUpdateName.Location = new System.Drawing.Point(206, 10);
            this.textUpdateName.Name = "textUpdateName";
            this.textUpdateName.Size = new System.Drawing.Size(200, 35);
            this.textUpdateName.TabIndex = 13;
            this.textUpdateName.TextChanged += new System.EventHandler(this.SU_ID_text_TextChanged);
            // 
            // textUpdateId
            // 
            this.textUpdateId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textUpdateId.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textUpdateId.Location = new System.Drawing.Point(206, 51);
            this.textUpdateId.Name = "textUpdateId";
            this.textUpdateId.Size = new System.Drawing.Size(290, 35);
            this.textUpdateId.TabIndex = 14;
            this.textUpdateId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SignUp_Btn
            // 
            this.SignUp_Btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SignUp_Btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SignUp_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignUp_Btn.Location = new System.Drawing.Point(416, 10);
            this.SignUp_Btn.Name = "SignUp_Btn";
            this.SignUp_Btn.Size = new System.Drawing.Size(80, 35);
            this.SignUp_Btn.TabIndex = 24;
            this.SignUp_Btn.Text = "중복 확인";
            this.SignUp_Btn.UseVisualStyleBackColor = false;
            // 
            // textUpdateEmail
            // 
            this.textUpdateEmail.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textUpdateEmail.Location = new System.Drawing.Point(206, 89);
            this.textUpdateEmail.Name = "textUpdateEmail";
            this.textUpdateEmail.Size = new System.Drawing.Size(290, 35);
            this.textUpdateEmail.TabIndex = 25;
            this.textUpdateEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(513, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 530);
            this.panel1.TabIndex = 26;
            // 
            // textIntro
            // 
            this.textIntro.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textIntro.Location = new System.Drawing.Point(12, 133);
            this.textIntro.Multiline = true;
            this.textIntro.Name = "textIntro";
            this.textIntro.Size = new System.Drawing.Size(485, 186);
            this.textIntro.TabIndex = 27;
            this.textIntro.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(10, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 2);
            this.panel2.TabIndex = 28;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(425, 336);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 28);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "여자";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SU_man_rb
            // 
            this.SU_man_rb.AutoSize = true;
            this.SU_man_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SU_man_rb.Location = new System.Drawing.Point(325, 336);
            this.SU_man_rb.Name = "SU_man_rb";
            this.SU_man_rb.Size = new System.Drawing.Size(58, 28);
            this.SU_man_rb.TabIndex = 30;
            this.SU_man_rb.TabStop = true;
            this.SU_man_rb.Text = "남자";
            this.SU_man_rb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = "성별";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textUpdatePhone
            // 
            this.textUpdatePhone.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textUpdatePhone.Location = new System.Drawing.Point(315, 374);
            this.textUpdatePhone.Name = "textUpdatePhone";
            this.textUpdatePhone.Size = new System.Drawing.Size(180, 35);
            this.textUpdatePhone.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "연락처";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(10, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 27);
            this.label3.TabIndex = 35;
            this.label3.Text = "주소";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(163, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 27);
            this.textBox1.TabIndex = 34;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnFindAdr
            // 
            this.btnFindAdr.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFindAdr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFindAdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFindAdr.Location = new System.Drawing.Point(415, 424);
            this.btnFindAdr.Name = "btnFindAdr";
            this.btnFindAdr.Size = new System.Drawing.Size(80, 29);
            this.btnFindAdr.TabIndex = 36;
            this.btnFindAdr.Text = "중복 확인";
            this.btnFindAdr.UseVisualStyleBackColor = false;
            this.btnFindAdr.Click += new System.EventHandler(this.btnFindAdr_Click);
            // 
            // signUpLink
            // 
            this.signUpLink.ActiveLinkColor = System.Drawing.Color.White;
            this.signUpLink.AutoSize = true;
            this.signUpLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpLink.LinkColor = System.Drawing.Color.DarkGray;
            this.signUpLink.Location = new System.Drawing.Point(12, 515);
            this.signUpLink.Name = "signUpLink";
            this.signUpLink.Size = new System.Drawing.Size(64, 18);
            this.signUpLink.TabIndex = 37;
            this.signUpLink.TabStop = true;
            this.signUpLink.Text = "회원 탈퇴";
            this.signUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLink_LinkClicked);
            // 
            // btnUpdatePw
            // 
            this.btnUpdatePw.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdatePw.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdatePw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatePw.Location = new System.Drawing.Point(308, 512);
            this.btnUpdatePw.Name = "btnUpdatePw";
            this.btnUpdatePw.Size = new System.Drawing.Size(91, 27);
            this.btnUpdatePw.TabIndex = 38;
            this.btnUpdatePw.Text = "패스워드 변경";
            this.btnUpdatePw.UseVisualStyleBackColor = false;
            this.btnUpdatePw.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnUpdateConfirm
            // 
            this.btnUpdateConfirm.AllowDrop = true;
            this.btnUpdateConfirm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdateConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdateConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUpdateConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnUpdateConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateConfirm.Location = new System.Drawing.Point(417, 512);
            this.btnUpdateConfirm.Name = "btnUpdateConfirm";
            this.btnUpdateConfirm.Size = new System.Drawing.Size(80, 27);
            this.btnUpdateConfirm.TabIndex = 39;
            this.btnUpdateConfirm.Text = "정보 수정";
            this.btnUpdateConfirm.UseVisualStyleBackColor = false;
            this.btnUpdateConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(556, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 27);
            this.label4.TabIndex = 42;
            this.label4.Text = "회원 상태";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(521, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 27);
            this.label5.TabIndex = 41;
            this.label5.Text = "등록 엘리먼트";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(536, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 27);
            this.label6.TabIndex = 40;
            this.label6.Text = "회원 유형";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(641, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 35);
            this.textBox2.TabIndex = 43;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(641, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 35);
            this.textBox3.TabIndex = 44;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(641, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 35);
            this.textBox4.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(585, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Joined in 2022. 10. 17";
            // 
            // UserUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdateConfirm);
            this.Controls.Add(this.btnUpdatePw);
            this.Controls.Add(this.signUpLink);
            this.Controls.Add(this.btnFindAdr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textUpdatePhone);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.SU_man_rb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textIntro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textUpdateEmail);
            this.Controls.Add(this.SignUp_Btn);
            this.Controls.Add(this.textUpdateId);
            this.Controls.Add(this.textUpdateName);
            this.Controls.Add(this.Upload_Btn);
            this.Controls.Add(this.iconPictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserUpdate";
            this.Text = "UserUpdate";
            this.Load += new System.EventHandler(this.UserUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Button Upload_Btn;
        private TextBox textUpdateName;
        private TextBox textUpdateId;
        private Button SignUp_Btn;
        private TextBox textUpdateEmail;
        private Panel panel1;
        private TextBox textIntro;
        private Panel panel2;
        private RadioButton radioButton1;
        private RadioButton SU_man_rb;
        private Label label1;
        private TextBox textUpdatePhone;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button btnFindAdr;
        private LinkLabel signUpLink;
        private Button btnUpdatePw;
        private Button btnUpdateConfirm;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label7;
    }
}