using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUI
{
    public class UIHelper
    {
        public static void ApplyRoundedCorners(Control control, int borderRadius)
        {
            if (control == null || borderRadius <= 0) return;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(control.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(control.Width - borderRadius, control.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, control.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }

        public static void UIMouseEvent(Control c, List<Color> colorList) {
            Color original = c.ForeColor;
            c.MouseEnter += (sender, e) =>
            {
                c.BackColor = colorList[0];
                c.ForeColor = Color.Black;
            };

            c.MouseLeave += (sender, e) =>
            {
                c.BackColor = colorList[1];
                c.ForeColor = original;
            };

            c.MouseClick += (sender, e) =>
            {
                c.BackColor = colorList[2];
                c.ForeColor = Color.White;
            };
        }
    }

    public class RoundControl : Control
    {
        private Control _targetControl;
        private int _borderRadius = 15;

        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; ApplyRoundedCorners(); }
        }

        public Control TargetControl
        {
            get => _targetControl;
            set { _targetControl = value; ApplyRoundedCorners(); }
        }

        public RoundControl(Control targetControl, int borderRadius = 15)
        {
            _targetControl = targetControl;
            _borderRadius = borderRadius;
            ApplyRoundedCorners();
        }

        private void ApplyRoundedCorners()
        {
            if (_targetControl != null)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, _borderRadius, _borderRadius, 180, 90);
                path.AddArc(_targetControl.Width - _borderRadius, 0, _borderRadius, _borderRadius, 270, 90);
                path.AddArc(_targetControl.Width - _borderRadius, _targetControl.Height - _borderRadius, _borderRadius, _borderRadius, 0, 90);
                path.AddArc(0, _targetControl.Height - _borderRadius, _borderRadius, _borderRadius, 90, 90);
                path.CloseFigure();
                _targetControl.Region = new Region(path);
            }
        }
    }


}
