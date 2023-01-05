namespace element_manager
{
    partial class UserList
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.picture = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnPermit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Location = new System.Drawing.Point(10, 10);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(80, 80);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(118, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(564, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "username";
            // 
            // lblCompany
            // 
            this.lblCompany.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCompany.Location = new System.Drawing.Point(121, 46);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(560, 15);
            this.lblCompany.TabIndex = 2;
            this.lblCompany.Text = "company";
            // 
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(617, 74);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnPermit
            // 
            this.btnPermit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPermit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermit.Location = new System.Drawing.Point(698, 74);
            this.btnPermit.Name = "btnPermit";
            this.btnPermit.Size = new System.Drawing.Size(75, 23);
            this.btnPermit.TabIndex = 4;
            this.btnPermit.Text = "승인";
            this.btnPermit.UseVisualStyleBackColor = false;
            this.btnPermit.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.picture);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 5;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPermit);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblName);
            this.Name = "UserList";
            this.Size = new System.Drawing.Size(776, 100);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picture;
        private Label lblName;
        private Label lblCompany;
        private Button btnInfo;
        private Button btnPermit;
        private Panel panel1;
    }
}
