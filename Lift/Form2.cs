using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift
{
    public partial class Form2 : Form
    {
        public static int floor;
        public Form2()
        {
            InitializeComponent();
        }

        

        
        public static int flr()
        {
            return floor;
        }

        private void click_func(object sender, EventArgs e)
        {
            floor = Convert.ToInt32(((Button)sender).Text);
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1.pressed = false;
            this.Dispose();
            Application.Exit();
        }
    }
}
