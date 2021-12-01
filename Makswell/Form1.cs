using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makswell
{
    public partial class Form1 : Form
    {
        int N;
        double R, Tmax, Xmax, Ymax, Dt, K;
        double[] X, Y, Vx, Vy;
        Random rndm = new Random();
        double[] V;
        int[] CN;
        int t;
        double p_x, p_y, p2, V_par1_x, V_par1_y, V_perp1_x, V_perp1_y, V_par2_x, V_par2_y, V_perp2_x, V_perp2_y;
        
        Bitmap bmp1, bmp2;
        Graphics gr1, gr2;
        Pen P1 = new Pen(Color.Green, 2);
        Pen P2 = new Pen(Color.Black, 2);
        SolidBrush Br = new SolidBrush(Color.Yellow);
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            t = 0;
            N = int.Parse(Numbers.Text);
            R = double.Parse(Radius.Text);
            Tmax = double.Parse(temperature.Text);
            Xmax = double.Parse(length.Text) / 2;
            Ymax = double.Parse(width.Text) / 2;
            Dt = double.Parse(dt.Text);
            K = double.Parse(scale.Text);

            X = new double[N];
            Y = new double[N];
            Vx = new double[N];
            Vy = new double[N];
            V = new double[N];
            CN = new int[N];

            for (int i = 0; i < N; i++)
            {
                V[i] = 0;
                CN[i] = 0;
                X[i] = (2 * rndm.NextDouble() - 1) * (Xmax - R);
                Y[i] = (2 * rndm.NextDouble() - 1) * (Ymax - R);
                Vx[i] = (2 * rndm.NextDouble() - 1) * Tmax;
                Vy[i] = (2 * rndm.NextDouble() - 1) * Tmax;
            }
            bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gr1 = Graphics.FromImage(bmp1);
            bmp2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gr2 = Graphics.FromImage(bmp2);

            gr1.Clear(pictureBox1.BackColor);
            gr2.Clear(pictureBox1.BackColor);

            gr1.DrawRectangle(P2, (int)(bmp1.Width / 2 - K * Xmax), (int)(bmp1.Height / 2 - K * Ymax), (int)(2 * K * Xmax), (int)(2 * K * Ymax));
            gr2.DrawImage(bmp1, 0, 0);

            for (int i = 0; i < N; i++)
            {
                gr2.DrawEllipse(P1, (int)(bmp1.Width / 2 + K * (X[i] - R)), (int)(bmp1.Height / 2 - K * (Y[i] + R)), (int)(2 * K * R), (int)(2 * K * R));
                gr2.FillEllipse(Br, (int)(bmp1.Width / 2 + K * (X[i] - R)), (int)(bmp1.Height / 2 - K * (Y[i] + R)), (int)(2 * K * R), (int)(2 * K * R));
            }
            pictureBox1.Image = bmp2;
            Start_button.Enabled = false;
            Stop_button.Enabled = true;
            timer1.Enabled = true;
        }
        private void Stop_button_Click(object sender, EventArgs e)
        {
            Start_button.Enabled = true;
            Stop_button.Enabled = false;
            timer1.Enabled = false;
        }

       private void timer1_Tick_1(object sender, EventArgs e)
        {
            t++;
            Past_time.Text = (t * Dt).ToString();
            //Движение частиц
            for (int i = 0; i < N; i++)
            {
                X[i] += Vx[i] * Dt;
                Y[i] += Vy[i] * Dt;
                V[i] += Math.Sqrt(Vx[i] * Vx[i] + Vy[i] * Vy[i]) * Dt;
                // Проверяем соударение со стенками
                if ((X[i] >= Xmax - R) && (Vx[i] > 0)) Vx[i] = -Vx[i];
                if ((X[i] <= -Xmax + R) && (Vx[i] < 0)) Vx[i] = -Vx[i];
                if ((Y[i] >= Ymax - R) && (Vy[i] > 0)) Vy[i] = -Vy[i];
                if ((Y[i] <= -Ymax + R) && (Vy[i] < 0)) Vy[i] = -Vy[i];
            }

            //Соударение частиц между собой
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    p_x = X[j] - X[i];
                    p_y = Y[j] - Y[i];
                    p2 = p_x * p_x + p_y * p_y;
                    if (p2 <= 4 * R * R)
                    {
                        V_par1_x = (Vx[i] * p_x + Vy[i] * p_y) * p_x / p2;
                        V_par1_y = (Vx[i] * p_x + Vy[i] * p_y) * p_y / p2;
                        V_par2_x = (Vx[j] * p_x + Vy[j] * p_y) * p_x / p2;
                        V_par2_y = (Vx[j] * p_x + Vy[j] * p_y) * p_y / p2;

                        if ((V_par2_x - V_par1_x) * p_x + (V_par2_y - V_par1_y) * p_y < 0)
                        {
                            V_perp1_x = Vx[i] - V_par1_x;
                            V_perp1_y = Vy[i] - V_par1_y;
                            V_perp2_x = Vx[j] - V_par2_x;
                            V_perp2_y = Vy[j] - V_par2_y;
                            Vx[i] = V_par2_x + V_perp1_x;
                            Vy[i] = V_par2_y + V_perp1_y;
                            Vx[j] = V_par1_x + V_perp2_x;
                            Vy[j] = V_par1_y + V_perp2_y;
                            CN[i]++;
                            CN[j]++;
                        }
                    }
                }
            }

            gr2.DrawImage(bmp1, 0, 0);
            for (int i = 0; i < N; i++)
            {
                gr2.DrawEllipse(P1, (int)(bmp1.Width / 2 + K * (X[i] - R)), (int)(bmp1.Height / 2 - K * (Y[i] + R)), (int)(2 * K * R), (int)(2 * K * R));
                gr2.FillEllipse(Br, (int)(bmp1.Width / 2 + K * (X[i] - R)), (int)(bmp1.Height / 2 - K * (Y[i] + R)), (int)(2 * K * R), (int)(2 * K * R));
            }
            pictureBox1.Image = bmp2;
        }
    }
}

        


       