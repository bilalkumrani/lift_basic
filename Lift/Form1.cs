using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift
{
    public partial class Form1 : Form
    {
        int? floor=null;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Bilal Khan\source\repos\Lift\Lift\tor2.wav");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lift.ImageLocation = @"C:\Users\Bilal Khan\source\repos\Lift\Lift\lift.png";
            
        }

        public  static bool pressed = true;
        private void btn4_Click(object sender, EventArgs e)
        {
            player.Play();
           




            move(sender, e);
            Form2 obj = new Form2();
            obj.ShowDialog();
            floor = Form2.flr();
            this.Text = floor + "";
            if(pressed)
            {
                switch(floor)
                {

                    case 1:
                        btn4_Click((Object)btn1, e);
                        break;
                        case 2:
                        btn4_Click((Object)btn2, e);
                        break;
                        case 3:
                        btn4_Click((Object)btn3, e);
                        break;
                        case 4:
                        btn4_Click((Object)btn4, e);
                        break;
                        case 0:
                        btn4_Click((Object)btnG, e);
                        break;

                        
                }
                
            }
            
            


           
        }
        public void move(object sender, EventArgs e)
        {
            while (this.lift.Top != ((Button)sender).Top)
            {
                if (this.lift.Top > ((Button)sender).Top)
                {
                    this.lift.Top--;
                }
                else if (this.lift.Top < ((Button)sender).Top)
                {
                    this.lift.Top++;
                }
                else
                {

                    break;

                }
                Thread.Sleep(10);

            }
        }


        
    }
}
