using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;
using Microsoft.DirectX.AudioVideoPlayback;
using ProXoft.WinForms;

using Newtonsoft.Json;

namespace WindowsApplication
{
    public partial class CreateBookmark : Form
    {
        public Label labelCurrentPosition;
        public Label Laber_TimeAll;
        public DataSet dataSet;
        public DataTable table;
        public Video Video;
        public string filename;
        public BasicShapeScrollBarBookmark Bookmark;
        int i = 0; // Переменная проверки
        ColorDialog MyDialog = new ColorDialog();
        public ScrollBarEnhanced Track_AudioTrack;
        
        int StartValue;
        int FinishValue;
        SideBar.Playlist SB;
        int AllValue;
        string[] StartLeaveSplit;

        public CreateBookmark()
        {
            InitializeComponent();
            laColor.Text = "";            
        }

        private void tbNameBookmark_Enter(object sender, EventArgs e)
        {
            if (tbNameBookmark.Text == "Введите название закладки")
            {
                tbNameBookmark.Text = null;
            }
            tbNameBookmark.BackColor = Color.White;
            tbNameBookmark.ForeColor = Color.Black;
        }

        private void tbNameBookmark_Leave(object sender, EventArgs e)
        {
            if (tbNameBookmark.Text == null || tbNameBookmark.Text == "")
            {
                tbNameBookmark.Text = "Введите название закладки";
                tbNameBookmark.BackColor = Color.White;
                tbNameBookmark.ForeColor = Color.Gray;
            }
        }

        private void buCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            tbNameBookmark.ResetText();
            mtbStart.ResetText();
            mtbFinish.ResetText();
            cbStart.Checked = false;
            cbFinish.Checked = false;
        }

        private void buSaveBookmark_Click(object sender, EventArgs e)
        {

            CheckParameters();
            if (i == 0)
            {
                DataRow newRow = table.NewRow();
                newRow["Name"] = tbNameBookmark.Text.ToString();
                newRow["Start"] = mtbStart.Text.ToString();
                newRow["Finish"] = mtbFinish.Text.ToString();
                newRow["Color"] = laColor.Text.ToString();
                table.Rows.Add(newRow);

                dataSet.AcceptChanges();

                string json = JsonConvert.SerializeObject(dataSet);


                using (FileStream fs = new FileStream(filename + "+" + Video.Duration + ".json", FileMode.Create))
                {
                    StreamWriter w = new StreamWriter(fs);
                    w.WriteLine(json);
                    w.Close();
                    fs.Close();
                }

                SplitSecond();
                Bookmark = new BasicShapeScrollBarBookmark(tbNameBookmark.Text.ToString() + "Start", StartValue, ScrollBarBookmarkAlignment.LeftOrTop, 5, 5, ScrollbarBookmarkShape.Rectangle, laColor.ForeColor, true, false, null);
                Track_AudioTrack.Bookmarks.Add(Bookmark);
                Bookmark = new BasicShapeScrollBarBookmark(tbNameBookmark.Text.ToString() + "Finish", FinishValue, ScrollBarBookmarkAlignment.LeftOrTop, 5, 5, ScrollbarBookmarkShape.Rectangle, laColor.ForeColor, true, false, null);
                Track_AudioTrack.Bookmarks.Add(Bookmark);

                SB = (SideBar.Playlist)Application.OpenForms["Playlist"];

                if (SB == null)
                {
                    SB = new SideBar.Playlist();
                    SB.Show();
                }

                SB.Activate();
                SB.ReloadList(dataSet);
            }
        }
        private void cbCheckedChanged(object sender, EventArgs e)
        {
            cbFinish.BackColor = Color.Transparent;
            string name = (sender as CheckBox).Name;
            if (name == "cbStart")
            {
                mtbStart.BackColor = Color.White;
                if (cbStart.Checked == true)
                {
                    mtbStart.Enabled = false;
                    mtbStart.Text = labelCurrentPosition.Text.ToString();
                }
                if (cbStart.Checked == false)
                {
                    mtbStart.Clear();
                    mtbStart.Enabled = true;
                }
            }
            if (name == "cbFinish")
            {
                mtbFinish.BackColor = Color.White;
                if (cbFinish.Checked == true)
                {
                    mtbFinish.Enabled = false;
                    mtbFinish.Text = labelCurrentPosition.Text.ToString();
                }
                if (cbFinish.Checked == false)
                {
                    mtbFinish.Clear();
                    mtbFinish.Enabled = true;
                }
            }
        }
        void CheckParameters()
        {
            if (tbNameBookmark.Text == null || tbNameBookmark.Text == String.Empty || tbNameBookmark.Text == "Введите название закладки")
            {
                tbNameBookmark.BackColor = Color.Red;
                tbNameBookmark.ForeColor = Color.Black;
                i++;
            }
            else
            {
                tbNameBookmark.BackColor = Color.White;
                tbNameBookmark.ForeColor = Color.Black;
            }
            if (mtbStart.Text == null || mtbStart.Text == String.Empty || mtbStart.Text == "  :")
            {
                mtbStart.BackColor = Color.Red;
                i++;
            }
            else
            {
                mtbStart.BackColor = Color.White;
            }
            if (mtbFinish.Text == null || mtbFinish.Text == String.Empty || mtbFinish.Text == "  :" || mtbFinish.Text == "00:00")
            {
                mtbFinish.BackColor = Color.Red;
                if (mtbFinish.Text == "00:00" && cbFinish.Checked == true)
                {
                    cbFinish.BackColor = Color.Red;
                }
                i++;
            }
            else
            {
                mtbFinish.BackColor = Color.White;
            }
            if (laColor.Text == null || laColor.Text == String.Empty || laColor.Text == "" || laColor.Text =="Выберите цвет для закладки!")
            {
                laColor.Text = "Выберите цвет для закладки!";
                laColor.BackColor = Color.Red;
                i++;
            }
            else
            {
                laColor.BackColor = Color.Transparent;
            }
        }

