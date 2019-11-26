namespace WindowsApplication
{
    partial class CreateBookmark
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
            this.tbNameBookmark = new System.Windows.Forms.TextBox();
            this.mtbStart = new System.Windows.Forms.MaskedTextBox();
            this.mtbFinish = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStart = new System.Windows.Forms.CheckBox();
            this.cbFinish = new System.Windows.Forms.CheckBox();
            this.buCancel = new System.Windows.Forms.Button();
            this.buSaveBookmark = new System.Windows.Forms.Button();
            this.buColorSet = new System.Windows.Forms.Button();
            this.laColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNameBookmark
            // 
            this.tbNameBookmark.BackColor = System.Drawing.Color.White;
            this.tbNameBookmark.ForeColor = System.Drawing.Color.Gray;
            this.tbNameBookmark.Location = new System.Drawing.Point(12, 12);
            this.tbNameBookmark.Name = "tbNameBookmark";
            this.tbNameBookmark.Size = new System.Drawing.Size(288, 20);
            this.tbNameBookmark.TabIndex = 0;
            this.tbNameBookmark.Text = "Введите название закладки";
            this.tbNameBookmark.Enter += new System.EventHandler(this.tbNameBookmark_Enter);
            this.tbNameBookmark.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // mtbStart
            // 
            this.mtbStart.Location = new System.Drawing.Point(56, 38);
            this.mtbStart.Mask = "00:00";
            this.mtbStart.Name = "mtbStart";
            this.mtbStart.Size = new System.Drawing.Size(34, 20);
            this.mtbStart.TabIndex = 1;
            this.mtbStart.ValidatingType = typeof(System.DateTime);
            this.mtbStart.Enter += new System.EventHandler(this.mtb_Enter);
            // 
            // mtbFinish
            // 
            this.mtbFinish.Location = new System.Drawing.Point(56, 64);
            this.mtbFinish.Mask = "00:00";
            this.mtbFinish.Name = "mtbFinish";
            this.mtbFinish.Size = new System.Drawing.Size(34, 20);
            this.mtbFinish.TabIndex = 2;
            this.mtbFinish.ValidatingType = typeof(System.DateTime);
            this.mtbFinish.Enter += new System.EventHandler(this.mtb_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Начало:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Конец:";
            // 
            // cbStart
            // 
            this.cbStart.AutoSize = true;
            this.cbStart.Location = new System.Drawing.Point(120, 41);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(180, 17);
            this.cbStart.TabIndex = 5;
            this.cbStart.Text = "Текущее положение ползунка";
            this.cbStart.UseVisualStyleBackColor = true;
            this.cbStart.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            // 
            // cbFinish
            // 
            this.cbFinish.AutoSize = true;
            this.cbFinish.Location = new System.Drawing.Point(120, 67);
            this.cbFinish.Name = "cbFinish";
            this.cbFinish.Size = new System.Drawing.Size(180, 17);
            this.cbFinish.TabIndex = 6;
            this.cbFinish.Text = "Текущее положение ползунка";
            this.cbFinish.UseVisualStyleBackColor = true;
            this.cbFinish.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            // 
            // buCancel
            // 
            this.buCancel.Location = new System.Drawing.Point(10, 126);
            this.buCancel.Name = "buCancel";
            this.buCancel.Size = new System.Drawing.Size(129, 23);
            this.buCancel.TabIndex = 7;
            this.buCancel.Text = "Отменить";
            this.buCancel.UseVisualStyleBackColor = true;
            this.buCancel.Click += new System.EventHandler(this.buCancel_Click);
            // 
            // buSaveBookmark
            // 
            this.buSaveBookmark.Location = new System.Drawing.Point(169, 126);
            this.buSaveBookmark.Name = "buSaveBookmark";
            this.buSaveBookmark.Size = new System.Drawing.Size(129, 23);
            this.buSaveBookmark.TabIndex = 8;
            this.buSaveBookmark.Text = "Сохранить";
            this.buSaveBookmark.UseVisualStyleBackColor = true;
            this.buSaveBookmark.Click += new System.EventHandler(this.buSaveBookmark_Click);
            // 
            // buColorSet
            // 
            this.buColorSet.Location = new System.Drawing.Point(10, 97);
            this.buColorSet.Name = "buColorSet";
            this.buColorSet.Size = new System.Drawing.Size(129, 23);
            this.buColorSet.TabIndex = 9;
            this.buColorSet.Text = "Цвет";
            this.buColorSet.UseVisualStyleBackColor = true;
            this.buColorSet.Click += new System.EventHandler(this.buColorSet_Click);
            // 
            // laColor
            // 
            this.laColor.AutoSize = true;
            this.laColor.Location = new System.Drawing.Point(145, 102);
            this.laColor.Name = "laColor";
            this.laColor.Size = new System.Drawing.Size(15, 13);
            this.laColor.TabIndex = 10;
            this.laColor.Text = "lc";
            // 
            // CreateBookmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buCancel;
            this.ClientSize = new System.Drawing.Size(312, 152);
            this.Controls.Add(this.laColor);
            this.Controls.Add(this.buColorSet);
            this.Controls.Add(this.buSaveBookmark);
            this.Controls.Add(this.buCancel);
            this.Controls.Add(this.cbFinish);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbFinish);
            this.Controls.Add(this.mtbStart);
            this.Controls.Add(this.tbNameBookmark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(328, 191);
            this.MinimumSize = new System.Drawing.Size(328, 191);
            this.Name = "CreateBookmark";
            this.ShowIcon = false;
            this.Text = "Создать закладку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNameBookmark;
        private System.Windows.Forms.MaskedTextBox mtbStart;
        private System.Windows.Forms.MaskedTextBox mtbFinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbStart;
        private System.Windows.Forms.CheckBox cbFinish;
        private System.Windows.Forms.Button buCancel;
        private System.Windows.Forms.Button buSaveBookmark;
        private System.Windows.Forms.Button buColorSet;
        private System.Windows.Forms.Label laColor;
    }
}