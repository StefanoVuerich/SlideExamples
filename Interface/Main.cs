using System;
using System.Text;

namespace Interface
{
	class Size 
	{ 
		public Size() {}
		
		public Size(int width, int height)
		{ Width = width; Height = height; }
		
		public int Width { get; set; } public int Height { get; set; } 
	}
	
	interface ICanResize
	{
		void SetNewSize(Size s);
	}
	
	abstract class Widget
	{
		public Widget() { RenderSize = new Size(0,0); }
		
		public abstract string Render();
		
		protected Size RenderSize { get; set; }
	}
	
	class Button : Widget, ICanResize
	{
		public int Margin { get; set; }
		
		public void SetNewSize(Size s)
		{
			RenderSize = new Size(s.Width + Margin, s.Height + Margin);
		}
		
		public override string Render()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Button: Size [{0}x{1}]", RenderSize.Width, RenderSize.Height);
			return sb.ToString();
		}
	}
	
	class Text : Widget, ICanResize
	{
	
		public Size FontSize { get; set; }
		
		private string textvalue;
		public string Value 
		{ 
			get { return textvalue; } 
			set { textvalue = value; }
		}
	
		public void SetNewSize(Size s)
		{
			RenderSize = new Size(Math.Max(s.Width, Value.Length * FontSize.Width), Math.Max(s.Height, FontSize.Height));
		}
	
		public override string Render()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Text: Text {0} Size[{1}x{2}]", Value, RenderSize.Width, RenderSize.Height);
			return sb.ToString();
		}
	}
		
	
	class MainClass
	{
		public static void Show(Widget[] widgets)
		{
			foreach(Widget w in widgets)
			{
				Console.WriteLine(w.Render());
			}
		}
		
		public static void Resize(Widget[] widgets, Size size)
		{
			foreach(Widget w in widgets)
			{
				ICanResize icr = w as ICanResize;
				//ICanResize icr = (ICanResize)w;
				if (icr != null)
					icr.SetNewSize(size);
				
				if (w is ICanResize)
					(w as ICanResize).SetNewSize(size);
				
			}
		}
		
		public static void Main (string[] args)
		{
			Widget[] widgets = new Widget[3];
			Button b1 = new Button();
			b1.Margin = 10;
			widgets[0] = b1;
			
			Text t1 = new Text();
			t1.FontSize = new Size(8, 10);
			t1.Value = "Ciao";
			widgets[1] = t1;
			
			Text t2 = new Text();
			t2.FontSize = new Size(10, 14);
			t2.Value = "Prova";
			widgets[2] = t2;
			
			Resize(widgets, new Size(0, 0));
			Show(widgets);
			
			Size resize = new Size() { Height = 10, Width = 50};
			Resize(widgets, resize);
			
			Show(widgets);
			
		}
	}
}

