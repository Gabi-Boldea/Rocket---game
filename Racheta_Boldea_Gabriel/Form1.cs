using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racheta_Boldea_Gabriel
{
    public partial class Form1 : Form
    {
        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #endregion

        #region .. code for Flickering ..

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        bool st, dr, sus, jos, trage;
        bool miscare = false;
        int viteza = 10;
        int vitezaa;
        int vieti = 3;
        int scor = 0;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                st = false;
            if (e.KeyCode == Keys.Right)
                dr = false;
            if (e.KeyCode == Keys.Up)
                sus = false;
            if (e.KeyCode == Keys.Down)
                jos = false;
            if (e.KeyCode == Keys.Space)
                trage = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                st = true;
            if (e.KeyCode == Keys.Right)
                dr = true;
            if (e.KeyCode == Keys.Up)
                sus = true;
            if (e.KeyCode == Keys.Down)
                jos = true;
            if (e.KeyCode == Keys.Space)
                trage = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //glont
            if(trage && miscare == false)
            {
                glont.Visible = true;
                glont.Top = r.Top;
                glont.Left = r.Left + 20;
                glont.Height = 20;
                glont.Width = 20;
                miscare = true;
            }
            if (glont.Top >= 0 && miscare == true)
            {
                glont.Top = glont.Top - 25;

            }
            if (glont.Top < 0)
            {
                glont.Visible = false;
                miscare = false;

            }

            //miscarea rachetei
            if (st == true)
            {
                if (r.Left <= 0)
                    r.Left = r.Left + 2;
                else
                    r.Left = r.Left - viteza;
            }
            if (dr == true)
            {
                if (r.Left >= this.Width - r.Width + 2)
                    r.Left = r.Left - 2;
                else
                    r.Left = r.Left + viteza;
            }
            if (sus == true)
            {
                if (r.Top <= 0)
                    r.Top = r.Top + 2;
                else
                    r.Top = r.Top - viteza;
            }
            if (jos == true)
            {
                if (r.Top >= this.Height - r.Height - 40)
                    r.Top = r.Top - 2;
                else
                    r.Top = r.Top + viteza;
            }

            //miscarea asteroidului
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "asteroizi")
                {
                    if (x.Bounds.IntersectsWith(glont.Bounds) && glont.Visible == true)
                    {
                        glont.Top = x.Top - glont.Height;
                        x.Visible = false;
                        x.Top = this.Height + 100;
                        scor++;
                        lbl_scor.Text = Convert.ToString(scor);
                        if (scor == 50)
                        {
                            timer1.Enabled = false;
                            MessageBox.Show("Good job!");
                            Application.Exit();
                        }
                    }
                    if (x.Top <= this.Height)
                    {
                        Random va = new Random();
                        vitezaa = va.Next(5, 15);
                        x.Top = x.Top + vitezaa;
                    }
                    else
                    {
                        x.Visible = true;
                        Random nr = new Random();
                        int xa = nr.Next(1, 370);//coordonata pe orizontala a asteroidului
                        int ya = nr.Next(80, 120);//coordonata pe verticala
                        int dimo = nr.Next(50, 90);//dimensiune pe orizontala
                        int dimv = nr.Next(50, 100);//dimensiune pe verticala
                        x.Top = -ya;
                        x.Left = xa;
                        x.Width = dimo;
                        x.Height = dimv;
                        x.Visible = true;
                    }
                    if (r.Bounds.IntersectsWith(x.Bounds) && x.Visible)
                    {
                        vieti--;
                        x.Visible = false;
                        if (vieti == 2)
                            viata_3.Visible = false;
                        if (vieti == 1)
                            viata_2.Visible = false;
                        if (vieti == 0)
                        {
                            viata_1.Visible = false;
                            r.Visible = false;
                            MessageBox.Show("Game Over!");
                            Application.Exit();
                        }

                    }
                }
            }
        }
    }
}
