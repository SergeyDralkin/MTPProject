namespace SideBar
{
    partial class Playlist
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tc = new System.Windows.Forms.TabControl();
            this.tpPlaylist = new System.Windows.Forms.TabPage();
            this.buAdd = new System.Windows.Forms.Button();
            this.lbPlaylist = new System.Windows.Forms.ListBox();
            this.tpBookmarks = new System.Windows.Forms.TabPage();
            this.buDel = new System.Windows.Forms.Button();
            this.buTest = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buSave = new System.Windows.Forms.Button();
            this.tc.SuspendLayout();
            this.tpPlaylist.SuspendLayout();
            this.tpBookmarks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpPlaylist);
            this.tc.Controls.Add(this.tpBookmarks);
            this.tc.Location = new System.Drawing.Point(12, 12);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(321, 629);
            this.tc.TabIndex = 0;
            // 
            // tpPlaylist
            // 
            this.tpPlaylist.Controls.Add(this.buAdd);
            this.tpPlaylist.Controls.Add(this.lbPlaylist);
            this.tpPlaylist.Location = new System.Drawing.Point(4, 22);
            this.tpPlaylist.Name = "tpPlaylist";
            this.tpPlaylist.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlaylist.Size = new System.Drawing.Size(313, 603);
            this.tpPlaylist.TabIndex = 0;
            this.tpPlaylist.Text = "Плейлист";
            this.tpPlaylist.UseVisualStyleBackColor = true;
            // 
            // buAdd
            // 
            this.buAdd.Location = new System.Drawing.Point(6, 574);
            this.buAdd.Name = "buAdd";
            this.buAdd.Size = new System.Drawing.Size(301, 23);
            this.buAdd.TabIndex = 1;
            this.buAdd.Text = "Добавить";
            this.buAdd.UseVisualStyleBackColor = true;
            this.buAdd.Click += new System.EventHandler(this.buAdd_Click);
            // 
            // lbPlaylist
            // 
            this.lbPlaylist.FormattingEnabled = true;
            this.lbPlaylist.Location = new System.Drawing.Point(6, 6);
            this.lbPlaylist.Name = "lbPlaylist";
            this.lbPlaylist.Size = new System.Drawing.Size(301, 563);
            this.lbPlaylist.TabIndex = 0;
            this.lbPlaylist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbPlaylist_MouseDoubleClick);
            // 
            // tpBookmarks
            // 
            this.tpBookmarks.Controls.Add(this.buDel);
            this.tpBookmarks.Controls.Add(this.buTest);
            this.tpBookmarks.Controls.Add(this.lv);
            this.tpBookmarks.Controls.Add(this.buSave);
            this.tpBookmarks.Location = new System.Drawing.Point(4, 22);
            this.tpBookmarks.Name = "tpBookmarks";
            this.tpBookmarks.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookmarks.Size = new System.Drawing.Size(313, 603);
            this.tpBookmarks.TabIndex = 1;
            this.tpBookmarks.Text = "Метки";
            this.tpBookmarks.UseVisualStyleBackColor = true;
            // 
            // buDel
            // 
            this.buDel.Location = new System.Drawing.Point(7, 275);
            this.buDel.Name = "buDel";
            this.buDel.Size = new System.Drawing.Size(130, 23);
            this.buDel.TabIndex = 4;
            this.buDel.Text = "Удалить закладку";
            this.buDel.UseVisualStyleBackColor = true;
            this.buDel.Click += new System.EventHandler(this.buDel_Click);
            // 
            // buTest
            // 
            this.buTest.Location = new System.Drawing.Point(177, 275);
            this.buTest.Name = "buTest";
            this.buTest.Size = new System.Drawing.Size(130, 23);
            this.buTest.TabIndex = 3;
            this.buTest.Text = "Загрузить";
            this.buTest.UseVisualStyleBackColor = true;
            this.buTest.Click += new System.EventHandler(this.BuTest_Click);
            // 
            // lv
            // 
            this.lv.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv.GridLines = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(7, 7);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(300, 262);
            this.lv.TabIndex = 2;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Начало";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Конец";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Цвет";
            // 
            // buSave
            // 
            this.buSave.Location = new System.Drawing.Point(7, 574);
            this.buSave.Name = "buSave";
            this.buSave.Size = new System.Drawing.Size(300, 23);
            this.buSave.TabIndex = 1;
            this.buSave.Text = "Сохранить в файл";
            this.buSave.UseVisualStyleBackColor = true;
            this.buSave.Click += new System.EventHandler(this.buSave_Click);
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 653);
            this.Controls.Add(this.tc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(361, 692);
            this.MinimumSize = new System.Drawing.Size(361, 692);
            this.Name = "Playlist";
            this.ShowIcon = false;
            this.Text = "Плейлист";
            this.tc.ResumeLayout(false);
            this.tpPlaylist.ResumeLayout(false);
            this.tpBookmarks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tpPlaylist;
        private System.Windows.Forms.Button buAdd;
        private System.Windows.Forms.ListBox lbPlaylist;
        private System.Windows.Forms.TabPage tpBookmarks;
        private System.Windows.Forms.Button buSave;
        private System.Windows.Forms.Button buTest;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buDel;
    }
}

