using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantSystem.DesignCodes
{
    internal class Borders
    {
        public static void SetBorderRadius(Panel panel, int borderRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(panel.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, panel.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            panel.Region = new Region(path);
        }

        public static void SetBorderRadius(TextBox textBox, int borderRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(textBox.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(textBox.Width - borderRadius, textBox.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, textBox.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            textBox.Region = new Region(path);
        }

        public static void SetBorderRadius(Button button, int borderRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(button.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(button.Width - borderRadius, button.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, button.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            button.Region = new Region(path);
        }

    }
}
