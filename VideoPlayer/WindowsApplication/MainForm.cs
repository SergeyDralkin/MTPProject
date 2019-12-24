using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Microsoft.DirectX.AudioVideoPlayback;
using ProXoft.WinForms;
using System.Data;
using System.Windows.Media;
using System.ComponentModel;
using Newtonsoft.Json;
using SideBar;


namespace WindowsApplication
{
    public partial class MainForm : Form
    {
        //
        //Класс Microsoft.DirectX.AudioVideoPlayback.Audio 
        //
        string[] files = new string[0];
        EX.VideoPlayer player = new EX.VideoPlayer();
        public Video video;
        Audio audio;
        public string filename;
        SideBar.Playlist SB;
        DataSet dataSet = new DataSet("dataSet");
        DataTable table = new DataTable();
        BasicShapeScrollBarBookmark Bookmark = new BasicShapeScrollBarBookmark();
        ToolTip t = new ToolTip();

        public MainForm()
        {
            InitializeComponent();
            //
            //dataset
            //
            dataSet.Namespace = "Boormarks";
            DataColumn Name = new DataColumn("Name");
            DataColumn Start = new DataColumn("Start");
            DataColumn Finish = new DataColumn("Finish");
            DataColumn ColorMark = new DataColumn("Color");
            table.Columns.Add(Name);
            table.Columns.Add(Start);
            table.Columns.Add(Finish);
            table.Columns.Add(ColorMark);
            dataSet.Tables.Add(table);
            создатьЗакладкуToolStripMenuItem.Enabled = false;
        }

        //
        //Играть
        //
        private void BT_Play_Click(object sender, EventArgs e)
        {
            video.Play();
        }

        //
        //Пауза
        //
        private void BT_Pause_Click(object sender, EventArgs e)
        {
            if (video.Paused) video.Play();
            else video.Pause();
        }

        //
        //Стоп
        //
        private void BT_Stop_Click(object sender, EventArgs e)
        {
            video.Stop();
        }

        //
        //Назад
        //
        private void BT_MM_Click(object sender, EventArgs e)
        {
            if (video.CurrentPosition > 5) video.CurrentPosition -= 5;
        }

        //
        //Вперед
        //
        private void BT_PP_Click(object sender, EventArgs e)
        {
            if ((video.StopPosition / 1000000) > (video.CurrentPosition + 5)) video.CurrentPosition += 5;
        }

        //
        //Звук
        //
        private void Track_Volume_Scroll(object sender, EventArgs e)
        {
            if (Track_Volume.Value == 100)
            {
                video.Audio.Volume = 0;
            }
            else
            {
                video.Audio.Volume = ((100 - Track_Volume.Value) * (-100));
            }
        }

        //
        //Баланс звука L:R [-10000:10000]
        //
        private void Track_Balance_Scroll(object sender, EventArgs e)
        {
            video.Audio.Balance = ((Track_Balance.Value - 10) * 1000);
        }

        //
        //Звук на правый динамик
        //
        private void r_MouseClick(object sender, MouseEventArgs e)
        {
            if (filename == null) return;
            Track_Balance.Value = 20;
            video.Audio.Balance = 10000;
        }

        //
        //Звук на левый динамик
        //
        private void l_Click(object sender, EventArgs e)
        {
            if (filename == null) return;
            Track_Balance.Value = 0;
            video.Audio.Balance = -10000;
        }

        //
        //Звук баланс
        //
        private void Track_Balance_KeyDown(object sender, KeyEventArgs e)
        {
            if (filename == null) return;
            if (e.KeyCode == Keys.Enter)
            {
                Track_Balance.Value = 10;
                video.Audio.Balance = 0;
            }
        }

        //
        //Изменение размеров окна
        //
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Panel_Video.Size = new Size(Size.Width - 18, Size.Height - 168);
                Panel_Video.Location = new Point(0, 24);
            }

