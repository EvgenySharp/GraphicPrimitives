namespace GraphicPrimitives.Primitives
{
    public abstract class PrimitiveBase
    {
        public Color FillColor { get; set; }
        public Color BorderColor { get; set; }
        public int BorderWidth { get; set; }
        public Point Position { get; set; }

        public abstract void Draw(Graphics g);
        public abstract bool Contains(Point point);
        public abstract void Resize(Point newSize);
        public virtual void Move(Point newPosition)
        {
            Position = newPosition;
        }
    }
}