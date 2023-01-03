namespace element_manager
{
    partial class Search
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
            this.textUpdateName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox2.IconSize = 39;
            this.iconPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 11;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.UseGdi = true;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // textUpdateName
            // 
            this.textUpdateName.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textUpdateName.Location = new System.Drawing.Point(40, 0);
            this.textUpdateName.Name = "textUpdateName";
            this.textUpdateName.Size = new System.Drawing.Size(605, 39);
            this.textUpdateName.TabIndex = 14;
            this.textUpdateName.Text = "검색어 입력";
            this.textUpdateName.TextChanged += new System.EventHandler(this.textUpdateName_TextChanged);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.textUpdateName);
            this.Controls.Add(this.iconPictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private TextBox textUpdateName;
    }
}