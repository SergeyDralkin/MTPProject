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

namespace SideBar
{
    public partial class Playlist : Form
    {
        DataTable dataTable;



        public Playlist()
        {
            InitializeComponent();
        }

        public void buAdd_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Открыть файл";
            dialog.Filter = "Видео файлы (*.avi; *.qt; *.mov; *.mpg; *.mpeg; *.m1v; *.wmv)|*.avi; *.qt; *.mov; *.mpg; *.mpeg; *.m1v; *.wmv|Все файлы (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
                lbPlaylist.Items.Add(Path.GetFileNameWithoutExtension(dialog.FileName));
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
            foreach (DataRow row in dataTable.Rows)
            {
                if (Convert.ToString(row["Name"]) == lv.SelectedItems[0].Text)
                {
                    row.Delete();
                }
            }
            lv.Items.Remove(lv.SelectedItems[0]);

            string json = JsonConvert.SerializeObject(dataTable);

        }


        public void ReloadList(DataSet Videolist) 
        {

            dataTable = Videolist.Tables[0];
            var list = lv;
            ListViewItem lvadd;
            //list.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {

                lvadd = new ListViewItem(Convert.ToString(row["Name"]));
                lvadd.SubItems.Add(Convert.ToString(row["Start"]));
                lvadd.SubItems.Add(Convert.ToString(row["Finish"]));
                lvadd.SubItems.Add(Convert.ToString(row["Color"]));
                list.Items.Add(lvadd);
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
