using System;

namespace Abstract
{
    abstract class DrawMap
    {
        abstract public void ShowPosition(Envelope e);
		
		private string title;
		public string Title
		{
			get { return title; }
			set { title = value; }
		}
    }
	
	class DrawMapConsole : DrawMap
    {
        override public void ShowPosition(Envelope e)
        {
            Console.WriteLine("Console: {4} ({0},{1}),({2},{3})", e.xmin, e.ymin, e.xmax, e.ymax, Title);
        }
    }
	
	class DrawMapWindow : DrawMap
    {
        override public void ShowPosition(Envelope e)
        {
            Console.WriteLine("Window: {4} ({0},{1}),({2},{3})", e.xmin, e.ymin, e.xmax, e.ymax, Title);
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
			DrawMap draw = new DrawMapWindow();
			draw.Title = "La mia mappa";
			//draw = new DrawMapConsole();
			
            Map m = new Map();
            m.DrawMap = draw;
            m.PanTo();
            
        }
    }
}

