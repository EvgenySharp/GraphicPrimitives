using GraphicPrimitives.Primitives;

namespace GraphicPrimitives
{
    public class Connection
    {
        public PrimitiveBase Start { get; }
        public PrimitiveBase End { get; }
        public Color LineColor { get; set; }
        public int LineWidth { get; set; }

        public Connection(PrimitiveBase start, PrimitiveBase end)
        {
            Start = start;
            End = end;
            LineColor = Color.Black;
            LineWidth = 2;
        }

        public void Draw(Graphics g)
        {
            using (Pen pen = new Pen(LineColor, LineWidth))
            {
                g.DrawLine(pen, Start.Position, End.Position);
            }
        }
    }
}
