using GraphicPrimitives.Primitives;

namespace GraphicPrimitives
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            RectanglePrimitive rect1 = new RectanglePrimitive
            {
                Position = new Point(50, 50),
                Width = 100,
                Height = 50,
                FillColor = Color.Red,
                BorderColor = Color.Orange,
                BorderWidth = 2
            };

            CirclePrimitive circle1 = new CirclePrimitive
            {
                Position = new Point(200, 100),
                Radius = 50,
                FillColor = Color.Blue,
                BorderColor = Color.Black,
                BorderWidth = 2
            };

            TrianglePrimitive triangle1 = new TrianglePrimitive
            {
                Position = new Point(350, 100),
                SideLength = 100,
                FillColor = Color.Green,
                BorderColor = Color.Black,
                BorderWidth = 2
            };

            RectanglePrimitive rect2 = new RectanglePrimitive
            {
                Position = new Point(50, 50),
                Width = 100,
                Height = 50,
                FillColor = Color.Red,
                BorderColor = Color.Orange,
                BorderWidth = 2
            };

            CirclePrimitive circle2 = new CirclePrimitive
            {
                Position = new Point(200, 100),
                Radius = 50,
                FillColor = Color.Blue,
                BorderColor = Color.Black,
                BorderWidth = 2
            };

            TrianglePrimitive triangle2 = new TrianglePrimitive
            {
                Position = new Point(350, 100),
                SideLength = 100,
                FillColor = Color.Green,
                BorderColor = Color.Black,
                BorderWidth = 2
            };

            primitiveCanvas1.AddPrimitive(rect1);
            primitiveCanvas1.AddPrimitive(circle1);
            primitiveCanvas1.AddPrimitive(triangle1);
            primitiveCanvas2.AddPrimitive(rect2);
            primitiveCanvas2.AddPrimitive(circle2);
            primitiveCanvas2.AddPrimitive(triangle2);
        }
    }
}
