namespace GraphicPrimitives.Primitives
{
    public class CirclePrimitive : PrimitiveBase
    {
        public int Radius { get; set; }

        public override void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(FillColor))
            using (Pen pen = new Pen(BorderColor, BorderWidth))
            {
                int diameter = Radius * 2;
                int x = Position.X - Radius;
                int y = Position.Y - Radius;

                g.FillEllipse(brush, x, y, diameter, diameter);
                g.DrawEllipse(pen, x, y, diameter, diameter);
            }
        }

        public override bool Contains(Point point)
        {
            int dx = point.X - Position.X;
            int dy = point.Y - Position.Y;
            return dx * dx + dy * dy <= Radius * Radius;
        }

        public override void Resize(Point newSize)
        {
            int dx = newSize.X - Position.X;
            int dy = newSize.Y - Position.Y;
            Radius = (int)Math.Sqrt(dx * dx + dy * dy);
        }
    }
}