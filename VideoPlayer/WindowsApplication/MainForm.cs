using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Microsoft.DirectX.AudioVideoPlayback;
using ProXoft.WinForms;
using System.Data;

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
        Video video;
        Audio audio;
        string filename;

        DataSet dataSet = new DataSet("dataSet");
        DataTable table = new DataTable();

        public MainForm()
        {
            InitializeComponent();           

            /*//Sample bookmark of value 50 (blue rectangle, left aligned)
            BasicShapeScrollBarBookmark bookmarkBS = new BasicShapeScrollBarBookmark("BasicShape sample #1", 500, ScrollBarBookmarkAlignment.RightOrBottom, 5, 5, ScrollbarBookmarkShape.Rectangle, Color.Blue, true, false, null);
            Track_AudioTrack.Bookmarks.Add(bookmarkBS);
            //Sample bookmark of value 75 (red rectangle, left aligned)
            bookmarkBS = new BasicShapeScrollBarBookmark("BasicShape sample #2", 750, ScrollBarBookmarkAlignment.LeftOrTop, 5, 5, ScrollbarBookmarkShape.Rectangle, Color.Red, true, false, null);
            Track_AudioTrack.Bookmarks.Add(bookmarkBS);
            //Sample bookmark of value 25 (green bar)
            bookmarkBS = new BasicShapeScrollBarBookmark("BasicShape sample #3", 250, ScrollBarBookmarkAlignment.LeftOrTop, 1, 1, ScrollbarBookmarkShape.Rectangle, Color.Green, true, true, null);
            Track_AudioTrack.Bookmarks.Add(bookmarkBS);
            //Sample bookmark of value 40 (green rectangle, centered)
            bookmarkBS = new BasicShapeScrollBarBookmark("BasicShape sample #4", 400, ScrollBarBookmarkAlignment.Center, 9, 9, ScrollbarBookmarkShape.Rectangle, Color.Green, true, false, null);
            Track_AudioTrack.Bookmarks.Add(bookmarkBS);*/


            //
            //dataset
            //
            dataSet.Namespace = "Boormarks";   
            DataColumn Name = new DataColumn("name");
            DataColumn Start = new DataColumn("Start");
            DataColumn Finish = new DataColumn("Finish");
            DataColumn ColorMark = new DataColumn("Color");
            table.Columns.Add(Name);
            table.Columns.Add(Start);
            table.Columns.Add(Finish);
            table.Columns.Add(ColorMark);
            dataSet.Tables.Add(table);
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
            
            if ( Track_Volume.Value == 100)
            {
                video.Audio.Volume = 0;
            }
            else
            {
                video.Audio.Volume = ((100 -  Track_Volume.Value) * (-100));
            }
        } 

        //
        //Баланс звука L:R [-10000:10000]
        //
        private void Track_Balance_Scroll(object sender, EventArgs e)
        {
            video.Audio.Balance = (( Track_Balance.Value - 10) * 1000);
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
            if ( WindowState == FormWindowState.Maximized)
            {
                 Panel_Video.Size =  Size;
                 Panel_Video.Location = new Point(0,24);
                 Track_AudioTrack.Location = new Point(5,0);
                 Track_AudioTrack.Size = new Size( Size.Width-15,45);
                 label1.Visible = false;                
                 r.Visible = false;                
                 BT_OpenFile.Visible = false;
                 BT_Play.Visible = false;
                 BT_Pause.Visible = false;
                 Laber_TimeAll.Visible = false;
                 Laber_TimeNow.Visible = false;
                 Track_AudioTrack.Visible = false;
            }

            if ( WindowState == FormWindowState.Normal)
            {
                 Panel_Video.Size = new Size( Size.Width - 38, Size.Height -168);
                 Panel_Video.Location = new Point(17,30);
                 Track_AudioTrack.Location = new Point(102, 400);
                 Track_AudioTrack.Size = new Size(313,23);
                 label1.Visible = true;                
                 r.Visible = true;                
                 BT_OpenFile.Visible = true;
                 BT_Play.Visible = true;
                 BT_Pause.Visible = true;
                 Laber_TimeAll.Visible = true;
                 Laber_TimeNow.Visible = true;
                 Track_AudioTrack.Visible = true;
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
                //int height = Panel_Video.Height;
                //int width = Panel_Video.Width;
                video = new Video(dialog.FileName);
                audio = new Audio(dialog.FileName);
                video.Owner = Panel_Video;
                BT_MM.Enabled = true;
                BT_Pause.Enabled = true;
                BT_Play.Enabled = true;
                BT_PP.Enabled = true;
                BT_Stop.Enabled = true;
                Track_AudioTrack.Enabled = true;
                Track_Balance.Enabled = true;
                Track_Volume.Enabled = true;
                Timer100ms.Enabled = true;
                Track_AudioTrack.Enabled = true;
            }

            //
            //Обновление данных
            //
            filename = Path.GetFileNameWithoutExtension(dialog.FileName);
            if (video == null)
            {
                return;
            }
            Text = "Player: " + filename;
            video.Open(dialog.FileName);
            audio.Open(dialog.FileName);
            video.Owner =  Panel_Video;
            Track_AudioTrack.Maximum = Convert.ToInt32(video.StopPosition / 10000000);
            Laber_TimeAll.Text = String.Format("{0:00}:{1:00}",  Math.Floor(Track_AudioTrack.Maximum / 60),  Track_AudioTrack.Maximum % 60);
            Panel_Video.Size = new Size( Size.Width - 38,  Size.Height - 168);
            if ( Track_Volume.Value == 100)
            {
                audio.Volume = 0;
            }
            else 
            {
                audio.Volume = ((100 -  Track_Volume.Value) * (-100));
            }
            BT_Play_Click(null, null);
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
            FormBookmark.dataSet = dataSet;
            FormBookmark.table = table;
            FormBookmark.Video = video;
            FormBookmark.filename = filename;
            FormBookmark.Show();
        }

        private void открытьПлейлистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Playlist playlist = new Playlist();
            playlist.Show();
        }
    }
}