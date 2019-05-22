namespace CarService.WPF.Common
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Linq;

    public class ZoomBorder : Border
    {
        private UIElement _child = null;
        private Point _origin;
        private Point _start;

        private static TranslateTransform GetTranslateTransform(UIElement element)
        {
            return (TranslateTransform)((TransformGroup)element.RenderTransform)
              .Children.First(tr => tr is TranslateTransform);
        }

        private static ScaleTransform GetScaleTransform(UIElement element)
        {
            return (ScaleTransform)((TransformGroup)element.RenderTransform)
              .Children.First(tr => tr is ScaleTransform);
        }

        public override UIElement Child
        {
            get { return base.Child; }
            set
            {
                if (value != null && value != this.Child)
                    this.Initialize(value);
                base.Child = value;
            }
        }

        public void Initialize(UIElement element)
        {
            this._child = element;
            if (_child == null) return;
            var group = new TransformGroup();
            var st = new ScaleTransform();
            @group.Children.Add(st);
            var tt = new TranslateTransform();
            @group.Children.Add(tt);
            _child.RenderTransform = @group;
            _child.RenderTransformOrigin = new Point(0.0, 0.0);
            this.MouseWheel += ChildMouseWheel;
            this.MouseLeftButtonDown += ChildMouseLeftButtonDown;
            this.MouseLeftButtonUp += ChildMouseLeftButtonUp;
            this.MouseMove += ChildMouseMove;
            this.PreviewMouseRightButtonDown += new MouseButtonEventHandler(
                ChildPreviewMouseRightButtonDown);
        }

        public void Reset()
        {
            if (_child == null) return;
            // reset zoom
            var st = GetScaleTransform(_child);
            st.ScaleX = 1.0;
            st.ScaleY = 1.0;

            // reset pan
            var tt = GetTranslateTransform(_child);
            tt.X = 0.0;
            tt.Y = 0.0;
        }

        #region Child Events

        private void ChildMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (_child == null) return;
            var st = GetScaleTransform(_child);
            var tt = GetTranslateTransform(_child);

            double zoom = e.Delta > 0 ? .2 : -.2;
            if (!(e.Delta > 0) && (st.ScaleX < .4 || st.ScaleY < .4))
                return;

            var relative = e.GetPosition(_child);

            var abosuluteX = relative.X * st.ScaleX + tt.X;
            var abosuluteY = relative.Y * st.ScaleY + tt.Y;

            st.ScaleX += zoom;
            st.ScaleY += zoom;

            tt.X = abosuluteX - relative.X * st.ScaleX;
            tt.Y = abosuluteY - relative.Y * st.ScaleY;
        }

        private void ChildMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (_child == null) return;
            var tt = GetTranslateTransform(_child);
            _start = e.GetPosition(this);
            _origin = new Point(tt.X, tt.Y);
            this.Cursor = Cursors.Hand;
            _child.CaptureMouse();
        }

        private void ChildMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (_child == null) return;
            _child.ReleaseMouseCapture();
            this.Cursor = Cursors.Arrow;
        }

        void ChildPreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Reset();
        }

        private void ChildMouseMove(object sender, MouseEventArgs e)
        {
            if (_child == null) return;
            if (!_child.IsMouseCaptured) return;
            var tt = GetTranslateTransform(_child);
            var v = _start - e.GetPosition(this);
            tt.X = _origin.X - v.X;
            tt.Y = _origin.Y - v.Y;
        }

        #endregion
    }
}
