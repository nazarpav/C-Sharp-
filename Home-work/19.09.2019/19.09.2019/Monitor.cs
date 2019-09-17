using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


//3840 x 2160  |  2560 x 1440   |  1920 x 1080  |  1280 x 720
namespace _19._09._2019
{
    enum MonitorExtension {HD ,FHD,QHD,UHD};
    class Monitor
    {
        private int _height;
        private int _width;
        private MonitorExtension _monitorExtension;
        private bool _isON;
        private string _manufacturingPlant;
        private static int counterObj;
        private static string type;

        public int Height { get => _height; }
        public int Width { get => _width; }
        public static object Cursor { get; private set; }
        public static int CounterObj { get => counterObj;}
        public static string Type { get => type;}
        public string ManufacturingPlant { get => _manufacturingPlant; set => _manufacturingPlant = value; }

        public void SetIsON(bool isON)
        {
            this._isON = isON;
        }
        public bool GetIsON()=> this._isON;
        MonitorExtension GetMonitorExtension()=> this._monitorExtension;

        static Monitor()
        {
            counterObj = 0;
            type = "Monitor";
        }
        //3840 x 2160  |  2560 x 1440   |  1920 x 1080  |  1280 x 720
        public void DrawMonitorsExtension()
        {
            if (!_isON)
                throw new Exception("monitor is off");
            short x= 3840, y= 2160;
            byte color = 11;
            for (int g = 0; g < 4; g++)
            {
                Console.ForegroundColor = (ConsoleColor)color--;
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < y/40; i++)
                {
                    for (int j = 0; j < x/20; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition( x/20-15,y/40);
                Console.Write("Extension => "+y+" x "+x);
                if (x<= 2560)
                {
                    x -= 1280/2;
                    y -= 720/2;
                    continue;
                }
                x -= 1280;
                y -= 720;
            }
            Console.ReadKey();
        }
        public Monitor()
        {
            this.ManufacturingPlant = "none";
            this._isON = false;
            this._monitorExtension = MonitorExtension.HD;
            _height = 720;
            _width = 1280;
            counterObj++;
        }
        public Monitor(MonitorExtension monitorExtension, string manufacturingPlant, bool isON = false)
        {
            this.ManufacturingPlant = manufacturingPlant;
            this._isON = isON;
            counterObj++;
            switch (monitorExtension)
            {
                case MonitorExtension.HD:
                    this._monitorExtension = MonitorExtension.HD;
                    _height =720;
                    _width=1280;
                    break;
                case MonitorExtension.FHD:
                    this._monitorExtension = MonitorExtension.FHD;
                    _height = 1080;
                    _width = 1920;
                    break;
                case MonitorExtension.QHD:
                    this._monitorExtension = MonitorExtension.QHD;
                    _height = 1440;
                    _width = 2560;
                    break;
                case MonitorExtension.UHD:
                    this._monitorExtension = MonitorExtension.UHD;
                    _height = 3840;
                    _width = 2160;
                    break;
            }
        }
        public Monitor(MonitorExtension monitorExtension, bool isON = false)
        {
            this.ManufacturingPlant = "none";
            this._isON = isON;
            counterObj++;
            switch (monitorExtension)
            {
                case MonitorExtension.HD:
                    this._monitorExtension = MonitorExtension.HD;
                    _height = 720;
                    _width = 1280;
                    break;
                case MonitorExtension.FHD:
                    this._monitorExtension = MonitorExtension.FHD;
                    _height = 1080;
                    _width = 1920;
                    break;
                case MonitorExtension.QHD:
                    this._monitorExtension = MonitorExtension.QHD;
                    _height = 1440;
                    _width = 2560;
                    break;
                case MonitorExtension.UHD:
                    this._monitorExtension = MonitorExtension.UHD;
                    _height = 3840;
                    _width = 2160;
                    break;
            }
        }
        ~Monitor()
        {
            counterObj--;
        }


    }
}
