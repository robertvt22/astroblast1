using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace astroblast1
{
    public partial class Form1 : Form
    {
        Int16 x=500, y=500, scorOZN = 0, scorAsteroid = 0;
        Point pozitieOZN, pozitieAsteroid;

        

        Random rnd = new Random();


        private void timerAsteroid_Tick(object sender, EventArgs e)
        {
            pozitieAsteroid.Y += 5;
            if (pozitieAsteroid.Y >= 621)
            {
                pozitieAsteroid.Y = 1;
                pozitieAsteroid.X = rnd.Next(1,1025);
                scorAsteroid++;
                this.Text = "Astroblast          OZN=" + scorOZN + "    Asteroid=" + scorAsteroid;
            }
            
            if(pictureBox1Asteroid.Bounds.IntersectsWith(pictureBox1UFO.Bounds))
            {
                pozitieAsteroid.Y = 1;
                pozitieAsteroid.X = rnd.Next(1, 1025);
                scorOZN++;
                this.Text = "Astroblast          OZN=" + scorOZN + "    Asteroid=" + scorAsteroid;
            }
            pictureBox1Asteroid.Invalidate();
            pictureBox1Asteroid.Location = pozitieAsteroid;

        }

        
        public Form1()
        {
            InitializeComponent();
            pozitieOZN.Y = 621;
            pozitieAsteroid.X = 500;
            DoubleBuffered = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
                x -= 10;
            if (x <= 1)
                x = 1;
            if (e.KeyData == Keys.Right)
                x += 10;
            if (x >= 1039)
                x = 1039;


            pozitieOZN.X = x;
            pictureBox1UFO.Invalidate();
            pictureBox1UFO.Location = pozitieOZN;



        }
    }
}
