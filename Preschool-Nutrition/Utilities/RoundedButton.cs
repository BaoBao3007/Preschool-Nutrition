using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Utilities
{
    public class RoundedButton:Button
    {
        public int BorderRadius { get; set; } = 40; // Độ bo góc

        protected override void OnPaint(PaintEventArgs pevent)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90); // Góc trái trên
                path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90); // Góc phải trên
                path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90); // Góc phải dưới
                path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90); // Góc trái dưới
                path.CloseFigure();
                this.Region = new Region(path);
            }
            base.OnPaint(pevent); // Gọi phương thức vẽ của lớp cha
        }
    }
}
