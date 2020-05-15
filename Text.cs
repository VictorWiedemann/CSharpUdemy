using System;

namespace CSharpUdemy
{
    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public override void Draw()
        {
            Console.WriteLine("drew text");
        }
    }
}