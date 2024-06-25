namespace GraphicPrimitives.Primitives
{
    public class RectanglePrimitive : PrimitiveBase
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(FillColor))
            using (Pen pen = new Pen(BorderColor, BorderWidth))
            {
                g.FillRectangle(brush, Position.X, Position.Y, Width, Height);
                g.DrawRectangle(pen, Position.X, Position.Y, Width, Height);
            }
        }

        public override bool Contains(Point point)
        {
            Rectangle rect = new Rectangle(Position.X, Position.Y, Width, Height);
            return rect.Contains(point);
        }

        public override void Resize(Point newSize)
        {
            Width = newSize.X - Position.X;
            Height = newSize.Y - Position.Y;
        }
    }
}
