using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;


namespace FootBallGame
{
    public class GoalShot
    {
        int speed; 
        public PictureBox pic;
        Form f; 
        public Thread th;
        Point loc; 
        delegate void setLocationCallBack(int top);
        public GoalShot(int speed, Point loc, Form f) 
        {
            this.speed = speed;
            this.loc = loc;
            this.f = f;
            pic = new PictureBox();
            pic.Image = global::FootBallGame.Properties.Resources.FBall;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.SetBounds(loc.X, loc.Y, 30, 30);
            f.Controls.Add(pic);
            th = new Thread(new ThreadStart(drop));
            th.Start();
        }

        private void drop()
        {
            while (true)
            {
                setLocation(5);
                Thread.Sleep(speed);
            }
        }

        private void setLocation(int top)
        {
            if (f.InvokeRequired)
            {
                setLocationCallBack d = new setLocationCallBack(setLocation);
                f.Invoke(d, new object[] { top });
            }
            else
            {
                if (pic.Top > 70)
                    pic.Top -= top;

                else
                {
                    th.Abort();
                    f.Controls.Remove(pic);
                }

            }
        }

        public Rectangle getBounds()
        {
            return pic.Bounds;
        }

    }

}

