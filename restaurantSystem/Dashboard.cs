using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using restaurantSystem.DesignCodes;

namespace restaurantSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            DesignCodes.Borders.SetBorderRadius(panel2, 20);
            DesignCodes.Borders.SetBorderRadius(panel3, 20);
            DesignCodes.Borders.SetBorderRadius(panel4, 20);
        }
    }
}
