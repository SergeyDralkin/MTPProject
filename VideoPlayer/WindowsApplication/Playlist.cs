using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using WindowsApplication;


namespace SideBar
{
    public partial class Playlist : Form
    {
        DataSet dataSet;
        List<string> videoPath = new List<string>();
        WindowsApplication.MainForm MF;


        public Playlist()
        {
            InitializeComponent();
        }

        public void buAdd_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Открыть файл";
            dialog.Filter = "Видео файлы (*.avi; *.mp4; *.qt; *.mov; *.mpg; *.mpeg; *.m1v; *.wmv)|*.avi; *.mp4; *.qt; *.mov; *.mpg; *.mpeg; *.m1v; *.wmv|Все файлы (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
                lbPlaylist.Items.Add(Path.GetFileNameWithoutExtension(dialog.FileName));
            videoPath.Add(dialog.FileName);
        }

        private void buSave_Click(object sender, EventArgs e)
        {

        }

        private void BuTest_Click(object sender, EventArgs e)
        {
            DataSet dataSet;
            string path = "Bookrmarks.json";
            if (File.Exists(path))
            {
                dataSet = JsonConvert.DeserializeObject<DataSet>(File.ReadAllText(path));

                DataTable dataTable = dataSet.Tables["Table1"];

                ListViewItem lvadd;
                foreach (DataRow row in dataTable.Rows)
                {
                    lvadd = new ListViewItem(Convert.ToString(row["id"]));
                    lvadd.SubItems.Add(Convert.ToString(row["item"]));
                    lv.Items.Add(lvadd);
                }
            }       
        }

        private void buDel_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                if (Convert.ToString(row["Name"]) == lv.SelectedItems[0].Text)
                {
                    row.Delete();
                    dataSet.AcceptChanges();
                    break;
                }
            }
            lv.Items.Remove(lv.SelectedItems[0]);

           
            string json = JsonConvert.SerializeObject(dataSet);


            MF = (WindowsApplication.MainForm)Application.OpenForms["MainForm"];
            using (FileStream fs = new FileStream("JSON/" + MF.filename + "+" + MF.video.Duration + ".json", FileMode.Create))
            {
                    StreamWriter w = new StreamWriter(fs);
                    w.WriteLine(json);
                    w.Close();
                    fs.Close();
                }

            MF.Reload_Bookmarks();

        }


        public void ReloadList(DataSet Videolist) 
        {

            dataSet = Videolist;
            
            foreach (DataRow row in Videolist.Tables[0].Rows)
            {
                var list = lv;
                ClearList();
                ListViewItem lvadd;
                lvadd = new ListViewItem(Convert.ToString(row["Name"]));
                lvadd.SubItems.Add(Convert.ToString(row["Start"]));
                lvadd.SubItems.Add(Convert.ToString(row["Finish"]));
                lvadd.SubItems.Add(Convert.ToString(row["Color"]));
                list.Items.Add(lvadd);
            }

        }
        public void ClearList()
        {
            lv.Items.Clear();
            
        }

        private void lbPlaylist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbPlaylist.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                MF = (WindowsApplication.MainForm)Application.OpenForms["MainForm"];
                MF.Activate();
                MF.LoadVideo(videoPath[index].ToString());

            }

            
        }
    }

    public class Bookmark
    {
        public string Name { get; set; }
        public string Start { get; set; }
        public string Finish { get; set; }
        public string Color { get; set; }
    }
}