        void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox thisTextBox = (sender as TextBox);
            string str = thisTextBox.Text;
            int a = str.Length;
            if (a == 0)
            {
                if (tbNameBookmark.Text == null || tbNameBookmark.Text == "")
                {
                    tbNameBookmark.Text = "Введите название закладки";
                    tbNameBookmark.BackColor = Color.White;
                    tbNameBookmark.ForeColor = Color.Gray;
                }
                return;
            }
            while (str[0] == ' ')
            {
                str = str.Remove(0, 1);
                thisTextBox.Text = str;
                if (str == "")
                {
                    if (tbNameBookmark.Text == null || tbNameBookmark.Text == "")
                    {
                        tbNameBookmark.Text = "Введите название закладки";
                        tbNameBookmark.BackColor = Color.White;
                        tbNameBookmark.ForeColor = Color.Gray;
                    }
                    return;
                }
            }
        }
        void mtb_Enter(object sender, EventArgs e)
        {
            MaskedTextBox thisTextBox = (sender as MaskedTextBox);
            thisTextBox.BackColor = Color.White;
        }

        private void buColorSet_Click(object sender, EventArgs e)
        {

            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                laColor.BackColor = Color.Transparent;
                laColor.ForeColor = MyDialog.Color;
                laColor.Text = MyDialog.Color.Name;
            }
        }
        public void SplitSecond()
        {
            string[]  StartSplit = mtbStart.Text.ToString().Split(':');
            string[] FinishSplit = mtbFinish.Text.ToString().Split(':');

            StartValue = int.Parse(StartSplit[0]) * 60 + int.Parse(StartSplit[1]);
            FinishValue = int.Parse(FinishSplit[0]) * 60 + int.Parse(FinishSplit[1]);
        }

        private void mtbStart_Leave(object sender, EventArgs e)
        {
            //SplitSecond();
            StartLeaveSplit = Laber_TimeAll.Text.ToString().Split(':');
            AllValue = int.Parse(StartLeaveSplit[0]) * 60 + int.Parse(StartLeaveSplit[1]);

            if (StartValue > AllValue)
            {
                mtbStart.Text = Laber_TimeAll.Text;
            }
        }
    }
}
