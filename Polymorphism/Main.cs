using System;

namespace Polymorphism
{
    class DrawMap
    {
        virtual public void ShowPosition(Envelope e)
        {
            return;
        }
    }
	
	class DrawMapConsole : DrawMap
    {
        override public void ShowPosition(Envelope e)
        {
            Console.WriteLine("Console: ({0},{1}),({2},{3})", e.xmin, e.ymin, e.xmax, e.ymax);
        }
    }
	
	class DrawMapWindow : DrawMap
    {
        override public void ShowPosition(Envelope e)
        {
            Console.WriteLine("Window: ({0},{1}),({2},{3})", e.xmin, e.ymin, e.xmax, e.ymax);
        }
    }

    class Envelope
    {
        public double xmin, xmax, ymin, ymax;
    }

    class Map
    {
        public void PanTo()
        {
			Envelope e = new Envelope();
            e.ymin = 10;
            e.xmin = 100;
            e.ymax = 20;
            e.xmax = 200;

            drawMap.ShowPosition(e);
        }

		private DrawMap drawMap;
        public DrawMap DrawMap
        {
			get { return drawMap; }
            set { drawMap = value; }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
			DrawMap draw = null;//new DrawMapWindow();
			draw = new DrawMapConsole();
			
            Map m = new Map();
            m.DrawMap = draw;
            m.PanTo();
            
        }
    }
}

