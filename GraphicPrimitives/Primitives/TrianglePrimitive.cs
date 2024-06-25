namespace GraphicPrimitives.Primitives
{
    public class TrianglePrimitive : PrimitiveBase
    {
        public int SideLength { get; set; }

        public override void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(FillColor))
            using (Pen pen = new Pen(BorderColor, BorderWidth))
            {
                Point[] points = GetTrianglePoints();
                g.FillPolygon(brush, points);
                g.DrawPolygon(pen, points);
            }
        }

        public override bool Contains(Point point)
        {
            Point[] points = GetTrianglePoints();
            return IsPointInTriangle(point, points[0], points[1], points[2]);
        }

        public override void Resize(Point newSize)
        {
            int dx = newSize.X - Position.X;
            int dy = newSize.Y - Position.Y;
            SideLength = (int)Math.Sqrt(dx * dx + dy * dy);
        }

        private Point[] GetTrianglePoints()
        {
            Point top = new Point(Position.X, Position.Y - SideLength / 2);
            Point left = new Point(Position.X - SideLength / 2, Position.Y + SideLength / 2);
            Point right = new Point(Position.X + SideLength / 2, Position.Y + SideLength / 2);
            return new Point[] { top, left, right };
        }

        private bool IsPointInTriangle(Point p, Point p0, Point p1, Point p2)
        {
            var s = p0.Y * p2.X - p0.X * p2.Y + (p2.Y - p0.Y) * p.X + (p0.X - p2.X) * p.Y;
            var t = p0.X * p1.Y - p0.Y * p1.X + (p0.Y - p1.Y) * p.X + (p1.X - p0.X) * p.Y;

            if ((s < 0) != (t < 0))
                return false;

            var A = -p1.Y * p2.X + p0.Y * (p2.X - p1.X) + p0.X * (p1.Y - p2.Y) + p1.X * p2.Y;
            return A < 0 ? (s <= 0 && s + t >= A) : (s >= 0 && s + t <= A);
        }
    }
}
