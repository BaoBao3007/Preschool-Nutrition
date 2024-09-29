using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preschool_Nutrition.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1600, 900);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new Size(1600, 900);
            this.MaximumSize = new Size(1600, 900);
        }
    }
}