            if (WindowState == FormWindowState.Normal)
            {
                Panel_Video.Size = new Size(Size.Width - 53, Size.Height - 168);
                Panel_Video.Location = new Point(17, 30);
                Track_AudioTrack.Location = new Point(102, 400);
                Track_AudioTrack.Size = new Size(313, 23);
            }
        }

        //
        //Отрыть файл
        //
        private void BT_OpenFile_Click_1(object sender, EventArgs e)
        {
            //
            //Диалог выбора файла
            //     
            var dialog = new OpenFileDialog();
            dialog.Title = "Открыть файл";
            dialog.Filter = "Видео файлы (*.avi; *.mp4; *.qt; *.mov; *.mpg; *.mpeg; *.m1v; *.wmv)|*.avi; *.mp4; *.qt; *.mov; *.mpg; *.mpeg; *.m1v; *.wmv|Все файлы (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LoadVideo(dialog.FileName);
            }
        }

        //
        //Тик таймера 
        //
        private void Timer_Tick(object sender, EventArgs e)
        {
            Track_AudioTrack.Value = Convert.ToInt32(video.CurrentPosition);
            Laber_TimeNow.Text = String.Format("{0:00}:{1:00}", Math.Floor(video.CurrentPosition / 60), video.CurrentPosition % 60);
        }

        //
        //Навигация по треку
        //
        private void Track_AudioTreck_Scroll(object sender, ProXoft.WinForms.EnhancedScrollEventArgs e)
        {
            video.CurrentPosition = (double)Track_AudioTrack.Value;
        }

        //
        //Отпускание левой клавиши мыши на Scrollbar 
        //
        private void Track_AudioTreck_MouseUp(object sender, MouseEventArgs e)
        {
            video.Play();
        }

        //
        //Нажатие левой клавиши мыши на Scrollbar 
        //
        private void Track_AudioTreck_MouseDown(object sender, MouseEventArgs e)
        {
            video.Pause();
        }

        //
        //Перемещение при клике левой клавишой мыши на Scrollbar 
        //
        private void Track_AudioTreck_MouseClick(object sender, ProXoft.WinForms.EnhancedMouseEventArgs e)
        {
            video.Pause();
            Track_AudioTrack.Value = e.Value;
            video.CurrentPosition = (double)Track_AudioTrack.Value;
            video.Play();
        }

        private void создатьЗакладкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBookmark FormBookmark = new CreateBookmark();
            FormBookmark.labelCurrentPosition = this.Laber_TimeNow;
            FormBookmark.Laber_TimeAll = this.Laber_TimeAll;
            FormBookmark.dataSet = dataSet;
            FormBookmark.table = table;
            FormBookmark.Video = video;
            FormBookmark.filename = filename;
            FormBookmark.Track_AudioTrack = Track_AudioTrack;
            FormBookmark.Show();
        }

        private void открытьПлейлистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Playlist playlist = new Playlist();
            playlist.Show();
        }

        public void LoadVideo(string path)
        {
            if (video != null)
            {
                video.Dispose();
                audio.Dispose();
            }
            video = new Video(path);
            audio = new Audio(path);
            video.Owner = Panel_Video;
            BT_Pause.Enabled = true;
            BT_Play.Enabled = true;
            BT_Stop.Enabled = true;
            Track_AudioTrack.Enabled = true;
            Track_Balance.Enabled = true;
            Track_Volume.Enabled = true;
            Timer100ms.Enabled = true;
            Track_AudioTrack.Enabled = true;

            filename = Path.GetFileNameWithoutExtension(path);
            if (video == null)
            {
                return;
            }
            Text = "Player: " + filename;
            video.Open(path);
            audio.Open(path);
            video.Owner = Panel_Video;
            Track_AudioTrack.Maximum = Convert.ToInt32(video.StopPosition / 10000000);
            Laber_TimeAll.Text = String.Format("{0:00}:{1:00}", Math.Floor(Track_AudioTrack.Maximum / 60), Track_AudioTrack.Maximum % 60);
            Panel_Video.Size = new Size(Size.Width - 53, Size.Height - 168);
            if (Track_Volume.Value == 100)
            {
                audio.Volume = 0;
            }
            else
            {
                audio.Volume = ((100 - Track_Volume.Value) * (-100));
            }
            BT_Play_Click(null, null);

            создатьЗакладкуToolStripMenuItem.Enabled = true;
            Track_AudioTrack.Bookmarks.Clear();

            if (File.Exists("JSON /" + filename + "+" + video.Duration + ".json"))
            {
                Reload_Bookmarks();
                SB.ReloadList(dataSet);
            }
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                BT_Pause_Click(null, null);
            }
        }
        public void Reload_Bookmarks()
        {
            SB = (SideBar.Playlist)Application.OpenForms["Playlist"];
            if (SB == null)
            {
                SB = new SideBar.Playlist();
                SB.Show();
            }

            dataSet = JsonConvert.DeserializeObject<DataSet>(File.ReadAllText("JSON /" + filename + "+" + video.Duration + ".json"));

            DataTable dataTable = dataSet.Tables[0];
            ColorConverter converter = new ColorConverter();
            Track_AudioTrack.Bookmarks.Clear();

            foreach (DataRow row in dataTable.Rows)
            {

                Color cl = new Color();
                cl = Color.FromName(Convert.ToString(row["Color"]));
                if (cl.R == 0 && cl.G == 0 && cl.B == 0 && cl.Name != "Black")
                    cl = (Color)converter.ConvertFromInvariantString("#" + Convert.ToString(row["Color"]));

                DateTime dt = new DateTime();

                dt = Convert.ToDateTime("00:" + row["Start"]);


                Bookmark = new BasicShapeScrollBarBookmark(Convert.ToString(row["Name"]) + "Start", dt.Second, ScrollBarBookmarkAlignment.LeftOrTop, 5, 5, ScrollbarBookmarkShape.Rectangle, cl, true, false, null);
                Track_AudioTrack.Bookmarks.Add(Bookmark);

                dt = Convert.ToDateTime("00:" + row["Finish"]);
                Bookmark = new BasicShapeScrollBarBookmark(Convert.ToString(row["Name"]) + "Finish", dt.Second, ScrollBarBookmarkAlignment.LeftOrTop, 5, 5, ScrollbarBookmarkShape.Rectangle, cl, true, false, null);
                Track_AudioTrack.Bookmarks.Add(Bookmark);

            }

        }

        private void Track_AudioTrack_Move(object sender, EventArgs e)
        {
            
        }

        private void Track_AudioTrack_MouseMove(object sender, EnhancedMouseEventArgs e)
        {
            t.Show("тут должна быть подсказка", Track_AudioTrack);
        }
    }
}