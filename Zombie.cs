using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieSlayer
{
    internal class Zombie
    {
        int x, y, h, w;
        int step;

        Image img;

        Image[] img_walking_r = { Image.FromFile("C:\\Final Project game\\ZombieSlayer\\images\\Zombie\\movR1.png"), Image.FromFile("C:\\Final Project game\\ZombieSlayer\\images\\Zombie\\movR2.png"), Image.FromFile("C:\\Final Project game\\ZombieSlayer\\images\\Zombie\\movR3.png"), Image.FromFile("C:\\Final Project game\\ZombieSlayer\\images\\Zombie\\movR4.png") };
        int counter_wrl = 0;

        //Image[] img_walking_l = { Image.FromFile("images/gunman_wl1.png"), Image.FromFile("images/gunman_wl2.png"), Image.FromFile("images/gunman_wl3.png") };
        //int counter_wlr = 0;

        //Image img_standing = Image.FromFile("images/gunman_4.png");

        public const int STANDING = 0;
        public const int LEFT = 1;
        public const int RIGHT = 2;

        int state = STANDING;

        public bool ready = false;


        public Zombie(int x, int y)
        {
           
            step = 10;
            this.x = x;
            this.y = y - h;
            img = img_walking_r[0];
        }
        
        

        

        public void draw(Graphics gfx, int x, int y, int h, int w, int count)
        {
            img = img_walking_r[count];
            
            

            gfx.DrawImage(img, x, y, w, h);
            
        }

       
        
    }
}
