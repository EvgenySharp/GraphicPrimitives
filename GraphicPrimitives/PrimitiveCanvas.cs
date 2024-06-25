using System.ComponentModel;
using System.Windows.Forms.Design;
using GraphicPrimitives.Primitives;

namespace GraphicPrimitives
{
    [Designer(typeof(ControlDesigner))]
    public class PrimitiveCanvas : Panel
    {
        private readonly List<PrimitiveBase> _primitives = new List<PrimitiveBase>();
        private readonly List<Connection> _connections = new List<Connection>();
        private PrimitiveBase _selectedPrimitive;
        private PrimitiveBase _startConnectionPrimitive;
        private bool _isResizing;
        private bool _isMoving;
        private Point _lastMousePosition;

        public void AddPrimitive(PrimitiveBase primitive)
        {
            _primitives.Add(primitive);
            Invalidate();
        }

        public void AddConnection(Connection connection)
        {
            _connections.Add(connection);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var connection in _connections)
            {
                connection.Draw(e.Graphics);
            }
            foreach (var primitive in _primitives)
            {
                primitive.Draw(e.Graphics);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            foreach (var primitive in _primitives)
            {
                if (primitive.Contains(e.Location))
                {
                    _selectedPrimitive = primitive;
                    _lastMousePosition = e.Location;

                    if (e.Button == MouseButtons.Left)
                    {
                        _isResizing = true;
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        _isMoving = true;
                    }
                    else if (e.Button == MouseButtons.Middle)
                    {
                        HandleConnectionCreation(primitive);
                    }

                    break;
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            HandlePrimitiveResizingAndMoving(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            ResetMouseActions();
        }

        private void HandleConnectionCreation(PrimitiveBase primitive)
        {
            if (_startConnectionPrimitive == null)
            {
                _startConnectionPrimitive = primitive;
            }
            else
            {
                AddConnection(new Connection(_startConnectionPrimitive, primitive));
                _startConnectionPrimitive = null;
            }
        }

        private void HandlePrimitiveResizingAndMoving(MouseEventArgs e)
        {
            if (_isResizing && _selectedPrimitive != null)
            {
                _selectedPrimitive.Resize(e.Location);
                Invalidate();
            }
            else if (_isMoving && _selectedPrimitive != null)
            {
                Point offset = new Point(e.Location.X - _lastMousePosition.X, e.Location.Y - _lastMousePosition.Y);
                _selectedPrimitive.Move(new Point(_selectedPrimitive.Position.X + offset.X, _selectedPrimitive.Position.Y + offset.Y));
                _lastMousePosition = e.Location;
                Invalidate();
            }
        }

        private void ResetMouseActions()
        {
            _isResizing = false;
            _isMoving = false;
            _selectedPrimitive = null;
        }
    }
}
