using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace EX
{
    class VideoPlayer
    {
        //
        //Переменные
        //

        private bool open;              //Открыть файл или нет.
        private bool pause;             //Пауза активна?
        //Уровни звука; (0-100)
        private int volumebass;
        private int volumetreble;
        private int volumeleft;
        private int volumeright;
        private int volume;
        //
        private int navigate;        //Переход по треку, ms
        //
        //Модуль который проигрывает звук
        //
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string Cmd, StringBuilder StrReturn, int ReturnLength, IntPtr HwndCallback);
        //
        //Конструктор
        //
        public VideoPlayer()
        {
            volumebass = 100;
            volumetreble = 100;
            volumeleft = 100;
            volumeright = 100;
            volume = 100;
            navigate = 0;
            pause = false;
        }
        //
        //Конструктор2
        //
        public VideoPlayer(string FileName)
        {
            mciSendString("open \"" + FileName + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            volumebass = 100;
            volumetreble = 100;
            volumeleft = 100;
            volumeright = 100;
            volume = 100;
            navigate = 0;
            open = true;
            pause = false;
        }
        //
        //Открыть файл
        //
        public void Open(string FileName)
        {
            mciSendString("open \"" + FileName + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            open = true;
        }
        //
        //Закрыть файл
        //
        public void Close()
        {
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
            open = false;
        }
        //
        //Воспроизведение открытого файла
        //
        public bool Play()
        {
            if (open)
            {
                navigate = 0;
                mciSendString("seek MediaFile to 0", null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);
                return true;
            }
            else return false;
        }
        //
        //Воспроизведение открытого файла по кругу
        //
        public bool PlayLoop()
        {
            if (open)
            {
                mciSendString("play MediaFile REPEAT", null, 0, IntPtr.Zero);
                return true;
            }
            else return false;
        }
        //
        //Воспроизведение файла
        //
        public bool PlayFile(string FileName)
        {
            if (open)
            {
                 Close();
            }
             Open(FileName);
            return  Play();
        }
        //
        //Стоп
        //
        public void Stop()
        {
            if (open)
            {
                mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
            }
        }
        //
        //Пауза
        //
        public void Pause()
        {
            //Если играет трек
            if ( pause == false)
            {
                //Останавливаем проигрывание
                mciSendString("pause MediaFile", null, 0, IntPtr.Zero);
                pause = true;
            }
            else
            {
                //Возобновляем проигрывание
                mciSendString("resume MediaFile", null, 0, IntPtr.Zero);
                pause = false;
            }
        }
        //
        //Движение по треку, переход на позицию
        //
        public int Navigate
        {
            get
            {
                if (! open) return -1;
                StringBuilder sb = new StringBuilder(128);
                mciSendString("status MediaFile position", sb, 128, IntPtr.Zero);
                return Convert.ToInt32(sb.ToString()) / 1000;
            }
            set
            {
                 navigate = value;
                mciSendString("seek MediaFile to " + value * 1000, null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);
            }
        }
        //
        //Получение текущего статуса
        //
        public String Status
        {
            get
            {
                StringBuilder sb = new StringBuilder(128);
                mciSendString("status MediaFile mode", sb, 128, IntPtr.Zero);
                return sb.ToString();
            }
        }
        //
        //Громкость левого динамика (0-100)
        //
        public int VolumeLeft
        {
            get
            {
                return  volumeleft;
            }
            set
            {
                 volumeleft = value;
                mciSendString("setaudio MediaFile left volume to " + value * 10, null, 0, IntPtr.Zero);
            }
        }
        //
        //Громкость правого динамика (0-100)
        //
        public int VolumeRight
        {
            get
            {
                return  volumeright;
            }
            set
            {
                 volumeleft = value;
                mciSendString("setaudio MediaFile right volume to " + value * 10, null, 0, IntPtr.Zero);
            }
        }
        //
        //Громкость (0-100)
        //
        public int Volume
        {
            get
            {
                return  volume;
            }
            set
            {
                 volume = value;
                mciSendString("setaudio MediaFile volume to " + value * 10, null, 0, IntPtr.Zero);
            }
        }
        //
        //Бас (0-100)
        //
        public int VolumeBass
        {
            get
            {
                return  volumebass;
            }
            set
            {
                 volumebass = value;
                mciSendString("setaudio MediaFile volume to " + value * 10, null, 0, IntPtr.Zero);
            }
        }
        //
        //Высокочастотный уровень (0-100)
        //
        public int VolumeTreblee
        {
            get
            {
                return  volumetreble;
            }
            set
            {
                 volumetreble = value;
                mciSendString("setaudio MediaFile treble to " + value * 10, null, 0, IntPtr.Zero);
            }
        }
        //
        //Длинна файла, секунды
        //
        public int Length
        {
            get
            {
                if ( open)
                {
                    StringBuilder sb = new StringBuilder(128);
                    mciSendString("status MediaFile length", sb, 128, IntPtr.Zero);
                    if (sb.Length == 0) return 0;
                    return Convert.ToInt32(sb.ToString()) / 1000;
                }
                else return 0;
            }
        }
        //
        //Выполняется проигрывание?
        //
        public bool IsPlay
        {
            get
            {
                if ( Status == "playing") return true;
                else return false;
            }
        }
        //
        //Проигрыватель роботает?
        //
        public bool IsWork
        {
            get
            {
                if (Status == null) return false;
                else return true;
            }
        }

    }
}
